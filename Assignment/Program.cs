namespace Assignment;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int choice = Console.Read();
        int second = choice - 48;

        
        int currentYear = DateTime.Now.Year;

        int leapYearCount = 0;

        Console.WriteLine("Next 20 Leap Years:");

        while (leapYearCount < second)
        {
        
            if (IsLeapYear(currentYear))
            {
                Console.WriteLine(currentYear);

                leapYearCount++;
            }

            currentYear++;
        }

        // Console.ReadLine(); 
    }

    static bool IsLeapYear(int year)
    {
        return (year % 400 == 0) || ((year % 4 == 0) && (year % 100 != 0));
    }
}