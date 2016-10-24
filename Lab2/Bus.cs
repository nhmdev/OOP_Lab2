using System;
namespace Lab2
{
	public class Bus : EngineBased
	{
		int busNumber;
		bool inService;

		public int BusNumber { get { return busNumber; } }
		public bool InService { get { return inService; } }
		public string Driver { get; set; }

		public Bus(string manufacturer,
		           string model, 
		           int numberOfWheels, 
		           int weight, 
		           int numberOfGears) : base(manufacturer,model,weight,numberOfWheels,numberOfGears)
		{
			
			
		}

		public void TakeInService(int busNumber, string driver) {
			this.busNumber = busNumber;
			this.Driver = driver;
			this.inService = true;
		}
	}
}
