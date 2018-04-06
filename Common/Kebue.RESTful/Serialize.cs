using Newtonsoft.Json;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Kebue.RESTful
{
    public static class Serialize
    {
        /// <summary>
        /// 序列化 String
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string SerializeString<T>(this T obj)
        {
            // 序列化
            return JsonConvert.SerializeObject(obj);
            //using (MemoryStream stream = new MemoryStream())
            //{
            //    DataContractJsonSerializer jsonSerialize = new DataContractJsonSerializer(typeof(T));
            //    jsonSerialize.WriteObject(stream, obj);
            //    return Encoding.UTF8.GetString(stream.ToArray());
            //}
        }

        public static string XmlSerializerString<T>(this T obj, Encoding encoding = null)
        {
            if (obj == null)
            {
                throw new ArgumentNullException("Input Object Is Equals Null");
            }
            if (encoding == null)
            {
                encoding = Encoding.UTF8;
            }
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineChars = "\r\n";
            settings.Encoding = encoding;
            settings.IndentChars = "    ";
            using (MemoryStream stream = new MemoryStream())
            {
                using (XmlWriter writer = XmlWriter.Create(stream, settings))
                {
                    serializer.Serialize(writer, obj);
                    writer.Close();
                }
                stream.Position = 0;
                using (StreamReader reader = new StreamReader(stream, encoding))
                {
                    return reader.ReadToEnd();
                }
            }
        }
    }
}
