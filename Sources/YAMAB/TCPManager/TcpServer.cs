using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Sockets;
using System.Threading;
using System.Net;

namespace TcpLib
{
    class TcpServer
    {
        private const int MAX_BUFF_SIZE = 4096;

        private TcpListener tcpListener;
        private Thread listenThread;
        bool m_newDataEventIsEnabled = false;

        #region NewConnectionEvent
        /// <summary>
        /// This arguent is sent as "e" argument when the OnNewConnection event is thrown
        /// I am using this event n order to pass queue which stored the incoming data.
        /// I need separate queue in order to support multiple clients. 
        /// </summary>
        public class NewConnectionArg : EventArgs
        {
            Queue<byte> m_queueIn;
            long m_connectionId;

            /// <summary>
            /// I send to also the queue which enables the user to extract data from the with a separate and not
            /// via the event which sent for each new data. 
            /// The queue shoule be used when high performance is used, otherwise you should use the event.
            /// </summary>
            /// <param name="connectionId"></param>
            /// <param name="queueIn"></param>
            public NewConnectionArg(long connectionId, Queue<byte> queueIn)
            {
                m_queueIn = queueIn;
                m_connectionId = connectionId;
            }

            /// <summary>
            /// Queue which stored the imcoming data
            /// </summary>
            public Queue<byte> QueueIn
            {
                get
                {
                    return m_queueIn;
                }
            }

            /// <summary>
            /// Handle of the Tcp Connection
            /// </summary>
            public long ConnectionId
            {
                get
                {
                    return m_connectionId;
                }
            }
        }

        public delegate void NewConnectionEventHandler(object sender, NewConnectionArg e);
                             
        /// <summary>
        /// The event is raised when new connectioni established with TCP client.
        /// </summary>
        public event NewConnectionEventHandler NewConnectionEvent;

        private void OnNewConnection(NewConnectionArg e)
        {
            NewConnectionEvent(this, e);
        }

        #endregion

        #region CloseConnectionEvent
        /// <summary>
        /// This arguent is sent as "e" argument when the OnNewConnection event is thrown
        /// I am using this event n order to pass queue which stored the incoming data.
        /// I need separate queue in order to support muliple clients. 
        /// </summary>
        public class CloseConnectionArg : EventArgs
        {
            long m_clientId;

            public CloseConnectionArg(long clientId)
            {
                m_clientId = clientId;
            }

            /// <summary>
            /// Handle of the Tcp Connection
            /// </summary>
            public long ClientId
            {
                get
                {
                    return m_clientId;
                }
            }
        }

        public delegate void CloseConnectionEventHandler(object sender, CloseConnectionArg e);

        /// <summary>
        /// The event is raised when the connection with the TCP client is closed.
        /// </summary>
        public event CloseConnectionEventHandler CloseConnectionEvent;

        private void OnCloseConnection(CloseConnectionArg e)
        {
            CloseConnectionEvent(this, e);
        }

        #endregion

        #region NewDataEvent
        /// <summary>
        /// This arguent is sent as "e" argument when the NewDataEvents is thrown
        /// </summary>
        public class NewDataArg : EventArgs
        {
            private byte[] m_newData;
            private long m_clientId;

            public NewDataArg(long clientId,byte[] newData)
            {
                m_newData = newData;
                m_clientId = clientId;
            }

            public byte[] NewData
            {
                get
                {
                    return m_newData;
                }
            }

            /// <summary>
            /// Stores the client id which shoule collect the data.
            /// </summary>
            public long ClientId
            {
                get
                {
                    return m_clientId;
                }
            }
        }

        public delegate void NewDataEventHandler(object sender, NewDataArg e);

        /// <summary>
        /// The event is raised to report about new data to the client.
        /// </summary>
        public event NewDataEventHandler NewDataEvent;

        private void OnNewData(NewDataArg e)
        {
            NewDataEvent(this, e);
        }

        #endregion
        
        /// <summary>
        /// Stores the currently connected clients
        /// Key - client handle number.
        /// Value - TcpClient
        /// </summary>
        Dictionary<long, TcpClient> m_clients = new Dictionary<long, TcpClient>();
        Dictionary<long, Queue<byte>> m_clientsData = new Dictionary<long, Queue<byte>>();

        private void Init(IPAddress ip, int port)
        {
            this.tcpListener = new TcpListener(ip, port);
            this.listenThread = new Thread(new ThreadStart(ListenForClients));
            this.listenThread.Start();
        }


        ///<summary>
        /// Use this contructor if you want to listen for incoming connection attempts on the specified local IP address
        /// and port number.
        ///</summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="newDataEventIsEnabled">
        /// Indicates if event should be raised.
        /// In case of false the data will be stored in queue which shoule be read\clear
        /// by the client
        /// </param>
        public TcpServer(IPAddress ip, int port,bool newDataEventIsEnabled)
        {
            m_newDataEventIsEnabled = newDataEventIsEnabled;
            Init(ip, port);
        }

        /// <summary>
        /// Use this contructor if you want to listen for incoming connection attempts on any local IP address
        /// and port number.
        /// </summary>
        /// <param name="port"></param>
        /// <param name="newDataEventIsEnabled">
        /// Indicates if event should be raised.
        /// In case of false the data will be stored in queue which shoule be read\clear
        /// by the client
        /// </param>
        public TcpServer(int port, bool newDataEventIsEnabled)
        {
            m_newDataEventIsEnabled = newDataEventIsEnabled;
            Init(IPAddress.Any, port);
        }

        public void AbortServer()
        {
            m_listenForClients = false;
            tcpListener.Stop();
        }

        bool m_listenForClients = false;

        private void ListenForClients()
        {
            this.tcpListener.Start();
            long clientHandle;
            TcpClient client;

            m_listenForClients = true;
            while(m_listenForClients)
            {
                //blocks until a client has connected to the server
                try
                {
                    while (tcpListener.Pending() == false)
                    {
                        Thread.Sleep(1);
                        if (m_listenForClients == false)
                        {
                            return;
                        }
                    }
                    client = this.tcpListener.AcceptTcpClient();
                    if (m_listenForClients == false)
                    {
                        return;
                    }
                }
                catch (Exception ex)
                {
                    //ex = ex;
                    //Exception will be thrown in case the application which is using the 
                    //TCP server call the CloseConnection method (usually is called when the 
                    //apllication is closed)
                    return;
                }
                clientHandle = client.Client.Handle.ToInt64();

                //Save the tcp client in dictionary
                m_clients.Add(clientHandle, client);

                //Produce queue for storing the client data
                m_clientsData.Add(clientHandle, new Queue<byte>());

                //Report about new connection
                OnNewConnection(new NewConnectionArg(clientHandle, m_clientsData[clientHandle]));

                //Create a thread to handle communication with connected client
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientCommThread));
                clientThread.Start(client);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="handle"></param>
        /// <param name="data"></param>
        /// <returns>
        /// True in case the data was sent successfully.
        /// </returns>
        /// <remarks>
        /// Use this for sending string - byte[] buffer = encoder.GetBytes("Hello Client!");
        /// </remarks>
        public bool SendData(long handle,byte[] data)
        {
            TcpClient client;
            bool retVal = false;

            try
            {
                client = m_clients[handle];
                NetworkStream clientStream = client.GetStream();
                clientStream.Write(data, 0, data.Length);
                clientStream.Flush();
                retVal =true;
            }
            catch
            {
                OnCloseConnection(new CloseConnectionArg(handle));
            }
            return retVal;
        }

        public void SendData(long handle, string data)
        {
            ASCIIEncoding encoder = new ASCIIEncoding();
            byte[] buffer = encoder.GetBytes(data);

            SendData(handle, data);
        }

        public void CloseConnection(long clientHandle)
        {
            if (m_clients.ContainsKey(clientHandle))
            {
                CloseConnection(m_clients[clientHandle]);
                m_clients.Remove(clientHandle);
            }
        }

        /// <summary>
        /// Close the connection and release all its resources
        /// </summary>
        /// <param name="client"></param>
        private void CloseConnection(TcpClient client)
        {
            long clientHandle;

            RequestCloseConnection();
            //m_closeConnection = true;
            clientHandle = client.Client.Handle.ToInt64();
            OnCloseConnection(new CloseConnectionArg(clientHandle));  //Report about connection close 
            client.Close();
            m_clients.Remove(clientHandle);
            m_clientsData.Remove(clientHandle);
        }

        /// <summary>
        /// Call this function when your application is aborted and you want the server to abort
        /// it waiting for new coonection(it is block method).
        /// </summary>
        public void RequestCloseConnection()
        {
            tcpListener.Stop();
        }


        /// <summary>
        /// Wait for new data from the client
        /// Note that each client has its thread.
        /// </summary>
        /// <param name="client"></param>
        private void HandleClientCommThread(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[MAX_BUFF_SIZE];
            int bytesRead;

            //while (m_closeConnection==false)
            while(m_clients.ContainsKey(tcpClient.Client.Handle.ToInt64()))
            {
                bytesRead = 0;
                try
                {
                    //blocks until a client sends a message
                    bytesRead = clientStream.Read(message, 0, MAX_BUFF_SIZE);

                    if (m_newDataEventIsEnabled)
                    {
                        byte[] cloneMessage;
                        cloneMessage = new byte[bytesRead];
                        for (int i = 0; i < bytesRead; i++)
                        {
                            cloneMessage[i] = message[i];
                        }

                        //Raise event to inform the client about new data, I am using the queue because I need new array
                        //in case the message array will be override with new data
                        OnNewData(new NewDataArg(tcpClient.Client.Handle.ToInt64(), cloneMessage));
                    }
                    else
                    {
                        //Populate the client queue with the new data
                        lock (m_clientsData[tcpClient.Client.Handle.ToInt64()])
                        {
                            for (int i = 0; i < bytesRead; i++)
                            {
                                m_clientsData[tcpClient.Client.Handle.ToInt64()].Enqueue(message[i]);
                            }
                        }
                    }
                }
                catch
                {
                    //a socket error has occured, close the connection
                    OnCloseConnection(new CloseConnectionArg(tcpClient.Client.Handle.ToInt64()));
                    break;
                }

                if (bytesRead == 0)
                {
                    //the client has disconnected from the server
                    break;
                }

                //message has successfully been received
                //ASCIIEncoding encoder = new ASCIIEncoding();
                //System.Diagnostics.Debug.WriteLine(encoder.GetString(message, 0, bytesRead));
                Thread.Sleep(10);
            }
            CloseConnection(tcpClient);
        }


    }
}
