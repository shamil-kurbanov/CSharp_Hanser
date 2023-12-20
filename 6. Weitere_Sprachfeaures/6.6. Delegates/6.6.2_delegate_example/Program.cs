using System;
using static System.Console;

//Deklaration des Delegattyps
delegate void MeinDelegat(string nachricht);

class Program
{
	public static void Main()
	{
		//Erstellung einer Instanz des Delegaten und ZUweisung einer Methode
		MeinDelegat delegatInstanz = ZeigeNachricht;

		//Aufruf der Methode über den Delegaten
		delegatInstanz("Hallo, Delegaten!");
		WriteLine();
	}

	//Die Methode, die über der Delegat repräsentiert
	public static void ZeigeNachricht(string text)
	{
		WriteLine(text);
	}
}