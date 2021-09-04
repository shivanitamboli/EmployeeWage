using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.OopsConcept
{
    class SwitchCase
    {

        public const int ISPARTTIME = 1;
        public const int ISFULLTIME = 2;
        public const int EMPRATEPERHOUR = 1;

        static void Main(String args[])
        {
            int empHrs = 0;
            int empWage = 0;

            Random random = new Random();
            int empCheck =random.Next(0, 3);

            switch(empCheck)
            {
                case ISPARTTIME:
                    empHrs = 4;
                    break;


                case ISFULLTIME:
                    empHrs = 8;
                    break;

                default:
                    empHrs = 0;
                    break;

            }

            empWage = empHrs * EMPRATEPERHOUR;
            Console.WriteLine("empWage:" + empWage);



        }



    }
}
