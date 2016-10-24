using System;
namespace Lab2
{
	public abstract class Vehicle
	{
		int speed = 0;
		protected int numberOfWheels;
		protected int weight;
		protected string manufacturer;
		protected string model;

		public int Speed { get { return speed;} }
		public int NumberOfWheels { get { return numberOfWheels; } }
		public int Weight { get { return weight; } }
		public string Manufacturer { get { return manufacturer; } }
		public string Model { get { return model; } }

		protected Vehicle(string manufacturer, string model, int weight, int numberOfWheels )
		{
			this.numberOfWheels = numberOfWheels;
			this.weight = weight;
			this.manufacturer = manufacturer;
			this.model = model;

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
