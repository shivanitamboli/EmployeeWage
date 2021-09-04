using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.OopsConcept
{
    class Poly2
    {

        
            public void show()
            {
                Console.WriteLine("Base class");
            }
        }

        // derived class name 'derived'
        // 'baseClass' inherit here
        class derived : Poly2
        {

            // overriding
            new public void show()
            {
                Console.WriteLine("Derived class");
            }
        }

        class GFG
        {

            // Main Method
            public static void Main()
            {

                // 'obj' is the object of
                // class 'baseClass'
                Poly2 obj = new Poly2();


                // invokes the method 'show()'
                // of class 'baseClass'
                obj.show();

                obj = new derived();

                // it also invokes the method
                // 'show()' of class 'baseClass'
                obj.show();

            }
        }

    }

