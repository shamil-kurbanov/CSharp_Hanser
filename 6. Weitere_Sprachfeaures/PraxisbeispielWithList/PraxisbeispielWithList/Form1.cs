using System.Collections;
using System.Xml;

namespace PraxisbeispielWithList
{
	public partial class Form1 : Form
	{
		private ArrayList? al = null;


		public Form1()
		{
			InitializeComponent();
			al = new ArrayList();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			al = new ArrayList();
			al.Add("Das");
			al.Add("ist");
			al.Add("ein");
			al.Add("Test");
			al.Add("mit");
			al.Add("der");
			al.Add("ArrayList");
			al.Add("Das");
			al.Add("ist");
			al.Add("ok");
			ListAnzeigen(al);

		}

		private void ListAnzeigen(ArrayList al)
		{
			listBox1.Items.Clear();
			for (int i = 0; i < al.Count; i++)
			{
				listBox1.Items.Add(al[i]);
			}
		}

		//Austeigend sortieren		
		private void button1_Click_1(object sender, EventArgs e)
		{

			al.Sort();
			ListAnzeigen(al);
		}

		//Absteigend sortieren
		private void button2_Click_1(object sender, EventArgs e)
		{
			al.Reverse();
			ListAnzeigen(al);
		}

		//Search _ Suchen
		private int ix = -1; //Index des letztmaligen Vorkommens

		private void button3_Click_1(object sender, EventArgs e)
		{
			char lf = (char)10; //für Zeilenvorshub
			int i = al.IndexOf(textBox1.Text, ix + 1); //Suche wird ab ix fortgesetzt

			if (i < 0)
			{
				MessageBox.Show($"Das Element wurde nicht gefunden! {lf} " +
					 $"Suche beginnt wieder von vorn!");
				ix = -1;
				listBox1.SelectedIndex = -1; //Zeilenmarkierung entfernen

			}
			else
			{
				listBox1.SelectedIndex = i; //gefundenes Wort markieren
				ix = i;
			}
		}
	}
}
