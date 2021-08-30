using System;
using System.Linq;
using System.Drawing;

namespace IthsLabb1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mata in en sträng, siffror och bokstäver. Strängen ska sökas igenom och markera där strängen börjar och slutar på samma siffra utan att bli avbruten av en bokstav.

            
            //Be användaren mata in en textsträng
            Console.WriteLine("Mata in valfri sträng av bokstäver och siffror");
            string input = "29535123p48723487597645723645";

            

            char[] inputChar = new char[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                inputChar[i] = input[i];
                Console.WriteLine(input);
            }


    

            Console.ReadKey();
        }
    }
}
