/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex23_Array_Cinema
{




    class Program
    {
        static void Main(string[] args)
        { // 예약 , 예약 확인, 취소

            string[,] seat = new string[3, 5]; // 3행 5열 좌석

            for (int i = 0; i < seat.GetLength(0); i++) // 행의 개수를 돌려준다.
            {
                for (int j = 0; j < seat.GetLength(1); j++) // 열의 개수를 돌려준다.
                {
                    seat[i, j] = "__";
                }
            }


            *//*        for (int i = 0; i < seat.GetLength(0); i++) // 행의 개수를 돌려준다.
                     {
                         for (int j = 0; j < seat.GetLength(1); j++) // 열의 개수를 돌려준다.
                         {
                          seat[i, j] = "__";
                         }
                     }*//*

            // 예매
            seat[2, 0] = "홍길동";
            seat[0, 0] = "김유신";

            for (int i = 0; i < seat.GetLength(0); i++) // 행의 개수를 돌려준다.
            {
                for (int j = 0; j < seat.GetLength(1); j++) // 열의 개수를 돌려준다.
                {
                    // __ 빈 좌석, 나머지 예매
                    Console.Write(seat[i,j] == "__" ? "[빈 좌석]" : "[예매]");
 
                }
                Console.WriteLine();
            }

            int row, col;
            // 예매 시작
            row = 0;
            col = 0;
            // [0,0] 예매 하겠다.
            if (seat[row, col] == "__")
            {
                Console.WriteLine("예매 가능한 좌석 입니다.");
            }
            else {
                Console.WriteLine("이미 예약 되었습니다.");
            }

            // 예매 가능하도록 좌석을 초기화

            for (int i = 0; i < seat.GetLength(0); i++) // 행의 개수를 돌려준다.
            {
                for (int j = 0; j < seat.GetLength(1); j++) // 열의 개수를 돌려준다.
                {
                    seat[i, j] = "__"; // 좌석 초기화
                }
            }

            for (int i = 0; i < seat.GetLength(0); i++) // 행의 개수를 돌려준다.
            {
                for (int j = 0; j < seat.GetLength(1); j++) // 열의 개수를 돌려준다.
                {
                    // __ 빈 좌석, 나머지 예매
                    Console.Write(seat[i, j] == "__" ? "빈 좌석" : "예매");

                }
                Console.WriteLine();
            }
        }
 
    }
}
*/