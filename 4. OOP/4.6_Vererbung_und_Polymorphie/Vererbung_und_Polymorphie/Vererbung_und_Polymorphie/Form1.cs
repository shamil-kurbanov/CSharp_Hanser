namespace Vererbung_und_Polymorphie
{
    public partial class Form1 : Form
    {
        private PrivatKunde kunde1;
        private FirmenKunde kunde2;

        public Form1()
        {
            this.Text = "Privat- and Firmenkunde";
            InitializeComponent();
            kunde1 = new PrivatKunde("Herr", "Kotz", "München");
            kunde2 = new FirmenKunde("Frau", "Weiss", "PrimeTime Software");
            kunde2.StammKunde = true;
            textBox1.Text = "100";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double brutto = Convert.ToDouble(textBox1.Text);
            label3.Text = kunde1.GetAdresse();
            kunde1.AddGuthaben(brutto);
            label5.Text = "Bonusguthaben ist " + kunde1.Guthaben.ToString("C");

            label4.Text = kunde2.GetAdresse();
            kunde2.AddGuthaben(brutto);
            label6.Text = "Bonusguthaben ist " + kunde2.Guthaben.ToString("C");

            kunde1.Test();
        }
    }
}