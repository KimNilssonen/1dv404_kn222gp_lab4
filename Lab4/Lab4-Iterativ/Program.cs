using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Iterativ
{
    class Program
    {
        static void Main(string[] args)
        {
            RunTests runTests = new RunTests();
            runTests.testStarter();

            Console.WriteLine("\n=  Välkommen till inloggning  =\n\n");
            Login login = new Login();
            LoggedIn loggedIn = new LoggedIn();
            LoginDetails loginDetails = new LoginDetails();
            AddPoints addPoints = new AddPoints();
            
            while (true)
            {
                // The user inputs his username and password.
                Console.Write("Användarnamn: ");
                string username = Console.ReadLine();

                Console.Write("Lösenord    : ");
                string password = Console.ReadLine();


                // If the login is a success, 
                if (login.inlogg(username, password) == true)
                {
                    Console.Clear();
                    Console.WriteLine("Välkommen {0}\n\n", loginDetails.correctUsername);
                    while (true)
                    {
                        try
                        {
                            Console.Write("Hur många lag vill du lägga till? : ");
                            int input = int.Parse(Console.ReadLine());
                            int maxNumberOfTeams = 10;

                            if (input <= maxNumberOfTeams)
                            {
                                string[] numberOfTeams = new string[input];
                                loggedIn.teams(numberOfTeams);
                                string theTeam = loggedIn.teamsPresent(numberOfTeams);
                                Console.Clear();
                                Console.WriteLine("Du har valt lag: {0}\n", theTeam);
                                

                                    Console.Write("Hur många poäng vill du tilldela detta lag? (1-10)");
                                    int input2 = int.Parse(Console.ReadLine());
                                    if (addPoints.addPoints(theTeam, input2) == true)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Du måste ge poäng mellan 1-10!");
                                    }
                            }
                            else
                            {
                                Console.WriteLine("\nDu kan bara ange 10 lag!\n\n");
                            }
                        }
                        catch
                        {
                            Console.WriteLine("\nDu måste skriva ett nummer!\n\n");
                        }
                    }

                    break;
                }
            }
            Console.WriteLine("\nDina poäng är registrerade.");
        }
    }
}
