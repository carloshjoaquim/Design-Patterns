using System;

namespace FactoryMethod
{
    public class Mario : IPersonagem
    {
        public void ShowAttributes()
        {            
            Console.WriteLine("Roupas : Camiseta vermelha, boné vermelho com a letra M e um macacão azul.");
            Console.WriteLine("Personagem Principal.");

        }

        public void ShowImage()
        {
            Console.WriteLine(@"   _____               .__        ");
            Console.WriteLine(@"  /     \ _____ _______|__| ____  ");
            Console.WriteLine(@" /  \ /  \\__  \\_  __ \  |/  _ \ ");
            Console.WriteLine(@"/    Y    \/ __ \|  | \/  (  <_> )");
            Console.WriteLine(@"\____|__  (____  /__|  |__|\____/ ");
            Console.WriteLine(@"        \/     \/                 ");
            Console.WriteLine();
        }

        public void ShowName()
        {
            Console.WriteLine("Nome: Mário");
        }
    }
}
