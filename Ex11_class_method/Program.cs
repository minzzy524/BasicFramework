using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex11_class_method
{

    // 설계도 : 속성 + 기능

    // 기능 == 행위 == "method(한국말로는 함수)"
    // Method 하나 당 기능 하나

    class Test {
        private int i; // instance variable or member field
        // 행위 기능
        // method 는 누군가 이름을 부르면 실행됨. 
        // 4가지
        // void, parameter (x) : public void m(){ 실행 코드 } 돌려줄건 없고 동전구멍 있어요-> 24번 라인
        // void, parameter (o) : public void m(int i) { 실행 코드} -> 돌려줄건 없고 동전구멍 있어요
        // return, parameter(x) : publc int m() { return 값 } -> 당신이 나를 불러주면 나는 return 으로 정수값을 주겠습니다.
        // return, parameter(o) : publc int m(int i) { return i; }  뭔가를 돌려 줄거고 동전구멍 있어요(뽑기)


        // parameter 인수, 인자, 매개값(변수)
        public void callMethod() // L19
        {
            Console.WriteLine("일반 함수"); // L40
            
        } 

        public void callMethod2(int i) // L20
        {
            // 개발자 마음
            if(i < 10)
            {
                Console.WriteLine("....");
            }
            else
            {
                Console.WriteLine("<<<<");
            }
        }

        public string callMethod3() // return type 함수의 결과 string 같은 타입을 전달 // L21
        {
            return "타입만 동일";
        }


        public string callMethod4(string str) // L22
        {
            return str + "방가";
        }

        // 추가적으로
        public int callMethod5(int i , int j , int k)
        {
            return i + j + k;
        }
    }





    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(); // 메모리에 올림
            // 함수는 호출에 의해서 실행
            test.callMethod(); // 19L
            // test.callMethod2(); 이거는 안돼, int 크기의 동전 넣어야 작동함.
            test.callMethod2(5); // 20L

            string result = test.callMethod3(); // L45 타입만 동일한 걸 돌려줘
            {
                Console.WriteLine(result);

                result = test.callMethod4("친구야!"); // L22
                Console.WriteLine(result);

                int value = test.callMethod5(1, 2, 3); // L57
                Console.WriteLine(value);
            }


            
        }
    }
}
