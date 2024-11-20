using System.Runtime.CompilerServices;

namespace stringPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input ="Hello, World!";

            string[] strings = input.Split(' ');
            Array.Reverse(strings);
            string output = string.Join(" ", strings);
            Console.WriteLine(output);
            
            
            // reversing string through extension method
            string reversedString = input.Reverse();
            Console.WriteLine(reversedString);

            CharCount.CharCountFunc();

            Console.ReadLine();
        }

        

    }

    public static class ExtensionMethod
    {
        //extension Method
        public static string Reverse(this string str)
        {
            char[]  arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }

    //counting characters in a string

    public static class CharCount
    {
        public static void CharCountFunc()
        {
            string input = "Hello World";
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Iterate through each character in the string
            foreach (char c in input.ToUpper()) // Convert to uppercase for case-insensitive counting
            {
                if (char.IsLetter(c)) // Ignore spaces or non-letter characters
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
            }

            // Print the character counts
            foreach (var kvp in charCount)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
