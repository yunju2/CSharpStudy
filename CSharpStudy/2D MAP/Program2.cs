using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2D_MAP
{
    interface iMap
    {
        void Input(ConsoleKeyInfo key);
        void Print();

    }
    public class Program2
    {
        string[,] arr1;
        public void Run()
        {
            Console.Write("정수를 입력하세요>>");
            string n = Console.ReadLine();
            int n1 = Convert.ToInt32(n);

            arr1 = new string[n1, n1];


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

                    if (x == i && y == j)
                    {
                        arr1[i, j] = "*";
                    }
                }
            }

            // 처리하기
            ConsoleKeyInfo key;
            while (true)
            {
                Print();

                key = Console.ReadKey(false);

                switch (key.Key)
                {
                    case ConsoleKey.A:
                        {
                            if (y <= 0)
                            {
                                y = 0;
                            }
                            else
                            {
                                arr1[x, y]=arr1[x,y-1];
                                arr1[x, --y] = "*";
                            }
                        }
                        break;
                    case ConsoleKey.W:
                        {

                            try
                            {
                                arr1[--x, y] = "*";
                            }
                            catch
                            {
                                x = 0;
                            }

                            break;
                        }
                    case ConsoleKey.D:
                        {
                            if (n1 <= y + 1)
                            {
                                y = n1 - 1;
                                // y = n1;
                            }
                            else
                            {
                                arr1[x, ++y] = "*";
                            }

                            break;
                        }
                    case ConsoleKey.S:
                        {
                            try
                            {
                                arr1[++x, y] = "*";
                            }
                            catch
                            {
                                x = n1 - 1;
                            }

                        }
                            
                        break;
                }
                Console.Clear();

                // 처리
                // 그리기

                // 1. 원래 별 위치에 숫자를 어떻게 넣을까? 원래 *에 2였으면 2를 어떻게 구할까?
            }

        }

        public void Print()
        {
            for (int i = 0; i < arr1.GetLength(0); ++i)
            {
                for (int j = 0; j < arr1.GetLength(1); ++j)
                {
                    Console.Write(arr1[i, j] + "\t");

                }
                Console.WriteLine();
            }
        }


    }
}
    // problem
   // 1. 인덱스 범위 문제-
   // 2. 방향 맞추기 -
   // 3. 나머지 자잘한 버그 고치기 
   // 4. 코드 정리 (클래스로 묶어보기 : iMap)-
