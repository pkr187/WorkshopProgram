namespace FindLeapYear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int year = 1994; year <= 2014; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    Console.WriteLine("{0} is a leap year.", year);
                    DateTime leapDay = new DateTime(year, 2, 29);
                    DateTime nextYear = leapDay.AddYears(1);
                    Console.WriteLine("   One year from {0} is {1}.", leapDay.ToString("d"), nextYear.ToString("d"));                  
                }
            }
        }
    }
}