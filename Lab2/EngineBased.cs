using System;
namespace Lab2
{
	public abstract class EngineBased : Vehicle
	{
		protected int numberOfGears;
		int activeGear;
		bool engineIsOn;

		public bool EngineIsOn { get { return engineIsOn; } }
		public int ActiveGear { get { return activeGear; } }

		protected EngineBased(string manufacturer,
		                   string model, 
		                   int weight, 
		                   int numberOfWheels, 
		                   int numberOfGears) : base(manufacturer, model,weight, numberOfWheels)
		{
			this.numberOfGears = numberOfGears;
		}

		public void startEngine()
		{
			engineIsOn = true;
		}

		public void stopEngine() {
			engineIsOn = false;
		}

		public bool ChangeGear(int gear) {
			if (gear <= numberOfGears)
			{
				this.activeGear = gear;
				return true;
			}
			else 
			{
				return false;
			}
			
		}	
	}
}
