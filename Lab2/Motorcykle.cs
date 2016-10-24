using System;
namespace Lab2
{
	public class Motorcykle : EngineBased
	{
		public int NumberOfBags { get; set;}
		public Motorcykle(string manufacturer, 
		                  string model, 
		                  int weight, 
		                  int numberOfGears) : base(manufacturer,model,weight,2,numberOfGears)
		{
		}
	}
}
