using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1.Abstract_Factory_Pattern
{
    /*
1. **추상 팩토리 패턴의 정의에 앞서 팩토리 메서드란?**

조건에 따라 객체 생성을 다르게 해야하는 작업을 수행하는걸, 클래스에게 따로 위임해 놓는 것. 위임받은 클래스가 팩토리 클래스.

ㄴ여러 물건들을 조건에 따라 자동으로 생성할 수 있는 공장을 만드는것.

ㄴ스타크래프트로 비유하자면 마린, 파이어뱃, 고스트를 생산하는 걸 마린생산 따로, 파이어뱃 생산 따로, 고스트 생상 따로가 아닌 배럭이라는 공장 클래스 하나에게 맡긴다.

이 때 위의 팩토리 클래스를 추상화시키고 하위 클래스를 만들어 이들이 실제로 객체들을 생산할 수 있게 해야 한다.

ㄴ공장에 대한 설계도를 만들어서 공장들을 더 만들 수 있게

ㄴ전 세계에 단 1개가 아닌 여러개 지어야 한다.

ㄴ스타크래프트로 비유하자면 배럭은 게임상에서 단 1개만 짓지 않는다. 배럭은 계속 지을 수 있어야 한다. 그리고 각 배럭은 서로 다른 위치와 체력값을 가지고 있어야 한다.


2. **추상 팩토리 패턴의 정의**

추상 팩토리 패턴은 서로 연관되거나 의존적인 객체들의 조합(family)을 만드는 인터페이스를 제공하는 방법이다.

팩토리 메서드의 확장판. 서로 관련이 있는 객체들을 통째로 묶어서 팩토리 클래스로 만들고, 이들 팩토리를 조건에 따라 생성하도록 다시 팩토리를 만들어서 객체를 생성하는 패턴

**팩토리 메소드 패턴과 추상 팩토리 패턴과의 차이점**

팩토리 메소드 패턴은 single method가 여러 종류의 객체를 생성하는 것이고

추상 팩토리 패턴은 object 별 한 종류의 객체를 생성하는데, 여러 객체를 생성해서 여러 종류의 객체를 생성하는 팩토리 효과를 나타내는 것이다.

추상 팩토리 패턴은 동일한 처리로직의 하위클래스의 결합을 통해 **선택적으로 객체**를 생성 할 수 있는 장점이 있다.

ㄴ 여러종류의 컴퓨터부품을 생산하는 공장의 연장선으로 각 회사별 공장
ㄴ 삼성 컴퓨터 공장은 삼성 모니터, 삼성 키보드, 삼성 마우스를 생산. LG컴퓨터는 LG 모니터, LG        키보드, LG마우스를 생산

ㄴ 삼성 컴퓨터 공장, LG컴퓨터 공장처럼 비슷하지만 각자 다른 부품을 만드는 공장들

ㄴ 각 부품들은 같은 인터페이스를 사용하지만 실제 객체단계에서는 엄밀히 다른 부품.

 */

    /*
     3.**추상 팩토리 패턴의 예시와 구현코드**

삼성컴퓨터는 삼성부품(삼성객체)들로만, LG컴퓨터는 LG부품(LG객체)들로만 구성되어 있다.
삼성컴퓨터가 방침을 바꿔서 키보드는 LG껄로 바꾸기로 했다.
     */

    // 3-1. 팩토리 메서드라면
    public class ComputerFactory
    {
        public void createComputer(String type)
        {
            //객체 생성
            KeyboardFactory keyboardFactory = new KeyboardFactory();
            MouseFactory mouseFactory = new MouseFactory();

            //객체의 메소드 호출(본격적인 작업)
            keyboardFactory.createKeyboard(type);
            mouseFactory.createMouse(type);
        }
    }

    public class KeyboardFactory
    {
        public Keyboard createKeyboard(String type)
        {
            Keyboard keyboard = null;
            switch (type)
            {
                case "LG":
                    keyboard = new LGKeyboard();
                    break;

                case "Samsung":
                    keyboard = new SamsungKeyboard();
                    break;
            }

            return keyboard;
        }
    }
    public class SamsungKeyboard : Keyboard
    {
        public void SamsungKeyboard()
        {
            Console.WriteLine("Samsung 키보드 생성");
        }
    }

    //  팩토리 메서드는 공장을 기준으로 생산하며 삼성인지 LG인지 타입이 결정되면 모든 부품들이
    //  일괄적으로 생산되어 있도록 구성되어 있기 때문에 수정하기 어렵다.




    // 3-2. 추상팩토리라면

    interface ComputerFactory
    {
        public Keyboard createKeyboard();
        public Mouse createMouse();
    }

    //삼성컴퓨터팩토리
    public class SamsungComputerFactory : ComputerFactory
    {
        public SamsungKeyboard createKeyboard()
        {
            return new SamsungKeyboard();
        }

        public SamsungMouse createMouse()
        {
            return new SamsungMouse();
        }
    }

    //삼성 키보드
    public class SamsungKeyboard : Keyboard
    {
        public void SamsungKeyboard()
        {
            Console.WriteLine("Samsung 키보드 생성");
        }
    }
    //삼성마우스
    public class SamsungMouse : Mouse
    {
        public void SamsungMouse()
        {
            Console.WriteLine("Samsung 마우스 생성");
        }
    }

    /*
     추상 팩토리 패턴은 삼성 카탈로그(삼성 모니터, 삼성 키보드, 삼성 마우스)를 기준으로 생산하고 카탈로그에서 키보드 부분만 바꾸면 된다.

비유하자면 팩토리 메소드 패턴은 생산 공장을 기준으로,

추상 팩토리 패턴은 회사의 카탈로그를 중심으로 생산을 가동한다고 볼 수 있다.

추상 팩토리 패턴은 팩토리 메소드 패턴보다 유연하지만, 팩토리 메서드 패턴은 1개의 하위클래스 내 매개변수 를 통해 생성을 선택적으로 처리하기에 
    다형성의 단점(하나의 타입으로 전부 관리가 가능하는게 힘들어진다)은 해결할 수 있으므로 상황에 따라 적합한 패턴을 사용하면 된다. 

위의 예제를 예로 들면, **삼성이 LG부품을 사용하는 등 부품을 교체할 일이 절대 없을 것이며,** 스피커, 램 같은 새로운 부품을 추가하는 일, 
    다른 컴퓨터 생산 회사를 추가하는 일만 있다고 가정한다면 추상 팩토리 패턴보다는 팩토리 메서드 패턴이 유지보수가 좀 더 편하다.
     */




    // 4. 스타크래프트를 예시로 한 팩토리 메서드 패턴과 추상 팩토리 패턴
    // RaceCapacity.cs

    public abstract class RaceCapacity
    {
        public abstract void expend();
    }

    public class SupplyDepot : RaceCapacity
    {
        public override void expend()
        {
            Console.WriteLine("테란 유닛 제한 + 8");
        }
    }

    public class Pylon : RaceCapacity
    {
        public override void expend()
        {
            Console.WriteLine("프로토스 유닛 제한 + 8");
        }
    }
    //-----------------------------------------------------
    // UnitBuilding.

    public abstract class UnitBuilding
    {
        public abstract void produce();
    }

    public class Barracks : UnitBuilding
    {
        public override void produce()
        {
            Console.WriteLine("테란 유닛 생산");
        }
    }

    public class GateWay : UnitBuilding
    {
        public override void produce()
        {
            Console.WriteLine("프로토스 유닛 생산");
        }
    }
    // 각각 여러 다른 기능들을 가지고 있는 건물들

    //------------------------------------------------------

    // 팩토리 메소드
    // FactoryMethod.cs

    public class FactoryMethod : MonoBehaviour
    {
        public Race type = Race.Terran;

        public RaceFactory getFactory()
        {
            RaceFactory factory = null;
            switch (type)
            {
                case Race.Terran:
                    factory = new TerranFactory();
                    break;
                case Race.Protoss:
                    factory = new ProtossFactory();
                    break;
            }
            return factory;
        }
    }

    // ------------------------------------------

    // FactoryMethodUse.cs


    public class FactoryMethodUse : MonoBehaviour
    {
        void Start()
        {
            FactoryMethod factoryMethod = new FactoryMethod();

            RaceFactory factory = factoryMethod.getFactory();

            RaceCapacity capacity = factory.makeCapacityBuilding();
            UnitBuilding building = factory.makeUnitBuilding();

            capacity.expend();
            building.produce();
        }
    }
    // 팩토리 메서드 패턴에서는 유닛을 생산하는 건물(배럭, 게이트웨이 등)들이 같이 묶여있고 ,
    // 인구수 관리를 담당하는 건물(서플라이 데폿, 파일론)들이 같이 묶여있다.
    // 종족이라는 입력값이 들어가면 그에 맞는 공장을 가동한다

    // ------------------------------------------

    // 추상 팩토리
    // Factory.cs
    public enum Race
    {
        Terran,
        Protoss,
        Zerg
    }

    public abstract class RaceFactory
    {
        public abstract RaceCapacity makeCapacityBuilding();
        public abstract UnitBuilding makeUnitBuilding();
    }

    public class TerranFactory : RaceFactory
    {
        public override RaceCapacity makeCapacityBuilding()
        {
            return new SupplyDepot();
        }

        public override UnitBuilding makeUnitBuilding()
        {
            return new Barracks();
        }
    }

    public class ProtossFactory : RaceFactory
    {
        public override RaceCapacity makeCapacityBuilding()
        {
            return new Pylon();
        }

        public override UnitBuilding makeUnitBuilding()
        {
            return new GateWay();
        }
    }
    // 테란이 건설할 수 있는 건물들 목록, 프로토스가 건설할 수 있는 건물들 목록을 유연하게 수정할 수 있다.
    // 또한 현재 테란 건물 목록에 파일론(Pylon)을 넣어버리거나,
    // 프로토스가 건설할 수 있는 건물 목록에 게이트웨이(GateWay)를 빼버리는것도 가능하다.
    // 현재는 스타포트 객체가 없지만 완성된다면 테란이 건설할 수 있는 건물목록에 스타포트를 바로 넣으면 된다.
}
