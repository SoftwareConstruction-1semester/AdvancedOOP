using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedOOP
{
    class Daniel : Person, IStudent
    {
        public void sleep()
        {
            Console.WriteLine("ZZZZZzzzzzzzzz");
        }

        public void Study()
        {
            Console.WriteLine("[hard work]");
        }
    }
}
