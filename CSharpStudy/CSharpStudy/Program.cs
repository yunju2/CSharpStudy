using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    class Caculator
    {
        void calculate(string sign, int number1, int number2)
        {
            int tmp = 0;
            string result = "";
            switch (sign)
            {
                case "+":
                    {
                        tmp = add(number1, number2);
                        result = tmp.ToString();
                    }
                    break;

                case "-":
                    {
                        tmp = sub(number1, number2);
                        result = tmp.ToString();
                    }
                    break;
                case "*":
                    {
                        tmp = number1 * number2;
                        result = tmp.ToString();

                    }
                    break;
                case "/":
                    {
                        tmp = number1 / number2;
                        result = tmp.ToString();
                    }
                    break;
                case "^":
                    {
                        tmp = (int)Math.Pow(number1, number2);
                        result = tmp.ToString();
                    }
                    break;

                case "<<":
                    {
                        tmp = number1 << number2;
                        result = tmp.ToString();
                    }
                    break;

                case "root":
                    //result = (int)Math.Sqrt();
                    break;

                case "++":
                    break;
                
                case "--":
                    break;

                default:
                    result = "잘못된 값입니다. 다시 입력해주세요";
                    break;
            }

            print(result);
            //return result;
        }

        int add(int a, int b)
        {
            // int add.a = number1;
            // int add.b = number2;
            // int temp = add.a + add.b;
            // result1 = temp;
            return a + b;
        }
        int sub(int a, int b)
        {
            return a - b;
        }

        void print(int result)
        {
            Console.WriteLine("값>>{0}", result);
        }

        void print(string result)
        {
            Console.WriteLine("값>>{0}", result);
        }

        public void run()
        {
            int result1;

            while (true)
            {
                Console.WriteLine("부호를 입력하시요>>");
                string sign = Console.ReadLine();

                if (sign.ToLower() == "clear")
                {
                    Console.Clear();
                    continue;
                }

                Console.WriteLine("인자값1>>");
                string num1 = Console.ReadLine();
                int number1;
                if (!Int32.TryParse(num1, out number1))
                {
                    Console.WriteLine("오류!! 1번 인자값을 숫자를 입력하세요!");
                    continue;
                }

                Console.WriteLine("인자값2>>");
                string num2 = Console.ReadLine();
                int number2;
                if (!Int32.TryParse(num2, out number2))
                {
                    Console.WriteLine("오류!! 2번 인자값을 숫자를 입력하세요!");
                    continue;
                }

                if (sign.ToLower() == "end")
                    break;

                calculate(sign, number1, number2);
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Caculator c = new Caculator();
                c.run();
            }
        }
    }
}

