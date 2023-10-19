using System;
using static System.Console;

class Program
{
	static void Main()
	{
		WriteLine("Maximum von drei Zahlen");
		WriteLine();
		int a, b, c, max;
		WriteLine("Geben Sie die erste Zahl ein:");
		a = Convert.ToInt32(ReadLine());
		max = a;
		WriteLine("Geben Sie die zweite Zahl ein:");
		b = Convert.ToInt32(ReadLine());
		if (b > a)
		{
			max = b;
		}

		WriteLine("Geben Sie die dritte Zahl ein:");
		c = Convert.ToInt32(ReadLine());
		if (c > max)
		{
			max = c;
		}
		WriteLine("Das Maximum ist " + max.ToString());
		ReadLine();
	}
}