using System;
using System.Collections;
using static System.Console;
namespace CSharp
{
    class Operator
    {
        static public void ArithmaticOperators()
        {
            int a = 111 + 222;
            WriteLine($"a : {a}");

            int b = a - 100;
            WriteLine($"b : {b}");

            int c = b * 10;
            WriteLine($"c : {c}");

            double d = c / 6.3;
            WriteLine($"d : {d}");

            WriteLine($"22 / 7 = {22 / 7}({22 % 7})");
        }
        static public void InDecOperator()
        {
            int a = 10;
            WriteLine(a++);
            WriteLine(++a);

            WriteLine(a--);
            WriteLine(--a);
        }
        static public void StringConcatenate()
        {
            string result = "123" + "456";
            WriteLine(result);

            result = "Hello" + " " + "World!";
            WriteLine(result);
        }
        static public void RelationalOperator()
        {
            WriteLine($"3 > 4 : {3 > 4}");
            WriteLine($"3 >= 4 : {3 >= 4}");
            WriteLine($"3 < 4 : {3 < 4}");
            WriteLine($"3 <= 4 : {3 <= 4}");
            WriteLine($"3 == 4 : {3 == 4}");
            WriteLine($"3 != 4 : {3 != 4}");
        }
        static public void LogicalOperator()
        {
            WriteLine("Testing && ...");
            WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");
            WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
            WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
            WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");

            WriteLine("\nTesting || ...");
            WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");
            WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");
            WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");
            WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");

            WriteLine("\nTesting ! ...");
            WriteLine($"!True : {!true}");
            WriteLine($"!False : {!false}");
        }
        static public void ConditionalOperator()
        {
            string result = (10 % 2) == 0 ? "짝수" : "홀수";
            WriteLine(result);

            result = (10 % 3) == 0 ? "짝수" : "홀수";
            WriteLine(result);
        }
        static public void NullConditionalOperator()
        {
            ArrayList a = null; //ArrayList는 배열인 것 같다. 아마도..
            a?.Add("히히");
            a?.Add("네이스");
            WriteLine($"Count : {a?.Count}"); //a가 null이라면 null 반환
            WriteLine($"{a?[0]}"); //a가 null이 아니라면 a의 0번째 배열요소를 반환
            WriteLine($"{a?[1]}"); //a가 null이 아니라면 a의 1번째 배열요소를 반환

            a = new ArrayList();
            a?.Add("히히");
            a?.Add("네이스");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
            WriteLine();

            //간단하게 응용 해보기
            WriteLine("응용 실습");
            WriteLine();
            ArrayList player = null;
            int playerLevel = 0;

            WriteLine($"플레이어의 레벨 : {playerLevel}");
            WriteLine("얻은 메달 : ");
            player?.Add("동메달");
            player?.Add("은메달");
            player?.Add("금메달");
            WriteLine($"{player?[0]}");
            WriteLine($"{player?[1]}");
            WriteLine($"{player?[2]}");

            player = new ArrayList();
            playerLevel = 50;
            WriteLine($"플레이어의 레벨 : {playerLevel}");
            WriteLine("얻은 메달 : ");
            player?.Add("동메달");
            player?.Add("은메달");
            player?.Add("금메달");
            WriteLine($"{player?[0]}");
            WriteLine($"{player?[1]}");
            WriteLine($"{player?[2]}");

            //나중에 null일때 뒤의 멤버에 접근하는 방법 알아내면 수정해보자..
        }
        static public void ShiftOperator()
        {
            WriteLine("Testing << ...");

            int a = 1;
            WriteLine("a      : {0:D5} (0x{0:X8})", a);
            WriteLine("a << 1 : {0:D5} (0x{0:X8})", a << 1);
            WriteLine("a << 2 : {0:D5} (0x{0:X8})", a << 2);
            WriteLine("a << 5 : {0:D5} (0x{0:X8})", a << 5);

            WriteLine("\nTesting >> ...");

            int b = 255;
            WriteLine("b     : {0:D5} (0x{0:X8})", b);
            WriteLine("b >> 1: {0:D5} (0x{0:X8})", b << 1);
            WriteLine("b >> 2: {0:D5} (0x{0:X8})", b << 2);
            WriteLine("b >> 5: {0:D5} (0x{0:X8})", b << 5);

            WriteLine("\nTesting >> 2 ...");

            int c =- 255;
            WriteLine("c     : {0:D5} (0x{0:X8})", c);
            WriteLine("c >> 1: {0:D5} (0x{0:X8})", c >> 1);
            WriteLine("c >> 2: {0:D5} (0x{0:X8})", c >> 2);
            WriteLine("c >> 5: {0:D5} (0x{0:X8})", c >> 5);
        }
        static public void BitwiseOperator()
        {
            int a = 9;
            int b = 10;

            WriteLine($"{a} & {b} : {a & b}");
            WriteLine($"{a} | {b} : {a | b}");
            WriteLine($"{a} ^ {b} : {a ^ b}");

            int c = 255;
            WriteLine("~{0}(0x{0:X8}) : {1}(0x{1:X8})", c, ~c);
        }
        static public void AssignmentOperator()
        {
            int a;
            a = 100;
            WriteLine($"a = 100 : {a}");
            a += 90;
            WriteLine($"a += 90 : {a}");
            a -= 80;
            WriteLine($"a -= 80 : {a}");
            a *= 70;
            WriteLine($"a *= 70 : {a}");
            a /= 60;
            WriteLine($"a /= 60 : {a}");
            a %= 50;
            WriteLine($"a %/ 50 : {a}");
            a &= 40;
            WriteLine($"a &= 40 : {a}");
            a |= 30;
            WriteLine($"a |= 30 : {a}");
            a ^= 20;
            WriteLine($"a ^= 20 : {a}");
            a <<= 10;
            WriteLine($"a <<= 10 : {a}");
            a >>= 1;
            WriteLine($"a >>= 1 : {a}");
        }
        static public void NullCoalescing()
        {
            int? num = null;
            WriteLine($"{num ?? 0}");

            num = 99;
            WriteLine($"{num ?? 0}");

            string str = null;
            WriteLine($"{str ?? "Default"}");

            str = "Specific";
            WriteLine($"{str ?? "Default"}");
        }
        private void Practice()
        {
            /*
            1. 다음 i++와 ++i 의 차이점은?
            -> i++은 문장이 끝난 뒤에 값을 더하고 ++i는 값을 더한 뒤에 문장이 실행된다.

            2. 다음 보기 중 그 결과가 다른 것은?
            (1) i = i + 1;
            (2) i++; 이거 -> 문장이 실행되고 더하기 때문에 Writeline 실행 후 더해짐, 0으로 출력됨
            (3) ++i;
            (4) i += 1;

            3. 다음 코드에서 a와 b는 각각 얼마인가?
            int a = 8 >> 1; 0000 0000 0000 0100 따라서 a = 4;
            int b = a >> 2; 0000 0000 0000 0001 따라서 b = 1;
            살짝 넘었어(선)

            4. 다음 코드에서 a의 값은?
            int a = 0xF0 | 0x0F; 240 | 15; 따라서 a = 255;
            많이 넘었어(선)

            5. 다음 코드에서 b의 값은?
            int a = 10;
            string b = a == 0 ? "가나다" : "ABC";
            b = "ABC";
             */
        }
    }
}
/* 메모장
I. 연산자
1. 산술 연산자(두 개의 피연산자 필요로 함 : 이항 연산자)
(1) + -> 양쪽 피연산자를 더함
(2) - -> 왼쪽 피연산자에서 오른쪽 피연산자를 차감
(3) * -> 양쪽 피연산자를 곱함
(4) / -> 왼쪽 연산자를 오른쪽 피연산자로 나눈 몫을 구함
(5) % -> 왼쪽 연산자를 오른쪽 피연산자로 나눈 후의 나머지를 구함

2. 증가/감소 연산자(하나의 피연산자를 필요로 함 : 단항 연산자, 위치에 따라 실행 순서가 달라짐)
(1) ++ -> 피연산자의 값을 1 증가
(2) -- -> 피연산자의 값을 1 감소
위치가 앞일 때 - 값을 변경한 후 문장 실행 (전위 증가/감소 연산자)
위치가 뒤일 때 - 문장을 실행한 후 값 변경 (후위 증가/감소 연산자)

3. 문자열 결합 연산자
(1) + -> 양 쪽의 문자열을 이어 붙임

4. 관계 연산자
(1) < -> 왼쪽 피연산자가 오른쪽 피연산자보다 작으면 참, 아니면 거짓을 반환
(2) > -> 왼쪽 피연산자가 오른쪽 피연산자보다 크면 참, 아니면 거짓을 반환
(3) <= -> 왼쪽 피연산자가 오른쪽 피연산자보다 작거나 같으면 참, 아니면 거짓을 반환
(4) >= -> 왼쪽 피연산자가 오른쪽 피연산자보다 크거나 같으면 참, 아니면 거짓을 반환
(5) == -> 왼쪽 피연산자와 오른쪽 피연산자가 같으면 참, 아니면 거짓을 반환 (값을 할당하는 '=' 과 구별 중요)
(6) != -> 왼쪽 피연산자가 오른쪽 피연산자와 다르면 참, 아니면 거짓을 반환

5. 논리 연산자
(1) &&(=AND) -> 논리곱 연산자, 두 개의 진리값이 모두 참이여야 참을, 둘 중 하나라도 거짓이면 거짓 반환
(2) ||(=OR) -> 논리합 연산자, 두 개의 진리값중 하나만 참이어도 참을, 둘 다 거짓이면 거짓 반환
(3) !(=NOT) -> 부정 연산자, 참이라면 거짓, 거짓이라면 참을 반환

6. 조건 연산자
-> 조건식 ? 참일때의 값 : 거짓일 때의 값
의 형태

7. 널 조건부 연산자
(1) ?. -> 객체의 멤버에 접근하기 전에 해당 객체가 null인지 검사하여 그 결과가 참이라면 null 반환, 아닌 경우 뒤에
지정한 멤버 반환
(2) ?[] -> 위와 동일한 기능을 수행하나 객체의 멤버 접근이 아닌 배열과 같은 컬렉션 객체의 첨자를 이용한 참조에 사용

8. 비트 연산자 (비트 수준에서 데이터를 가공하기 위해 사용)
(1) <<(왼쪽 시프트 연산자) -> 첫 번째 피연산자의 비트를 두 번째 피연산자의 수만큼 왼쪽 이동(십진수 떠올리기)
(2) >>(오른쪽 시프트 연산자) -> 첫 번째 피연산자의 비트를 두 번째 피연산자의 수만큼 오른쪽 이동(십진수 떠올리기)
-시프트 연산자-
(3) &(논리곱 연산자) -> 두 피연산자의 비트 논리곱 수행
(4) |(논리합 연산자) -> 두 피연산자의 비트 논리합 수행
(5) ^(배타적 논리합 연산자) -> 두 피연산자의 비트 배타적 논리합 수행
(6) ~(보수 연산자) -> 피연산자의 비트를 0->1, 1->0으로 반전시킴, 단항 연산자
-비트 논리 연산자-

9. 할당 연산자
(1) =(할당 연산자) -> 오른쪽 피연산자를 왼쪽 피연산자에 할당
(2) +=(덧셈 할당 연산자) -> a += 1; 는 a = a + 1; 과 같음
(3) -=(뺄셈 할당 연산자) -> a -= 1; 는 a = a - 1; 과 같음
(4) *=(곱셈 할당 연산자) -> a *= 1; 는 a = a * 1; 과 같음
(5) /=(나눗셈 할당 연산자) -> a /= 1; 는 a = a / 1; 과 같음
(6) %=(나머지 할당 연산자) -> a %= 1; 는 a = a % 1; 과 같음
(7) &=(논리곱 할당 연산자) -> a &= 1; 는 a = a & 1; 과 같음
(8) |=(논리합 할당 연산자) -> a |= 1; 는 a = a | 1; 과 같음
(9) ^=(배타적 논리합 할당 연산자) -> a ^= 1; 는 a = a ^ 1; 과 같음
(10) <<=(왼쪽 시프트 할당 연산자) -> a <<= 1; 는 a = a << 1; 과 같음
(11) >>=(오른쪽 시프트 할당 연산자) -> a >>= 1; 는 a = a >> 1; 과 같음

10. 널 병합 연산자
- ?? -> 왼쪽 피연산자가 null이 아니라면 왼쪽 피연산자 반환, 완쪽 피연산자가 null이라면 오른쪽 피연산자 반환

※연산자의 우선순위
증감 연산자(후위 연산자)/널 조건부 연산자 -> 증감 연산자(전위 연산자) -> 산술 연산자(* , %) -> 산술 연산자(+ , -)
-> 시프트 연산자(<< , >>) -> 관계 연산자(< , > , <= , >= , is , as) -> 관계 연산자(== , !=) -> 비트 논리 연산자(&)
-> 비트 논리 연산자(|) -> 논리 연산자(&&) -> 논리 연산자(||) -> 널 병합 연산자(??) -> 조건 연산자(?:) -> 할당 연산자)
*/