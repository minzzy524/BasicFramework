using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04_RefType
{
    // 수업용 하나의 namespace 안에 여러 개 클래스 만들어서 스터디
    // 원칙적인 방법은 별도의 Lib 생성해서 사용하는 것이 원칙 (Ex03_EmpLib 처럼)
    class Test // 설계도(객체변수, member field, instance variable, i라는 변수는 클래스 내에서 어디든 사용 가능)
    {
        public int i;  // i 라는 변수는 객체마다 다 각각 가지고 있어서 객체변수라고 함.

        public void print() // 함수 기능
        {
            int data = 100; // local variable(지역변수) -> print 라는 함수가 호출될 때 생성되었다가 함수 끝나면 같이 사라짐. 
            Console.WriteLine("data : {0}", data);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.print();

            Test test2 = new Test();
            test2.print();

            Test test3 = new Test();
            test3.print();

            // test, test2, test3 는 참조 타입니다 (변수가 주소를 가지고 있다.)

            for (int i = 0; i < 10; i++); // block variable // i 변수는 for 문 시작 생성 끝나면 소멸
            {

            }

            for (int i = 0; i < 10; i++); // block variable // i 변수는 for 문 시작 생성 끝나면 소멸
            {

            }


        } 
    }
}
