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
                        tmp = mul(number1 , number2);
                        result = tmp.ToString();

                    }
                    break;
                case "/":
                    {
                        tmp = div(number1 , number2);
                        result = tmp.ToString();
                    }
                    break;
                case "^":
                    {
                        tmp = inv(number1, number2);
                        result = tmp.ToString();
                    }
                    break;

                case "<<":
                    {
                        tmp = shift(number1,number2);
                        result = tmp.ToString();
                    }
                    break;


                default:
                    result = "잘못된 값;입니다. 다시 입력해주세요";
                    break;
            }

            print(result);
            //return result;
        }
            void calculate1(string sign,int number1)
            {
                int tmp;
                string result = "";
            switch (sign)
            {
                case "root":
                    {
                        tmp = root(number1);
                        result = tmp.ToString();
                        break;
                    }
                case "++":
                    {
                        tmp = addmove(number1);
                        result = tmp.ToString();
                        break;
                    }
                case "--":
                    {
                        tmp = submove(number1);
                        result = tmp.ToString();

                        break;
                    }
                default:
                    result = "잘못된 값;입니다. 다시 입력해주세요";
                    break;
            }
            print(result);
            }

        int add(int a, int b)
        {
            // int add.a = number1;
            // int add.b = number2;
            // int temp = add.a + add.b;s
            // result1 = temp;
            return a + b;
        }
        int sub(int a, int b)
        {
            return a - b;
        }
        int div(int a, int b)
        {
            return a / b;
        }
        int mul (int a, int b)
        {
            return a * b;
        }
        int inv(int a, int b)
        {
            return (int) Math.Pow(a, b);
        }
        int shift(int a, int b)
        {
            return a << b;
        }
        int root(int a)
        {
            return (int)Math.Sqrt(a);
        }
        int addmove(int a)
        {
            return ++a;
        }
        int submove(int a)
        {
            return --a;
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
            

            while (true)
            {
                Console.WriteLine("부호를 입력하시요>>");
                string sign = Console.ReadLine();

                if (sign.ToLower() == "clear")
                {
                    Console.Clear();
                    continue;
                }
                if (sign.ToLower() == "end")
                {
                    break;
                }

                    Console.WriteLine("인자값1>>");
                    string num1 = Console.ReadLine();
                    int number1;
                    if (!Int32.TryParse(num1, out number1))
                    {
                        Console.WriteLine("오류!! 1번 인자값을 숫자를 입력하세요!");
                        continue;
                    }
                if (sign=="root")
                {  calculate1(sign, number1);
                    continue;

                }
                else if (sign == "++")
                {
                    calculate1(sign, number1);
                    continue;

                }
                else if (sign == "--")
                {
                    calculate1(sign, number1);
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

