using System;
namespace Lab2
{
	public abstract class Vehicle
	{
		int speed;
		protected int numberOfWheels;
		protected int weight;
		protected string manufacturer;
		protected string model;

		public int Speed { get; }
		public int NumberOfWheels { get; }
		public int Weight { get; }
		public string Manufacturer { get; }
		public string Model { get; }

		public Vehicle()
		{
			

		}

		public int increseSpeed(int speed){
			this.speed += speed;
			return speed;
		}

		public int DecreseSpeed(int speed) {
			this.speed -= speed;
			return speed;
		}
	}
}
