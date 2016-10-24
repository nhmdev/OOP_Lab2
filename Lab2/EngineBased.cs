using System;
namespace Lab2
{
	public abstract class EngineBased : Vehicle
	{
		protected int numberOfGears;
		int activeGear;
		bool engineIsOn;

		public bool EngineIsOn { get; }
		public int ActiveGear { get; }

		public EngineBased()
		{

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
