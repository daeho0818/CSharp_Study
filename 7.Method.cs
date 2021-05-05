using System;
using static System.Console;

namespace CSharp
{
    class Method
    {
        public static void Calculator()
        {
            int result = _Method.Plus(3, 4);
            WriteLine(result);

            result = _Method.Minus(5, 2);
            WriteLine(result);
        }
        public static void Return()
        {
            WriteLine($"10번째 피보나치 수 : {_Method.Fibonacci(10)}");

            _Method.PrintProfile("", "123-4567");
            _Method.PrintProfile("임대호", "456-1230");
        }
        public static void SwapByValue()
        {
            int x = 3;
            int y = 4;

            WriteLine($"x:{x}, y:{y}");

            _Method.Swap(x, y);

            WriteLine($"x:{x}, y:{y}");
        }
        public static void SwapByRef()
        {
            int x = 3;
            int y = 4;

            WriteLine($"x:{x}, y:{y}");

            _Method._Swap(ref x, ref y);

            WriteLine($"x:{x}, y:{y}");
        }
        public static void RefReturn()
        {
            _Method carrot = new _Method();
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            WriteLine($"Ref Local Price :{ref_local_price}");
            WriteLine($"NorMal Local Price :{normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            WriteLine($"Ref Local Price :{ref_local_price}");
            WriteLine($"Normal Local Price :{normal_local_price}");
        }
        public static void UsingOut()
        {
            int a = 20;
            int b = 3;
            // int c;
            // int d;

            _Method.Divide(a, b, out int c, out int d);

            WriteLine($"a : {a}, b : {b}, a / b : {c}, b % a : {d}");
        }
        public static void Overloading()
        {
            WriteLine(_Method.PlusValue(1, 2));
            WriteLine(_Method.PlusValue(1, 2, 3));
            WriteLine(_Method.PlusValue(1.0, 2.4));
            WriteLine(_Method.PlusValue(1, 2.4));
        }

        public static void UsingParamgs()
        {
            int sum = _Method.Sum(3, 4, 5, 6, 7, 8, 9, 10);
            WriteLine($"Sum : {sum}");
        }

        public static void NamedParameter()
        {
            _Method._PrintProfile(name: "박찬호", phone: "010-123-1234");
            _Method._PrintProfile(phone: "010-2908-2748", name : "임대호");
            _Method._PrintProfile(name: "쌉지딱", phone: "010-2908-2748");
            _Method._PrintProfile(name: "호히힝", phone: "522-5222-5222");
        }
    }
    public class _Method
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
        public static int Minus(int a, int b)
        {
            return a - b;
        }
        public static int Fibonacci(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibonacci(n - 1) +Fibonacci(n - 2);
        }
        public static void PrintProfile(string name, string phone)
        {
            if(name == "")
            {
                WriteLine("이름을 입력해주세요.");
                return;
            }
            WriteLine($"Name : {name}, Phone : {phone}");
        }
        public static void Swap(int a, int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }
        public static void _Swap(ref int a, ref int b)
        {
            int temp = b;
            b = a;
            a = temp;
        }

        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            WriteLine($"Price :{price}");
        }
        public static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }

        public static int PlusValue(int a, int b)
        {
            WriteLine("Calling int Plus(int, int)...");
            return a + b;
        } 
        public static int PlusValue(int a, int b, int c)
        {
            WriteLine("Calling int Plus(int, int)...");
            return a + b + c;
        }
        public static double PlusValue(double a, double b)
        {
            WriteLine("Calling double Plus(double, double)...");
            return a + b;
        }

        public static double PlusValue(int a, double b)
        {
            WriteLine("Calling double Plus(int, double)...");
            return a + b;
        }

        public static int Sum(params int[] args)
        {
            Write("Summing...");
            int sum = 0;
            for(int i = 0; i < args.Length; i++)
            {

                Write(args[i]);
                sum += args[i];
                Write(", ");
            }
            WriteLine();
            return sum;
        }

        public static void _PrintProfile(string name, string phone)
        {
            WriteLine($"Name : {name}, Phone : {phone}");
        }
    }
}

/* 메모장
I. 참조에 의한 매개변수 전달
1. ref -> 값에 의한 호출이 아닌 참조에 의한 호출을 하도록 함 (넘겨준 변수의 값이 변함)
2. in -> 읽기 전용 (변수에 값 대입 불가)
3. out -> 쓰기 전용 (변수를 읽지 못함 - WriteLine() X)
 
 */