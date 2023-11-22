using Amazon;
using System;
using System.Collections;

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
			UseStack();
		}

		static void UseStack()
		{
			var stack = new Stack();
			stack.Push(1);
			stack.Push(2);
			//stack.Push(null);
			//stack.Clear();
            Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
			Console.WriteLine(stack.Pop());
		}
		static void UseBoxingAndUnboxing()
		{

			// there are 2 types of variables in C#
			// value types: Numerical, Floating numbers, Char, Boolean
			// reference types: object, string
			var list = new ArrayList();
			//BOXING num to object
			list.Add(1);
			list.Add("Emmanuel");

			var thisObj = list[0]; // this is not a number
			var number = (int)list[0]; // this is casted to int

			var anotherList = new List<int>();
			anotherList.Add(1);
			var test = anotherList[0]; // this is an integer
			var names = new List<string>();
			names.Add("a");
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