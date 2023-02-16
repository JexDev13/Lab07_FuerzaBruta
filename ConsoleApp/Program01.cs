namespace ConsoleApp;
class Program01
{
    static void Main01(string[] args)
    {
        Console.WriteLine("Brute Force Algorithm!!");
        var text = "THIS IS A SIMPLE TEST";
        var pattern = "SIMPLE";
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

        int patternsIndexFound = FindSinglePattern(text, pattern);
        if (patternsIndexFound > 0)
        {
            Console.WriteLine($"Pattern found at index: {patternsIndexFound}");
        }
        else
        {
            Console.WriteLine($"No pattern found");
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

}
