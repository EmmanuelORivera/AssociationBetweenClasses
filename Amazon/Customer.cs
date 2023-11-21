namespace Amazon
{
	public class Customer
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public void Promote()
		{
			var rating = CalculateRating();

			if (rating == 0)
			{
				Console.WriteLine("Promoted to Level 1");
			}
			else
			{
				Console.WriteLine("Promoted to Level 2");
			}
		}
		private int CalculateRating()  // this can be private because there is no needed to share this method outside of this class.
		{
			return 0;
		}
	}
}