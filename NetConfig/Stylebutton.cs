using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace NetConfig
{
    class Stylebutton : Button
    {
        private Rectangle clickRectangleValue = new Rectangle();
        

        public Stylebutton()
            : base()
        {
            this.Size = new Size(100, 40);
            this.Location = new Point(50, 50);
            this.Font = new System.Drawing.Font("Square721 BT", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));            
            this.BackgroundImage = NetConfig.Properties.Resources.Button2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        }        

        
        

        // Draw the smaller pressed button image.
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            this.BackgroundImage = NetConfig.Properties.Resources.Button3;            
            Invalidate();
        }

        // Draw the button in the hot state. 
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);            
            this.BackgroundImage = NetConfig.Properties.Resources.Button;
            Invalidate();
        }

        // Draw the button in the unpressed state.
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);            
            this.BackgroundImage = NetConfig.Properties.Resources.Button2;
            Invalidate();
        }

        // Draw the button hot if the mouse is released on the button. 
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            OnMouseEnter(e);
        }

        
        
        
    }
}
