namespace Einfache_LINQ_Abfragen
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//Die abzufragende Integer-List enthält irgendwelche ganzzahlogen Werten
		private int[] zahlen = { 5, -4, 18, 26, 0, 19, 16, 2, -1, 0, 9, -5, 8, 15, 19 };


		private void Form1_Load(object sender, EventArgs e)
		{

		}

		//Die LINQ-Abfrage in Query-Expression Syntax
		private void button1_Click(object sender, EventArgs e)
		{
			var expr = from z in zahlen
					   where z > 10
					   orderby z
					   select z;

			//Die Anzeige
			listBox1.DataSource = expr.ToList();
		}

		//Dieselbe Abfrage in Extension-Method-Syntax
		private void button2_Click(object sender, EventArgs e)
		{
			var expr = zahlen
							.Where(z => z > 10)
				            .OrderBy(z => z);

			//Die Anzeige
			listBox1.DataSource = expr.ToList();
		}

	}
}
