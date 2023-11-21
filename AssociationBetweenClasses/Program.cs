using System;

namespace AssociationBetweenClasses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UseInheritance();
			UseComposition();
			
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