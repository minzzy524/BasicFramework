using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex15_static_scope
{
     class Program

    {


        public class Test // class 내부에서는 private 와 public은 같은 식구
        {
            private static int i; // private 접근자로 인해서 class 이름으로는 접근 불가능 -> Test.i (x)
            public static int j; // public 접근자 가지고 있으니 class 이름으로 접근 가능 -> Test.j (o)

            // 클래스가 일반 자원과 static 자원을 다 가지고 있는 경우
            // 일반 함수에서 static member를 가지고 놀 수 있다. (메모리의 생성 시점이 항상 static이 우선함.)
            // static 함수에서 일반 member 가지고 놀 수 있다. (static은 일반자원보다 항상 우선)

            public static void method()
            {
                i = 100;
                j = 200;
                Console.WriteLine("i:{0}, j:{1}", i, j);
            }

            public void gMethod() { // 일반함수 >> memory에서 >> Test t = new Test() 실행 >> memory에
                // 일반함수가 static 자원을 가지고 노는 것은 당연하다. 생성시점이 static 보다 늦기 때문에
                i = 111;
                j = 222;
                Console.WriteLine("gMethod => i:{0}, j:{1}", i, j);
            }
        }

        // 접근
        class Test2
        {
            public static int sk; // static variable
            public int gk;        // instance variable, member field 

            public void method() // 일반함수
            {
                // sk static 변수 접근 (o)
                // gk 변수 접근 (o)
                sk = 100;
                gk = 200;
            }

            public static void sMethod() // 일반함수
            {
                // sk static 변수 접근(o)
                // gk 변수 접근 (x) : sMethod() 메모리에 있을 때 일반자원은 없어요.
                sk++;
                //gk++;   -> 생성이 안 되어 있음.
            }
        }





        static void Main(string[] args)
        {
            Test.method(); // 함수는 접근 가능 (L20에 static이라 이미 메모리에 올라가 있으니까)
            // gMethod() 안된다 -> 메모리에 올려야 함 new로 올리자
            Test t = new Test();
            t.gMethod(); // 일반 자원 사용 가능

            // 1. 일반 함수에서는 : 일반 자원 , static 자원 접근 모두 가능하다.
            // 2. static 함수에서는 : static 자원만 접근 가능하다. 
        }
    }
}
