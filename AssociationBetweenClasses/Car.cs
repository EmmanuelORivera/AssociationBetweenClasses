namespace AssociationBetweenClasses
{
	public class Car : Vehicle
	{
        public Car(string registrationNumber)
            :base(registrationNumber)
        {
            Console.WriteLine("Car is beign initialized. {0}",registrationNumber);
        }
    }
}