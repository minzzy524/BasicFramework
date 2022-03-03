using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex16_constructor
{
    class Program
    {

        /*
                생성자 함수(특수한 목적을 가짐) : " member field 의 초기화" 를 목적으로 함
                생성 방법 : 1. 함수의 이름이 class 이름과 똑같으면 된다.
                            2. 접근자는 public(접근이 목적이니까)
                            3. return type은 존재하지 않는다. (받아 줄 애가 없다 -> 무조건 void -> 따라서 안쓴다)
                종류 : default constructor(parameter 없음) , overloading constructor (parameter의 개수와 타입을 달리해서 함수를 만드는 방법) 
                실행 시점 : 객체 생성과 동시에 호출되는 함수(new Test(), new Test(100, 200)) 
                            > 생성자가 호출되기 전에는 당연히 member field 가 메모리에 올라가 있다.
        */
        class Test
        {
            // 1. 생성자를 구현하지 않으면 컴파일러가 자동으로 생성자 하나 만든다.
            // Test(){} 자동생성

        }

        class Test2
        {
            public Test2()
            { // default 생성자
                // 어떤 자원의 초기화가 필요하다면 만들어서 써라.
            }
        }


        class Test3
        {
            public Test3() { } // defualt
            public Test3(int i) { } // overloading
        }

        class Test4
        {
            public Test4(int i) // overloading 만 생성
            {

            } // overloading 생성자 하나라도 존재하면 default는 반드시 구현을 통해서 사용 가능
              // 개발자 의도 : 당신이 객체 생성 시 반드시 parameter 1개를 가지고 생성하세요}
        }

        class Test5
        {

            public Test5(int i) { } // overloading 만 생성
            public Test5(int i, int j) { } // overloading 만 생성
        }


        class Book // 개발자 의도 : defaut 뺏다는 이기는 "당신은 반드시 책을 만들 때 이름과 가격을 써라" 는 뜻
        {
            private string bname;
            private int price;

            // public Book() { }

            // 사실은 안 좋은 코드. 할당을 하는 코드 3번 반복
            // 개발자의 의도는 옵션 3가지 주는 개념

            public Book(string bname)
            {
                this.bname = bname;
                this.price = 1000;
            }

            public Book(int price)
            {
                this.bname = "무제";
                this.price = price;
            }

            public Book(string bname, int price)
            {
                this.bname = bname;
                this.price = price;
            }
        }


        static void Main(string[] args)

        {
        }
    }
}

