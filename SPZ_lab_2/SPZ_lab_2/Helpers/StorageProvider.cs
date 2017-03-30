using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using SPZ_lab_2.Models;

namespace SPZ_lab_2.Controllers
{
    public class StorageProvider
    {
        public static void SaveToLocalStorage<T>(string filePath, T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            if (false == Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "/" + Constants.Strings.DataFolder))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "/" + Constants.Strings.DataFolder);
            }
            using (var stream = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "/" + Constants.Strings.DataFolder + "/" + filePath, false, Encoding.UTF8))
            {
                serializer.Serialize(stream, obj);
            }
        }

        public static T LoadFromLocalStorage<T>(string filePath) where T : class
        {
            string workingPath = AppDomain.CurrentDomain.BaseDirectory + "/" + Constants.Strings.DataFolder + "/" + filePath;
            if (File.Exists(workingPath) == false)
            {
                return default(T);
            }
            using (FileStream fileStream = new FileStream(workingPath, FileMode.Open))
            {
                using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    using (Stream stream = new MemoryStream())
                    {
                        var serialized = reader.ReadToEnd();
                        MemoryStream stm = new MemoryStream();

                        StreamWriter stw = new StreamWriter(stm);
                        stw.Write(serialized);
                        stw.Flush();

                        stm.Position = 0;

                        XmlSerializer ser = new XmlSerializer(typeof(T));
                        T result = (ser.Deserialize(stm) as T);

                        return result;
                    }
                }
            }
            return default(T);
        }
    }
}
