using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationManager
{
    class SerializationTools
    {

        static DateTime m_lastOperationTime = DateTime.Now.AddDays(-1);
        private const double WAIT_TIME = 10;//msec

        /// <summary>
        /// Validate waiting time between serialize and deserialize operations
        /// </summary>
        private static void ValidateOperationTime()
        {
            TimeSpan ts = DateTime.Now - m_lastOperationTime;
            int timeToWait;

            if (ts.TotalMilliseconds < WAIT_TIME)
            {
                timeToWait = (int)(WAIT_TIME - ts.TotalMilliseconds);
                System.Threading.Thread.Sleep(timeToWait);
            }
            m_lastOperationTime = DateTime.Now;
        }

        /// <summary>
        /// write the specified object to an xml file at a given location
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="obj">This parameter is sent in order to get its type later</param>
        internal static void SerializeObject(string fileName, object obj)
        {
            XmlSerializer xmlSerial;
            Stream writer = null;

            try
            {
                ValidateOperationTime();
                xmlSerial = new XmlSerializer(obj.GetType());

                using (writer = new FileStream(fileName, FileMode.Create))
                {
                    xmlSerial.Serialize(writer, obj);
                    writer.Flush();
                    //writer.Close();
                }

                //writer.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                //if (writer != null)
                //{
                //    writer.Close();
                //}
            }
        }

        /// <summary>
        /// convert the specified xml file into the given object
        /// the caller must verify that the file exists!
        /// </summary>
        /// <remarks>
        /// #9509 - fixed bug, the previous mechanism that uses the Stream reader, did not load the text with the Enter character.
        /// </remarks>
        /// <param name="fileName"></param>
        /// <param name="obj"></param>
        /// <returns></returns>
        internal static object DeserializeObject(string fileName, object obj)
        {
            object desObj;
            XmlTextReader xmlTextReader = null;

            try
            {
                ValidateOperationTime();
                //#9509 - remove this code
                //XmlSerializer xmlSerial = new XmlSerializer(obj.GetType());
                //Stream reader = new FileStream(fileName, FileMode.Open);
                //desObj = xmlSerial.Deserialize(reader);
                //reader.Close();
                //return desObj;


                //#9509 - new code
                XmlSerializer xmlSerial = new XmlSerializer(obj.GetType());
                xmlTextReader = new XmlTextReader(fileName);
                desObj = xmlSerial.Deserialize(xmlTextReader);
                //xmlTextReader.Close();
                return desObj;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (xmlTextReader != null)
                {
                    xmlTextReader.Close();
                }
            }
        }
    }
}
