namespace NetConfig
{
    partial class Config
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Config));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sysIPAddress6 = new NetConfig.SysIPAddress();
            this.sysIPAddress5 = new NetConfig.SysIPAddress();
            this.sysIPAddress4 = new NetConfig.SysIPAddress();
            this.sysIPAddress3 = new NetConfig.SysIPAddress();
            this.sysIPAddress2 = new NetConfig.SysIPAddress();
            this.sysIPAddress1 = new NetConfig.SysIPAddress();
            this.ipAddressControl2 = new IPAddressControlLib.IPAddressControl();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "IP-адресс:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Шлюз:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(16, 219);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "DNS:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::NetConfig.Properties.Resources.Button2;
            this.button1.Location = new System.Drawing.Point(151, 274);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "ЗАПИСАТЬ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Image = global::NetConfig.Properties.Resources.Button2;
            this.button2.Location = new System.Drawing.Point(355, 274);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 33);
            this.button2.TabIndex = 17;
            this.button2.Text = "ОТМЕНА";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox1.Location = new System.Drawing.Point(147, 47);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 20);
            this.textBox1.TabIndex = 24;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.textBox2.Location = new System.Drawing.Point(353, 47);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(133, 20);
            this.textBox2.TabIndex = 25;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(16, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 26;
            this.label5.Text = "Название:";
            // 
            // sysIPAddress6
            // 
            this.sysIPAddress6.BackColor = System.Drawing.SystemColors.Window;
            this.sysIPAddress6.Location = new System.Drawing.Point(355, 214);
            this.sysIPAddress6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sysIPAddress6.Name = "sysIPAddress6";
            this.sysIPAddress6.Size = new System.Drawing.Size(132, 20);
            this.sysIPAddress6.TabIndex = 23;
            this.sysIPAddress6.Text = "0.0.0.0";
            // 
            // sysIPAddress5
            // 
            this.sysIPAddress5.BackColor = System.Drawing.SystemColors.Window;
            this.sysIPAddress5.Location = new System.Drawing.Point(355, 155);
            this.sysIPAddress5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sysIPAddress5.Name = "sysIPAddress5";
            this.sysIPAddress5.Size = new System.Drawing.Size(132, 20);
            this.sysIPAddress5.TabIndex = 22;
            this.sysIPAddress5.Text = "0.0.0.0";
            // 
            // sysIPAddress4
            // 
            this.sysIPAddress4.BackColor = System.Drawing.SystemColors.Window;
            this.sysIPAddress4.Location = new System.Drawing.Point(355, 96);
            this.sysIPAddress4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sysIPAddress4.Name = "sysIPAddress4";
            this.sysIPAddress4.Size = new System.Drawing.Size(132, 20);
            this.sysIPAddress4.TabIndex = 21;
            this.sysIPAddress4.Text = "0.0.0.0";
            // 
            // sysIPAddress3
            // 
            this.sysIPAddress3.BackColor = System.Drawing.SystemColors.Window;
            this.sysIPAddress3.Location = new System.Drawing.Point(147, 214);
            this.sysIPAddress3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sysIPAddress3.Name = "sysIPAddress3";
            this.sysIPAddress3.Size = new System.Drawing.Size(132, 20);
            this.sysIPAddress3.TabIndex = 20;
            this.sysIPAddress3.Text = "0.0.0.0";
            // 
            // sysIPAddress2
            // 
            this.sysIPAddress2.BackColor = System.Drawing.SystemColors.Window;
            this.sysIPAddress2.Location = new System.Drawing.Point(147, 155);
            this.sysIPAddress2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sysIPAddress2.Name = "sysIPAddress2";
            this.sysIPAddress2.Size = new System.Drawing.Size(132, 20);
            this.sysIPAddress2.TabIndex = 19;
            this.sysIPAddress2.Text = "0.0.0.0";
            // 
            // sysIPAddress1
            // 
            this.sysIPAddress1.BackColor = System.Drawing.Color.YellowGreen;
            this.sysIPAddress1.Location = new System.Drawing.Point(147, 96);
            this.sysIPAddress1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sysIPAddress1.Name = "sysIPAddress1";
            this.sysIPAddress1.Size = new System.Drawing.Size(132, 20);
            this.sysIPAddress1.TabIndex = 18;
            this.sysIPAddress1.Text = "0.0.0.0";
            this.sysIPAddress1.TextChanged += new System.EventHandler(this.sysIPAddress1_TextChanged);
            // 
            // ipAddressControl2
            // 
            this.ipAddressControl2.AllowInternalTab = false;
            this.ipAddressControl2.AutoHeight = true;
            this.ipAddressControl2.BackColor = System.Drawing.SystemColors.Window;
            this.ipAddressControl2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddressControl2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddressControl2.Location = new System.Drawing.Point(355, 128);
            this.ipAddressControl2.MinimumSize = new System.Drawing.Size(87, 20);
            this.ipAddressControl2.Name = "ipAddressControl2";
            this.ipAddressControl2.ReadOnly = false;
            this.ipAddressControl2.Size = new System.Drawing.Size(132, 20);
            this.ipAddressControl2.TabIndex = 27;
            this.ipAddressControl2.Text = "...";
            // 
            // Config
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::NetConfig.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(588, 322);
            this.Controls.Add(this.ipAddressControl2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.sysIPAddress6);
            this.Controls.Add(this.sysIPAddress5);
            this.Controls.Add(this.sysIPAddress4);
            this.Controls.Add(this.sysIPAddress3);
            this.Controls.Add(this.sysIPAddress2);
            this.Controls.Add(this.sysIPAddress1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Config";
            this.Text = "Конфигурация";
            this.Activated += new System.EventHandler(this.Config_Activated);
            this.Deactivate += new System.EventHandler(this.Config_Deactivate);
            this.Load += new System.EventHandler(this.Config_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Config_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Config_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Config_MouseUp_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private SysIPAddress sysIPAddress1;
        private SysIPAddress sysIPAddress2;
        private SysIPAddress sysIPAddress3;
        private SysIPAddress sysIPAddress4;
        private SysIPAddress sysIPAddress5;
        private SysIPAddress sysIPAddress6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;        
        private IPAddressControlLib.IPAddressControl ipAddressControl2;
    }
}