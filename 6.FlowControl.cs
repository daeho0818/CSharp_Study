using System;
using static System.Console;
namespace CSharp
{
    class FlowControl
    {
        static public void IfElse()
        {
            Write("숫자를 입력하세요. : ");

            string input = ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
                WriteLine("음수");
            else if (number > 0)
                WriteLine("양수");
            else
                WriteLine("0");

            if (number % 2 == 0)
                WriteLine("짝수");
            else
                WriteLine("홀수");
        }
        static public void IfIf()
        {
            Write("숫자를 입력하세요 : ");

            string input = ReadLine();
            int number = Int32.Parse(input);

            if (number > 0)
            {
                if (number % 2 == 0)
                {
                    WriteLine("0보다 큰 짝수");
                }
                else
                {
                    WriteLine("0보다 큰 홀수");
                }
            }
            else
            {
                WriteLine("0보다 작거나 같은 수");
            }
        }
        static public void Switch()
        {
            Write("요일을 입력하세요.(일, 월, 화, 수, 목, 금, 토) : ");
            string day = ReadLine();

            switch (day)
            {
                case "일":
                    WriteLine("Sunday");
                    break;
                case "월":
                    WriteLine("Monday");
                    break;
                case "화":
                    WriteLine("Tuesday");
                    break;
                case "수":
                    WriteLine("Wednesday");
                    break;
                case "목":
                    WriteLine("Thursday");
                    break;
                case "금":
                    WriteLine("Friday");
                    break;
                case "토":
                    WriteLine("Saturday");
                    break;
                default:
                    WriteLine($"{day}는(은) 요일이 아닙니다.");
                    break;
            }
        }
        static public void Switch2()
        {
            object obj = null;

            string s = Console.ReadLine();
            if (int.TryParse(s, out int out_i)) // TryParse : 변환의 성공 여부를 반환하기 때문에 코드의 흐름 유지 가능
                obj = out_i;
            else if (float.TryParse(s, out float out_f)) // out : 출력 전용 매개 변수임을 나타내는 용도로 쓰인다고 알아 놓자.
                obj = out_f;
            else
                obj = s;
            switch (obj)
            {

                case int i:
                    WriteLine($"{i}는 int 형식입니다.");
                    break;
                case float f when f >= 0: // when : if와 비슷함, 추가적인 조건 검사 수행
                    WriteLine($"{f}는 양의 float 형식입니다.");
                    break;
                case float f:
                    WriteLine($"{f}는 음의 float 형식입니다.");
                    break;
                default:
                    WriteLine($"{obj}는 모르는 형식입니다.");
                    break;
            }
        }
        static public void While()
        {
            int i = 10;
            while (i > 0)
                WriteLine($"i : {i--}");
        }
        static public void DoWhile()
        {
            int i = 10;

            do
            {
                WriteLine("a) i : {0}", i--);
            }
            while (i > 0);

            do
            {
                WriteLine("b) i : {0}", i--);
            }
            while (i > 0);
        }
        static public void For()
        {
            for (int i = 0; i < 5; i++)
            {
                WriteLine(i);
            }
        }
        static public void ForFor()
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
        static public void ForEach()
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach (int a in arr)
            {
                WriteLine(a);
            }
        }
        static public void InfiniteFor()
        {
            int i = 0;
            for (; ; )
            {
                WriteLine(i++);
            }
        }
        static public void InfiniteWhile()
        {
            int i = 0;
            while (true)
            {
                WriteLine(i++);
            }
        }
        static public void Break()
        {
            while (true)
            {
                Write("계속할까요?(예/아니오) : ");
                string answer = ReadLine();

                if (answer == "아니오")
                {
                    break;
                }
            }
        }
        static public void Continue()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                WriteLine($"{i} : 홀수");
            }
        }
        static public void Goto()
        {
            Write("종료 조건(숫자)를 입력하세요 : ");

            string input = ReadLine();

            int input_number = Convert.ToInt32(input);

            int exit_number = 0;

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    for (int k = 0; k < 3; k++)
                    {
                        if (exit_number++ == input_number)
                        {
                            goto EXIT_FOR;
                        }
                        WriteLine(exit_number);
                    }
                }
            }

            goto EXIT_PROGRAM;

        EXIT_FOR:
            WriteLine("\nExit nested for...");

        EXIT_PROGRAM:
            WriteLine("Exit program...");
        }
        private void Practice()
        {
            /* 
            1. 다음과 같은 결과를 출력하는 프로그램 for문으로 작성
            *
            **
            ***
            ****
            *****
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    Write("*");
                }
            WriteLine();
            }
            2. 다음과 같은 결과를 출력하는 프로그램 for문으로 작성
            *****
            ****
            ***
            **
            *
            for(int i = 0; i < 5; i++)
            {
                for(int j = 5; j > i; j--)
                {
                    Write("*");
                }
            WriteLine();
            }
            3. 1번과 2번을 for문 대신 do~while 문으로 각각 작성
            (1)
            int i = 1;
            int j = 0;
            do
            {
                do
                {
                    Write("*");
                    j++;
                } while(j < i);
                j = 0;
                WriteLine();
                i++;
            } while(i < 6);
            (2)
            int i = 0;
            int j = 5;
            do
            {
                do
                {
                    Write("*");
                    j--;
                } while(i < j);
                j = 5;
                WriteLine();
                i++;
            } while(i < 5);

            4. 사용자로부터 입력받은 횟수만큼 별 반복 출력. 단, 입력 수 0보다 작거나 같을 경우 "0보다 같거나 작은 숫자는 사용할 수 없습니다"
            라는 메세지 띄우고 프로그램 종료

            Console.Write("반복 횟수를 입력하세요 : ");
            string input = Console.ReadLine();
            int ChangeInt = Convert.ToInt32(input);
            for (int i = 0; i <= ChangeInt; i++)
            {
                if (ChangeInt <= 0)
                {
                    Console.WriteLine("0보다 작거나 같은 수는 입력할 수 없습니다.");
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            */
        }
    }
}
/* 메모장
I. 분기문 : 프로그램의 흐름을 조건에 따라 여러 갈래로 나누는 흐름 제어 구문
1. if ~ else 문
 + 중첩 if 문
2. switch 문
II. 반복문 : 특정 조건을 만족하는 동안 코드를 계속 반복해서 실행하도록 하는 문장
1. while 문
while(조건식)
{
    실행할 문장
}
-> 조건식이 true인 동안 실행

2. do ~ while 문
do
{
    실행할 문장
}while(조건식);
-> 무조건 처음 한번은 실행

3. for 문
for(초기식; 조건식; 증감식;)
{
    실행할 문장
}

4. 중첩 for 문
for(초기식; 초건식; 증감식;)
{
    for(초기식; 초건식; 증감식;)
        {
            실행할 문장
        }
    실행할 문장
}

5. foreach 문
foreach(자료형 변수명 in 배열 또는 컬렉션)
{
    실행할 문장
}

III. 점프문
1. break
- 현재 실행중인 반복문이나 switch문의 실행 중단

2. continue
- 한 회 건너 뛰어 반복을 계속 수행함

3. goto

goto 레이블;

레이블 :
    이어지는 코드
*/