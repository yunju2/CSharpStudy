﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;
            while (true)
            {
                Console.WriteLine("부호를 입력하시요>>");
                string sign = Console.ReadLine();

                Console.WriteLine("인자값1>>");
                string num1 = Console.ReadLine();
                int number1 = int.Parse(num1);

                Console.WriteLine("인자값2>>");
                string num2 = Console.ReadLine();
                int number2 = int.Parse(num2);

                if (sign == "+")
                {

                    result = number1 + number2;

                    Console.WriteLine("결과>>{0}", result);

                }
                if (sign == "-")
                {
                    result = number1 - number2;

                    Console.WriteLine("결과>>{0}", result);
                }

                if (sign == "*")
                {
                    result = number1 * number2;

                    Console.WriteLine("결과>>{0}", result);
                }

                if (sign == "/")
                {
                    result = number1 / number2;

                    Console.WriteLine("결과>>{0}", result);
                }
                if (sign == "^")
                {
                    result = (int)Math.Pow(number1, number2);

                    Console.WriteLine("결과>>{0}", result);
                }
                if (sign == "")
                {

                }

            }
        }
    }
}
