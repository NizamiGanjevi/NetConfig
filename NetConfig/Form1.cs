using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.Threading;

namespace NetConfig
{
    public partial class Form1 : Form
    {

        public string ip, gate, dns;           
        public static int count = 0;
        int X, Y; //переменные для передвижения формы
        Boolean bDrag = false;
       
        public Form1()
        {
            InitializeComponent();
            DMenuStrip();
            notifyIcon1.Visible = true;            
            IPStatus();
            UPtoDate.Update();
            UPtoDate.deletebak();
            timer2.Start();
            DeleteStartapp();
            LoadList();
            
            
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        //Объявляем глабальные переменные и путь к файлу настроек  

        private void Exit()
        {
            this.Visible = false;
            UPtoDate.Update();
            UPtoDate.deletebak();
        }

        private void minimize()
        {
            this.WindowState = FormWindowState.Minimized;
        }

        //Испульзуем метод для открытия формы с настройкой профиля
        private void button3_Click(object sender, EventArgs e)
        {
            
            ShowNewProfil();
                      
        }
        //Метод для открытия формы настройки профиля
        private void ShowNewProfil()
        {
            
            //Задаем переменную для работы с классом 
             
            Config config = new Config();
            config.ShowDialog();
            UPtoDate.Update();
            UPtoDate.deletebak();
                    

        }
        private void button5_Click(object sender, EventArgs e)
        {
            minimize();
        }       
        
        private void button4_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;          
        }

       

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;    
            
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            this.button4.Image = global::NetConfig.Properties.Resources.Exit2;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            
            this.button4.Image = global::NetConfig.Properties.Resources.Exit4;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            this.button5.Image = global::NetConfig.Properties.Resources.minimize2;
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            this.button5.Image = global::NetConfig.Properties.Resources.minimize3;
        }
                

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            this.button3.BackgroundImage = global::NetConfig.Properties.Resources.Setting2;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.button3.BackgroundImage = global::NetConfig.Properties.Resources.Setting1;
        }
        
        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                X = Cursor.Position.X;
                Y = Cursor.Position.Y;
                bDrag = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (bDrag == true)
            {
                this.Location = new Point(this.Location.X + Cursor.Position.X - X, this.Location.Y + Cursor.Position.Y - Y);
                X = Cursor.Position.X;
                Y = Cursor.Position.Y;
            }
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bDrag = false;
            }
        }

      
        private void Form1_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible == true & this.ShowInTaskbar == true)
            {
                notifyIcon1.Visible = true;
            }
            else if (this.Visible == false)
            {
                notifyIcon1.Visible = true;
            }
        }
        

        private void IPStatus()
        {            
            ReadXml.readxml();
            NetMC.GetIP();
            ip = NetMC.IPAdress;
            gate = NetMC.gateaddress;
            dns = NetMC.DnsAddress1;
            textBox1.Text = ip;
            textBox2.Text = "255.255.255.0";
            textBox3.Text = gate;
            textBox4.Text = dns;
        }       

        private void timer1_Tick(object sender, EventArgs e)
        {
            int sec = 100;
            timer1.Interval = sec;
            IPStatus();      
                              
                       
        }
       
        

        private void DMenuStrip()
        {
            this.contextMenuStrip1.Renderer = new ContextMenuStripBackColorRenderer();
            this.contextMenuStrip1.Invalidate();
            this.contextMenuStrip2.Renderer = new ContextMenuStripBackColorRenderer();
            this.contextMenuStrip2.Invalidate();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ip == ReadXml.ip1)
            {
                UPtoDate.Updateinfo();
            }
            timer2.Interval = 60000;
        }
        
        //__________________________________________________________//

        private void DeleteStartapp()
        {
            if (Directory.Exists(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\NetConfig"))
            {
                DirectoryInfo di = new DirectoryInfo(@"C:\ProgramData\Microsoft\Windows\Start Menu\Programs\Startup\NetConfig");
                di.Delete(true);
            }
            
        }

        

        private void label4_Click(object sender, EventArgs e)
        {
        }
        

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadList()
        {
            XmlEdit.ReadProfileList();
            listBox1.Items.Clear();
            if (!File.Exists(XmlEdit.path) || XmlEdit.ProfileList.Length == 0)
            {                               
                listBox1.Items.Add("Нет Профилей");                
            }            
            else
            {
                for (int i = 0; i <= XmlEdit.numprof; i++)
                {
                    listBox1.Items.Add(XmlEdit.ProfileList[i]);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ProfNum = listBox1.SelectedIndex;
            XmlEdit.ReadProfileSet(ProfNum);
            ipAddressControl1.Text = XmlEdit.IPAddress;
            ipAddressControl2.Text = XmlEdit.SubMask;
            ipAddressControl3.Text = XmlEdit.Gateway;
            ipAddressControl4.Text = XmlEdit.DNS1;
            ipAddressControl5.Text = XmlEdit.DNS2;
            ipAddressControl1.Enabled = true;
            ipAddressControl2.Enabled = true;
            ipAddressControl3.Enabled = true;
            ipAddressControl4.Enabled = true;
            ipAddressControl5.Enabled = true;
        }

       

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int n = listBox1.IndexFromPoint(e.X, e.Y);
                if (n != ListBox.NoMatches)
                {
                    listBox1.SelectedIndex = n;
                    contextMenuStrip2.Show(listBox1, e.Location);                    
                }
            }
        }

        private void переименоватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenameProfile rename = new RenameProfile();
            rename.ShowDialog();
            RenameProfile.bName = true;
            RenameProfile.index = listBox1.SelectedIndex;
            
        }
        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int n = listBox1.SelectedIndex;            
            XmlEdit.DeleteProfile(n);            
            LoadList();
        }

        private void stylebutton1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();               
            RenameProfile newprof = new RenameProfile();
            newprof.ShowDialog();
            LoadList();
        }

        private void stylebutton4_Click(object sender, EventArgs e)
        {
            NetMC.SetIP(ipAddressControl1.Text, "255.255.255.0");
            NetMC.setGateway(ipAddressControl3.Text);
            NetMC.setDNS(ipAddressControl4.Text);
            IPStatus();
        }

        private void stylebutton3_Click(object sender, EventArgs e)
        {
            IPStatus();
        }

        private void stylebutton2_Click(object sender, EventArgs e)
        {

        }

        

        

        
                        
    }
}
