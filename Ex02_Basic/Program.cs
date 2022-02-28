using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex03_Emplib;

namespace Ex02_Basic
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            Emp emp = new Emp();
            Console.WriteLine(emp.GetHashCode());
            // 메모리를 하나 더 쓴 것 
            // new 하면 heap에 empno, ename, sal 등이 올라감. 이제 emp하고 . 찍으면 그 주소로 이동 가능
            emp.Empno = 7788;
            emp.Ename = "홍길동";
            //  Emp.cs 파일의 get / set 작동시키는 것
            emp.Sal = 1000;
            Console.WriteLine(emp.Empno);
            emp.EmpPrint(); 

        }
    }
}
