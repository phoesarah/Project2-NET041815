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

            while (totalfirstsecond < 10)
            {
                Console.Write(Convert.ToString(totalfirstsecond));
                totalfirstsecond = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = totalfirstsecond;
                
                if (totalfirstsecond % 2 == 0)
                {
                
                }

            }
            Console.ReadLine();

        }
    }
}
