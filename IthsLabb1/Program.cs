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
            //Hitta ett sätt att spara flera tal/strängar


            //Om inte, kolla nästa
            //Kolla från nästa tecken och framåt

            //Se om tecknet är samma som ifrån det yttre
            //Om samma tecken påträffas, spara

            

            //Be användaren mata in en textsträng
            Console.WriteLine("Mata in valfri sträng av bokstäver och siffror");
            string input = "29535123p48723487597645723645";
            long sum = 0;

            //Loopa igenom alla tecken
            for (int i = 0; i < input.Length; i++)
            {
                //Kolla om tecknet är ett tal
                //Om det inte är ett tal, avbryt och gå till nästa
                if (char.IsNumber(input[i]) == false)
                {
                    continue;
                }

                for (int j = i + 1; j < input.Length; j++)
                {
                    //Kolla om tecknet är ett tal
                    if (char.IsNumber(input[j]) == true)
                    {
                        if (input[i] == input[j])
                        {
                            string numberMatch = input.Substring(i, j - i + 1);
                            Console.WriteLine("");
                            Console.WriteLine(numberMatch);
                            long result;
                            long.TryParse(numberMatch, out result);
                            sum += result;
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine($"Summan av delsträngarna är {sum}");



            Console.ReadKey();
        }
    }
}
