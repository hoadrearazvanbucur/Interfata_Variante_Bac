using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.IO;
using System.Diagnostics;

namespace Interfata_Variante_Bac.ControlView
{
    public class ControlViewMain : Panel
    {
        private Panel panelS2, panelS3;
        private Form pictureForm;

        public ControlViewMain()
        {
            this.panelS2 = new Panel();
            this.panelS3 = new Panel();
            this.pictureForm = new Form();
            layoutPanel();
            layouts();
        }


        public void layoutPanel()
        {
            this.panelS2.Location = new Point(159, 170);
            this.panelS3.Location = new Point(308, 170);
            this.Size = new Size(460, 420);
            this.panelS2.Size = new Size(140, 110);
            this.panelS3.Size = new Size(140, 170);
            this.BackColor = this.panelS2.BackColor = this.panelS3.BackColor = Color.Transparent;
            this.BorderStyle = this.panelS2.BorderStyle = this.panelS3.BorderStyle = BorderStyle.None;
            this.Controls.Add(panelS2);
            this.Controls.Add(panelS3);
        }
        public void layouts()
        {
            PictureBox arrowLeft = new PictureBox();
            layoutArrowLeft(arrowLeft);
            this.Controls.Add(arrowLeft);

            PictureBox arrowRight = new PictureBox();
            layoutArrowRight(arrowRight);
            this.Controls.Add(arrowRight);

            Label varianta = new Label();
            layoutVarianta(varianta, "Varianta 1");
            this.Controls.Add(varianta);

            Button s1 = new Button();
            layoutS1(s1);
            this.Controls.Add(s1);

            Button s2 = new Button();
            layoutS2(s2);
            this.Controls.Add(s2);

            Button s3 = new Button();
            layoutS3(s3);
            this.Controls.Add(s3);

            Button panelBS2_1 = new Button();
            Button panelBS2_23 = new Button();
            Button panelBS3_1 = new Button();
            Button panelBS3_2 = new Button();
            Button panelBS3_3 = new Button();
            layoutSP(panelBS2_1, panelBS2_23, panelBS3_1, panelBS3_2, panelBS3_3);
            this.panelS2.Controls.Add(panelBS2_1);
            this.panelS2.Controls.Add(panelBS2_23);
            this.panelS3.Controls.Add(panelBS3_1);
            this.panelS3.Controls.Add(panelBS3_2);
            this.panelS3.Controls.Add(panelBS3_3);
        }
        public void layoutSP(Button panelBS2_1, Button panelBS2_23, Button panelBS3_1, Button panelBS3_2, Button panelBS3_3)
        {
            setButton(panelBS2_1, 5, 0, 130, 50, 12, "Problema 1");
            setButton(panelBS2_23, 5, 60, 130, 50, 12, "Problemele\n2 si 3");
            setButton(panelBS3_1, 5, 0, 130, 50, 12, "Problema 1");
            setButton(panelBS3_2, 5, 60, 130, 50, 12, "Problema 2");
            setButton(panelBS3_3, 5, 120, 130, 50, 12, "Problema 3");
            panelBS2_1.Click += new EventHandler(panelBS2_1_Click);
            panelBS2_23.Click += new EventHandler(panelBS2_23_Click);
            panelBS3_1.Click += new EventHandler(panelBS3_1_Click);
            panelBS3_2.Click += new EventHandler(panelBS3_2_Click);
            panelBS3_3.Click += new EventHandler(panelBS3_3_Click);
            this.panelS2.Visible = this.panelS3.Visible = false;
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
        public void setLabel(Label label, int l1, int l2, int s1, int s2, int size, string text)
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
        public void setButton(Button button, int l1, int l2, int s1, int s2, int size, string text)
        {
            button.Location = new Point(l1, l2);
            button.Size = new Size(s1, s2);
            button.Text = text;
            button.Font = new Font("Cambria", size, FontStyle.Bold);
            button.FlatStyle = FlatStyle.Popup;
            button.BackColor = Color.Gray;
            button.ForeColor = SystemColors.ControlText;
            button.Cursor = Cursors.Hand;
            button.TabStop = false;
        }
        public string nrVarianta()
        {
            foreach (Control c in this.Controls)
                if (c is Label && (c as Label).Text.Split(' ')[0].Equals("Varianta") == true)
                    return $"Varianta_{(c as Label).Text.Split(' ')[1]}";
            return null;
        }



        public void layoutArrowLeft(PictureBox arrowLeft)
        {
            setPicture(arrowLeft, 70, 40, 30, 30, Application.StartupPath + @"\images\arrow_left.png");
            arrowLeft.Click += new EventHandler(arrowLeft_Click);
        }
        public void layoutArrowRight(PictureBox arrowRight)
        {
            setPicture(arrowRight, 360, 40, 30, 30, Application.StartupPath + @"\images\arrow_right.png");
            arrowRight.Click += new EventHandler(arrowRight_Click);
        }
        public void layoutVarianta(Label varianta, string text)
        {
            setLabel(varianta, 100, 30, 260, 50, 20, text);
        }


        public void layoutS1(Button s1)
        {
            setButton(s1, 9, 110, 140, 50, 14, "Subiectul 1");
            s1.Click += new EventHandler(s1_Click);
        }
        public void layoutS2(Button s2)
        {
            setButton(s2, 159, 110, 140, 50, 14, "Subiectul 2");
            s2.Click += new EventHandler(s2_Click);
        }
        public void layoutS3(Button s3)
        {
            setButton(s3, 308, 110, 140, 50, 14, "Subiectul 3");
            s3.Click += new EventHandler(s3_Click);
        }


        public void arrowLeft_Click(object sender, EventArgs e)
        {
            this.panelS2.Visible = false;
            this.panelS3.Visible = false;
            StreamReader fisier = new StreamReader(Application.StartupPath + @"\nrVariante.txt");
            int nr = int.Parse(fisier.ReadLine());
            foreach (Control c in this.Controls)
                if (c is Label && (c as Label).Text.Split(' ')[0].Equals("Varianta") == true)
                {
                    int nrVarianta = int.Parse((c as Label).Text.Split(' ')[1]);
                    nrVarianta--;
                    if (nrVarianta < 1) (c as Label).Text = "Varianta " + nr;
                    else (c as Label).Text = "Varianta " + nrVarianta.ToString();
                }
        }
        public void arrowRight_Click(object sender, EventArgs e)
        {
            this.panelS2.Visible = false;
            this.panelS3.Visible = false;
            StreamReader fisier = new StreamReader(Application.StartupPath + @"\nrVariante.txt");
            int nr = int.Parse(fisier.ReadLine());
            foreach (Control c in this.Controls)
                if (c is Label && (c as Label).Text.Split(' ')[0].Equals("Varianta") == true)
                {
                    int nrVarianta = int.Parse((c as Label).Text.Split(' ')[1]);
                    nrVarianta++;
                    (c as Label).Text = "Varianta " + nrVarianta.ToString();
                    if (nrVarianta > nr) (c as Label).Text = "Varianta 1";
                    else (c as Label).Text = "Varianta " + nrVarianta.ToString();
                }
        }
        

        public void s1_Click(object sender, EventArgs e)
        {
            this.panelS2.Visible = false;
            this.panelS3.Visible = false;
            string path = nrVarianta()+"_S1";         
            layoutPictureForm(pictureForm, path);
            pictureForm.Show();

        }
        public void s2_Click(object sender, EventArgs e)
        {
            this.panelS3.Visible = false;
            if (this.panelS2.Visible == false) this.panelS2.Visible = true;
            else this.panelS2.Visible = false;

        }
        public void s3_Click(object sender, EventArgs e)
        {
            this.panelS2.Visible = false;
            if (this.panelS3.Visible == false) this.panelS3.Visible = true;
            else this.panelS3.Visible = false;

        }



        public void panelBS2_1_Click(object sender, EventArgs e)
        {
            string path = nrVarianta() + "_S2_1";
            layoutPictureForm(pictureForm, path);
            pictureForm.Show();
        }
        public void panelBS2_23_Click(object sender, EventArgs e)
        {
            string path = nrVarianta() + "_S2_23";
            layoutPictureForm(pictureForm, path);
            pictureForm.Show();
        }
        public void panelBS3_1_Click(object sender, EventArgs e)
        {
            string path = nrVarianta() + "_S3_1.txt";
            Process.Start("notepad.exe", Application.StartupPath + @"\images\"+ path);
        }
        public void panelBS3_2_Click(object sender, EventArgs e)
        {
            string path = nrVarianta() + "_S3_2.txt";
            Process.Start("notepad.exe", Application.StartupPath +@"\images\"+ path);
        }
        public void panelBS3_3_Click(object sender, EventArgs e)
        {
            string path = nrVarianta() + "_S3_3.txt";
            Process.Start("notepad.exe", Application.StartupPath + @"\images\"+ path);
        }


        public void layoutPictureForm(Form pictureForm, string path)
        {
            pictureForm.Size = new Size(650, 750);
            pictureForm.MaximumSize = new Size(650, 750);
            pictureForm.MinimumSize = new Size(650, 750);
            pictureForm.StartPosition = FormStartPosition.CenterScreen;
            pictureForm.FormBorderStyle = FormBorderStyle.None;
            pictureForm.BackColor = SystemColors.ControlLightLight;
            pictureForm.BackgroundImage = Image.FromFile(Application.StartupPath + $@"\images\{path}.png");
            pictureForm.BackgroundImageLayout = ImageLayout.Stretch;
            pictureForm.BackColor = SystemColors.ControlLightLight;
            pictureForm.TabStop = false;
            PictureBox back = new PictureBox();
            setPicture(back, 10, 10, 40, 40, Application.StartupPath + @"\images\back.png");
            back.Click += new EventHandler(back_Click);
            pictureForm.Controls.Add(back);
        }
        public void back_Click(object sender, EventArgs e)
        {
            this.pictureForm.Hide();
        }

    }
}
