using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10_class
{

    // 연습 클래스
    // 외워라
    // 클래스 == 설계도 == 데이터 타입

    class Person // 교재 p461 부터 p480까지의 내용
    {
        // "설계도" 라고 정의 : 최소 "속성"[고유(이름, 상수로 만들 수 있는 것),상태(스피드,온도),부품(엔진)] + "기능"(함수)을 가지고 있음.
        // 그럼 설계도라고 정의할 수 있음 -> 이걸 통해서 객체 생성
        // 속성(정보를 담는 그릇 : 크기 + 이름 -> "변수") 

        // 클래스 안에 쓸 수 있는 건 (변수) 와 (함수) 밖에 없다.
        int num; // 타입 변수; // 클래스가 가지는 변수 : instance variable(객체 변수), 범용적인 의미로는 member field : new 했을 때, 생성되는 객체마다 가지는 변수
                 // Person p = new Person();   Person p2 = new Person();
                 // p.num과 p2.num은 다른 것.

        // 기본적인 접근자를 가지고 있다.
        // 아무것도 명시하지 않으면 private int num 으로 처리됨.
        // private -> 설계도를 만든 사람의 "데이터를 보호하겠다는 의지" 가 있다. 

        // 객체지향 언어의 특징
        // 캡술화(은닉화) 하는 기술 -> private
        // 1. private : 클래스 내부에서는 모두 같은 식구, 객체 입장에서는 볼 수 없다. 
        // 2. public : 클래스 내부에서는 모두 같은 식구, 객체 입장에서는 볼 수 있다. (직접할당의 문제 발생)
        // 3. private을 쓰면서 객체가 사용(접근)할 수 있게 하는 것. 
        // 3.1 함수를 생성 : public : 캡술화 된 자원에 대해서 read, write 할 수 있게 만든다. -> "간접할당" 하겠다.
        // 객체지향의 원칙. 모든 멤버필드는 프라이빗으로 잡는다. 간접적으로 읽기와 쓰기를 할당할 순 있다.


        private int k;
        public int y; // Person 이라는 class 안 에서는 똑같다.

        private string ename;



        public int getK() // getk를 통해서 k를 건드리니까 간접할당
        { // 함수의 목적은 보호된 자원의 값을 리턴할 때 쓴다. 읽기 전용(read)
            return k;
            // return k+10; 나는 당신이 입력한 값에 대해서 무조건 +10해서 주겠다 (개발자 의지대로 사용 가능)
        }

        public void setK(int data)
        { // 함수의 목적은 보호된 자원의 값을 쓸 때 할 때 쓴다. 쓰기 전용(write)

            if (data < 0) // 설계자의 의도는 (-)값 안 받겠다. 함수를 통한 간접할당 사용
            {
                k = 0;
            }
            else
            {
                k = data;
            }
        }


        // property(함수x) : private 한 member field 에 대해서 간접적인 데이터 처리 목적 : read, write
        // int num > property > get , set > read, write 구현
        // 캡슐화된 멤버필드의 자료를 read / write 
        // smart field 이름도 사용

        public int Num // 함수가 아니라서 () 안 씀
        { // 캡슐화 된 int num에 접근하기 위해 property (get,set)를 이용함.
            get { return num; }
            set { num = value; }
        }

        // ename의 property
        public string Ename
        {
            get { return ename + "님"; }  // 내 마음대로 쓸 수 있다.(조작 가능)
            set { ename = value; }
        }

    }

    class Apt
    {
        private string aptname; // private string aptname("삼성"); <- 이렇게는 안하고 L102처럼 한다. 
        private string aptcolor;

        // private string aptname = "삼성아파트:"
        // private string aptcolor = "gray";  이런 식으로 초기화하면 안됨

        // 함수 이름
        // 특수한 목적의 함수 (사용방법은 member field 의 초기화)
        // @@ 외워 이런 방법이야
        // 설계 약속 : 함수의 이름 클래스 이름과 같다.
        // ex)
        public Apt() // 원칙적으로 함수는 public void(동전 넣으면 아무것도 안줘) or public int(정수 줄게) or public string(문자열 줄게)
        {            // 생성자 함수 (constructor) >> 객체가 생성 될 때 동시에 호출되는 함수.
                     // Apt apt = new Apt();
                     // member field 가 먼저 memory에 올라가고, 생성자 함수가 실행된다.
                     
            aptname = "삼성";
            aptcolor = "red";

        }

        public Apt(string aptname, string aptcolor) // 생성자 함수 // overloading (함수의 이름은 같은데 parameter의 개수와 타입을 다르게 쓰는 방법)
        {
            this.aptname = aptname;
            this.aptcolor = aptcolor;   
        }

        public string Aptname
        {
            get { return aptname; }
        }

        public string Aptcolor
        {
            get { return aptcolor; }
        }


    }
    // 요구사항
    // 아파트를 만들 때 특별한 요구사항이 없으면 이름과 색상은 기본설정을 한다. 필요 시 강제로 이름과 색상을 넣을 수 있게 한다.
    // Apt apt = new Apt(); -> 아파트 이름 / 색상 : null


    class Program
    {
        static void Main(string[] args)
        {
            // 2명의 사람을 만드세요.
            Person p = new Person(); // 관용적으로 class 는 대문자, 변수는 소문자임.
            Person p2 = new Person();
            // p.num = 100; // 이거 오류난다. 왜? class는 기본 접근자가\ priave라서 public으로 안 해주면 오류.
            // p 라는 변수가 직접적으로 num 이라는 변수의 접근을 막는 것
            p.y = 100; // 직접 할당 p 라는 주소로 y 값을 바로 접근하는 것. 
                       // 여기서 y는 클래스 다르지만 public 이니까 Program 클래스 내부에서도 접근 가능

            p2.y = 200; // 직접 할당
            // y 라는 변수 양수값만
            p.y = -100; // 이런 문제가 있기 때문에 직접할당을 꺼려 한다. 그래서 정보를 담는 건 public 잘 안 쓴다. 값이 바뀌어 버리니까

            p.setK(-100);
            Console.WriteLine(p.getK());


            p.Num = 555; // set { num = value; } 동작
            Console.WriteLine("get {0}", p.Num); // get { return num } 동작


            p.Ename = "김민성";
            Console.WriteLine("get ename : {0}", p.Ename);

            Apt apt = new Apt();
            Console.WriteLine("apt.name :{0}", apt.Aptname);
            Console.WriteLine("apt.color :{0}", apt.Aptcolor);

            // 생성자 함수 사용
            Apt apt2 = new Apt("LG", "yellow"); // 객체를 생성하면서 바로 초기화 가능 () 안에 화살표 두 번째 꺼
            Console.WriteLine("apt2.name :{0}", apt2.Aptname);
            Console.WriteLine("apt2.color :{0}", apt2.Aptcolor);


            #region 정리
            /*

            1.클래스 == 설계도 == 데이터 타입
            2.클래스 가장 기본적인 구성 요소 > 속성(정보) : member field +기능(함수) : method
            3.클래스 요소 중에 : 속성(instance variable, member field)
            3.1 private 접근자를 통해서 캡슐화
            3.2 객체 입장에서 read, write(직접 할당 불가)
            3.3 별도의 public 한 함수를 통해서 get, set 구현 -> 살짝 불편함
            3.4 전용(read , write ) 을 만든 게 property
            3.5 member field property 를 구현함으로써 간접적인 데이터 처리 가능

            문장을 읽으면서 코드가 생각나면 된다.복습해라 복습

            */

            #endregion






            // 오늘 과제) 가위바위 보

            // 컴퓨터
            /*            Random rnd = new Random();
                        Console.WriteLine(rnd.Next(1, 10));*/
            // 1 가위
            // 2 바위
            // 3 보

            // 컴퓨터의 랜덤값 : 1
            // 내가 입력 값 : 2 -> 내가 이김.

            // 조건판단




            // 

            /*            Boolean auto = true; // 항상 메뉴 보여줌
                        int balance = 0;


                        while (auto) // 무한루프
                        {
                            Console.WriteLine("************************************");
                            Console.WriteLine("1. 예금 | 2. 출금 | 3. 잔고 | 4. 종료");
                            Console.WriteLine("************************************");

                            Console.WriteLine("선택");
                            int input = 2;
                            input = int.Parse(Console.ReadLine());
                            switch (input)
                            {
                                case 1:
                                    Console.WriteLine("예금");
                                    balance += int.Parse("100");
                                    break; //switch 탈출
                                case 2:
                                    Console.WriteLine("출금");
                                    balance -= int.Parse("50");
                                    break; //switch 탈출
                                case 3:
                                    Console.WriteLine("잔고 : " + balance);
                                    break; //switch 탈출
                                case 4:
                                    Console.WriteLine("종료");
                                    auto = false;  //논리를 이용해서 while(false) 탈출
                                    break; //switch 탈출

                                default:
                                    Console.WriteLine("올바른 메뉴를 선택하세요");
                                    break;

                            }
                        }*/




        }
    }
}
