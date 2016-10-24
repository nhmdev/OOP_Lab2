using System;
using System.Collections.Generic;
namespace Lab2
{
	public class IO
	{
		public IO()
		{
		}

		public static int ShowMenu(){
			int retVal = 0;
			List<ConsoleKey> validMenuOptions = new List<ConsoleKey>();

			validMenuOptions.Add(ConsoleKey.D1);
			validMenuOptions.Add(ConsoleKey.D2);
			validMenuOptions.Add(ConsoleKey.D3);
			validMenuOptions.Add(ConsoleKey.D4);

			Console.WriteLine("***** The ultimate DMV *****");
			Console.WriteLine("1. List all vehicles");
			Console.WriteLine("2. Add a new vehicle");
			Console.WriteLine("3. Remove vehicle");
			Console.WriteLine("4. Quit application");
			Console.WriteLine("****************************");
			Console.Write("Choose: ");
			ConsoleKeyInfo menuInput = Console.ReadKey(true);

			while(!(validMenuOptions.Contains(menuInput.Key))){
				Console.Write("Wrong choice. Try again: ");
				menuInput = Console.ReadKey(true);
			}

			switch (menuInput.Key){
				case ConsoleKey.D1: retVal = 1; break;
				case ConsoleKey.D2: retVal = 2; break;
				case ConsoleKey.D3: retVal = 3; break;
				case ConsoleKey.D4: retVal = 4; break;
			}
			return retVal;
		}
	}
}
