using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex13_static
{
    /*
        @static 자원
        1. 객체 생성 이전에 메모리에 올라가는 자원
        2. 객체를 생성하지 않고도 직접적인 접근(사용)이 가능한 자원
        3. 종류 : static class / * static field (Point) / static constructor / * static method (Point)  // *는 기억
        4. static 한 단어로 "공유자원" 단, 객체 간)
        5. static 자원 접근(사용) 방법

        Class Sample{
        public static int s;

        public static void print(){ 
            // static method 라고 하는데 왜 만들어 쓸까?
            // 얻는 이점이 뭘까?
            // new 하지 않고도 사용할 수 있는 함수
            // [자주 사용] 하는 함수니까 [편하게 사용] 하게 해주려고
            }
        }

        // static 자원은 성능 향상에 도움이 된다? 
        // 많이 쓰면 성능 향상에 문제가 있다 -> 많이 쓰지마라
        // static 자원의 종료시점 -> 프로그램 종료될 때(그 전까지 메모리에 남아있다. 그래서 성능저하) 




    */

    public class Sample
    {
        public static int s;    // static varable // 공유자원
        public int i;           // class 안 변수 : instance variable
                                // 생성시점 : new Sample() 하면 heap 생성되고 사용 가능

        public void print()
        {
        //    int i = 100;        // local variable(함수 호출되면 생성되고 함수 끝나면 같이 소멸)
        }
        public void printstatic()
        {
            Console.WriteLine("static s : {0}", s);
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Sample.s = 100; // static 자원은 클래스 이름을 접근
            // 원칙적으로 클래스는 반드시 new를 통해서 메모리에 road 하고 사용.
            // 원칙 : Sample sample = new Sample();
            Sample sa = new Sample(); // 사진 3.3 12:00
            sa.printstatic();
            Sample sa1 = new Sample();
            sa1.printstatic();
            Sample sa2 = new Sample(); // 사진 12:06
            sa2.printstatic();

            Console.WriteLine();

            // 사진보면서 sa.s = 1000; 하면 sa2.s = 1000 나온다
            // 접근할 떄는 클래스 이름으로 "Sample.s" 로 접근함 (아파트로 따지면 공동 체육시설)

            // TIP)
            // java와의 차이 : 자바는 참조변수로 static 자원 접근 가능 / java code : sa.s = 200; 가능
            // C#은 참조변수로 접근 불가 (누구의 것도 아니다) : sa.s = 200; 불가능, 클래스 이름으로 접근 가능 


        }
    }
}
