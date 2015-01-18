using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Iterativ
{
    class TestTeams
    {
        public TestTeams()
        {

        }
        public bool teamArrayTest()
        {
           
            LoggedIn loggedIn = new LoggedIn();
            string[] test = new string[-0];
            if(loggedIn.teams(test) == false)
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
