using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace DISCRETE_PROJECT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, firstnum, lastnum, i, ctr;

            Console.Write("Input starting number of range: ");
            firstnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input ending number of range : ");
            lastnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("The prime numbers between {0} and {1} are : \n", firstnum, lastnum);

            for (num = firstnum; num <= lastnum; num++)
            {
                ctr = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && num != 1)
                    Console.Write("{0} ", num);
            }
            // ------------------------------------------------------------
            // SECOND PROJECT
            int n, j, sum;
            int startingnum, endignum;
            Console.Write("Input the starting range or number : ");
            startingnum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the ending range of number : ");
            endignum = Convert.ToInt32(Console.ReadLine());
            Console.Write("The Perfect numbers within the given range : ");
            for (n = startingnum; n <= endignum; n++)
            {
                j = 1;
                sum = 0;
                while (j < n)
                {
                    if (n % j == 0)
                        sum = sum + j;
                    j++;
                }
                if (sum == n)
                    Console.Write("{0} ", n);
                Console.ReadKey();
            }
        }
    }
}
