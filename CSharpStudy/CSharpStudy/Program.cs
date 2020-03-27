using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    // struct, class
    // c++ 객체지향
    class CalculatorArg
    {
        public string sign;
        // 멤버변수
        public int number1;
        public int number2;

        // 최초 생성 시 1회만 호출하는 함수를 만들고 싶다 -> 생성자
        public CalculatorArg()
        {
        }

        // 소멸자 -> 반대
        ~CalculatorArg()
        {
        }

        // 멤버함수, 메소드
        void func()
        {
            //this.number1;
        }

        // 외부에서 불렀으면 이렇게 불렀을 것
        //void func(CalculatorArg arg)
        //{
        //    arg.number1;
        //}
    }

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
                        tmp = pow(number1, number2);
                        result = tmp.ToString();
                    }
                    break;

                case "<<":
                    {
                        tmp = shift(number1,number2);
                        result = tmp.ToString();
                    }
                    break;
                case "==":
                    {
                        bool tmp1;
                        tmp1 = equal( number1, number2);
                        result = tmp1.ToString();
                    }
                    break;
                default:
                    result = "잘못된 값;입니다. 다시 입력해주세요";
                    break;
            }

            print(result);
            //return result;
        }
        void calculate1(string sign, int number1)
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
        int pow(int a, int b)
        {
            int a_ = 1;
            for (int i = 0; i < b; ++i)
            {
                a_ *= a;


            }
            return a_;
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
        bool equal(int a,int b)
        {
            return a == b;
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
                CalculatorArg arg = new CalculatorArg();
                arg.sign = Console.ReadLine();

                if (arg.sign.ToLower() == "clear")
                {
                    Console.Clear();
                    continue;
                }
                if (arg.sign.ToLower() == "end")
                {
                    break;
                }

                Console.WriteLine("인자값1>>");
                string num1 = Console.ReadLine();
                if (!Int32.TryParse(num1, out arg.number1))
                {
                    Console.WriteLine("오류!! 1번 인자값을 숫자를 입력하세요!");
                    continue;
                }

                if (arg.sign == "root" || arg.sign == "++" || arg.sign == "--")
                {
                    calculate1(arg.sign, arg.number1);
                    continue;
                }

              
                Console.WriteLine("인자값2>>");
                string num2 = Console.ReadLine();
                if (!Int32.TryParse(num2, out arg.number2))
                {
                    Console.WriteLine("오류!! 2번 인자값을 숫자를 입력하세요!");
                    continue;
                }



                calculate(arg.sign, arg.number1, arg.number2);
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

