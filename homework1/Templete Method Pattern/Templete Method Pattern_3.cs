using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _220316_DesignPattern_TemplateMethod
{
    // 추상 클래스 선생님
    abstract class Teacher      // 추상클래스에 선생님이 공통적으로 하는 행동을 정의
    {
        public void start_class()
        {
            // 선생님들은 수업을 시작하면 아래의 4가지 행동은 모두 실행한다.
            // 이 모든 행동(함수)을 한번에 담아서 실행할 수 있는 함수작성
            inside();
            attendance();
            teach();
            outside();
        }
        // 공통 메서드 - teach()를 제외하고 똑같은 결과를 반환하는 함수는 추상클래스에서 완성.
        public void inside()
        {
            Console.WriteLine("선생님이 강의실로 들어옵니다.");
        }

        public void attendance()
        {
            Console.WriteLine("선생님이 출석을 부릅니다.");
        }

        public void outside()
        {
            Console.WriteLine("선생님이 강의실을 나갑니다.");
        }
        // 추상 메서드 
        // 선생님들은 모두 강의한다는 행동(함수)을 하지만 무엇을 가르치는지는 선생님마다 다르다
        // 따라서 추상메서드로 작성해서 teacher를 상속받는 하위 클래스에서 구현하도록 한다.
        public abstract void teach();
    }

    // 국어 선생님
    class Korean_Teacher : Teacher
    {
        public override void teach()     // 국어 선생님이 무엇을 가르치는지 자식 클래스인 Korean_Teacher에서 override로 실행블럭 작성
        {
            Console.WriteLine("선생님이 국어를 수업합니다.");
        }
    }
    // 수학 선생님
    class Math_Teacher : Teacher
    {
        public override void teach()    // 수학 선생님이 무엇을 가르치는지 자식 클래스인 Math_Teacher에서 override로 실행블럭 작성
        {
            Console.WriteLine("선생님이 수학을 수업합니다.");
        }
    }
    //영어 선생님
    class English_Teacher : Teacher
    {
        public override void teach()    // 영어 선생님이 무엇을 가르치는지 자식 클래스인 English_Teacher에서 override로 실행블럭 작성
        {
            Console.WriteLine("선생님이 영어를 수업합니다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Korean_Teacher kr = new Korean_Teacher();   //국어 선생님 class의 개별 객체 생성
            Math_Teacher mt = new Math_Teacher();       //수학 선생님 class의 개별 객체 생성
            English_Teacher en = new English_Teacher(); //영어 선생님 class의 개별 객체 생성

            kr.start_class();   // 국어 선생님의 수업시작(start_class()함수 실행)
                                // 자식 클래스는 부모 클래스의 함수를 사용할 수 있는데
                                // start_class가 포함하는 함수 중 teach는 자식에서 override 되어 있으므로
                                // 자식클래스의 재정의된 함수를 실행한다
            Console.WriteLine("----------------------------");
            mt.start_class();   // 수학 선생님의 수업시작(start_class()함수 실행)
            Console.WriteLine("----------------------------");
            en.start_class();   // 영어 선생님의 수업시작(start_class()함수 실행)

            // 위의 세개의 객체가 동일한 함수를 실행하지만 teach()만 다른 결과를 출력하고 나머지는 동일한 결과를 출력하여 구분됨. 
        }
    }
}