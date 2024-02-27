namespace Assignment;

class Program
{
    static void Main(string[] args)
    {
        
        int currentYear = DateTime.Now.Year;

        int leapYearCount = 0;

        Console.WriteLine("Next 20 Leap Years:");

        while (leapYearCount < 20)
        {
        
            if (IsLeapYear(currentYear))
            {
                Console.WriteLine(currentYear);

                leapYearCount++;
            }

            currentYear++;
        }
    }

    static bool IsLeapYear(int year)
    {
        return (year % 4 == 0) && (year % 100 != 0);
    }
}