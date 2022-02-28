using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // 제어문과 연산자 같이 연습
            /*for(int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"i : {i}");
                        }*/

            /* int i; 
             for (i = 0; i < 10; i++)
             {
                 Console.WriteLine($"i : {i}");
             }
             Console.WriteLine($"for 끝나고 i : {i}");*/  //이런 식으로는 잘 안 쓴다  i를 더 못 쓰니까

            /*            for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine($"i : {i}");
                        }*/

            // 이중 for문 구구단

            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i == j) break; // 현재 제어구문을 탈출하세요.
                                       //Console.Write("{0} * {1} = {2}\t", i, j, i * j);
                    Console.Write("*");
                }
                Console.WriteLine(); // 엔터
            }
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (i == j) continue; // skip하고 지나가라
                    Console.Write("{0} * {1} = {2}\t", i, j, i * j);

                }
                Console.WriteLine(); // 엔터
            
                }
            int result;
            Console.Write("숫자값을 입력하세요");
            result = int.Parse(Console.ReadLine()); // 입력받은 값을 정수값으로 변환
            

            switch(result)
            {
                case 1: Console.WriteLine(result);
                    break;
                case 2:
                    Console.WriteLine(result);
                    break;
                case 3:
                    Console.WriteLine(result);
                    break;
                case 4:
                    Console.WriteLine(result);
                    break;
                case 5:
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("nothing");
                    break;

            }
            


            }
        }
    }
