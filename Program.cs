using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace advancedOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Daniel d = new Daniel();
            d.Name = "Danny";
            d.sleep();

            Zhivko z = new Zhivko();
            z.Name = "Zzzzhivko";
            z.Facebook();

            Cat c = new Cat();
            c.Move();

            // you cannot instansiate abstrACT CLASSES
            //Animal a = new Animal();

            IStudent[] students = new IStudent[3];
            students[0] = d;
            students[1] = z;
            students[2] = c;

            foreach (IStudent s in students)
            {
                s.Study();
                if (s is Person)
                {
                    Person pp = (Person) s;
                    Console.WriteLine(pp.Name);
                }

                if (s is Daniel)
                {
                    Daniel dd = (Daniel) s;
                    dd.sleep();
                }
            }
        }
    }
}
