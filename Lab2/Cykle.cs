using System;
namespace Lab2
{
	public class Cykle : NonEngineBased
	{
		int activeGear;
		protected int numberOfGears;

		public int ActiveGear { get { return activeGear; } }
		public string Type { get; set;}


		public Cykle(string manufacturer, string model, int weight, int numberOfGears) : base (manufacturer,model,weight,2)
		{
			this.numberOfGears = numberOfGears;
		}

		public bool ChangeGear(int gear){
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
