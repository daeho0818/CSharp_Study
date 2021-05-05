using System;
using System.Globalization;
using System.Runtime.Serialization.Formatters;
using static System.Console;
namespace CSharp
{
    class String
    {
        static public void StringSearch()
        {
            string greeting = "Good Morning";
            WriteLine(greeting);
            WriteLine();
            
            //IndexOf()
            WriteLine("IndexOf 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("IndexOf 'o' : {0}", greeting.IndexOf("o"));

            //LastIndexOf()
            WriteLine("LastIndexOf 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("LastIndexOf 'o' : {0}", greeting.LastIndexOf("o"));

            //StartsWith()
            WriteLine("StartsWith 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("StartsWith 'Morning' : {0}", greeting.StartsWith("Morning"));

            //EndsWith()
            WriteLine("EndsWith 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("EndsWith 'Morning' : {0}", greeting.EndsWith("Morning"));

            //Contains
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            //Replace()
            WriteLine("Replaced 'Morning' with 'Evening' : {0}",
                greeting.Replace("Morning", "Evening"));
        }
        static public void StringModify()
        {
            WriteLine("ToLower() : '{0}'", "ABC".ToLower());
            WriteLine("ToUpper() : '{0}'", "abc".ToUpper());

            WriteLine("Insert() : '{0}'", "Happy Friday!".Insert(5, " Sunny"));
            WriteLine("Remove() : '{0}'", "I Don't Love You.".Remove(2, 6));

            WriteLine("Trim() : '{0}'", " No Spaces ".Trim());
            WriteLine("TrimStart() : '{0}'", " No Spaces ".TrimStart());
            WriteLine("TrimEnd() : '{0}'", " No Spaces ".TrimEnd());
        }
        static public void StringSlice()
        {
            string greeting = "Good morning";

            WriteLine(greeting.Substring(0, 5)); // "Good"
            WriteLine(greeting.Substring(5)); // "morning"
            WriteLine();

            string[] arr = greeting.Split(
                new string[] {" "}, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);
        }
        static public void StringFormatBasic()
        {
            string fmt = "{0,-20}{1,-15}{2,30}";
            WriteLine(fmt, "Publisher", "Author", "Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Hanbit", "Sanghyun Park", "C# 7.0 Programming");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
        static public void StringFormatNumber()
        {
            //D : 10진수
            WriteLine("10진수 : {0:D}", 123);
            WriteLine("10진수 : {0:D5}", 123);

            //X : 16진수
            WriteLine("16진수 : 0x{0:X}", 0xFF1234);
            WriteLine("16진수 : 0x{0:X8}", 0xFF1234);

            //N : 숫자
            WriteLine("숫자 : {0:N}", 123456789);
            WriteLine("숫자 : {0:N0}", 123456789); // 자릿수 0은 소숫점 이하를 제거함

            //F : 고정소수점
            WriteLine("고정소수점 : {0:F}", 123.45);
            WriteLine("고정소수점 : {0:F5}", 123.456);

            //E : 공학용 (지수)
            WriteLine("공학 : {0:E}", 123.456789);
        }
        static public void StringFormatDateTime()
        {
            DateTime dt = new DateTime(2020, 10, 31, 12, 30, 31);

            WriteLine("12시간 형식 : {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            WriteLine("24시간 형식 : {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            CultureInfo ciKo = new CultureInfo("ko-KR");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciKo));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciKo));
            WriteLine(dt.ToString(ciKo));

            CultureInfo ciEn = new CultureInfo("en-US");
            WriteLine();
            WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            WriteLine(dt.ToString(ciEn));
        }
        static public void StringInterpolation()
        {
            string name = "임대호";
            int age = 17;
            WriteLine($"{name, -10}, {age:D3}");

            name = "임대딱";
            age = 18;
            WriteLine($"{name}, {age,-10:D3}");

            name = "귀엽다";
            age = 5;
            WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");
        }
    }
}

/*메모장
I. string 형식이 제공하는 메소드

1. 문자열 안에서 찾기
(1) IndexOf() -> 현재 문자열 내에서 찾고자 하는 지정된 문자 또는 문자열의 위치를 찾음(찾으면 1 반환, 못찾으면 -1 반환)
(2) LastIndexOf() -> 위의 내용과 똑같은데, 이건 뒤에서부터 찾음(찾으면 1 반환, 못찾으면 -1 반환)
(3) StartsWith() -> 현재 문자열이 지정된 문자열로 시작되는지를 평가
(4) EndsWith() -> 현재 문자열이 지정된 문자열로 끝나는지를 평가
(5) Contains() -> 현재 문자열이 지정된 문자열을 포함하는지 평가
(6) Replace() -> 현재 문자열에서 지정된 문자열이 다른 지정된 문자열로 모두 바뀐 새 문자열을 반환

2. 문자열 변형하기
(1) ToLower() -> 현재 문자열의 모든 대문자를 소문자로 바꾼 새 문자열 반환
(2) ToUpper() -> 현재 문자열의 모든 소문자를 대문자로 바꾼 새 문자열 반환
(3) Insert() -> 현재 문자열의 지정된 위치에 지정된 문자열이 삽입된 새 문자열 반환
(4) Remove() -> 현재 문자열의 지정된 ㅜ이치로부터 지정된 수만큼의 문자가 삭제된 새 문자열 반환
(5) Trim() -> 현재 문자열의 앞/뒤에 있는 공백을 삭제한 새 문자열 반환
(6) TrimStart() -> 현재 문자열의 앞에 있는 공백을 삭제한 새 문자열 반환
(70 TrimEnd() -> 현재 문자열의 뒤에 있는 공백을 삭제한 새 문자열 반환

3. 문자열 분할하기
(1) Split() -> 현재 문자열을 지정된 문자를 기준으로 분리한 문자열의 배열 반환
(2) SubString() -> 현재 문자열의 지정된 위치로부터 지정된 수만큼의 문자로 이루어진 새 문자열 반환

4. 문자열 서식 맞추기
(1) Format() -> 첨자({0}), 왼쪽/오른쪽 맞춤, 서식 문자열로 구성
- 왼쪽/ 오른쪽 맞춤
- 숫자 서식화 - {D} -> 10진수, {X} -> 16진수, {N} -> ","로 묶어 표현할 수, {F} -> 고정소수점, {E} -> 지수

5. 날짜 및 시간 서식화
- 날짜와 시간 클래스 DateTime
-> DateTime dt = new DateTime(2020, 10, 31, 12, 30, 31) // 년, 월, 일, 시, 분, 초
- 서식 지정자
(1) y - 연도 -> yy(두 자릿수 연도), yyyy(네 자릿수 연도)
(2) M - 월 -> M(한 자릿수 월), MM(두 자릿수 월)
(3) d - 일 -> d(한 자릿수 일), dd(두 자릿수 일)
(4) h - 시(1~12) -> h(한 자릿수 시), hh(두 자릿수 시)
(5) H - 시(1~23) -> H(한 자릿수 시), HH(두 자릿수 시)
(6) m - 분 -> m(한 자릿수 분), mm(두 자릿수 분)
(7) s - 초 -> s(한 자릿수 초), ss(두 자릿수 초)
(8) tt - 오전/오후 -> tt(오전/오후)
(9) ddd - 요일 -> ddd(약식 요일, 예: 토), dddd(전체 요일, 예: 토요일)

6. 문화권 정보 접근
- 클래스 CultureInfo
-> CultureInfo ciko = new CultureInfo("ko-KR");

7. 문자열 보간(보간 : 비거나 누락된 부분을 채운다는 뜻)
- $ 기호를 사용
 */