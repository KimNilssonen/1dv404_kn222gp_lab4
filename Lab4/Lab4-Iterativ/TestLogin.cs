using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Iterativ
{
    class TestLogin
    {
        public TestLogin()
        {

        }

        public bool usernameTest()
        {
            Login login = new Login();
            if(login.inlogg("admon", "password") == false)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool passwordTest()
        {
            Login login = new Login();
            if(login.inlogg("admin", "paasword") == false)
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
