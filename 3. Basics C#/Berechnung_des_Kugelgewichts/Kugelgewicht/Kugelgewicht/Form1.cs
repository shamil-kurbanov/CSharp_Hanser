namespace Kugelgewicht
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private struct Kugel //kapselt Radius und spez. Gewicht einer Kugel
        {
            public double Radius;
            public double Sg;
        }

        private double rueckgabewert; //Rückgabewert für Variante 2

        //Hilfsfunktion, liest Kugelwerte aus Eingabemaske

        private Kugel BerechneKugel()
        {
            Kugel kugel;
            kugel.Radius = Convert.ToDouble(textBox.Text) / 2;

            if (rb_holz.Checked)
            {
                kugel.Sg = 1.4; //Holz
            }
            else if (rb_alu.Checked)
            {
                kugel.Sg = 2.7; //Alu
            }
            else if (rb_glas.Checked)
            {
                kugel.Sg = 3.0; //Glas
            }
            else if (rb_eisen.Checked)
            {
                kugel.Sg = 7.87; //Eisen
            }
            else
            {
                kugel.Sg = 11.3; //Blei
            }

            return kugel;
        }

        //Gewicht G = 4/3*Pi*Pow(ra,3)*Sg
        private double KugelGewicht(double ra, double sg)
        {
            double vol = 4 / 3.0 * Math.PI * Math.Pow(ra, 3);
            return sg * vol;
        }

        private void KugelGewicht(Kugel kugel)
        {
            double vol = 4 / 3.0 * Math.PI * Math.Pow(kugel.Radius, 3);
            rueckgabewert = kugel.Sg * vol;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            textBox.Text = "20";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kugel kugel = BerechneKugel();
            double r = kugel.Radius;
            double sg = kugel.Sg;
            double rueckgabewert = KugelGewicht(r, sg);     //Aufruf
            label1.Text = rueckgabewert.ToString("#,#0.000 Gramm");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kugel kugel = BerechneKugel();
            KugelGewicht(kugel);
            label2.Text = rueckgabewert.ToString("#,#0.000 Gramm");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            /*
             * Kugel kugel = BerechneKugel();
            KugelGewicht(ref kugel);   Fehler     //Aufruf (kugel trägt Ergebnis)  
            label3.Text = kugel.Sg.ToString("#,#0.000 Gramm");
             */
        }

    }
    }