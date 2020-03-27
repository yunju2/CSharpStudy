using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Result
    {
        public Result()
        {
            this.Value = string.Empty;
        }

        public Result(string value)
        {
            this.Value = value;
        }

        public string Value { get; set; }
    }

    class NullResult : Result
    {
    }

    class ClearResult : Result
    {
    }

    class EndResult : Result
    {
    }

    class Argument
    {
        public Argument(double value)
        {
            this.Value = value;
        }

        public double Value { get; set; }
    }

    class NullArgument : Argument
    {
        public NullArgument() : base(0)
        {
        }
    }

    interface IOperator
    {
        int ArgCount { get; }
        Result Process(Argument arg1, Argument arg2);
    }

    class ErrorOperator : IOperator
    {
        public string Message { get; private set; }
        public ErrorOperator(string str)
        {
            Message = str;
        }

        public int ArgCount => 0;
        public Result Process(Argument arg1, Argument arg2)
        {
            throw new Exception(this.ToString());
        }

        public override string ToString()
        {
            return $"[Error] {Message}";
        }
    }

    class PlusOperator : IOperator
    {
        public int ArgCount => 2;
        public Result Process(Argument arg1, Argument arg2)
        {
            return new Result((arg1.Value + arg2.Value).ToString());
        }
    }

    class DivOperator : IOperator
    {
        public int ArgCount => 2;
        public Result Process(Argument arg1, Argument arg2)
        {
            if (arg2.Value == 0)
            {
                throw new Exception("0으로 나눌 수 없습니다.");
            }
            return new Result((arg1.Value / arg2.Value).ToString());
        }
    }

    class EqualsOperator : IOperator
    {
        public int ArgCount => 2;
        public Result Process(Argument arg1, Argument arg2)
        {
            return new Result((arg1.Value == arg2.Value).ToString());
        }
    }

    class PowerOperator : IOperator
    {
        public int ArgCount => 2;
        public Result Process(Argument arg1, Argument arg2)
        {
            double rv = arg1.Value;
            for (int i = 1; i < (int)arg2.Value; ++i)
            {
                rv *= arg1.Value;
            }
            return new Result(rv.ToString());
        }
    }

    class IncreaseOperator : IOperator
    {
        public int ArgCount => 1;
        public Result Process(Argument arg1, Argument arg2)
        {
            return new Result((arg1.Value + 1).ToString());
        }
    }


    class RootOperator : IOperator
    {
        public int ArgCount => 1;
        public Result Process(Argument arg1, Argument arg2)
        {
            return new Result(Math.Sqrt(arg1.Value).ToString());
        }
    }

    class ClearOperator : IOperator
    {
        public int ArgCount => 0;
        public Result Process(Argument arg1, Argument arg2)
        {
            return new ClearResult();
        }
    }

    class EndOperator : IOperator
    {
        public int ArgCount => 0;
        public Result Process(Argument arg1, Argument arg2)
        {
            return new EndResult();
        }
    }

    class InputManager
    {
        public IOperator Process(out Argument arg1, out Argument arg2)
        {
            arg1 = new NullArgument();
            arg2 = new NullArgument();

            IOperator oper = CreateOperator();
            if (oper.ArgCount >= 1)
            {
                if (CreateArgument(1, out arg1) == false)
                {
                    return new ErrorOperator("인자 값을 숫자로 입력 하세요.");
                }
            }

            if (oper.ArgCount >= 2)
            {
                if (CreateArgument(2, out arg2) == false)
                {
                    return new ErrorOperator("인자 값을 숫자로 입력 하세요.");
                }
            }
            return oper;
        }

        private IOperator CreateOperator()
        {
            Console.Write("명령어를 입력하세요. ( +, /, ==, ^, ++, root, clear, end) : ");
            string cmd = Console.ReadLine();

            if (cmd == "+")
                return new PlusOperator();
            if (cmd == "/")
                return new DivOperator();
            if (cmd == "==")
                return new EqualsOperator();
            if (cmd == "^")
                return new PowerOperator();
            if (cmd == "++")
                return new IncreaseOperator();
            if (cmd.ToLower() == "root")
                return new RootOperator();
            if (cmd.ToLower() == "clear")
                return new ClearOperator();
            if (cmd.ToLower() == "end")
                return new EndOperator();
            return new ErrorOperator("명령어가 잘못 되었습니다");
        }

        private bool CreateArgument(int num, out Argument arg)
        {
            Console.Write($"{num}번 인자 값을 입력하세요 : ");
            string input = Console.ReadLine();
            if (double.TryParse(input, out double d))
            {
                arg = new Argument(d);
                return true;
            }
            arg = new NullArgument();
            return false;
        }
    }

    class OutputManager
    {
        public bool Process(Result result)
        {
            if (result is NullResult)
            {
                Console.WriteLine("결과가 잘못 되었습니다");
            }
            else if (result is EndResult)
            {
                Console.WriteLine($"종료합니다.");
                return false;
            }
            else if (result is ClearResult)
            {
                Console.Clear();
            }
            else
            {
                Console.WriteLine($"결과 : {result.Value}");
            }
            return true;
        }
    }

    class Program
    {
        public static void Main()
        {
            Program program = new Program();
            program.Run();
        }

        InputManager input = new InputManager();
        OutputManager output = new OutputManager();
        public void Run()
        {
            while (true)
            {
                Argument arg1;
                Argument arg2;
                IOperator oper = input.Process(out arg1, out arg2);

                Result result;
                try
                {
                    result = oper.Process(arg1, arg2);
                }
                catch (Exception e)
                {
                    Console.WriteLine($"[Error] {e}");
                    continue;
                }

                if (output.Process(result) == false)
                    break;

                Console.WriteLine();
            }
        }
    }
}
