using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Iterativ
{
    class TestPoints
    {
        public TestPoints()
        {

        }

        public bool pointTest()
        {
            AddPoints addPoints = new AddPoints();
            if(addPoints.addPoints("", 11) == false)
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
