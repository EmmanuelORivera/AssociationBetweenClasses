namespace AssociationBetweenClasses
{
	public class Vehicle
	{
		private readonly string registrationNumber;

		public Vehicle()
		{
			this.registrationNumber = "DefaultRegistrationNumber";
			Console.WriteLine("Vehicle is beign initialized.");
		}

		public Vehicle(string registrationNumber)
        {
			this.registrationNumber = registrationNumber;
			Console.WriteLine("Vehicle is beign initialized. {0} ",registrationNumber);
		}
    }
}