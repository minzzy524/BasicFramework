using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1.Templete_Method_Pattern

/*
 디자인 패턴

- 1995년 GoF(Gang of Four)라고 불리는 *Erich Gamma, Richard Helm, Ralph Johnson, John Vissides* 가 처음으로 디자인 패턴을 구체화하였다. 
디자인 패턴은 모듈의 세분화된 역할이나 모듈들 간의 인터페이스 구현 방식을 설계할때 참조할 수 있는 전형적인 해결 방식을 말한다.

디자인 패턴을 통해 설계 문제, 해결 방법, 방법을 언제 적용해야 할지, 그 결과는 무엇인지 등을 알 수 있다. 또한 디자인 패턴은 한 패턴에 변형을 가하거나 어떠한 요구사항을 반영하면 다른 패턴으로 변형되는 특징이 있다.

GoF의 디자인 패턴은 소프트웨어 공학에서 가장 많이 사용되는 디자인 패턴이다. 목적에 따라 분류할 시 생성 패턴 5개, 구조 패턴 7개, 행위 패턴 11개, 총 23개의 패턴으로 구성된다.

- 디자인 패턴 = 자동차 바퀴
- 바퀴 ⇒ 정형화되어 있는 것
- 다른 자동차여도 미쉐린 타이어, 한국타이어를 쓸 수 있다 ⇒ 유지, 보수가 쉽다

    디자인 패턴의 장점과 단점

**장점**

- 개발자 간의 원할한 의사소통
- 소프트웨어 구조 파악 용이
- 재사용을 통한 개발 시간 단축
- 설계 변경 요청에 대한 유연한 대처
- 불필요한 리소스 낭비 방지

**단점**

- 객체지향 설계 / 구현 위주로 사용된다
- 초기 투자 비용 부담

디자인 패턴의 유형

- *생성 패턴*
    
    *객체의 생성에 관련된 패턴*
    
    종류
    
    - 팩토리 패턴
    - 추상 팩토리 패턴
    - 싱글턴 패턴
    - 빌더
    - 프로토타입
    
- *구조 패턴*
    
    *클래스와 객체의 구성에 관련된 패턴*
    
    종류
    
    - 어댑터
    - 브리지
    - 컴퍼지트
    - 데커레이터
    - 퍼사드
    - 플라이웨이트
    - 플록시
- ***행위 패턴***

    **템플릿 메서드 패턴**

- 개념
    - 템플릿 메서드 패턴은 여러클래스에서 공통된 행위를 상위클래스에서 정의하고
    하위클래스에서 각각의 상세부분을 구현하는 것을 말한다.
    - 템플릿 메서드는 실행 순서는 고정하면서 세부 실행내용은 다양화 할 수 있는 경우에 사용하는 패턴이다.
    
    - 템플릿이란?
        - 큰 구조를 정의한 틀로서 전체적인 틀은 동일하되, 상세적인 부분은 다르게 찍어낼 수 있는 것을 말한다.
        - ex)대부분 블로그들은 여러 디자인의 템플릿을 제공해주고
        일정한 틀 안에서 자신만의 블로그를 쉽게 꾸밀 수 있도록 도와준다.
    
    - 인터페이스를 사용하지 않고 추상 클래스를 사용하는 이유
        - 인터페이스는 기본적으로 필드는 사용할 수 없으며, 모든 메서드 public virtual이므로 인터페이스로 구현할 경우, 템플릿 메서드 내부에서만 호출되어야 할 메서드 public 제어자에 의해 의도치 않은 사용처에서 호출될 위험이 있다.
    
    **장점** 
    
    - 중복 코드를 줄일 수 있다
    - 자식 클래스의 역할을 줄여준다
    
    **단점**
    
    - 클래스의 관리가 복잡해진다
    - 코드가 꼬여버릴 염려가 있다

 */
{
    //커피와 차를 만드는 예제
    abstract class Drink
    {
        protected string name;

        //템플릿 메서드
        public void getDrink() //커피와 차의 공통되는 부분
        {
            boil(); //물을 끓인다
            additives(); //첨가물을 넣는다
            stir(); //휘젓는다
            if (wantIce()) //hook
            {
                putIce();
            }
            drink(); //마신다
        }

        private void boil()
        {
            Console.WriteLine("물을 끓입니다.");
        }

        public abstract void additives();

        private void stir()
        {
            Console.WriteLine("휘젓습니다.");
        }

        public abstract void drink();
        public virtual bool wantIce() //hook
        {
            return false;
        }

        private void putIce()
        {
            Console.WriteLine("얼음을 넣습니다.");
        }
    }

    class IceCoffee : Drink
    {
        public IceCoffee()
        {
            this.name = "커피";
        }

        public override bool wantIce()
        {
            return true;
        }

        public override void additives()
        {
            Console.WriteLine(this.name + "을 추가합니다.");
        }




        public override void drink()
        {
            Console.WriteLine(this.name + "을 마십니다.");
        }
    }

    class Tea : Drink
    {

        public Tea()
        {
            this.name = "홍차";
        }


        public override void additives()
        {
            Console.WriteLine(this.name + "을 추가합니다.");
        }


        public override void drink()
        {
            Console.WriteLine(this.name + "을 마십니다.");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Tea tea = new Tea();
            tea.getDrink();

            Console.WriteLine("--------------------------------");

            IceCoffee coffee = new IceCoffee();
            coffee.getDrink();
        }
    }
}
