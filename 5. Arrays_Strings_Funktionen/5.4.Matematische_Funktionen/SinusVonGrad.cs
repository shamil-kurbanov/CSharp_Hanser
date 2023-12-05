using System;
using static System.Console;


class SinVonGrad
{
	public static void Sinus(double grad)
	{
		double d = Math.Sin(grad * (Math.PI / 180));
		WriteLine($"Sin ({grad}) = {Math.Round(d,2)}");
	}
}

