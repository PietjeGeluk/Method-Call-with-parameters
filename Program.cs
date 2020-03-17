using System;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Voer een getal in onder de 10");
            string guess = Convert.ToString(Console.ReadLine());
            string CorrectNumber = "10";

            if (guess != CorrectNumber)
                PrintColorMessage(ConsoleColor.Red, "Verkeerd nummer, probeer opnieuw");
            else
                Console.WriteLine("GOED GEANTWOORD!");
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }
    }
}
