using System;
using System.Diagnostics;
using System.Security.Cryptography;

namespace CSharp
{
    class Practice
    {
        static void Main()
        {
            Console.WriteLine("기본 구조");
            BasicStructure.basicStructure();
            Console.WriteLine();

            Console.WriteLine("정수형 변수");
            Data.wholeNumber();
            Console.WriteLine();

            Console.WriteLine("10진수, 2진수, 16진수");
            Data.IntegerLiterals();
            Console.WriteLine();

            Console.WriteLine("부호 있/없는 정수");
            Data.SignedUnsigned();
            Console.WriteLine();

            Console.WriteLine("Overflow");
            Data.Overflow();
            Console.WriteLine();

            Console.WriteLine("부동 소수점 형식");
            Data.FloatingPoint();
            Console.WriteLine();

            Console.WriteLine("소수 형식");
            Data.Decimal();
            Console.WriteLine();

            Console.WriteLine("Char");
            Data.Char();
            Console.WriteLine();

            Console.WriteLine("String");
            Data.String();
            Console.WriteLine();

            Console.WriteLine("Bool");
            Data.Bool();
            Console.WriteLine();

            Console.WriteLine("Object");
            Data.Object();
            Console.WriteLine();

            Console.WriteLine("BoxingUnboxing");
            Data.BoxingUnboxing();
            Console.WriteLine();

            Console.WriteLine("크기 서로 다른 정수 형식 사이 변환");
            Data.IntegralConversion();
            Console.WriteLine();

            Console.WriteLine("크기 서로 다른 부동 소수점 형식 사이 변환");
            Data.FloatConversion();
            Console.WriteLine();

            Console.WriteLine("부호가 있/없는 정수 형식 사이의 변환");
            Data.SignedUnsigendConversion();
            Console.WriteLine();

            Console.WriteLine("부동 소수점 형식과 정수 형식 사이의 변환");
            Data.FloatToIntegral();
            Console.WriteLine();

            Console.WriteLine("문자열 형식과 숫자 형식 사이의 변환");
            Data.StringNumberConversion();
            Console.WriteLine();

            Console.WriteLine("상수 const");
            Data.Constant();
            Console.WriteLine();

            Console.WriteLine("열거 형식 상수 enum");
            Data.Enum();
            Console.WriteLine();

            Console.WriteLine("enum result의 데이터 정해주기");
            Data.Enum2();
            Console.WriteLine();

            Console.WriteLine("enum result에 정수형 데이터 정해주기");
            Data.Enum3();
            Console.WriteLine();

            Console.WriteLine("null 상태인 변수, Nullable");
            Data.Nullable();
            Console.WriteLine();

            Console.WriteLine("암시적 형식, var");
            Data.UsingVar();
            Console.WriteLine();

            Console.WriteLine("공용 데이터 형식, CTS");
            Data.CTS();
            Console.WriteLine();

            Console.WriteLine("sting형식이 제공하는 문자열 안에서 찾는 메소드");
            String.StringSearch();
            Console.WriteLine();

            Console.WriteLine("string형식이 제공하는 문자열 변형하는 메소드");
            String.StringModify();
            Console.WriteLine();

            Console.WriteLine("string형식이 제공하는 문자열 분할하는 메소드");
            String.StringSlice();
            Console.WriteLine();

            Console.WriteLine("String Format Basic");
            String.StringFormatBasic();
            Console.WriteLine();

            Console.WriteLine("String Format Number");
            String.StringFormatNumber();
            Console.WriteLine();

            Console.WriteLine("String Format DateTime");
            String.StringFormatDateTime();
            Console.WriteLine();

            Console.WriteLine("String Interpolation");
            String.StringInterpolation();
            Console.WriteLine();

            Console.WriteLine("산술 연산자");
            Operator.ArithmaticOperators();
            Console.WriteLine();

            Console.WriteLine("증감 연산자");
            Operator.InDecOperator();
            Console.WriteLine();

            Console.WriteLine("문자열 결합 연산자");
            Operator.StringConcatenate();
            Console.WriteLine();

            Console.WriteLine("관계 연산자");
            Operator.RelationalOperator();
            Console.WriteLine();

            Console.WriteLine("논리 연산자");
            Operator.LogicalOperator();
            Console.WriteLine();

            Console.WriteLine("조건 연산자");
            Operator.ConditionalOperator();
            Console.WriteLine();

            Console.WriteLine("널 조건부 연산자");
            Operator.NullConditionalOperator();
            Console.WriteLine();

            Console.WriteLine("비트 시프트 연산자");
            Operator.ShiftOperator();
            Console.WriteLine();

            Console.WriteLine("비트 논리 연산자");
            Operator.BitwiseOperator();
            Console.WriteLine();

            Console.WriteLine("할당 연산자");
            Operator.AssignmentOperator();
            Console.WriteLine();

            Console.WriteLine("널 병합 연산자");
            Operator.NullCoalescing();
            Console.WriteLine();

            Console.WriteLine("if ~ else 문");
            //FlowControl.IfElse();
            Console.WriteLine();

            Console.WriteLine("중첩 if 문");
            //FlowControl.IfIf();
            Console.WriteLine();

            Console.WriteLine("Switch 문");
            //FlowControl.Switch();
            Console.WriteLine();

            Console.WriteLine("데이터 형식 Switch 문");
            //FlowControl.Switch2();
            Console.WriteLine();

            Console.WriteLine("While 문");
            FlowControl.While();
            Console.WriteLine();

            Console.WriteLine("Do~While 문");
            FlowControl.DoWhile();
            Console.WriteLine();

            Console.WriteLine("For 문");
            FlowControl.For();
            Console.WriteLine();

            Console.WriteLine("중첩 For 문");
            FlowControl.ForFor();
            Console.WriteLine();

            Console.WriteLine("foreach 문");
            FlowControl.ForEach();
            Console.WriteLine();

            Console.WriteLine("무한루트 For 문");
            //FlowControl.InfiniteFor();
            Console.WriteLine();

            Console.WriteLine("무한루트 While 문");
            //FlowControl.InfiniteWhile();
            Console.WriteLine();

            Console.WriteLine("Break 문");
            //FlowControl.Break();
            Console.WriteLine();

            Console.WriteLine("Continue 문");
            FlowControl.Continue();
            Console.WriteLine();

            Console.WriteLine("Goto 문");
            //FlowControl.Goto();
            Console.WriteLine();

            Console.WriteLine("메소드와 반환");
            Method.Calculator();
            Console.WriteLine();

            Console.WriteLine("반환");
            Method.Return();
            Console.WriteLine();

            Console.WriteLine("Fail Swap");
            Method.SwapByValue();
            Console.WriteLine();

            Console.WriteLine("Complete Swap");
            Method.SwapByRef();
            Console.WriteLine();

            Console.WriteLine("메소드 반환값 참조하기");
            Method.RefReturn();
            Console.WriteLine();

            Console.WriteLine("출력 전용 매개 변수");
            Method.UsingOut();
            Console.WriteLine();

            Console.WriteLine("함수 오버로딩");
            Method.Overloading();
            Console.WriteLine();

            Console.WriteLine("가변길이 매개 변수");
            Method.UsingParamgs();
            Console.WriteLine();

            Console.WriteLine("명명된 매개 변수");
            Method.NamedParameter();
            Console.WriteLine();
        }
    }
}