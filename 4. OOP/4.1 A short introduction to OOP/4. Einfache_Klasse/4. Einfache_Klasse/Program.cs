namespace _4._Einfache_Klasse
{
	internal static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			// Das Erzeugen und Initialisieren einer Instanz von Person bedarf keines Konstruktors


			ApplicationConfiguration.Initialize();
			Application.Run(new Form1());
		}
	}
}