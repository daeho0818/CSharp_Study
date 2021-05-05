using System;
using static System.Console;
//using : 그 뒤에 따라오는 것을 사용하겠다는 의미
//System : class를 담고 있는 namespace
//static System.Console - Console 안에 있는 class를 사용할 수 있게 해줌
//static : 어떤 데이터 형식의 정적 멤버를 데이터 형식의 이름을 명시하지 않고 참조하겠다고 선언하는 기능
namespace CSharp
{
    //namespace - 성격이나 하는 일이 비슷한 클래스, 구조체 등을 하나의 이름 아래 묶는 역할
    //클래스
    //구조체
    //인터페이스
    //등등

    class BasicStructure
    {
        //class : C#프로그램을 구성하는 기본 단위, 데이터와 데이터를 처리하는 기능(메소드)로 이루어짐
        public static void basicStructure()
        {
            //static void Main(string[] args){} : 메소드, 프로그램이 시작하면 실행되고 이 메소드가 종료되면 프로그램 종료
            //메소드 = C에서의 함수
            //static : 한정자, 메소드나 변수 등을 수식
            if (true) 
            {
                Console.WriteLine("사용법 : HelloWorld.exe <이름>");
                //using System; 때문에 System. <- 없이 사용 가능

                //---------------연습문제----------------
                Console.WriteLine("여러분, 안녕하세요?");
                Console.WriteLine("반갑습니다!");
                //---------------------------------------
                return;
                //return - 메소드를 종료
            }
//using static System.Console; 때문에 Console. <- 없이 사용 가능
        }
    }
}