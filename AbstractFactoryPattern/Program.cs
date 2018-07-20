using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    abstract class AbstractProductA
    {

    }

    class ProductA1 : AbstractProductA
    {

    }
    class ProductA2 : AbstractProductA
    {

    }

    
    abstract class AbstractProductB
    {

    }

    class ProductB1 : AbstractProductB
    {

    }

    class ProductB2 : AbstractProductB
    {

    }

    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();


        public abstract AbstractProductB CreateProductB();

    }


    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    class Client
    {
        AbstractProductA absA;
        AbstractProductB absB;

        Client(AbstractFactory abstractFactory)
        {
            absB=abstractFactory.CreateProductB();
            absA = abstractFactory.CreateProductA();
        }

    }









}
