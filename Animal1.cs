using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.OopsConcept
{
    class Animal1
    {

            public void animalSound()
            {
                Console.WriteLine("The animal makes a sound");
            }
        }

        internal class Pig : Animal1  // Derived class (child) 
        {
            public void animal1Sound()
            {
                Console.WriteLine("The pig says: wee wee");
            }
        }

        class Dog : Animal1  // Derived class (child) 
        {
            public void animal1Sound()
            {
                Console.WriteLine("The dog says: bow wow");
            }
        }
    }

