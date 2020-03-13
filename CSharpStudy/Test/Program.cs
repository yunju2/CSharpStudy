
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {

        static int pow(int a, int b)
        {
            // 2 ^ 3 -> 1 * 2 * 2 * 2
            //2 ^ 4 -> 1 * 2 * 2 * 2 * 2


            
            int a_ = 1;
            for (int i = 0; i < b; ++i)
            {
                a_ *=a;

              
            }
            return a_;
            




        }

        static void Main(string[] args)
        {
            int tmp = pow(2, 3);
            Console.WriteLine(tmp);
        }
    }
}

    


