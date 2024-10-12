using System;

class Program
{
    static int CountCharacterOccurrences(string str, char character)
    {
        int count = 0;

        foreach (char c in str)
        {
            if (c == character)
            {
                count++;
            }
        }
        return count;
    }
    static void Main(string[] args)
    {
        Console.Write("Nhập chuỗi: ");
        string inputString = Console.ReadLine();

        Console.Write("Nhập ký tự cần đếm: ");
        char characterToCount = Console.ReadLine()[0];

        int count = CountCharacterOccurrences(inputString, characterToCount);

        Console.WriteLine($"Ký tự '{characterToCount}' xuất hiện {count} lần trong chuỗi.");
    }
}
