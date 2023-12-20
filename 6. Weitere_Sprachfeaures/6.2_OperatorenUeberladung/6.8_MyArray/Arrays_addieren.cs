/*
 * Zwei gleich große eindimensionale Double-Arrays sollen
 * mittels "+" Operator addiert werden
 */

using static System.Console;

public class MyArray
{
	public static int Anzahl; // Anzahl der Elemente
	private double[] array; // 1-dim. Array

	//Der Konstruktor erzeugt das Array in entsprechender Größe:
	public MyArray(int n) 
	{
		Anzahl = n;
		array = new double[n];
	}

	//Ein Indexer ermöglicht den bequemen indizieren Zugriff auf die Elemente der Instanzen
	//der Klasse MyArray:
	public double this[int i]
	{
		get { return array[i]; }
		set { array[i] = value; }
	}

	//Eine Überladung des "+" Operators wird definiert. Rückgabewert ist eine neue Instanz von MyArray
	public static MyArray operator +(MyArray a, MyArray b)
	{
		MyArray arr = new MyArray(Anzahl);
		for (int i = 0; i < Anzahl; i++)
		{
			arr[i] = a[i] + b[i];
		}
		return arr;
	}

	//Anwendung der OperatorenÜberladung bei der Addition zweier Instanzen von MyArray:
	public static void addition()
	{
		MyArray a1 = new MyArray(3);
		a1[0] = 1.5;
		a1[1] = 5.25;
		a1[2] = -0.75;

		MyArray a2 = new MyArray(3);
		a2[0] = 0;
		a2[1] = 2.3;
		a2[2] = -7.1;

		MyArray arr = a1 + a2;

		//Anwendung des überladenen "+" Operators:
		for (int i = 0; i < MyArray.Anzahl; i++)
		{
			WriteLine(arr[i].ToString());
		}
	}
}