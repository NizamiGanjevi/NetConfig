using System;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;

namespace NetConfig
{
    public partial class Config : Form
    {
        int X, Y;
        Boolean bDrag = false;
        public Config()
        {
            InitializeComponent();
            Load_Config();
            

        }

  

       
       
       

        public void button1_Click(object sender, EventArgs e)
        {
            create(sysIPAddress1.Text, sysIPAddress2.Text, sysIPAddress3.Text, sysIPAddress4.Text, sysIPAddress5.Text, sysIPAddress6.Text, textBox1.Text, textBox2.Text);            
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            
            this.button1.Image = global::NetConfig.Properties.Resources.Button;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
            this.button1.Image = global::NetConfig.Properties.Resources.Button2;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            
            
        }

        

        private void Config_Load(object sender, EventArgs e)
        {
                     
        }

        private void Config_Activated(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            this.Hide();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.Image = global::NetConfig.Properties.Resources.Button;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.Image = global::NetConfig.Properties.Resources.Button2;
        }

        private void Config_Deactivate(object sender, EventArgs e)
        {
            
        }
        public static void create(string ipadr1, string gate1, string dnss1, string ipadr2, string gate2, string dnss2, string label1, string label2)
        {
            ReadXml.createxml(ipadr1, gate1, dnss1, ipadr2, gate2, dnss2, label1, label2);
            
        }

        private void sysIPAddress1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Load_Config()
        {
            ReadXml.readxml();
            sysIPAddress1.Text = ReadXml.ip1;
            sysIPAddress2.Text = ReadXml.gateway1;
            sysIPAddress3.Text = ReadXml.dns1;
            sysIPAddress4.Text = ReadXml.ip2;
            sysIPAddress5.Text = ReadXml.gateway2;
            sysIPAddress6.Text = ReadXml.dns2;            
            textBox1.Text = ReadXml.label1;
            textBox2.Text = ReadXml.label2;
            
        }

        private void Config_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                X = Cursor.Position.X;
                Y = Cursor.Position.Y;
                bDrag = true;
            }
        }

        private void Config_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (bDrag == true)
            {
                this.Location = new Point(this.Location.X + Cursor.Position.X - X, this.Location.Y + Cursor.Position.Y - Y);
                X = Cursor.Position.X;
                Y = Cursor.Position.Y;
            }
        }

        private void Config_MouseUp_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bDrag = false;
            }
        }

    }
    [Serializable]
    
    public class Setting
    {
        public string ip1 { get; set; }
        public string gateway1 { get; set; }
        public string dns1 { get; set; }
        public string ip2 { get; set; }
        public string gateway2 { get; set; }
        public string dns2 { get; set; }
        public string labelb1 { get; set; }
        public string labelb2 { get; set; }
        
        public Setting() { }
        public Setting(string ipadr1, string gate1, string dnss1, string ipadr2, string gate2, string dnss2, string label1, string label2)
        {
            ip1 = ipadr1;
            gateway1 = gate1;
            dns1 = dnss1;
            ip2 = ipadr2;
            gateway2 = gate2;
            dns2 = dnss2;
            labelb1 = label1;
            labelb2 = label2;
        }

        
    }

    
    
}
