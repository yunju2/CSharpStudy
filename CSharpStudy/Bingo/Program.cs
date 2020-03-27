using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo
{
    class Program
    {
        static bool inContain(int[,] arr, int value)
        {
            for (int x = 0; x < arr.GetLength(0); ++x)
            {
                for (int y = 0; y < arr.GetLength(1); ++y)
                {
                    if (arr[x, y] == value)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] arr = new int[5, 5];
            int n = 0;

            //for (int i = 0; i < arr.GetLength(0); ++i)
            //{
            //    for (int j = 0; j < arr.GetLength(1); ++j)
            //    {
            //        while (true)
            //        {
            //            int v = random.Next(1, 26);
            //            if (inContain(arr, v))
            //            {
            //                continue;
            //            }

            //            arr[i, j] = v;
            //        }
            //    }
            //}

            // 먼저 넣고
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    arr[i, j] = ++n;
                }
            }

            // shuffle : 랜덤 기법. 섞는다
            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    int x = random.Next(0, 5);
                    int y = random.Next(0, 5);

                    int temp = arr[i, j];
                    arr[i, j] = arr[x, y];
                    arr[x, y] = temp;
                }
            }

            for (int i = 0; i < arr.GetLength(0); ++i)
            {
                for (int j = 0; j < arr.GetLength(1); ++j)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }


        }
    }
}
