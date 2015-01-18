using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Iterativ
{
    class RunTests
    {
        public void testStarter()
        {
            test1();
            test2();
            test3();
            test4();
        }

        public void test1()
        {
            TestLogin testLogin = new TestLogin();
            if (testLogin.usernameTest() == true)
            {
                // Style it up later.
                Console.WriteLine("Test 1 - Username test, OK");
            }
        }

        public void test2()
        {
            TestLogin testLogin = new TestLogin();
            if(testLogin.passwordTest() == true)
            {
                // Style it up later.
                Console.WriteLine("Test 2 - Password test, OK");
            }
        }

        public void test3()
        {
            TestTeams testTeam = new TestTeams();
            if (testTeam.teamArrayTest() == true)
            {
                // Style it up later.
                Console.WriteLine("Test 3 - Team string test, OK");
            }
        }
 
        public void test4()
        {
            TestPoints testPoints = new TestPoints();
            if (testPoints.pointTest() == true)
            {
                Console.WriteLine("Test 4 - Points Test, OK");
            }
        }
    }
}
