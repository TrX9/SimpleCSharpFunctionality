class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Please enter a string to check if it is alphanumeric: (or type 'exit' to quit)");
            string input = Console.ReadLine();

            if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            bool isValid = IsAlphanumeric(input);

            if (isValid)
            {
                Console.WriteLine("The input string is alphanumeric.");
            }
            else
            {
                Console.WriteLine("The input string is not alphanumeric.");
            }
        }
    }

    static bool IsAlphanumeric(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return false;
        }

        foreach (char c in input)
        {
            if (!char.IsLetterOrDigit(c))
            {
                return false;
            }
        }

        return true;
    }
}
