namespace TestTask2
{
    public class PermutationsApp
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a string (or type 'exit' to quit): ");
                string input = Console.ReadLine();

                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

                if (string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input cannot be empty.");
                    continue;
                }

                List<string> permutations = GeneratePermutations(input);

                Console.WriteLine($"Input '{input}':");
                Console.WriteLine("Result:");
                foreach (string permutation in permutations)
                {
                    Console.WriteLine(permutation);
                }
                Console.WriteLine();
            }
        }

        public static List<string> GeneratePermutations(string s)
        {
            List<string> result = [];
            HashSet<string> resultSet = new HashSet<string>();

            GetProcessedRes(s.ToCharArray(), 0, resultSet);

            foreach (string permutation in resultSet)
            {
                result.Add(permutation);
            }

            return result;
        }

        private static void GetProcessedRes(char[] array, int index, HashSet<string> resultSet)
        {
            if (index == array.Length - 1)
            {
                resultSet.Add(new string(array));
            }
            else
            {
                for (int i = index; i < array.Length; i++)
                {
                    Swap(array, index, i);
                    GetProcessedRes(array, index + 1, resultSet);
                    Swap(array, index, i);
                }
            }
        }

        private static void Swap(char[] array, int i, int j)
        {
            (array[j], array[i]) = (array[i], array[j]);
        }
    }
}