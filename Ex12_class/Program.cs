﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex12_class
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.CarInfo(); // 입력한 정보대로

            Car car2 = new Car("기아","Pink"); // 내가 원하는대로 설정
            car2.CarInfo();
            Console.WriteLine("색상만 별도로 보고 싶어요 : {0}",car2.Carcolor);
        }
    }
}
