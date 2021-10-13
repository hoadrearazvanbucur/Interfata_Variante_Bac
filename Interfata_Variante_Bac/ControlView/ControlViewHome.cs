using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using Interfata_Variante_Bac.ControlView;

namespace Interfata_Variante_Bac
{
    public class ControlViewHome : Form
    {
        public ControlViewHome()
        {
            layoutForm();
            layoutPanels();
        }

        public void layoutForm()
        {
            this.Size = new Size(480, 600);
            this.MaximumSize = new Size(480, 600);
            this.MinimumSize = new Size(480, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.None;
            this.BackColor = SystemColors.ControlLightLight;
        }

        public void layoutPanels()
        {
            ControlViewHeader header = new ControlViewHeader();
            header.Location = new Point(10, 10);
            this.Controls.Add(header);

            ControlViewMain main = new ControlViewMain();
            main.Location = new Point(10, 170);
            this.Controls.Add(main);
        }
    }
}
