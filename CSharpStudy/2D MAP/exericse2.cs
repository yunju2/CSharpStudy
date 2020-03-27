using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_MAP
{
    class Program
    {
        static void Main(string[] args)
        {

           string[,] arr1 = new string[4,4];

          for (int i = 0; i<4   ; i++)
            {
                for (int j = 0; j<4 ; j++)
                {
                    if (i < j)
                    {
                        Console.Write("*");
                       
                    }
                    else if (i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("");
                       
                    }
                }
                    Console.WriteLine("");
              
           }
                
        }
    }
}
