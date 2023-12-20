using System;
using static System.Console;


internal class Program
{
	private static void Main(string[] args)
	{
		DateTime dateTime = DateTime.Now;
		Console.WriteLine("Das Datum ist der " + dateTime.ToString());

		DateTime dateTime2 = new DateTime(2019, 2, 20, 12, 34, 0);
		long ts = dateTime2.Ticks;
		Console.WriteLine("Seit dem 1. Januar des Jahres 1 sind" + ts.ToString() + " Ticks vergangen!");
	}
}