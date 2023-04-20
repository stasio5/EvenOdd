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
                Console.Write($"Podaj liczbę: ");
                userEntereredNumber = GetUserInput(-100,100);
                if (userEntereredNumber % 2 == 0) Console.Write("Liczba parzysta");
                else Console.Write("Liczba nieparzysta");
            }
            catch (Exception)
            {

                throw;
            }
            Console.ReadKey();
        }//Main()

        private static int GetUserInput(int minNumber, int maxNumber)
        {
            do
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                    Console.Write($"Wprowadzona wartość jest nieprawidłowa. \nPodaj proszę liczbę z zakresu {minNumber} do {maxNumber}: ");
                else if (number < minNumber || number > maxNumber)
                    Console.Write($"Wprowadzona liczba jest poza zakresem. \nPodaj proszę liczbę z zakresu {minNumber} do {maxNumber}: ");
                else
                    return number;
            }
            while (true);
        }
    }
}
