using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace TcpLib
{
    internal class TcpClientManager : CommManagerBase
    {
        System.Net.Sockets.TcpClient m_tcpClient;
        IPAddress m_ip,m_ipRecieve;

        int m_port,m_portRecive;
        bool m_raiseEventOnNewData=true;
        bool m_abortPollingThread = false;
        Queue<byte> m_buffer = new Queue<byte>();
        bool m_connected;
        IPEndPoint m_serverEndPoint;
        IPEndPoint m_transmitEndPoint;

        //Events
        #region ConnectionEstablishedEvent
        public class ConnectionEstablishedEventArg : EventArgs
        {
            public ConnectionEstablishedEventArg()
            {
            }
        }

        public delegate void ConnectionEstablishedEventHandler(object sender, ConnectionEstablishedEventArg e);

        /// <summary>
        /// The event is raised when connection established with TCP server.
        /// </summary>
        public event ConnectionEstablishedEventHandler ConnectionEstablishedEvent;

        private void OnConnectionEstablished(ConnectionEstablishedEventArg e)
        {
            if (ConnectionEstablishedEvent != null)
            {
                ConnectionEstablishedEvent(this, e);
            }
        }
        #endregion

        #region DisconnectEvent
        public class DisconnectEventArg : EventArgs
        {
            public DisconnectEventArg()
            {
               
            }
        }

        public delegate void DisconnectEventHandler(object sender, DisconnectEventArg e);

        /// <summary>
        /// The event is raised when connection with the server is cut.
        /// </summary>
        public event DisconnectEventHandler DisconnectEvent;

        private void OnDisconnect(DisconnectEventArg e)
        {
            m_connected = false;
            if (DisconnectEvent != null)
            {
                DisconnectEvent(this, e);
            }
        }
        #endregion


        #region NewDataEvent
        public class NewDataEventArg : EventArgs
        {
            private byte[] m_newData;

            public NewDataEventArg(byte[] newData)
            {
                m_newData = newData;
            }

            public byte[] NewData
            {
                get
                {
                    return m_newData;
                }
            }
        }

        public delegate void NewDataEventHandler(object sender, NewDataEventArg e);

        /// <summary>
        /// The event is raised when connection with the server is cut.
        /// </summary>
        public event NewDataEventHandler NewDataEvent;

        private void OnNewData(NewDataEventArg e)
        {
            NewDataEvent(this, e);
        }
        #endregion

        /// <summary>
        /// Indicates if the manager is currently connected to server.
        /// </summary>
        public bool Connected
        {
            get
            {
                return m_connected;
            }
        }

        /// <summary>
        /// Return the server IP.
        /// </summary>
        public string IP
        {
            get
            {
                return m_ip.ToString();
            }
        }

        /// <summary>
        /// Return the server port.
        /// </summary>
        public int Port
        {
            get
            {
                return m_port;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="raiseEventOnNewData">
        ///  Indicates if new data is read directly from the queue or "New Data" event should be rasied.
        /// </param>
        public TcpClientManager(string ip, int port, bool raiseEventOnNewData)
        {
            m_tcpClient = new System.Net.Sockets.TcpClient();
            m_ip = IPAddress.Parse(ip);
            m_port = port;
            m_raiseEventOnNewData = raiseEventOnNewData;
            m_serverEndPoint = new IPEndPoint(m_ip, m_port);
           
        }

        public TcpClientManager(string ip, int port, string ipRecieve,int portRecieve,bool raiseEventOnNewData)
        {
            m_tcpClient = new System.Net.Sockets.TcpClient();
            m_ip = IPAddress.Parse(ip);
            m_ipRecieve = IPAddress.Parse(ipRecieve);
            m_port = port;
            m_raiseEventOnNewData = raiseEventOnNewData;
            m_portRecive = portRecieve;
            m_transmitEndPoint = new IPEndPoint(m_ip, m_port);
            m_serverEndPoint = new IPEndPoint(m_ipRecieve, m_portRecive);
        }

        /// <summary>
        /// Async connect has been complete.
        /// </summary>
        /// <param name="ar"></param>
        private void OnConnect(IAsyncResult ar)
        {
            Thread thrd;
            try
            {
                m_tcpClient.EndConnect(ar);
                OnConnectionEstablished(new ConnectionEstablishedEventArg());
                m_connected = true;

                thrd = new Thread(PollingDataThread);

                thrd.Start();
            }
            catch
            {
                //Indicates that the operation has been cancelled
            }
        }

        /// <summary>
        /// Split the string to chars and send.
        /// Note each line should be terminated with \n.
        /// </summary>
        /// <param name="tcpManager"></param>
        /// <param name="message"></param>
        public void SendAsciMessage(string message)
        {
            SendMessage(Encoding.ASCII.GetBytes(message));
        }

        /// <summary>
        /// Split the string to chars and send.
        /// Note each line should be terminated with \n.
        /// </summary>
        /// <param name="tcpManager"></param>
        /// <param name="message"></param>
        public void SendAsciMessageWithDelay(string message, int delay)
        {
            string chr;

            for (int i = 0; i < message.Length; i++)
            {
                chr = message.Substring(i, 1);
                SendMessage(Encoding.ASCII.GetBytes(chr));
                if (delay > 0)
                {
                    Thread.Sleep(delay);
                }
            }
        }

        /// <summary>
        /// Start connetion process to server which was specified in the constructor.
        /// When connection is complete event will be raised
        /// </summary>
        public void AsynConnect()
        {
            IPEndPoint serverEndPoint = new IPEndPoint(m_ip, m_port);  
           
            m_tcpClient.BeginConnect(m_ip, m_port, OnConnect, null);
        }

        bool m_exit=false;

        private void SyncConnectThread()
        {           
            m_exit = false;
            while (m_exit == false)
            {
                try
                {
                    m_tcpClient.Close();
                    m_tcpClient = new System.Net.Sockets.TcpClient();
                    
                    m_tcpClient.Connect(m_serverEndPoint);
                 

                    Thread.Sleep(2000);   //Delay is needed, otherwise exception is thrown
                    m_connected = true;
                    OnConnectionEstablished(new ConnectionEstablishedEventArg());
                    Thread thrd = new Thread(PollingDataThread);
                    thrd.Start();

                    break;
                }
                catch(Exception ex)
                {

                }
                Thread.Sleep(100);
            }
        }

        /// <summary>
        /// Connect to server using syncronize connection method.
        /// When connection is complete the event "OnConnectionEstablished" will be raised.
        /// </summary>
        public void SyncConnect()
        {
            Thread thrd = new Thread(SyncConnectThread);
            thrd.Start();
        }

        /// <summary>
        /// In case event is not rasied for new data then the read data is stored in this queue.
        /// </summary>
        public Queue<byte> Buffer
        {
            get
            {
                lock(m_buffer)
                {
                    return m_buffer;
                }
            }
        }

        /// <summary>
        /// Send messages to the server.
        /// Exception is thrwon in case of errror.
        /// </summary>
        /// <param name="buffer"></param>
        public override void SendMessage(byte[] buffer)
        {
            try
            {
                if (m_connected)
                {
                    //lock (m_tcpClient)
                    {
                        if (m_transmitEndPoint != null)
                        {
                            m_tcpClient.Client.SendTo(buffer, m_transmitEndPoint);
                        }
                        else
                        {
                           m_tcpClient.GetStream().Write(buffer, 0, buffer.Length);
                        }

                       // m_tcpClient.Client.SendTo(( GetStream().Write(buffer, 0, buffer.Length);
                    }
                }
            }
            catch(Exception ex)
            {
                m_connected = false;
                Disconnect();
                OnDisconnect(new DisconnectEventArg()); //Report the client that the connection with sever is cut();
            }
        }

        public void Disconnect()
        {
            m_abortPollingThread = true;
            m_exit = true;
            Thread.Sleep(100);
            


            if (m_tcpClient != null)
            {
                m_tcpClient.Client.Close();
                m_tcpClient.Close();

                //m_tcpClient = null;
                GC.Collect();
                GC.WaitForPendingFinalizers();
            }




            m_connected = false;
        }

        //private bool ClientDisconnected()
        //{
        //    bool retVal = false;

        //   // if (m_tcpClient.Client.Poll(0,SelectMode.SelectRead))
        //    //{
        //        byte[] buffer = new byte[1];
        //        if (m_tcpClient.Client.Receive(buffer, SocketFlags.Peek) == 0)
        //        {
        //            retVal = true;
        //        }
        //    //}
        //    return retVal;
        //}

        /// <summary>
        /// Check if new data has been receieved from the server.
        /// </summary>
        private void PollingDataThread()
        {
            byte[] inBuffer;

            m_abortPollingThread = false;
            try
            {
                while (!(m_abortPollingThread) && (m_exit == false))
                {
                    if (m_tcpClient.Available > 0)
                    {

                        inBuffer = new byte[m_tcpClient.Available];
                        m_tcpClient.GetStream().Read(inBuffer, 0, inBuffer.Length);

                        if (m_raiseEventOnNewData == false)
                        {
                            lock (m_buffer)
                            {
                                for (int i = 0; i < inBuffer.Length; i++)
                                {
                                    m_buffer.Enqueue(inBuffer[i]);
                                }
                            }
                        }
                        else
                        {
                            OnNewData(new NewDataEventArg((byte[])inBuffer.Clone()));
                        }
                    }
                    //else
                    //{
                    //    //Handle host disconnected
                    //    //if (ClientDisconnected())
                    //    //{
                    //    //    m_abortPollingThread = true;
                    //    //    OnDisconnect(new DisconnectEventArg()); //Report the client that the connection with sever is cut
                    //    //    break;
                    //    //}
                    //}
                    Thread.Sleep(10);
                }

            }
            catch (Exception ex)
            {
                //m_abortPollingThread = true;
                //Thread.Sleep(100);
                //m_connected = false;


                Disconnect();
                OnDisconnect(new DisconnectEventArg()); //Report the client that the connection with sever is cut
            }

        }


    }
}
