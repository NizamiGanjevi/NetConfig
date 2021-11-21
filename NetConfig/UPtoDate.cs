using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NetConfig
{
    class UPtoDate
    {
        
        public static string path = @"\\192.168.0.133\авто\Spy++\set.xml";
        public static string localpath = Application.StartupPath + @"\\NetConfig.exe";
        public static string remotepath = @"\\192.168.0.133\авто\Spy++\NetConfig.exe";
        public static string version;
        public static double newversion;
        public static double oldversion = 1100;
        public static void Updateinfo()
        {
            try
            {

                if (File.Exists(path))
                {
                    XmlSerializer read = new XmlSerializer(typeof(Set));
                    using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
                    {
                        Set set = (Set)read.Deserialize(fs);
                        version = set.version;
                        newversion = Convert.ToDouble(version.Replace(".", ""));
                        if (newversion > oldversion && File.Exists(remotepath))
                        {
                            CopyFile(remotepath, localpath + @".new");
                        }
                    }

                }
            }
            catch
            {

            }
            
           
            
           

        }

        public static void deletebak()
        {
            if (File.Exists(localpath + @".bak"))
            {
                try
                {
                    FileInfo fn = new FileInfo(localpath + @".bak");
                    fn.Delete();
                }
                catch
                {

                }

            }
        }
        public static void Update()
        {
            if (File.Exists(UPtoDate.localpath + @".new"))
            {
                FileInfo fn = new FileInfo(UPtoDate.localpath + @".new");
                fn.Replace(UPtoDate.localpath, UPtoDate.localpath + @".bak");

            }
        }
        private static void CopyFile(string sourcefn, string destinfn)
        {
            FileInfo fn = new FileInfo(sourcefn);
            fn.CopyTo(destinfn, true);
        }

        


        

        
    }
    [Serializable]
    public class Set
    {
        public string version { get; set; }        

        public Set() { }
        public Set(string version1)
        {
            version = version1;
            
        }


    }
    
}
