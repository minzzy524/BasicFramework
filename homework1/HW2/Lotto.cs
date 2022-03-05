using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex22_Array_Quiz
{
    class LottoHint // Lotto 과제 힌트
    {
        private int[] numbers;
        private Random random; // member feild
        // 여기서 초기화 하지마라 new 이런거

        public LottoHint()
        { // member field 의 초기화가 목적인 생성자에서 처리하자
            numbers = new int[6];  // 여기서 배열의 초기화 진행해라 (초기화 : 최초로 값을 갖는 행위)
            random = new Random(); // 초기화

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine("lotto[{0}] = {1}", numbers, random);

                //var bytes = new byte[5];
                //rand.NextBytes(bytes);
                //Console.WriteLine("Five random byte values:");
                //textBox1.Text += Convert.ToString(i + 1 + "회 : " + array[i] + Environment.NewLine);
            }


        }

        public void getReadLottoNumbers()
        {



        }


        public void displayLottoNumbers()
        {

        }



        // 추가적인 함수의 구현
        // 정렬하는 함수 같은거는 private  같은거 써

    }
}


/*
   static void Main(){
       Lotto lotto = new Lotto();
       lotto.getReadLottoNumbers();
       lotto.displayLottoNumbers();

*/

