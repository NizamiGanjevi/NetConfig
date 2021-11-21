using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetConfig
{
    class SysIPAddress : TextBox
    {
        protected override CreateParams CreateParams
        {
            get
            {
                var cp = base.CreateParams;
                cp.ClassName = "SysIPAddress32";
                

                return cp;
                
            }
        }
    }
}
