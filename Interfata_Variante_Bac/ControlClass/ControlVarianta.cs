using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Interfata_Variante_Bac
{
    class ControlVarianta
    {
        private List<Varianta> variante;


        public ControlVarianta()
        {
            variante = new List<Varianta>();
            load();
        }


        public void load()
        {
            StreamReader fisier = new StreamReader(Application.StartupPath + @"\variante.txt");
            string linie = "";
            while ((linie = fisier.ReadLine()) != null){
                string[] linieSplit = linie.Split(',');
                variante.Add(new Varianta(linieSplit));
            }
            fisier.Close();
        }
        

        public List<Varianta> Variante
        {
            get => this.variante;
            set => this.variante = value;
        }

    }
}
