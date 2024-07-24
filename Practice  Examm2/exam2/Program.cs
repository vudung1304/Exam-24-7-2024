namespace Practice__Examm2.exam2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a String:");
        string inputString = Console.ReadLine();
        
        Console.WriteLine("Enter word to search:");
        string searchWord = Console.ReadLine();

        int count = CountOccurrences(inputString, searchWord);
        
        Console.WriteLine($"The word '{searchWord}' is found {count} time(s) in the string.");
        
    }

    public static int CountOccurrences(string inputString, string searchWord)
    {
        int count = 0;
        int index = inputString.IndexOf(searchWord, StringComparison.OrdinalIgnoreCase);

        while (index != -1)
        {
            count++;
            index = inputString.IndexOf(searchWord, index + searchWord.Length, StringComparison.OrdinalIgnoreCase);
        }

        return count;
    }
}