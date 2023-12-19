namespace _4._Einfache_Klasse
{
	public partial class Form1 : Form
	{
		private Kunde? kunde1; //Objekt referenzieren

        //#§#
        public Form1()
		{
			InitializeComponent();
            /*kunde1 = new Kunde(); // Objekt instanzieren

			//Eventhandler anmelden
			kunde1.WenigGuthaben += new Kunde.GuthabenLeer(GuthabenKontrolle);
			*/
        }


		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
            kunde1 = new Kunde(); //Objekt erzeugen

            //Objektfelder initialisieren
            kunde1.Anrede = "Herr";
            kunde1.Name = "Kurbanov";
            kunde1.PLZ = 12345;
            kunde1.Ort = "Hamburg";
            kunde1.Stammkunde = true;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label1.Text = kunde1?.Adresse(); //erste Methode aufrufen
            kunde1?.AddGuthaben(50); // zweite methode aufreufen
			label2.Text = "Guthaben ist " + kunde1?.Guthaben.ToString("C"); //Eigenschaft lesen
		}
	}
}