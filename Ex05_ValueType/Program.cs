using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05_ValueType
{
    #region + (값 타입) 구조체 : 작은 타입을 도와서 의미있는 집합으로 만드는 것. ("책"의 이름, "책"의 가격)
    struct Book
    {
        public string name;
        public int price;

        public Book(string _name, int _price) // 생성자 함수(Book이 가지고 있는 member(name,price)를 초기화 한다.)
        {
            name = _name;
            price = _price;
        } 
    }

    struct Human
    {
        public string ename;
        public int age;
    }

    #endregion

    #region + 열거형 : 하나의 (값 타입) : 
    enum mycolor {black, white, red, green, blue }; // 열거 타입 (black에 마우스 올려보면 '0'이라 뜸. 따로 설정 안하면 내부적으로 상수값 자동 할당(0부터 n까지)
    enum week { mon,tue = 101, sat, sun} // sat부터는 102 (명시적으로 상수값 설정 한 이후부터는 무조건 +1, 그냥 규칙. 약속된 규칙은 외우자)
    #endregion
    class Car
    {
        public string name;
        public int price;


        public Car(string _name, int _price)
        {
            name = _name;
            price = _price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;
            float f = 3.14f;

            Book book = new Book("홍길동전", 10000);
            // ** 중요 ** 그런데 구조체에서의 "new"는 객체를 생성하는 연산자가 아니다. 단지 "초기화(생성자를 통해)"를 하는 연산자
            // Book 구조체가 값 타입(stack에 만들어진다.)임을 증명하세요. (값의 할당으로)

            Book book2 = book; // 만약에 book2에 name과 price 값을 새로 주지 않으면 book의 값 그대로 복사해서 하나 더 생김.
                              // 구조체의 할당은 새로운 구조체를 하나 더 만드는 것이다.
            
            book2.name = "NEW";
            book2.price = 2000;

            Console.WriteLine("book {0},{1}",book.name, book.price);
            Console.WriteLine("book2 {0},{1}", book2.name, book2.price);


            Car car = new Car("GV80", 1000); // 힙에 생기고 주소 갖음
                                           // new 라는 연산자는 객체를 생성하는 연산자(new를 통해 만들어진 객체는 Heap이라는 메모리에 생성된다.)

            Car car2 = car; // (주소값 가지고 있음) 1. car와 car2는 같은 객체를 본다.
            car2.name = "NEW_CAR"; // car2로 바꾸면 car가 바라보는 값도 GV80,1000값이 NEW_CAR,6000으로 바뀐다.
            car2.price = 6000;

            Console.WriteLine("car {0},{1}", car.name, car.price); // 둘이 같은 주소를 바라봄
            Console.WriteLine("car2 {0},{1}", car2.name, car2.price); // 같은 주소

            Human h;
            h.ename = "홍길동";  // 초기화 하고 사용하는 것은 동일
            h.age = 100;        // 초기화 하고 사용하는 것은 동일
                               // 그럼 생성자로 초기화 하지 ^^
            Console.WriteLine(h.ename);
            Console.WriteLine(h.age);

            // 열거타입
            mycolor m;
            // m 열거타입 변수는 열거형 중에 하나를 가질 수 있다.
            m = mycolor.black;
            Console.WriteLine(m);
            Console.WriteLine((int)m); // 변수 형태에 () : "캐스팅" 이란 방법 -> "0" 출력됨.

            // 시스템이 제공하는 열거타입 (개발자가 상수값을 일일히 기억하기 어려우니 만들어 놓음)
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            week w;
            w = week.sat; // 개발자는 문자열 형태로 코드 해석, 편하게 작업 가능
            Console.WriteLine($"{w}");

            int a = 10;
            int b = 20;

            Console.WriteLine($"string example1 : {a} + {b} = {a + b}");
            Console.WriteLine("string example2 : {0} + {1} = {2}", a, b, a+b);

            // 상수

            const double PI = 3.14; // 변수명을 대문자로 씀(상수의 관용적 표현)
            // PI = 3.192; -> 이러면 에러 (상수는 변경불가) 

            // 중요! *** 형변환 ***
            int num = 1234;
            long lon = num; // long은 int 그릇보다 크기가 크다. 문제 없음
            // long lon = (long)num; // 이걸 컴파일러가 내부적으로 자동수행 해준다. -> 암시적 형변환

            // 명시적 형변환 (개발자가 의도를 가지고 실제 코드로 작업)
            long lon2 = 100000; // Int 범위는 -21억~+21억 범위
            // int num2 = lon2; // 값으로 보지 말고 가지고 있는 타입으로 보자. (long형을 int형으로 변환할 수 없다!)
            int num2 = (int)lon2; // int에 담은 걸로 칠게. -> 돌아는 가는데 문제가 있음
            // 다행히도 형변환 값이 int 범위라면 손실없이 데이터 가질 수 있음.
            Console.WriteLine(num2);

            // 여기부터 문제
            long lon3 = 10000000000; // Int 범위는 -21억~+21억 범위 (100억으로 범위 초과-> 데이터 손실)
            // int num2 = lon2; // 값으로 보지 말고 가지고 있는 타입으로 보자. (long형을 int형으로 변환할 수 없다!)
            int num3 = (int)lon3; // int에 담은 걸로 칠게. -> 돌아는 가는데 문제가 있음
            // 다행히도 형변환 값이 int 범위라면 손실없이 데이터 가질 수 있음.
            Console.WriteLine(num3); // "1410065408" 이라는 쓰레기 값 발생 (손실도 발생)

            // 결론 : 큰 타입을 작은 타입으로 넣는 것(형변환)은 손실을 감안 해야 한다.
            int x = 254;
            // byte y = x; // 값을 보면 byte 범위가 (0~255) 니까 될 거 같지만 타입을 봐야 함. 
            byte y = (byte)x;
            Console.WriteLine("y : {0}", y); // 범위 안에서는 문제 없이 "254"출력

            int x1 = 258;
            byte y1 = (byte)x1;
            Console.WriteLine("y1 : {0}", y1); // 범위 밖이라 손실 발생 "2" 출력 -> 원하는 값이 아니다.

            // 중요!!! *** var 타입 *** 앞으로 많이 쓸 내용
            var name = "문자열"; // string type
            var version = 8.0; // double type
            // 타입 정보 알고 싶으면
            Console.WriteLine(name.GetType()); // "System.String"
            Console.WriteLine(version.GetType()); // "System.Double"

            // 참고
            int i2 = default; // 타입이 가지는 기본 값을 쓰도록 하겠다.
            Console.WriteLine(i2); // 0 출력
            double d2 = default;
            Console.WriteLine(d2); // 0 출력
            Console.WriteLine(d2); // 0 출력
        }
    }
}
