using System;

namespace Lab2
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool gameLoop = true;
			while (gameLoop)
			{
				switch (IO.ShowMenu())
				{
					case 1:
						Console.WriteLine("***List all vehicles"); break;
					case 2:
						Console.WriteLine("***Add a vehicle"); break;
					case 3:
						Console.WriteLine("***Remove a vehicle"); break;
					case 4:
						gameLoop = false; break;

				}
			}
			Car myOwnCar = new Car("Kia", "Rio", 2400,5);

			Console.WriteLine(myOwnCar.NumberOfWheels);
		}
	}
}
