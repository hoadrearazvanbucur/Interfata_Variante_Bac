using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace Interfata_Variante_Bac.ControlView
{
    public class ControlViewHeader : Panel
    {
        public ControlViewHeader()
        {
            layoutPanel();
            layouts();
        }

        public void layoutPanel()
        {
            this.Size = new Size(460, 150);
            this.BackColor = Color.Transparent;
            this.BorderStyle = BorderStyle.None;
        }

        public void layouts()
        {
            PictureBox exit = new PictureBox();
            layoutExit(exit);
            this.Controls.Add(exit);

            Label title = new Label();
            layoutTitle(title);
            this.Controls.Add(title);

            Label sign = new Label();
            layoutSign(sign);
            this.Controls.Add(sign);
        }


        public void setPicture(PictureBox picture, int l1, int l2, int s1, int s2, string image)
        {
            picture.Location = new Point(l1, l2);
            picture.Size = new Size(s1, s2);
            picture.BackgroundImage = Image.FromFile(image);
            picture.BackgroundImageLayout = ImageLayout.Stretch;
            picture.BackColor = Color.Transparent;
            picture.Cursor = Cursors.Hand;
            picture.TabStop = false;
        }
        public void setLabel(Label label,int l1,int l2,int s1,int s2,int size,string text)
        {            
            label.Location = new Point(l1, l2);
            label.Size = new Size(s1, s2);                   
            label.AutoSize = false;
            label.Text = text;
            label.Font = new Font("Cambria", size, FontStyle.Regular);
            label.BackColor = Color.Transparent;
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.TabStop = false;
        }


        public void layoutExit(PictureBox exit)
        {
            setPicture(exit, 438, 0, 20, 20, Application.StartupPath + @"\images\exit.png");
            exit.Click += new EventHandler(exit_Click);
        }
        public void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void layoutTitle(Label title)
        {
            setLabel(title, 0, 0, this.Width, this.Height-20,24,"Variante Bacalaureat Informatica");
            title.Font = new Font("Cambria", 24, FontStyle.Regular | FontStyle.Bold);
        }
        public void layoutSign(Label title)
        {
            setLabel(title, 0, this.Height-20, this.Width, 20, 14, "Hoadrea Razvan");
            title.Font = new Font("Cambria", 14, FontStyle.Regular | FontStyle.Italic);
            title.TextAlign = ContentAlignment.MiddleRight;
        }

    }
}
