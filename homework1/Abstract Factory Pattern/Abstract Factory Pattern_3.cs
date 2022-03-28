using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex07_Designpattern
{
    abstract class guitarFactory
    {
        public abstract AbstractProductA Acousticguitar();
        public abstract AbstractProductB Electricguitar();
    }

    class stringFactory : guitarFactory
    {
        public override AbstractProductA Acousticguitar()
        {
            return new ProductA();
        }

        public override AbstractProductB Electricguitar()
        {
            return new ProductB();
        }
    }


    class bodyFactory : guitarFactory
    {
        public override AbstractProductA Acousticguitar()
        {
            return new ProductA2();
        }

        public override AbstractProductB Electricguitar()
        {
            return new ProductB2();
        }
    }
    abstract class AbstractProductA
    {

    }

    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    class ProductA : AbstractProductA
    {

    }

    class ProductB : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }

    class ProductA2 : AbstractProductA
    {

    }

    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interacts with " + a.GetType().Name);
        }
    }
    class Client
    {
        private AbstractProductA _abstractProductA;
        private AbstractProductB _abstractProductB;

        public Client(guitarFactory factory)
        {
            _abstractProductB = factory.Electricguitar();
            _abstractProductA = factory.Acousticguitar();
        }

        public void Run()
        {
            _abstractProductB.Interact(_abstractProductA);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            guitarFactory factory1 = new stringFactory();
            Client client = new Client(factory1);
            client.Run();

            guitarFactory factory2 = new bodyFactory();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.ReadKey();
        }
    }
}
