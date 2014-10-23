using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advancedOOP
{
    class Zhivko : Person, IStudent
    {
        public void Facebook()
        {
            Console.WriteLine(".........[not listening]");
        }

        public void Study()
        {
            Console.WriteLine("[hard work]");
        }
    }
}
