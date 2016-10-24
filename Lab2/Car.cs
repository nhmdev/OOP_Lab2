using System;
namespace Lab2
{
	public class Car : EngineBased
	{
		public bool IsPublicTransport { get; set;}

		public Car(string manufacturer, 
		           string model, 
		           int weight, 
		           int numberOfGears) : base (manufacturer, model,weight, 4,numberOfGears)
		{
			
		}
	}
}
