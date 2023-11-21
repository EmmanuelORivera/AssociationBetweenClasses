using System;

namespace AssociationBetweenClasses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var text = new Text();
			text.Copy();

			text.Width = 100;
			text.Copy();
        }
	}
}