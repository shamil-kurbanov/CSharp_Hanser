using System;
using static System.Console;


class PotenzUndWurzelOperationen
{
	public static void Pow_1_durch_3(double parameter)
	{
		double d = Math.Pow(parameter, (1 / 3.0));
		WriteLine(d.ToString("0.0000"));
	}
}