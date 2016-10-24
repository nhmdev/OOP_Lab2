using System;
namespace Lab2
{
	public class Cykle : NonEngineBased
	{
		int activeGear;
		protected int numberOfGears;

		public int ActiveGear { get; }
		public string Type { get; set;}


		public Cykle()
		{
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
