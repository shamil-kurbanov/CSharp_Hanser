namespace _4._3_MeineFormeln
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r = Convert.ToDouble(textBox1.Text); //Kreisradius konvertieren
            textBox2.Text = MeineFormeln.KreisUmfang(r).ToString("0.000");
            textBox3.Text = MeineFormeln.KugelVolumen(r).ToString("0.000");

            double b = Convert.ToDouble(textBox4.Text);
            textBox5.Text = MeineFormeln.Netto(b, 0.19).ToString("C");
        }
    }
}