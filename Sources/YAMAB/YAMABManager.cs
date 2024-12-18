using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using YAMAB.InputItems;
using YAMAB.Parser;
using TcpLib;
using OrionTools;

namespace YAMAB
{
    public class YAMABManager
    {
        TcpClientManager m_commManager;
        StateMachineYAMAB m_stateMachineYAMAB;
        byte[] m_RX,m_TX;

        public byte[] RX
        {
            get {return m_RX; }
        }

        public byte[] TX
        {
            get { return m_TX; }
        }


        #region Responses Item
        AllSensorsItem m_allSensorsItem=new AllSensorsItem();
        AllBazFailuresItem m_allBazFailuresItem=new AllBazFailuresItem();
        BazFailuresUpdateItem m_bazFailuresUpdateItem=new BazFailuresUpdateItem();
        #endregion

        /// <summary>
        /// Connect TCP server using the specified IP and port
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="port"></param>
        /// <param name="delayBeforeSendingEcho">The delay time between connection established and start send the echo command</param>
        public void Connect(string ip = "132.4.5.50", int port = 3000,int delayBeforeSendingEcho=2000)
        {
            //Now connect to the computer via UDP
            m_commManager = new TcpClientManager(ip, port, true);
            m_commManager.NewDataEvent += new TcpClientManager.NewDataEventHandler(UdpNewDataEventHandler);

            m_stateMachineYAMAB = new StateMachineYAMAB();
            m_stateMachineYAMAB.NewDataEvent += new StateMachineBase.NewDataEventHandler(StateMachineNewDataEventHandler);

            m_commManager.SyncConnect();

            //Wait for connection established
            TimeoutManager tm = new TimeoutManager(10000);
            tm.Start();
            while ((m_commManager.Connected == false) && (!tm.Timeout))
            {
                Thread.Sleep(1);
            }
            if (m_commManager.Connected == false)
            {
                throw new Exception("Cannot connect.");
            }

            Thread.Sleep(delayBeforeSendingEcho);
            m_thrdEcho = new Thread(SendEchoThred);
            m_thrdEcho.Start();

        }


        Thread m_thrdEcho;
        bool m_abortEchoThred;
       
        public void Disconnect()
        {
            m_abortEchoThred = true;
            System.Threading.Thread.Sleep(1000);
            if (m_commManager != null)
            {
                m_commManager.Disconnect();
                m_commManager = null;
                
            }
           
        }

        #region Event Handler
        private void UdpNewDataEventHandler(object sender, TcpClientManager.NewDataEventArg e)
        {
            m_RX = e.NewData;
            m_stateMachineYAMAB.Process(e.NewData);
        }

        private void StateMachineNewDataEventHandler(object sender, StateMachineYAMAB.NewDataArg e)
        {
            const int START_INDEX = 0;

            uint unitCode;
            uint opcode;
            uint length; //Data length
            int index = START_INDEX;

            try
            {
                //The unit code is located at the first byte of the message (one byte at index 0)
                unitCode = e.NewData[index++];

                //The opcode is located at 2 bytes after the unit code (two bytes at indexes 1 - 2)
                opcode = Shared.m_ConversionsLittleEndian.UshortFromBytes(e.NewData, index);
                index += 2;

                //The length is located at 2 bytes after the opcode (two bytes at indexes 3 - 4)
                length = Shared.m_ConversionsLittleEndian.UshortFromBytes(e.NewData, index);
                index += 2;

                switch ((Enums.Opcodes)opcode)
                {
                    case Enums.Opcodes.ALL_SENSORS:
                        AllSensorsParser.Parse(e.NewData, ref m_allSensorsItem);
                        m_allSensorsItem.answerReceieved = true;
                        break;
                    case Enums.Opcodes.ALL_BAZ_FAILURES:
                        AllBazFailuresParser.Parser(e.NewData, ref m_allBazFailuresItem);
                        m_allBazFailuresItem.answerReceieved = true;
                        break;
                    case Enums.Opcodes.BAZ_FAILURES_UPDATE:
                        BazFailuresUpdateParser.Parser(e.NewData, ref m_bazFailuresUpdateItem);
                        m_bazFailuresUpdateItem.answerReceieved = true;
                        break;
                    case Enums.Opcodes.ECHO:
                        //SendEcho();
                        break;
                    default:
                        //Opcode doesn't exist
                        break;
                }
            }

            catch (Exception ex)
            { 
            
            }
        }
        #endregion

        private void SendMessage(Enums.Opcodes opcode, byte[] data)
        {
            byte[] message2send=null;

            //if (opcode == Enums.Opcodes.ECHO)
            //{
              //  message2send = PackMessage2ECHOSend(opcode, data);
            //}
            //else
            //{
                message2send = PackMessage2Send(opcode, data);
            //}
            lock (m_commManager)
            {
                m_TX = message2send;
                m_commManager.SendMessage(message2send);
            }
        }


        private byte[] PackMessage2Send(Enums.Opcodes opcode, byte[] data)
        {
            List<byte> buffer2Send = new List<byte>
            {
                144
                //StateMachineYAMAB.ZABAD_ID // Add unit code
            };

            buffer2Send.AddRange(Shared.m_ConversionsLittleEndian.UShortToBytes((ushort)opcode)); // Add opcode

            //buffer2Send.Add(71);
            //Message data
            if (data != null)
            {
                buffer2Send.AddRange(Shared.m_ConversionsLittleEndian.UShortToBytes((ushort)data.Length)); // Add data length
                buffer2Send.AddRange(data); // Add data
            }
            else
            {
                buffer2Send.AddRange(Shared.m_ConversionsLittleEndian.UShortToBytes(0)); // No data - Add data length = 0
            }

            return buffer2Send.ToArray();
        }



        //private byte[] PackMessage2Send(Enums.Opcodes opcode, byte[] data)
        //{
        //    List<byte> buffer2Send = new List<byte>
        //    {
        //        StateMachineYAMAB.ZABAD_ID // Add unit code
        //    };

        //    buffer2Send.AddRange(Shared.m_ConversionsLittleEndian.UShortToBytes((ushort)opcode)); // Add opcode

        //    Message data
        //    if (data != null)
        //    {
        //        buffer2Send.AddRange(Shared.m_ConversionsLittleEndian.UShortToBytes((ushort)data.Length)); // Add data length
        //        buffer2Send.AddRange(data); // Add data
        //    }
        //    else
        //    {
        //        buffer2Send.AddRange(Shared.m_ConversionsLittleEndian.UShortToBytes(0)); // No data - Add data length = 0
        //    }

        //    return buffer2Send.ToArray();
        //}

        private bool WaitForResponse(ResponseItemBase response, int timeOutIntervalMsec = 1000)
        {
            TimeoutManager timeOutManger;
            bool retVal = true;

            timeOutManger = new TimeoutManager(timeOutIntervalMsec);
            timeOutManger.Start();
            while ((response.answerReceieved == false) && (timeOutManger.Timeout == false))
            {
                Thread.Sleep(1);
            }
            if (timeOutManger.Timeout)
            {
                retVal = false;
            }
            return retVal;
        }

        #region Messages


        /// <summary>
        /// 
        /// </summary>
        /// <param name="bazMode">0:Emergency</param>
        /// <param name="traverseAngleGunnerMirror">rad</param>
        /// <param name="jackingAngleGunnerMirror">rad</param>
        /// <param name="solonoidJacking">0:Close; 1:Open</param>
        /// <param name="solonoidTraverse">0:Close; 1:Open</param>
        /// <param name="sachiputResetValueTraverse">mrad</param>
        /// <param name="sachiputResetValueJacking">mrad</param>
        /// <param name="driftCalibrationStatus">0:Not in process, 1:In process</param>
        public void GetAllSensorsInformation(out byte bazMode,
                                                out float traverseAngleGunnerMirror,
                                                out float jackingAngleGunnerMirror,
                                                out byte solonoidJacking,
                                                out byte solonoidTraverse,
                                                out float sachiputResetValueTraverse,
                                                out float sachiputResetValueJacking,out byte driftCalibrationStatus)
        {
            m_allSensorsItem.answerReceieved = false;

           // byte[] data = new byte[1]
           // {
           //     71
           //};
           
           // SendMessage(Enums.Opcodes.ALL_SENSORS, data);

            if (WaitForResponse(m_allSensorsItem) == false)
            {
                throw new Exception("Device is not responding");
            }
            else
            {
                bazMode = m_allSensorsItem.m_bazMode;
                traverseAngleGunnerMirror = m_allSensorsItem.m_traverseAngleGunnerMirror;
                jackingAngleGunnerMirror = m_allSensorsItem.m_jackingAngleGunnerMirror;
                solonoidJacking = m_allSensorsItem.m_solonoidJacking;
                solonoidTraverse = m_allSensorsItem.m_solonoidTraverse;
                sachiputResetValueTraverse = m_allSensorsItem.m_sachiputResetValueTraverse;
                sachiputResetValueJacking = m_allSensorsItem.m_sachiputResetValueJacking;
                driftCalibrationStatus = m_allSensorsItem.m_driftCalibrationStatus;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberOfFailures"></param>
        /// <param name="errorNumber">0:1534</param>
        public void GetAllBazFailures(out ushort numberOfFailures, out ushort errorNumber)
        {
            m_allBazFailuresItem.answerReceieved = false;

            byte[] data = new byte[1]
            {
                71
           };
           
            SendMessage(Enums.Opcodes.ALL_BAZ_FAILURES, data);

            if (WaitForResponse(m_allBazFailuresItem) == false)
            {
                throw new Exception("Device is not responding");
            }
            else
            {
                numberOfFailures = m_allBazFailuresItem.m_numberOfFailures;
                errorNumber = m_allBazFailuresItem.M_errorNumber;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="failureNumber">0:1534</param>
        /// <param name="status">0:Not exist; 1:Exist</param>
        public void GetBazFailuresUpdate(out ushort failureNumber, out byte status)
        {
            m_bazFailuresUpdateItem.answerReceieved = false;

            byte[] data = new byte[1]
            {
                71
           };
           
            SendMessage(Enums.Opcodes.BAZ_FAILURES_UPDATE, data);

            if (WaitForResponse(m_bazFailuresUpdateItem) == false)
            {
                throw new Exception("Device is not responding");
            }
            else
            {
                failureNumber = m_bazFailuresUpdateItem.m_failureNumber;
                status = m_bazFailuresUpdateItem.m_status;
            }
        }


        public void SendEcho()
        {
            byte[] data = new byte[1]
            {
                71
           };
            SendMessage(Enums.Opcodes.ECHO, data);


        }

        private void SendEchoThred()
        {
           byte[] data = new byte[1]
            {
                71
           };
                      
           while (m_abortEchoThred == false)
           {
               try
               {
                   SendMessage(Enums.Opcodes.ECHO, data);
                   Thread.Sleep(1000);
               }
               catch
               { 

               }

           }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="systemMode">0:Emergency; 1:Gun slaved; 2:Sight slave; 3:Gun slaved and tacho</param>
        public void SetMainSystemMode(byte systemMode)
        {
            byte[] data = new byte[2]
            {
                71,
                systemMode
            };

            SendMessage(Enums.Opcodes.SET_MAIN_SYSTEM_MODE, data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="bazParamType">EL=4; AZ=5</param>
        /// <param name="value">Units in mrad. EL range=(-244):384; AZ range=(-60):60</param>
        public void SetBazParameters(byte bazParamType, float value)
        {
            List<byte> data = new List<byte>
            {
                71,
                3,//Indicates manual mode
                bazParamType
            };

            if (bazParamType == 4)//Elevation
            {
                value = (float)-1.01845958 * value;
           }
            else if (bazParamType == 5)//azimuth
            {
                value = (float)1.01845958 * value;
            }

            data.AddRange(Shared.m_ConversionsLittleEndian.FloatToBytes(value));
            SendMessage(Enums.Opcodes.SET_BAZ_PARAMETERS, data.ToArray());
        }

        public void SetDriftMode()
        {
            byte[] data = new byte[1]
            {
                71
           };
           
            SendMessage(Enums.Opcodes.SET_DRIFT_MODE, data);
        }

        public void RequestErrorTable()
        {
            byte[] data = new byte[1]
            {
                71
           };
           
            SendMessage(Enums.Opcodes.REQUEST_ERROR_TABLE, data);
        }
        #endregion
    }
}
