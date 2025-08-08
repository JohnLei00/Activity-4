internal class Program
{
    private static void Main(string[] args)
    {
        List<string> birthYears = new List<string>();
        Console.WriteLine("Enter 5 birth years:");

        for (int i = 0; i < 5; i++)
        {
            string input = Console.ReadLine();
            if (int.TryParse(input, out int year))
            {
                birthYears.Add(input);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric year.");
                i--;
            }
        }

        int currentYear = DateTime.Now.Year;
        foreach (var year in birthYears)
        {
            int birthYear = Convert.ToInt32(year);
            int age = currentYear - birthYear;
            string classification = (age < 18) ? "Minor" : (age <= 65) ? "Adult" : "Senior";
            Console.WriteLine($"Birth Year: {birthYear}, Age: {age}, Classification: {classification}");
        }
    }
}