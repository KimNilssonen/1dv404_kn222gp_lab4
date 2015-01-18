using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Iterativ
{
    class AddPoints
    {
        // Iteration 3.
        public bool addPoints(string team, int input)
        {
            
            while (true)
            {
                try
                {
                    int result =+ input;
   
                    if (input > 10 || input < 1)
                    {
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Lag {0} har nu {1} poäng.", team, result);
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Du måste ange ett poäng!");
                }
               
                

            }
            Console.WriteLine("Tryck 'Enter' för att avsluta.");


            ConsoleKeyInfo cki;
            cki = Console.ReadKey();
            if (cki.KeyChar == 13)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
