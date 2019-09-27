using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Referee.Core
{
    public static class Util
    {
        /// <summary>
        ///     Serializes an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="serializableObject"></param>
        /// <param name="fileName"></param>
        public static bool SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) return false;


            var xmlDocument = new XmlDocument();
            var serializer = new XmlSerializer(serializableObject.GetType());
            using (var stream = new MemoryStream())
            {
                serializer.Serialize(stream, serializableObject);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(fileName);
            }


            return true;
        }


        /// <summary>
        ///     Deserializes an xml file into an object list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public static T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) return default;

            var objectOut = default(T);

            try
            {
                var xmlDocument = new XmlDocument();
                xmlDocument.Load(fileName);
                var xmlString = xmlDocument.OuterXml;

                using (var read = new StringReader(xmlString))
                {
                    var outType = typeof(T);

                    var serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T) serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception)
            {
            }

            return objectOut;
        }
    }
}