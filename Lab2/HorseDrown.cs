using System;
namespace Lab2
{
	public class HorseDrown : NonEngineBased
	{
		public int NumberOfHorses { get; set; }
		public HorseDrown(string manufacturer, 
		                  string model, 
		                  int weight, 
		                  int numberOfWheels) : base(manufacturer,model,weight,numberOfWheels)
		{
		}
	}
}
