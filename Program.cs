using System;

namespace ProgramToFindLeapYear
{
	public class Program
	{
		public static void Main(string[]args)
		{
			int year;
			Console.Write("Enter the year: ");
			year = Convert.ToInt32(Console.ReadLine());
			if(year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
				Console.WriteLine($"{year} is Leap Year");
			else
				Console.WriteLine($"{year} is not a Leap Year");
				
			Console.ReadLine();
			
		}
	}
}