using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex14_static
{
    // 우리 회사는 비행기를 주문 제작 판매하는 회사
    // 우리 회사는 비행기를 생산하는 설계도 작성
    //요구사항//
    // 비행기를 생산하고 비행기 이름과 번호를 부여
    // 비행기가 생산되면 이름과 번호에 맞게 부여되었는지 확인하는 작업 필요(출력 정보 확인)
    // 공장장은 현재까지 만들어진 비행기 총 대수(누적)을 확인할 수 있다.

    // AirPlane air = new AirPlane("아시아나","707");
    // air.출력 .. 결과 ...
    // air.총 비행기 수 ... 3개
    // AirPlane air2 = new AirPlane("아시아나","708");
    // AirPlane air3 = new AirPlane("아시아나","709");
    
    class Airplane
    {
        private static int totalaircount; // !! @@중요 포인트@@ !! (static으로 객체 간 공유자원)
        private int airnum;
        private string airname;

        // public Airplane () { } // 기본 생성자 함수 

        public Airplane(string airname, int airnum) // 오버로딩 생성자 함수 통해서 강제로 입력
        {
            this.airname = airname;
            this.airnum = airnum;

            // 누적대수
            totalaircount++;
        }
        // 기능은 Method 로 만들자
        public void airDisplay()
        {
            Console.WriteLine("비행기 이름: {0}, 비행기 번호 {1}", this.airname, this.airnum);
        }

        public void totalAirCountDisplay()
        {
            Console.WriteLine("비행기 총 누적대수: {0}", totalaircount);

        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            Airplane a1 = new Airplane("대한항공", 707);
            a1.airDisplay();
            a1.totalAirCountDisplay();

            Airplane a2 = new Airplane("대한항공", 708);
            a2.airDisplay();
            a2.totalAirCountDisplay();

            Airplane a3 = new Airplane("대한항공", 709);
            a3.airDisplay();
            a3.totalAirCountDisplay();

            // L24 가 private이 아니라 public이면
            // Console.WriteLine(Airplane.totalaircount)
        }

    }
}

