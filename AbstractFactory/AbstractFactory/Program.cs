using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecutaAbstractFactory.MontaCarro("luxo");
            Carro c2 = ExecutaAbstractFactory.MontaCarro("popular");
            Carro c3 = ExecutaAbstractFactory.MontaCarro("teste null");

            Console.WriteLine(c1.ToString());
            Console.WriteLine(c2.ToString());
            Console.WriteLine(c3.ToString());

            Console.ReadKey();
        }
    }
}
