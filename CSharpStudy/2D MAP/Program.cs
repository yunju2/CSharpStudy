using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_MAP
{
    class Program
    {

        public void Run()
        {
            
            Console.Write("정수를 입력하세요>>");
            string n = Console.ReadLine();
            int n1 = Convert.ToInt32(n);
            string[,] arr1 = new string[n1, n1];


            int num = 1;
            Console.WriteLine("============================================");
            Random r = new Random();

            int x = r.Next(0, n1);
            int y = r.Next(0, n1);


            for (int i = 0; i < arr1.GetLength(0); ++i)
            {
                for (int j = 0; j < arr1.GetLength(1); ++j)
                {
                    arr1[i, j] = num.ToString();
                    num++;

                    if (x==i && y==j)
                    {
                        arr1[i,j] ="*";
                    }
                    
                    Console.Write(arr1[i, j] + "\t");
                }

                Console.WriteLine();
            }

        }
        static void Main(string[] args)
        {
            Program2 program2 = new Program2();
            program2.Run();
        } 

    }
}


