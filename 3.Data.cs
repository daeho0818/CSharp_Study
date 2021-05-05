using System;
using static System.Console;

namespace CSharp
{
    class Data
    {
        public static void wholeNumber()
        {
            int x;
            //변수, int는 데이터 형식, x는 식별자(변수의 이름)
            //현재 상태에는 쓰레기값이 들어가 있음.
            x = 100;
            //x의 값을 100으로 초기화

            sbyte a = -10;
            byte b = 40;
            WriteLine($"a = {a}, b = {b}");

            short c = -30000;
            ushort d = 60000;
            WriteLine($"c={c}, d={d}");

            int e = -1000_0000;
            uint f = 3_0000_0000;
            WriteLine($"e={e}, f={f}");

            long g = -5000_0000_0000;
            ulong h = 200_0000_0000_0000_0000;
            WriteLine($"g={g}, h={h}");
        }

        public static void IntegerLiterals()
        {
            byte a = 240; // 10진수 리터럴
            WriteLine($"a={a}");

            byte b = 0b1111_0000; // 2진수 리터럴
            WriteLine($"b={b}");

            byte c = 0XF0; // 16진수 리터럴
            WriteLine($"c={c}");

            uint d = 0x1234_abcd; // 16진수 리터럴
            WriteLine($"d={d}");
        }
        public static void SignedUnsigned()
        {
            byte a = 255;
            sbyte b = (sbyte)a;

            WriteLine(a);
            WriteLine(b);
        }
        public static void Overflow()
        {
            uint a = uint.MaxValue;
            WriteLine(a);
            a++; //변수의 최대값에서 1을 더함
            WriteLine(a); //숫자가 0이 됨 (byte로 치면, 최대값이 1111 1111 인데 여기서 1을 더해주면 1 0000 0000이 됨)
            a++;
            WriteLine(a);
            int b = int.MaxValue;
            WriteLine(b);
            b++; // 변수의 최대값에서 1을 더함
            WriteLine(b); // ...1111 1111 의 형태일텐데, 1을 더해주면 1 0000 0000 ... 의 형태가 됨
            //int형 변수는 음수가 있기 때문에 0000 0000 이 최소값인 음수인걸로 추정됨. 그래서 저 값이 나오나봄
        }
        public static void FloatingPoint()
        {
            float a = 3.1415_9265_3589_8932_3846f; // float 데이터 형식을 사용할 때는 값의 뒤에 f를 붙여야 함
            WriteLine(a);

            double b = 3.1415_9265_3589_7932_3846;
            WriteLine(b);
        }
        public static void Decimal()
        {
            float a = 3.1415_9265_3589_8932_3846_2643_3832_79f;
            double b = 3.1415_9265_3589_8932_3846_2643_3832_79;
            decimal c = 3.1415_9265_3589_8932_3846_2643_3832_79m;

            WriteLine(a);
            WriteLine(b);
            WriteLine(c);
        }
        public static void Char()
        {
            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';

            Write(a);
            Write(b);
            Write(c);
            Write(d);
            Write(e);
            WriteLine();
        }
        public static void String()
        {
            string a = "안녕하세요?";
            string b = "임대딱입니다.";

            WriteLine(a);
            WriteLine(b);
        }
        public static void Bool()
        {
            bool a = true;
            bool b = false;

            WriteLine(a);
            WriteLine(b);
        }
        public static void Object()
        {
            object a = 123;
            object b = 3.141592653589793238462643383279m;
            object c = true;
            object d = "안녕하세요";

            WriteLine(a);
            WriteLine(b);
            WriteLine(c);
            WriteLine(d);
        }
        public static void BoxingUnboxing()
        {
            int a = 123;
            object b = (object)a; // a의 값을 박싱하여 힙에 저장
            int c = (int)b; // b의 값을 언방식하여 스택에 저장

            WriteLine(a);
            WriteLine(b);
            WriteLine(c);

            double x = 3.1414213;
            object y = x; // x의 값을 힙에 저장
            double z = (double)y; // y의 값을 언박싱하여 스택에 저장

            WriteLine(x);
            WriteLine(y);
            WriteLine(z);
        }
        public static void IntegralConversion()
        {
            sbyte a = 127;
            WriteLine(a);

            int b = (int)a;
            WriteLine(b);

            int x = 128; // sbyte의 최댓값보다 1 더 큰 수
            WriteLine(x);

            sbyte y = (sbyte)x; // overflow
            WriteLine(y);
        }
        public static void FloatConversion()
        {
            float a = 69.6875f;
            WriteLine("a : {0}", a);

            double b = (double)a;
            WriteLine("b = {0}", b);

            WriteLine("69.6875 == b : {0}", 69.6875 == b);

            float x = 0.1f;
            WriteLine("x : {0}", x);

            double y = (double)x;
            WriteLine("y : {0}", y);

            WriteLine("0.1 == y : {0}", 0.1 == y);
        }
        public static void SignedUnsigendConversion()
        {
            int a = 500;
            WriteLine(a);

            uint b = (uint)a;
            WriteLine(b);

            int x = -30;
            WriteLine(x);

            uint y = (uint)x;
            WriteLine(y);
        }
        public static void FloatToIntegral()
        {
            float a = 0.9f;
            int b = (int)a;
            WriteLine(b);

            float c = 1.1f;
            int d = (int)c;
            WriteLine(d);
        }
        public static void StringNumberConversion()
        {
            int a = 123;
            string b = a.ToString();
            WriteLine(b);

            float c = 3.14f;
            string d = c.ToString();
            WriteLine(d);

            string e = "123456";
            int f = int.Parse(e);
            WriteLine(f);

            string g = "1.2345";
            float h = float.Parse(g);
            WriteLine(h);
        }
        public static void Constant()
        {
            const int MAX_INT = 2147483647;
            const int MIN_INT = -2147483647;

            WriteLine(MAX_INT);
            WriteLine(MIN_INT);

            /* 오류 예제
            const int a = 5;
            a = 3;
            "에러가 발생했숩니당."
            */
        }
        enum DialogResult { YES, NO, CANCLE, CONFIRM, OK } // Enum 함수에 사용
        public static void Enum()
        {
            WriteLine((int)DialogResult.YES);
            WriteLine((int)DialogResult.NO);
            WriteLine((int)DialogResult.CANCLE);
            WriteLine((int)DialogResult.CONFIRM);
            WriteLine((int)DialogResult.OK);
        }
        enum DialogResult2 { YES, NO, CANCLE, CONFIRM, OK }
        public static void Enum2()
        {
            DialogResult2 result = DialogResult2.YES;

            WriteLine(result == DialogResult2.YES);
            WriteLine(result == DialogResult2.NO);
            WriteLine(result == DialogResult2.CANCLE);
            WriteLine(result == DialogResult2.CONFIRM);
            WriteLine(result == DialogResult2.OK);
        }
        enum DialogResult3 { YES = 10, NO, CANCLE, CONFIRM = 50, OK }
        public static void Enum3()
        {
            WriteLine((int)DialogResult3.YES);
            WriteLine((int)DialogResult3.NO);
            WriteLine((int)DialogResult3.CANCLE);
            WriteLine((int)DialogResult3.CONFIRM);
            WriteLine((int)DialogResult3.OK);
        }
        public static void Nullable()
        {
            int? a = null;
            WriteLine(a.HasValue);
            WriteLine(a != null);

            a = 3;
            WriteLine(a.HasValue);
            WriteLine(a != null);
            WriteLine(a.Value);
        }
        public static void UsingVar()
        {
            var a = 20;
            WriteLine("Type : {0}, Value : {1}", a.GetType(), a);

            var b = 3.14142123;
            WriteLine("Type : {0}, Value : {1}", b.GetType(), b);

            var c = "Hello World!";
            WriteLine("Type : {0}, Value : {1}", c.GetType(), c);

            var d = new int[] { 10, 20, 30 };
            Write("Type : {0}, Value : ", d.GetType());

            foreach (var e in d) // 배열의 각 요소를 순회하는 기능이라 함. 나중에 배움
                Write("{0} ", e);

            WriteLine();
        }
        public static void CTS()
        {
            System.Int32 a = 123;
            int b = 456;
            WriteLine("a type : {0}, value : {1}", a.GetType().ToString(), a); // GetType();<-- 해당 변수(객체가 맞는 표현) 실체 형식 알려줌
            WriteLine("b type : {0}, value : {1}", b.GetType().ToString(), b); // ToSring();<-- 변수(객체가 맞는 표현)를 문자열로 표시

            System.String c = "abc";
            string d = "def";
            WriteLine("c type : {0}, value : {1}", c.GetType().ToString(), c);
            WriteLine("d type : {0}, value : {1}", d.GetType().ToString(), d);
        }
        private void Practice()
        {
            /*
            //----1. 다음 코드에서 잘못된 부분을 찾고 이유 설명----
        
            int a = 7.3; // int는 정수형 변수이기 때문에, 유리수 불가
            float b = 3.14; // float 형식을 사용하려면 실수의 뒤에 f를 붙여야 함
            double c = a * b;
            char d = "abc"; // char 형식은 문자 형식이기 때문에 작은 따옴표(' ')를, 한 글자만 써야 함
            string e = '한'; // string 은 문자열 형식이기 때문에 한 글자가 가능하지만, 큰 따옴표(" ")를 사용해야 함
            --------------------------------------------------------
            //----2. 값 형식과 참조 형식의 차이 ----
            
            값 형식은 변수의 값인 데이터가 담기는 곳이고
            참조 형식은 변수에 값이 있는 주소가 담긴다.
            ----------------------------------------
            //----3. 박싱과 언박싱 설명하기 ----
            박싱 : 값 형식에 담겨 있는 데이터를 힙 형식에 할당시키는 것(스택에는 데이터의 주소가 참조됨)
            언박싱 : 박싱되어있는 데이터를 꺼내 값 형식에 할당하는 것
            ----------------------------------------
            */
            //----4. 다음과 같이 사용자로부터 사각형의 너비와 높이를 입력받아 넓이를 계산하는 프로그램을 완성하세요.----
            WriteLine("사각형의 너비(가로)를 입력하세요.");
            string width = ReadLine();

            WriteLine("사각형의 높이(세로)를 입력하세요.");
            string height = ReadLine();
            //아래에 넓이 계산과 출력하는 코드 작성
            int a = Convert.ToInt32(width);
            int b = Convert.ToInt32(height);
            int c = 0;
            c = a * b;
            WriteLine(c);
            //---------------------------------------------------------------------------------------------------------
            /*
            //----5. 다음 코드를 컴파일한 후의 a와 b는 각각 어떤 데이터 형식?----
            var a = 2020; // 정수형 변수(int, long 등) 
            var b = "double"; // 문자열 형식 변수(string)
            */
        }
    }
}


/* 메모장
I.데이터 형식을 두가지로 분류 가능
1. 
값 형식(stack(스택)과 관련, 변수가 값을 담는 데이터 형식)과
참조 형식(stack(스택), heap(힙)과 관련, 변수가 값이 있는 곳의 위치를 담는 데이터 형식)

- stack : 먼저 선언한 변수 순서대로 쌓이고,나중에 선언한 변수 순서대로 제거됨 (first in last out) -> 싹다 무조건 제거됨
- heap : CLR의 가비지 컬렉터를 통해 사용하지 않는 객체 제거 -> 사용하지 않는 것만 제거됨
- 차이점 : stack은 프로그램이 끝나면 데이터가 자동으로 지워지지만, heap은 프로그램이 종료돼도 쓰지 않을 때까지 제거하지 않음

2. 기본 데이터 형식과 복합 데이터 형식(구조체, 클래스, 배열 등)
(1) 기본 데이터 형식 - 
                       값 형식 - 크게 숫자 형식, 논리 형식
                       참조 형식 - 문자열 형식, 오브젝트 형식으로 나뉨

㉠ 숫자 형식 - 정수 계열, 부동 소수 계열, 소수 계열로 나뉨
ⓐ 정수 계열 형식 - 정수 데이터를 담기 위해 사용
- byte -> 부호 없는 정수, 1바이트, 가능한 값의 범위 : 0~255
- sbyte -> signed byte 정수, 1바이트, -128~127
- short -> 정수, 2바이트, -32,768~32,767
- ushort -> unsigned short 부호 없는 정수, 2바이트, 0~65,535
- int -> 정수, 4바이트, -2,147,483,648~2,147,483,647
- uint -> unsigned int 부호 없는 정수, 4바이트, 0~4,294,967,295
- long -> 정수, 8바이트, -922,337,203,685,477,508~922,337,203,685,477,507
- ulong -> unsigned long 부호 없는 정수, 8바이트, 0~18,446,744,073,709,551,615
- char -> 유니코드 문자, 2바이트

ⓑ 부동 소수점 형식 - 소수점이 움직이면서 유리수를 표현
- float ->  단일 정밀도 부동 소수점 형식, 4바이트, -3.402823e38(-3.402823x10^38)~3.402823e38(3.402823x10^38)
- double -> 복수 정밀도 부동 소수점 형식, 8바이트, -1.79769313486232e308~1.79769313486232e308

ⓒ 소수 형식 - 실수를 다루며 정밀도가 높음
- decimal -> 29자리 데이터를 표현할 수 있는 소수 형식, 16바이트, +-1.0 x 10e-28~+-7.9 x 10e28

㉡ 문자, 문자열 형식
- char -> 개별 문자 표현 가능, 작은 따옴표(' ');
- sting -> 문자열 표현 가능, 큰 따옴표(" ");

㉢ 논리 형식 - 참(ture)와 거짓(false)을 다룬다.
- bool -> 논리 형식, 1바이트, true와 false

㉣ 오브젝트 형식 - 모든 데이터 형식을 다룰 수 있다.
- object -> 숫자 형식, 논리 형식, 문자/문자열 형식을 포함

※박싱과 언박싱
- 박싱 : 값 형식에 담긴 데이터를 힙에 할당하는 것 (스택에는 주소가 참조됨)
- 언박싱 : 박싱되어있는 데이터를 꺼내 값 형식에 할당하는 것

II. 데이터 형식 바꾸기 - 변수를 다른 데이터 형식의 변수에 옮겨 담는 것
1. 크기가 서로 다른 정수 형식 사이의 변환
2. 크기가 서로 다른 부동 소수점 형식 사이의 변환
3. 부호가 있/없는 정수 형식 사이의 변환
4. 부동 소수점 형식과 정수 형식 사이의 변환
5. 문자열 형식과 숫자 형식 사이의 변환

III. 상수와 열거 형식 - 변수와 달리 안에 담긴 데이터를 바꿀 수 없음
1. 상수
- const -> 상수, 자료형 앞에 붙임
2. 열거 형식
- enum -> 열거 형식 상수, 열거형식명 앞에 붙임

IV. 비어있는 변수
- Nullable -> int? a = null; 의 형식으로 사용(자료형? 변수이름)

V. 데이터 형식 파악
- var -> var a = 3;의 형식, 선언과 동시에 초기화해줘야 함(변수의 형식을 인식하기 위해서), 지역 변수로만 사용 가능

VI. 공용 형식 시스템
- .NET 프레임워크의 형식 체계의 표준(CTS라고 함), C#의 데이터 형식 체계가 CTS 표준을 따르고 있음
- CTS 표준을 따르는 모든 언어에서 똑같이 사용 가능
 */