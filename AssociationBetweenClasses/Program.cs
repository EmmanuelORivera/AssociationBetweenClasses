using Amazon;
using System;

namespace AssociationBetweenClasses
{
	public class GoldCustomer : Customer
	{
		public void OfferVouchar()
		{
		}
	}
	internal class Program
	{
		static void Main(string[] args)
		{
			UseInheritance();
			UseComposition();
			UseAccessModifiers();
			UseConstructorAndInheritance();
			var title = new Title();
			Shape shape = title;

			title.Width = 200;
			shape.Width = 100;

            Console.WriteLine(title.Width);

			StreamReader reader = new StreamReader(new MemoryStream()); // the new MemoryStream is upcasting to the Strem class
		}

		static void UseConstructorAndInheritance()
		{
			var car = new Car("1231231");
		}
		static void UseAccessModifiers()
		{
			var customer = new Customer();
			Amazon.RateCalculator calculater = new RateCalculator();
		}
		static void UseInheritance()
		{
			var text = new Text();
			text.Copy();

			text.Width = 100;
			text.Copy();
		}
		static void UseComposition()
		{
			var dbMigrator = new DbMigrator(new Logger());

			var logger = new Logger();
			var installer = new Installer(logger);

			dbMigrator.Migrate();
			installer.Install();
		}
	}
}