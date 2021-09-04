using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.OopsConcept
{
    class Uc2
    {
            private String employeeName;
            private int hours;
            private double rate, pay;

            public void setEmployeeName(String name)
            {
                employeeName = name;
            }
            public String getEmployeeName()
            {
                return employeeName;
            }
            public double calculatePay(int hours, double rate)
            {
                if (hours > 20)
                {
                    int extraHours = hours - 20;
                    pay = (20 * rate) + (extraHours * rate);
                }
                else pay = hours * rate;

                return pay;
            }
            public void displayEmployee()
            {
                Console.WriteLine("Employee's name: %s", getEmployeeName());
                Console.WriteLine("\nGross Salary: ", +pay);
            }
        }

    }

