using System;

namespace Lab2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Car myOwnCar = new Car("Kia", "Rio", 2400,5);

			Console.WriteLine(myOwnCar.NumberOfWheels);
		}
	}
}
