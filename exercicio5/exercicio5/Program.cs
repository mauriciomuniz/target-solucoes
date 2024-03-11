using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma string para inverter:");
        string input = Console.ReadLine();

        string reversed = ReverseString(input);
        Console.WriteLine("String invertida: " + reversed);
    }

    static string ReverseString(string input)
    {
        char[] charArray = input.ToCharArray();
        int start = 0;
        int end = input.Length - 1;

        while (start < end)
        {
            
            char temp = charArray[start];
            charArray[start] = charArray[end];
            charArray[end] = temp;

            start++;
            end--;
        }

        return new string(charArray);
    }
}
