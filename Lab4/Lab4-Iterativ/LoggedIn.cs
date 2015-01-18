using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Iterativ
{
    class LoggedIn
    {
        public LoggedIn()
        {

        }
        
        // Inputs the team names.
        public bool teams(string[] numberOfTeams)
        {

            while (true)
            {
                try
                {
                    for (int i = 0; i < numberOfTeams.Length; i++)
                    {
                        Console.Write("\nAnge lagnamn {0}: ", i + 1);
                        numberOfTeams[i] = Console.ReadLine();

                        if (numberOfTeams[i] == "")
                        {
                            i--;
                            throw new ArgumentException();
                        }

                        // Checks if the input is a number.
                        int value;
                        if (int.TryParse(numberOfTeams[i], out value))
                        {
                            Console.WriteLine("Skriv ett lag utan siffror!");
                            i--;
                        }

                    }
                    break;
                }
                catch
                {
                    Console.WriteLine("Du måste skriva något!");
                }
            }
            return false;
            
        }
        public string teamsPresent(string[] numberOfTeams){

            // Clears the console and presents the team names.
            Console.Clear();

            Console.WriteLine("Du har skrivit in följande lag: \n");
            for(int i = 0; i < numberOfTeams.Length; i++)
            {
                Console.WriteLine("Lag nummmer <{0}>: {1}\n", i + 1, numberOfTeams[i]);

            }

            Console.Write("\nVälj vilket lag du vill lägga till poäng på? ");
            int input = 0;
            while(true)
            {
                
                if (int.TryParse(Console.ReadLine(), out input))
                {
                    if (input > 0 && input <= numberOfTeams.Length)
                    {
                        return numberOfTeams[input - 1];
                    }
                    else
                    {
                        Console.WriteLine("Du måste välja ett lag!");
                    }
                }
                
            }
        }
    }
}
