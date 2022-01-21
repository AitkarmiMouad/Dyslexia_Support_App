using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dyslexia_Support_App
{
    public partial class AccessPage : UserControl
    {
        public AccessPage()
        {
            InitializeComponent();
        }

        private void AccessPage_Resize(object sender, EventArgs e)
        {
            panel1.Location = new Point(this.ClientSize.Width / 2 - panel1.Size.Width / 2, this.ClientSize.Height / 2 - panel1.Size.Height / 2);
            panel1.Anchor = AnchorStyles.None;
        }
    }
}
