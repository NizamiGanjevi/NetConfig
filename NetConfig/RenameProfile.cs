using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetConfig
{
    public partial class RenameProfile : Form
    {
        #region public methods
        int X, Y;
        Boolean bDrag = false;
        public static Boolean bName = false;
        public static int index;
        public RenameProfile()
        {
            InitializeComponent();
        }
        #endregion

        #region privatemethods
        private void CreateProfile(string name)
        {
            XmlEdit.CreateNewProfile(name);

        }
        private void Rename(int index, string name)
        {
            XmlEdit.RenameProfile(index, name);
        }

        private void stylebutton1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            if (!bName)
            {
                CreateProfile(name);
            }
            else if (bName)
            {
                Rename(index, name);
            }
            
            this.Hide();
        }

        private void stylebutton2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RenameProfile_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                X = Cursor.Position.X;
                Y = Cursor.Position.Y;
                bDrag = true;
            }
        }

        private void RenameProfile_MouseMove(object sender, MouseEventArgs e)
        {
            if (bDrag == true)
            {
                this.Location = new Point(this.Location.X + Cursor.Position.X - X, this.Location.Y + Cursor.Position.Y - Y);
                X = Cursor.Position.X;
                Y = Cursor.Position.Y;
            }
        }

        private void RenameProfile_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                bDrag = false;
            }
        }
        #endregion
    }
}
