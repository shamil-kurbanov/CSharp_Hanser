namespace Polymorphes_Verhalten
{
    public partial class Form1 : Form
    {
        private PrivatKunde kunde1;
        private FirmenKunde kunde2;
        private FirmenKunde kunde3;
        private Kunde[] kunden = new Kunde[3]; //Array für 3 Objecte

        private const char LF = (char)10; //für Zeilenvorschub

        //Im Konstruktor von Form1 werden die notwendigen Initialisierungen vorgenommen:
        public Form1()
        {
            kunde1 = new PrivatKunde("Herr", "Kotz", "München");
            kunde1.StammKunde = false;
            kunde2 = new FirmenKunde("Frau", "Weiss", "PrimeTime Software");
            kunde2.StammKunde = true;
            kunde3 = new FirmenKunde("Herr", "Wenz", "Actition GmbH");
            kunde3.StammKunde = false;

            kunden[0] = kunde1;
            kunden[1] = kunde2;
            kunden[2] = kunde3;



            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Das Array wird in einer for-Schleife durchlaufen und ausgelesen. Dabei wird die polymorphen Methoden (das sind die 
            //mit virtual bzw. overreid deklarieren) für alle Objekte aufgerufen:

            double brutto = Convert.ToDouble(textBox1.Text);
            label3.Text = string.Empty;
            for (int i = 0; i < kunden.Length; i++)
            {
                kunden[i].AddGuthaben(brutto);
                label3.Text = label3.Text + LF + kunden[i].GetAdresse() + LF + kunden[i].Guthaben.ToString("C") + LF;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "100";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double brutto = Convert.ToDouble(textBox1.Text);
            label3.Text = string.Empty;
            foreach (Kunde kunde in kunden)
            {
                kunde.AddGuthaben(brutto);
                label3.Text = label3.Text + LF + kunde.GetAdresse() + LF + kunde.Guthaben.ToString("C") + LF;
            }
        }
    }
}