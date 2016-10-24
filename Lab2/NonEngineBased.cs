using System;
namespace Lab2
{
	public abstract class NonEngineBased : Vehicle
	{
		protected bool selfDriven;

		public bool SelfDriven { get { return selfDriven; } }


		public NonEngineBased(string manufacturer, 
		                      string model, 
		                      int weight, 
		                      int numberOfWheels ) : base(manufacturer ,model ,weight ,numberOfWheels)
		{

		}

	}
}
