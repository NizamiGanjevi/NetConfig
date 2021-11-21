using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetConfig
{
    class ContextMenuStripBackColorRenderer : ToolStripRenderer
    {

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            Graphics g = e.Graphics;
            Rectangle bounds = new Rectangle(System.Drawing.Point.Empty, e.Item.Size);

            if (e.Item.Selected)
            {
                

                using (Brush b = new System.Drawing.SolidBrush(SystemColors.MenuHighlight))
                {
                    g.FillRectangle(b, bounds);
                    
                }
                using (Brush b = new System.Drawing.SolidBrush(SystemColors.MenuHighlight))
                {
                    e.Item.ForeColor = SystemColors.Window;
                }

            }
            else
            {
                e.Item.ForeColor = SystemColors.ScrollBar;
            }
        }

    }
    
}
