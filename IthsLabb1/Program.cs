using System;

namespace IthsLabb1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mata in en sträng, siffror och bokstäver. Strängen ska sökas igenom och markera där strängen börjar och slutar på samma siffra utan att bli avbruten av en bokstav.
            

            //Be användaren mata in en textsträng
            Console.WriteLine("Mata in valfri sträng av bokstäver och siffror");
            string input = Console.ReadLine();  //"29535123p48723487597645723645";
            
            //Variabel för summan av delsträngarna
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
                            //Hittar de matchande delsträngarna samt kollar så den resterande texten i strängen inte blir en matchande delsträng
                            string numberMatch = input.Substring(i, j - i + 1);
                            string firstMatch = input.Substring(0, input.IndexOf(numberMatch));
                            string secondMatch = input.Substring(numberMatch.Length + firstMatch.Length);

                            //Ändrar färg på de highlightade delsträngarna
                            Console.Write(firstMatch);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(numberMatch);
                            Console.ResetColor();
                            Console.WriteLine(secondMatch);
                            
                            //Summerar de olika delsträngarna
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
            //Skriver ut summan av delsträngarna
            Console.WriteLine("");
            Console.WriteLine($"Summan av delsträngarna är {sum}");


            Console.ReadKey();
        }
    }
}
