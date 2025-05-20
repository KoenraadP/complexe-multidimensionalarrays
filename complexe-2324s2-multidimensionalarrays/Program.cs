using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complexe_2324s2_multidimensionalarrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1D array met daarin onmiddellijk al 9 cijfers/waarden
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // traagste alternatief
            int[] numbers2;
            numbers2 = new int[9];

            Console.WriteLine(numbers2[5]); // 0

            Console.WriteLine(numbers2.Length); // grootte van de array

            // Console.WriteLine(numbers2[9]); // kan niet, arrays zijn zero based

            Console.WriteLine(numbers.Last());

            string[] names = { "Jan", "Piet", "Klaas" };
            Console.WriteLine(Convert.ToInt32(names.Last().Last()));

            // array met 2 dimensies, Y en X
            // Y --> rijen
            // X --> kolommen
            int[,] multiNumbers =
            {
                // kolom 0, kolom 1, ...
                { 1, 2, 3 }, // rij 0
                { 4, 5, 6 }, // rij 1
                { 7, 8, 9 }, // rij 2
                { 10, 11, 12 } // rij 3
            };

            // eerste waarde van de array
            Console.WriteLine(multiNumbers[0, 0]); // 1

            // laatste waarde van de array
            // eerst rijen, dan kolommen
            Console.WriteLine(multiNumbers[3, 2]); // 12

            Console.WriteLine(multiNumbers.Length); // totaal aantal waarden in de array
            Console.WriteLine(multiNumbers.GetLength(0)); // aantal rijen in de array
            Console.WriteLine(multiNumbers.GetLength(1)); // aantal kolommen in de array

            // alle waarden tonen met foreach
            foreach (int number in multiNumbers)
            {
                Console.WriteLine(number); // 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
            }

            // alle waarden tonen met for loops
            for (int row = 0; row < multiNumbers.GetLength(0); row++) // alle rijen
            {
                // controle van [0,0] [0,1] [0,2] [1,0] ...
                for (int col = 0; col < multiNumbers.GetLength(1); col++) // alle kolommen
                {
                    Console.WriteLine(multiNumbers[row, col]); // 1 2 3 4 5 6 7 8 9 10 11 12
                }
            }

            // alle waarden uit de eerste rij
            for (int col = 0; col < multiNumbers.GetLength(1); col++) // alle kolommen
            {
                // eerste coördinaat gewoon op 0 laten staan want enkel rij 0 nodig
                Console.WriteLine(multiNumbers[0, col]); // 1 2 3
            }

            // alle waarden uit de eerste kolom
            for (int row = 0; row < multiNumbers.GetLength(0); row++) // alle rijen
            {
                // tweede coördinaat gewoon op 0 laten staan want enkel kolom 0 nodig
                Console.WriteLine(multiNumbers[row, 0]); // 1 4 7 10
            }
        }
    }
}
