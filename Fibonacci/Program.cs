using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = 1;
            int secondnumber = 0;
            int totalfirstsecond = 0;
            int sum = 0;

            while (totalfirstsecond < 4000000)
            {
                Console.Write(" " + Convert.ToString(totalfirstsecond));
                totalfirstsecond = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = totalfirstsecond;
                
                if (totalfirstsecond % 2 == 0)
                {
                    sum = totalfirstsecond + sum;
                }

            }
            Console.WriteLine(" \n The Sum of all even numbers in this sequence is " + Convert.ToString(sum));
            Console.ReadLine();

        }
    }
}
