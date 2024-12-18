using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;
using TcpLib;

namespace TcpLib
{
    /// <summary>
    /// http://stackoverflow.com/questions/16113524/converting-windows-sockets-to-net
    /// </summary>
    internal class UdpClientManager : CommManagerBase
    {
        IPEndPoint m_ipEndPointTransmit;
        System.Net.Sockets.UdpClient m_udpClient;
        IPAddress m_ip;
        int m_portTransmit;
        int m_portReceive;
        bool m_raiseEventOnNewData=true;
        bool m_abortPollingThread = false;
        Queue<byte> m_buffer = new Queue<byte>();
        bool m_connected; 

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
        public int PortTranmsit
        {
            get
            {
                return m_portTransmit;
            }
        }

        /// <summary>
        /// Return the server port.
        /// </summary>
        public int PortReceive
        {
            get
            {
                return m_portReceive;
            }
        }

        Socket m_socket;
        int m_receivePollingDelayMsec = 1;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="portReceive">Port to use for receiving data</param>
        /// <param name="portTransmit">Port to use for transmiting data</param>
        /// <param name="raiseEventOnNewData">
        ///  Indicates if new data is read directly from the queue or "New Data" event should be rasied.
        /// </param>
        /// <param name="receivePollingDelayMsec">Delay used in the polling thread.</param>
        public UdpClientManager(string ip, int portTransmit,int portReceive,bool raiseEventOnNewData,int receivePollingDelayMsec=1)
        {
            m_portTransmit = portTransmit;
            m_portReceive = portReceive;
            m_receivePollingDelayMsec =receivePollingDelayMsec;
            m_udpClient = new System.Net.Sockets.UdpClient();
            m_ip = IPAddress.Parse(ip);
            //m_ip = IPAddress.Any;
            m_ipEndPointTransmit = new IPEndPoint(IPAddress.Parse(ip), m_portTransmit);
            m_raiseEventOnNewData = raiseEventOnNewData;

            //IPEndPoint ep=new IPEndPoint(IPAddress.Any,0);
            //Socket m_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IPv4);
            //m_socket.Bind(ep);
                
        }

        /// <summary>
        /// Async connect has been complete.
        /// </summary>
        /// <param name="ar"></param>
        private void OnConnect(IAsyncResult ar)
        {
            try
            {
                //m_tcpClient.EndConnect(ar);
                OnConnectionEstablished(new ConnectionEstablishedEventArg());
                m_connected = true;
                Thread thrd = new Thread(PollingDataThread);
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
        /// <param name="message"></param>
        public void SendAsciMessage(string message)
        {
            SendMessage(Encoding.ASCII.GetBytes(message));
        }

        /// <summary>
        /// Split the string to chars and send.
        /// Note each line should be terminated with \n.
        /// </summary>
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
            m_ip=IPAddress.Any;
            IPEndPoint serverEndPoint = new IPEndPoint(m_ip, 0);  
            //m_tcpClient.BeginConnect(m_ip, m_port, OnConnect, null);
        }

        bool m_exit=false;

        /// <summary>
        /// 
        /// </summary>
        private void SyncConnectThread()
        {
            IPEndPoint serverEndPoint = new IPEndPoint(m_ip, m_portReceive);
            m_exit = false;

            while (m_exit == false)
            {
                try
                {
                    //m_udpClient.Close();
                    //m_udpClient = new System.Net.Sockets.UdpClient();
                    //m_udpClient.Connect(serverEndPoint);
     
                    ////Thread.Sleep(1000);   //Delay is needed, otherwise exception is thrown
                    //m_connected = true;
                    //OnConnectionEstablished(new ConnectionEstablishedEventArg());


                    IPEndPoint ep = new IPEndPoint(IPAddress.Any, m_portReceive);
                
                    m_socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Unspecified);
                    m_socket.Bind(ep);

                    //if (m_socket.IsBound)
                    {
                        m_connected = true;
                        OnConnectionEstablished(new ConnectionEstablishedEventArg());

                        Thread thrd = new Thread(PollingDataThread);
                        thrd.Start();
                        break;
                    }
                }
                catch(Exception ex)
                {
                }
                Thread.Sleep(100);
            }
        }

        public void AbortSyncConnect()
        {
            m_exit = true;
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
            lock (m_socket)
            {
                m_socket.SendTo(buffer, m_ipEndPointTransmit);
            }
            //m_socket.Send(buffer, 0, buffer.Length, SocketFlags.None, m_ipEndPointTransmit, null, null);
            //m_udpClient.Client.BeginSendTo(buffer, 0, buffer.Length,SocketFlags.None ,m_ipEndPointTransmit,null,null);
            //m_udpClient.Client.Send(buffer);
            //try
            //{
            //    m_tcpClient.GetStream().Write(buffer, 0, buffer.Length);
            //}
            //catch
            //{
            //    m_connected = false;
            //    Disconnect();
            //    OnDisconnect(new DisconnectEventArg()); //Report the client that the connection with sever is cut();
            //}
        }

        public void Disconnect()
        {
            m_abortPollingThread = true;
            Thread.Sleep(100);
            m_connected = false;
            m_exit = true;
            m_udpClient.Client.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();
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
            int inBufferCount;

            //IPEndPoint groupEP = new IPEndPoint(m_ip, m_portReceive); // listen on any port
            m_ip = IPAddress.Any;
            EndPoint ep = new IPEndPoint(m_ip, 0); // listen on any port; m_portReceive

            m_abortPollingThread = false;
            try
            {
                while (!(m_abortPollingThread) && (m_exit == false))
                {
                    lock (m_socket)
                    {
                        if (m_socket.Available > 0)
                        {
                            inBuffer = new byte[m_socket.Available];
                            inBufferCount = m_socket.ReceiveFrom(inBuffer, ref ep);
                            //m_udpClient.Receive(ref groupEP);
                            //if (m_udpClient.Available > 0)
                            {
                                //inBuffer = new byte[255];
                                //inBuffer = m_udpClient.Receive(ref groupEP);
                                //inBufferCount=m_udpClient.Client.ReceiveFrom(inBuffer,inBuffer.Length, SocketFlags.None, ref ep);
                                //m_tcpClient.GetStream().Read(inBuffer, 0, inBuffer.Length);

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
                                    OnNewData(new NewDataEventArg((byte[])inBuffer));
                                }
                            }
                           
                        }
                    }
                    if (m_receivePollingDelayMsec > 0)
                    {
                        Thread.Sleep(m_receivePollingDelayMsec);
                    }
                }
            }
            catch(Exception ex)
            {
                Disconnect();
                OnDisconnect(new DisconnectEventArg()); //Report the client that the connection with sever is cut
            }

        }

    }
}
