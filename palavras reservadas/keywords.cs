// Estou inciando os estudos em C# e este é um ex de código que fiz para entender melhor o funcionamento de algumas palavras-chave.
// https://learn.microsoft.com/pt-br/dotnet/csharp/language-reference/keywords/ esse é o link que utilizei para complementar o curso que estou fazendo.

using System;

public class Program
{
    public enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    public delegate void PrintMessage(string message);

    public static void Main()
    {
        PrintMessage print = Console.WriteLine;

        try
        {
            int maxValue = int.MaxValue;
            int result = checked(maxValue + 1);
            print("This line will not be executed.");
        }
        catch (OverflowException ex)
        {
            print($"Overflow exception caught: {ex.Message}");
        }

        DaysOfWeek today = DaysOfWeek.Wednesday;
        print($"Today is: {today}");
    }
}