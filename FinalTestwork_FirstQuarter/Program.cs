public static class Program
{
    public static void Main()
    {
        Random random = new Random();
        int length = random.Next(2, 6);
        string[] wordsInput = new string[length];
        string[] threeLetterWords = new string[0];
        Console.WriteLine("Слов в массиве " + length.ToString());
        for (int i = 0; i < wordsInput.Length; i++)
        {
            Console.WriteLine("Введите слово");
            wordsInput[i] = Console.ReadLine().ToString();
            if (wordsInput[i].Length <=  3)
            {
                threeLetterWords = threeLetterWords.Append(wordsInput[i]).ToArray();
            }
        }

        foreach (string word in threeLetterWords)
        {
            Console.WriteLine(word);
        }
    }

}