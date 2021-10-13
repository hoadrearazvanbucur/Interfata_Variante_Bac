using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Interfata_Variante_Bac.ControlView
{
    public class ControlViewMain : Panel
    {
        public ControlViewMain()
        {
            layoutPanel();
            layouts();
        }

        public void layoutPanel()
        {
            this.Size = new Size(460, 420);
            this.BackColor = Color.Transparent;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public void layouts()
        {
            
        }
    }
}
