class ReverseSentenceNoMethod
{
    static void Main(string[] args)
    {
        // Reverse a string without using Reverse() method
        string input = "there are snakes at the zoo";

        Console.WriteLine(input);
        Console.WriteLine(ReverseSentence(input));


        static string ReverseWord(string word)
        {
            string result = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                result += word[i];
            }
            return result;
        }

        static string ReverseSentence(string input)
        {
            string result = "";
            string[] words = input.Split(" ");

            foreach (string word in words)
            {
                result += ReverseWord(word) + " ";
            }

            return result;
        }
    }
}