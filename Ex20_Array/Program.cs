using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex20_Array
{
    class Program
    {
        static void Main(string[] args)
        {

            // Array(배열)는 객체다.
            // 1.객체니까 new를 통해서 생성한다.
            // 2.메모리는 Stack이 아니라 Heap에 생성된다.
            // 3."고정"배열이다. (정적배열) -> 의미는 한번 배열의 크기가 정해지면 변경할 수 없다. 
            // 4.자료구조의 기본



            // 값 배열
            int[] arr = new int[5]; // arr 이라는 메인 함수 안의 로컬 변수로 배열 생성
            Console.WriteLine(arr[0]); // "0" 출력, 기본값이 defualt 값으로 초기화되어 있음(0은 정수의 기본 값)
            int[] arr2 = new int[5] { 10, 20, 30, 40, 50 }; // 정해진 초기화 값 말고 내가 원하는 값으로 초기화 가능
            Console.WriteLine(arr2[0]); // "10" 출력


            int[] arr3 = new int[] { 1, 2, 3, 4, 5 }; // 방 개수 안 쓰고 초기화로 설정해도 됨. // 이런 것 도 쓰기는 쓴다.

            // 다 귀찮다 나는 초기값만 넣을게 컴파일러 니가 new int[] 알아서 만들어 // 보통 이거 많이 써
            int[] arr4 = { 100, 200, 300, 400, 500 }; // 이것도 가능하지

            // Array는 for문과 가장 궁합이 잘 맞는다.
            // for (int i = 0; i < 5; i++) { // 배열 몇 개 인지 세기도 귀찮다. >> Length 쓰자
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr4[i]);
            }
            // 기본적으로 배열은 상속됨.
            Console.WriteLine(arr4.Length); // 배열 개수 출력해봐


            Console.WriteLine("foreach"); // foreach : 나열된 자원에 대해서 순차적으로 접근해 데이터를 추출해주는 논리
            foreach (int item in arr4)
            { // foreach 가 편한 이유 : 방의 개수 상관 안하고 그냥 뽑아줌

                Console.WriteLine("arr4 : {0}", item);
            }
            //Console.WriteLine("arr : {0}", arr);

            // 배열의 할당
            int[] ar = { 1, 3, 5, 7, 9 };
            int[] ar2 = ar; // 할당(주소값 할당) // 외우자 배열의 할당은 주소값 할당이다.
            for (int i = 0; i < ar2.Length; i++)
            {
                ar2[i] += i;
            }
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("ar : {0}", ar[i]);
            }

            string[] strarr = new string[] { "가", "나", "다", "마" };


            int[] varray = new int[] { 12, 5, 45, 90, 56, 10 };
            Console.WriteLine("인덱스 값 :{0}", Array.IndexOf(varray, 45));  // 2 출력 (45는 2번째 인덱스)
            Console.WriteLine("인덱스 값 :{0}", Array.LastIndexOf(varray, 56));  // 4 출력 (45는 4번째 인덱스, 마지막으로 만나는)


            Array.Sort(varray); // 자동정렬, 초급자는 절대 접근 금지 // 과제할 때 sort 쓰면 0점
            Console.WriteLine("자동 정렬 Asc");
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine("varray[{0}] , {1}", i , varray[i]);
            }

            Console.WriteLine("자동 정렬 Desc >> 선행 >> sort");
            Array.Reverse(varray);
            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine("varray[{0}] , {1}", i, varray[i]);
            }

            // 초급 개발자는 정렬코드 직접 구현(swap, bubble sort)

            Console.WriteLine("------------------------------");

            Console.WriteLine("Clear");
            Array.Clear(varray, 2, 3); // {2},{3},{4} 값을 "0"으로 초기화

            for (int i = 0; i < varray.Length; i++)
            {
                Console.WriteLine("varray[{0}] , {1}", i, varray[i]);
            }

            Console.WriteLine("------------------------------");


            int[] a = new int[] { 45, 12, 88, 97, 10 };
            int[] b = new int[5]; // 5 개 방 >> defaut 값 0이 들어있음
            Array.Copy(a, b, 3); // a : source , b : target , 3 만큼을 copy
            foreach (int item in b)
            {
                Console.WriteLine("b[{0}]",item);
            }


            Console.WriteLine("------------------------------");

            // 2차원 배열 (영화관 티켓 i열 3번 자리, 위도경도 값)
            // 행, 열
            int[,] arr5 = new int[3,2];
            arr5[0,0] = 100;
            Console.WriteLine("arr5 : {0}", arr5[0,0]);

            int[,] arr6 = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            // 출력하려면 for문 몇 개 필요? 2개 필요 ( 행을 고정하고 열을 바꿔가면서 출력하면 된다.)
            // 무식한 방법
            /*            for (int i = 0; i < 3; i++) // 행의 갯수를 돌려준다.
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                Console.WriteLine("arr[{0},{1}] = {2}", i ,j,arr6[i,j]);
                            }
                        }
            */

            Console.WriteLine("행의 개수 : {0}", arr6.GetLength(0)); // 행의 개수
            Console.WriteLine("행의 개수 : {0}", arr6.GetLength(1)); // 열의 개수


            for (int i = 0; i < arr6.GetLength(0); i++) // 행의 개수를 돌려준다.
            {
                for (int j = 0; j < arr6.GetLength(1); j++) // 열의 개수를 돌려준다.
                {
                    Console.WriteLine("arr[{0},{1}] = {2}", i ,j,arr6[i,j]);
                }
            }

            Console.WriteLine("------------------------------");

            // 좌석 배치(영화관), 위도 경도 , 바둑판, ...
        }
    }
}



