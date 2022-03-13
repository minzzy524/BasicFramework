using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex03_Emplib // 우리가 앞으로 만들 설계도는 기본적으로 이런 구성은 되어 있어야 초가집은 지을 수 있다.
{
    public class Emp // 사실 여기에 object라는 클래스 상속됨(화장실 같이 기본으로 주는 기능)
    {
        // 설계도 = 속성(정보를 저장) + 기능 
        // 멤버 필드 
        private int empno;
        private string ename;
        private int sal;

        public Emp() { } // 생성자 함수 >> 속성의 초기화 // constructor
        public Emp(int empno, string ename, int sal)
        { // 생성자 함수 (오버로딩 되어 있음) 
            this.empno = empno;
            this.ename = ename;
            this.sal = sal;
        }

        // 속성(Property) 
        // private int empno; 캡슐화된 자원에 대해서 read, write 기능을 제공.
        public int Empno // private int empno 자원에 간접적으로 get, set 사용 가능
        {
            get { return empno; }
            set { // if (value < 0) { } 간접 할당도 가능.
                empno = value; }
        }
        public String Ename // private int empno 자원에 간접적으로 get, set 사용 가능
        {
            get { return ename; }
            set { ename = value; }
        }
        public int Sal // private int empno 자원에 간접적으로 get, set 사용 가능
        {
            get { return sal; }
            set { sal = value; }
        }

        public void EmpPrint() // 기능(함수)
        {
            Console.WriteLine("{0} - {1} - {2}", this.empno, this.ename, this.sal);
        }
    }
}
