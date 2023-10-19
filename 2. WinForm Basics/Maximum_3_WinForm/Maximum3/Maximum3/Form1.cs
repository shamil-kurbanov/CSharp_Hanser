namespace Maximum3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			int a = Convert.ToInt32(textBox_a.Text);
			int max = a;
			int b = Convert.ToInt32(textBox_b.Text);
			if (b > max)
			{
				max = b;
			}
			int c = Convert.ToInt32(textBox_c.Text);
			if (c > max)
			{
				max = c;
			}
			label_result.Text = "Das Maximums ist " + max.ToString();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBox_a.Text = "20";
			textBox_b.Text = "-3";
			textBox_c.Text = "5";

		}
	}
}