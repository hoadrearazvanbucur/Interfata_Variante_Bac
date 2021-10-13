using System;
using System.Collections.Generic;
using System.Text;

namespace Interfata_Variante_Bac
{
    public class Varianta
    {
        private string imageS1;
        private string imageS2_1;
        private string imageS2_23;
        private string imageS3_1;
        private string imageS3_2;
        private string imageS3_3;


        public Varianta(string []images)
        {
            this.imageS1 = images[0];
            this.imageS2_1 = images[1];
            this.imageS2_23 = images[2];
            this.imageS3_1 = images[3];
            this.imageS3_2 = images[4];
            this.imageS3_3 = images[5];        
        }

        public override string ToString() => this.imageS1 +","+ this.imageS2_1 + "," + this.imageS2_23 + "," + this.imageS3_1 + "," + this.imageS3_2 + "," + this.imageS3_3;


        public string ImageS1
        {
            get => this.imageS1;
            set => this.imageS1 = value;
        }
        public string ImageS2_1
        {
            get => this.imageS2_1;
            set => this.imageS2_1 = value;
        }
        public string ImageS
        {
            get => this.imageS2_23;
            set => this.imageS2_23 = value;
        }
        public string ImageS3_1
        {
            get => this.imageS3_1;
            set => this.imageS3_1 = value;
        }
        public string ImageS3_2
        {
            get => this.imageS3_2;
            set => this.imageS3_2 = value;
        }
        public string ImageS3_3
        {
            get => this.imageS3_3;
            set => this.imageS3_3 = value;
        }

    }
}
