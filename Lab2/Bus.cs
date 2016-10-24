using System;
namespace Lab2
{
	public class Bus : EngineBased
	{
		int busNumber;
		bool inService;

		public int BusNumber { get; }
		public bool InService { get; }
		public string Driver { get; set; }

		public Bus(string manufacturer, string model, int numberOfWheels, int weight, int numberOfGears)
		{
			this.manufacturer = manufacturer;
			this.model = model;
			this.numberOfWheels = numberOfWheels;
			this.weight = weight;
			this.numberOfGears = numberOfGears;
			
		}

		public void TakeInService(int busNumber, string driver) {
			this.busNumber = busNumber;
			this.Driver = driver;
			this.inService = true;
		}
	}
}
