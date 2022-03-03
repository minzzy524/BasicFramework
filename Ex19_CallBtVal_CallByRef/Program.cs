using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_CallBtVal_CallByRef
{
/*    class Text
    {
        public void print()
        {
            printdata(); // 필요에 따라서 내부에서만 사용
        }

        private int printdata() // "private" 의 의미는 뭘까? 
            // 1. 클래스 내부에서만 사용 가능
            // 2. 다른 함수를 도와줄 목적
            // 3. 공통함수 (주로 출력 같은 거)
        {
            return 10;
        }

        public void method(Car c) // 주소 전달
        {

        }

        public void method(int i) // 값 전달
        {

        }
    }*/

    class Car
    {
        public int speed;
        public void run(int data)
        {
            speed += data;
            data = 100;  // 이건 L65의 data 값이 바뀌지 않음. 
            //data2 = 500; 해도 L72의 data3 값이 바뀜. 참조값을 주니까
        }
    }

    class Car2
    {
        public int speed;
        public void run(ref int data) // xx 주소
        {
            speed += data;
            data = 50; // L55 값 안바뀜\
            // xx주소에다가 값을 50 써버림
        }
    }


    class Car3
    {
        public int speed;
        public void run(out int data) // xx 주소
        {
            data = 100;
            speed += data;
            data = 50; // L55 값 안바뀜\
            // xx주소에다가 값을 50 써버림
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            //Test t = new T();
            //t.printdata();

             Car car = new Car();
            int data2 = 20;
            car.run(data2); // data2 라는 변수가 가지는 값을 전달

            Console.WriteLine(car.speed);
            Console.WriteLine("data2 : {0}", data2);
            ////////////////////////////////////////////////////////
            ///
            Car2 car2 = new Car2();
            int data3 = 20; // xx 번지 (같은 주소에 덮어 쓰니까 값이 변경 되는거야)
            car2.run(ref data3); //

            Console.WriteLine(car2.speed);
            Console.WriteLine("data3 : {0}", data3);

            ////////////////////////////////////////////////////////
            ///
            Car3 car3 = new Car3();
            int data4 = 20; // 초기화 안하고 던져서 안에서 초기화
            car3.run(out data4); //

            Console.WriteLine(car3.speed);
            Console.WriteLine("data4 : {0}", data4);








        }
    }
}
