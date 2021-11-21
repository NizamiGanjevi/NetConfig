using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace NetConfig
{
     public static class ReadXml
    {
        public static string ip1;
        public static string submask = "255.255.255.0";
        public static string gateway1;
        public static string dns1;
        public static string ip2;
        public static string gateway2;
        public static string dns2;
        public static string path = Application.StartupPath + @"\Profile.xml";
        public static string label1;
        public static string label2;
        
        public static void readxml()
        {
            if (File.Exists(path))
            {
                try
                {
                    XmlSerializer create = new XmlSerializer(typeof(Setting));
                    using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                    {

                        Setting set = (Setting)create.Deserialize(fs);
                        ip1 = set.ip1;
                        gateway1 = set.gateway1;
                        dns1 = set.dns1;
                        ip2 = set.ip2;
                        gateway2 = set.gateway2;
                        dns2 = set.dns2;
                        label1 = set.labelb1;
                        label2 = set.labelb2;

                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось прочитать файл конфигурации!");
                    FileInfo fn = new FileInfo(path);
                    fn.Delete();
                    
                    createxml("127.0.0.1", "127.0.0.1", "127.0.0.1", "127.0.0.1", "127.0.0.1", "127.0.0.1", " ", " ");
                }
                
            }
            else
            {
                createxml("127.0.0.1", "127.0.0.1", "127.0.0.1", "127.0.0.1", "127.0.0.1", "127.0.0.1", " ", " ");
                
            }
            
            
            
            
        }
        public static void createxml(string ipadr1, string gate1, string dnss1, string ipadr2, string gate2, string dnss2, string labell1, string labell2)
        {
            XDocument doc = new XDocument(
                new XElement("Setting",
                    new XElement("ip1", ipadr1),
                    new XElement("gateway1", gate1),
                    new XElement("dns1", dnss1),
                    new XElement("ip2", ipadr2),
                    new XElement("gateway2", gate2),
                    new XElement("dns2", dnss2),
                    new XElement("labelb1", labell1),
                    new XElement("labelb2", labell2)));
            doc.Save(path);

        }
    }
}
