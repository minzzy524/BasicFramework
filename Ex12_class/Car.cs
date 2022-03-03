using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    public class Car
    {
        //요구사항
        //1.자동차는 이름을 갖고 있다. 자동차는 색상을 갖고 있다. 
        //2.자동차는 기본 이름과 색상을 가지고 있고 요구에 따라 이름과 색상을 옵션으로 선택할 수 있다
        //3.자동차를 생성하고 자동차의 이름과 색상 정보를 확인 할 수 있다.
        //4.자동차 생성 후에는 자동차의 이름과 색상을 변경할 수 없습니다.(멤버필드 프라이빗, 읽기만 가능 쓰기 불가능) 단, 이름과 색상의 별도 조회는 가능하다.

        private string carname;
        private string carcolor; // 1.

        public Car() {
            this.carname = "벤츠";
            this.carcolor = "블랙"; // 2. 기본 이름과 색상
        }

        public Car(string carname, string carcolor) { // 2. 요구에 따라 이름과 색상 옵션 선택
            this.carname = carname; // this는 객체 자신을 가르킴
            this.carcolor = carcolor;        
         }

        public string Carname
        {
            get { return this.carname; } // set 없으니까 이름 변경 불가
        }

        public string Carcolor
        {
            get { return this.carcolor; } // set 없으니까 색상 변경 불가
        }
        
        // 두 가지 정보확인 (기능)
        public void CarInfo() // 이름과 색상은 조회 가능
        {
            Console.WriteLine($"Carname : {carname}, Carcolor : {carcolor}");
        }


    }
}
