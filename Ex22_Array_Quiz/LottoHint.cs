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
        }

        public void getReadLottoNumbers()
        {
            for (int i = 0; i < 6; i++)
            {
                numbers[i] = random.Next(1, 46);
                for (int j = 0; j < i; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        --i;
                        break;
                    }
                }
            }
        }


        public void displayLottoNumbers()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }



        // 추가적인 함수의 구현
        // 정렬하는 함수 같은거는 private  같은거 써

    }

}

/*static void Main()
{
    LottoHint lotto = new LottoHint();
    lotto.getReadLottoNumbers();
    lotto.displayLottoNumbers();
}*/





