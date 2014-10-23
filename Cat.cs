using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedOOP
{
    class Cat : Animal, IStudent
    {
        public void Study()
        {
            Console.WriteLine("[hard work]");
        }
    }
}
