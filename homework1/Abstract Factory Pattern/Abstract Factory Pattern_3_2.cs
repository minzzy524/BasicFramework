using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IBody
    {

    }

    public interface IString
    {

    }

    public class AcousticBody : IBody
    {

        public AcousticBody()
        {
            Console.WriteLine("통기타의 몸체입니다\n");
        }
    }
    public class ElectricBody : IBody
    {

        public ElectricBody()
        {
            Console.WriteLine("일렉기타의 몸체입니다.\n");
        }
    }
    public class AcousticString : IString
    {

        public AcousticString()
        {
            Console.WriteLine("통기타의 줄입니다\n");
        }
    }
    public class ElectricString : IString
    {

        public ElectricString()
        {
            Console.WriteLine("일렉기타의 줄입니다.\n");
        }
    }


    public interface IGuitarFactory
    {

        void make();
        IBody CreateBody();
        IString CreateString();

    }

    public class AcousticGuitarFactory : IGuitarFactory
    {

        public void make()
        {
            Console.WriteLine("통기타 제작 재료입니다\n");
        }
        public IBody CreateBody()
        {
            return new AcousticBody();
        }
        public IString CreateString()
        {
            return new AcousticString();
        }
    }

    public class ElectricGuitarFactory : IGuitarFactory
    {
        public void make()
        {
            Console.WriteLine("일렉기타 제작 재료입니다\n");
        }
        public IBody CreateBody()
        {
            return new ElectricBody();
        }
        public IString CreateString()
        {
            return new ElectricString();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            IGuitarFactory acuostic = new AcousticGuitarFactory();
            IGuitarFactory electric = new ElectricGuitarFactory();

            acuostic.make();
            acuostic.CreateBody();
            acuostic.CreateString();

            electric.make();
            electric.CreateBody();
            electric.CreateString();

        }
    }
}