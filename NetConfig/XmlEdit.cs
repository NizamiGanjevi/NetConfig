using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.XPath;

namespace NetConfig
{
    class XmlEdit
    {
        static int ProfileID = 0;
        static public string path = Application.StartupPath + @"\Setting.xml";
        public static string[] ProfileList = new string[0];
        static public int numprof = 0;
        static public string ProfileName;
        static public string IPAddress;
        static public string SubMask;
        static public string Gateway;
        static public string DNS1;
        static public string DNS2;
        

        public static void CreateNewProfile(string name)
        {
            if (!File.Exists(path) || ProfileList.Length == 0)
            {
                XDocument doc = new XDocument(
                new XElement("Setting",
                    new XElement("Profile",
                        new XAttribute("id", ProfileID++),
                        new XElement("name", name),
                        new XElement("ip", " "),
                        new XElement("submask", " "),
                        new XElement("gateway", " "),
                        new XElement("primDNS", " "),
                        new XElement("secDNS", " "))));
                doc.Save(path);
            }
            else
            {
                XDocument doc = XDocument.Load(path);

                int maxId = doc.Root.Elements("Profile").Max(t => Int32.Parse(t.Attribute("id").Value));
                XElement Profile = new XElement("Profile",
                    new XAttribute("id", maxId + 1),
                    new XElement("name", name),
                    new XElement("ip", " "),
                    new XElement("submask", " "),
                    new XElement("gateway", " "),
                    new XElement("primDNS", " "),
                    new XElement("secDNS", " "));
                doc.Root.Add(Profile);
                doc.Save(path);

            }

        }
        
        public static void ReadProfileList()
        {
            try
            {
                XDocument doc = XDocument.Load(path);
                int maxId = doc.Root.Elements("Profile").Max(t => Int32.Parse(t.Attribute("id").Value));
                int i = 0;
                foreach (XElement el in doc.Root.Elements())
                {
                    i++;
                    numprof = i - 1;
                    Array.Resize(ref ProfileList, i);
                    ProfileList[numprof] = el.Element("name").Value.ToString();
                    int id = Int32.Parse(el.Attribute("id").Value);
                    id = numprof;
                    el.Attribute("id").Value = id.ToString();
                    doc.Save(path);

                }
            }
            catch
            {

            }
           
        }
        public static void ReadProfileSet(int Profnum)
        {
            XElement doc = XElement.Load(path);
            IEnumerable<XElement> list1 =
                from el in doc.Elements()
                where Int32.Parse(el.Attribute("id").Value) == Profnum
                select el;
            

            foreach (XElement el in list1)
            {
                ProfileName = el.Element("name").Value;
                IPAddress = el.Element("ip").Value;
                SubMask = el.Element("submask").Value;
                Gateway = el.Element("gateway").Value;
                DNS1 = el.Element("primDNS").Value;
                DNS2 = el.Element("secDNS").Value;

            }                                   
        }
        public static void DeleteProfile(int Profnum)
        {
            XDocument doc = XDocument.Load(path);
            IEnumerable<XElement> tracks = doc.Root.Elements("Profile").Where(
                t => Int32.Parse(t.Attribute("id").Value) == Profnum).ToList();
            tracks.Remove();
            doc.Save(path);
            
        }
        public static void RenameProfile(int index, string name)
        {


        }

    }
}
