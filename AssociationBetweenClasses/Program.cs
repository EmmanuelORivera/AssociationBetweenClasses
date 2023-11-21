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
			var installer = new Installer(logger));

			dbMigrator.Migrate();
			installer.Install();
		}
	}
}