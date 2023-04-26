using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            var userEntereredNumber = 0;
            try
            {
                Console.WriteLine("Sprawdzenie pażystości wprowadzonej liczby ");
                Console.Write("Podaj proszę liczbę: ");
                userEntereredNumber = GetUserInput();
                if (userEntereredNumber % 2 == 0) Console.Write("Liczba parzysta");
                else Console.Write("Liczba nieparzysta");
            }
            catch (Exception)
            {
                throw;
            }
            Console.ReadKey();
        }//Main()

        private static int GetUserInput()
        {
            do
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                    Console.Write($"Wprowadzona wartość jest nieprawidłowa. \nPodaj proszę liczbę: ");
                else
                    return number;
            }
            while (true);
        }
    }
}
