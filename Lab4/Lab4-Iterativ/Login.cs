using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Iterativ
{
    class Login
    {

        public Login()
        {

        }
        public bool inlogg(string username, string password)
        {
                // Fetching the correct username and password.
                // Think of this class, "LoginDetails", as a server.
                LoginDetails loginDetails = new LoginDetails();
                string correctUsername = loginDetails.correctUsername;
                string correctPassword = loginDetails.correctPassword;

            if(username == "admon" || password == "paasword")
            {
                return false;
            }

            
                if (username == correctUsername)
                {
                    if (password == correctPassword)
                    {
                        // If both the username and password are correct, return "true" to "Program".
                        return true;
                    }
                    else
                    {
                        Console.WriteLine("\nDu har skrivit fel lösenord!\nFörsök igen.\n");
                        return false;
                    }
                }
                else
                {
                    Console.WriteLine("\nDu har skrivit fel användarnamn!\nFörsök igen.\n");
                    return false;
                }
            
        }
        
    }
}
