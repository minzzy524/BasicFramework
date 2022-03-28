using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1.FastCampus
{
    class Array
    {
        static void Main(string[] args)
        {
            int[] reading = new int[6] { 4, 9, 1, 0, 21, 12 };

            for (int i = 0; i < reading.Length; i++)
                Console.WriteLine("reading[" + i + "]={0}", reading[i]);
        }
    }
}
