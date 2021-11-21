namespace NetConfig
{
    partial class RenameProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenameProfile));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stylebutton2 = new NetConfig.Stylebutton();
            this.stylebutton1 = new NetConfig.Stylebutton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Square721 BT", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Location = new System.Drawing.Point(89, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 21);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Square721 BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label2.Location = new System.Drawing.Point(5, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Название:";
            // 
            // stylebutton2
            // 
            this.stylebutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stylebutton2.BackgroundImage")));
            this.stylebutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stylebutton2.FlatAppearance.BorderSize = 0;
            this.stylebutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stylebutton2.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stylebutton2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.stylebutton2.Location = new System.Drawing.Point(156, 69);
            this.stylebutton2.Name = "stylebutton2";
            this.stylebutton2.Size = new System.Drawing.Size(95, 24);
            this.stylebutton2.TabIndex = 4;
            this.stylebutton2.Text = "ОТМЕНА";
            this.stylebutton2.UseVisualStyleBackColor = true;
            this.stylebutton2.Click += new System.EventHandler(this.stylebutton2_Click);
            // 
            // stylebutton1
            // 
            this.stylebutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stylebutton1.BackgroundImage")));
            this.stylebutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.stylebutton1.FlatAppearance.BorderSize = 0;
            this.stylebutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stylebutton1.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stylebutton1.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.stylebutton1.Location = new System.Drawing.Point(24, 69);
            this.stylebutton1.Name = "stylebutton1";
            this.stylebutton1.Size = new System.Drawing.Size(94, 24);
            this.stylebutton1.TabIndex = 3;
            this.stylebutton1.Text = "ПРИМЕНИТЬ";
            this.stylebutton1.UseVisualStyleBackColor = true;
            this.stylebutton1.Click += new System.EventHandler(this.stylebutton1_Click);
            // 
            // RenameProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NetConfig.Properties.Resources.back1;
            this.ClientSize = new System.Drawing.Size(278, 105);
            this.Controls.Add(this.stylebutton2);
            this.Controls.Add(this.stylebutton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RenameProfile";
            this.Text = "RenameProfile";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RenameProfile_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RenameProfile_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RenameProfile_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private Stylebutton stylebutton1;
        private Stylebutton stylebutton2;
    }
}