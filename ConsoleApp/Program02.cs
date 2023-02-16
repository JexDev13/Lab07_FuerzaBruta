namespace ConsoleApp;
class Program02
{
    static void Main02(string[] args)
    {
        Console.WriteLine("Brute Force Algorithm!!");
        string text = "THIS IS A SIMPLE FISH";
        string pattern = "IS";
        Console.WriteLine($"Text = {text}");
        Console.WriteLine($"Pattern = {pattern}");
        for (int i = 0; i < text.Length; i++)
        {
            Console.Write(String.Format("{0:00}  ", i));
        }
        Console.Write(Environment.NewLine);
        foreach (var item in text)
        {
            Console.Write($"{item,-3} ");
        }
        Console.Write(Environment.NewLine);

        foreach (int patternsIndexFound in FindPattern(text, pattern))
        {
            if (patternsIndexFound > 0)
            {
                Console.WriteLine($"Pattern found at index: {patternsIndexFound}");
            }
            else
            {
                Console.WriteLine($"No pattern found");
            }
        }
    }

    public static int FindSinglePattern(string text, string pattern)
    {
        int textLength = text.Length;
        int patternLength = pattern.Length;

        for (int i = 0; i <= textLength - patternLength; i++)
        {
            int j;
            for (j = 0; j < patternLength; j++)
            {
                if (text[i + j] != pattern[j])
                {
                    break;
                }
            }
            if (j == patternLength)
            {
                return i;
            }
        }
        return -1;
    }

    public static List<int> FindPattern(string text, string pattern)
    {
        List<int> occurrences = new List<int>();
        int textLength = text.Length;
        int patternLength = pattern.Length;

        for (int i = 0; i <= textLength - patternLength; i++)
        {
            int j;
            for (j = 0; j < patternLength; j++)
            {
                if (text[i + j] != pattern[j])
                {
                    break;
                }
            }
            if (j == patternLength)
            {
                occurrences.Add(i);
            }
        }

        return occurrences;
    }


}
