﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex21_Object_Array
{
    // class 생성
    class Ani
    {
        private string dogname;

        public Ani() { }
        public Ani(string dogname)
        {
            this.dogname = dogname;
        }

        public void aniDisplay()
        {
            Console.WriteLine("개 이름 : {0}", this.dogname);
        }


    }


    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = new int[] {1,2,3,4,5};

            /*
            Ani[] arr = new Ani[3];  // Ani는 클래스, 클래스는 타입 그래서 int 자리에 Ani 써도 된다.
                                     // Heap 메모리에 방 3개 만들었다.(방의 타입은 Ani) : 방의 값은 null(참조 없음) 왜? 지금 방만 만들었으니까
            // 각각의 방에 값을 넣어라(각각의 방에 Ani 타입의 갖는 주소를 넣어라) -> 주소 넣을라면 heap 메모리에 뭐가 생성되어야 함 -> new 또 필요
            Ani a = new Ani("멍멍이");
            Ani a1 = new Ani("발발이");
            Ani a2 = new Ani("야옹이");

            arr[0] = a; // (Ani 타입)을 갖는 주소값을 전달한 것.
            arr[1] = a1; // (Ani 타입)을 갖는 주소값을 전달한 것.
            arr[2] = a2; // (Ani 타입)을 갖는 주소값을 전달한 것.

            arr[0].aniDisplay();
            arr[1].aniDisplay();
            arr[2].aniDisplay();
            */

            Ani[] arr = new Ani[3];
            arr[0] = new Ani("멍멍이");
            arr[1] = new Ani("발발이");
            arr[2] = new Ani("야옹이");

            Ani[] arr2 = new Ani[] { new Ani("멍멍이"), new Ani("발발이"), new Ani("야옹이") };

            Ani[] arr3 = { new Ani("멍멍이"), new Ani("발발이"), new Ani("야옹이") }; // 이게 제일 편하지 이거 외워
            for (int i = 0; i < arr3.Length; i++)
            {
                arr3[i].aniDisplay();
            }

            Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");


            // foreach 로 출력
            foreach (Ani obj in arr3) // (type 변수명 in 변수)
            {
                obj.aniDisplay();
            }


        }
    }
}
