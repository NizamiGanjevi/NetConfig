using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;

namespace NetConfig
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string  name = "NetConfig";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            if (Process.GetProcessesByName(name).Length > 1)
            {

                IntPtr hWND = FindWindow(null, name);
                ShowWindow(hWND, 9);
                ShowWindow(hWND, 5);
                SetForegroundWindow(hWND);                                                 
                                          
               
            }
            else
            {
                Application.Run(new Form1());
            }
            
            
        }

        
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        
    }


   

}
