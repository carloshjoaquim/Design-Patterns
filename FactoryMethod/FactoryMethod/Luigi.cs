using System;

namespace FactoryMethod
{
    public class Luigi : IPersonagem
    {
        public void ShowAttributes()
        {
            Console.WriteLine("Roupas : Camiseta verde, boné verde com a letra L e um macacão azul.");
            Console.WriteLine("Irmão do Mário.");

        }

        public void ShowName()
        {
            Console.WriteLine("Nome: Luigi");
        }

        public void ShowImage()
        {
            Console.WriteLine(@".____          .__       .__ ");
            Console.WriteLine(@"|    |    __ __|__| ____ |__|");
            Console.WriteLine(@"|    |   |  |  \  |/ ___\|  |");
            Console.WriteLine(@"|    |___|  |  /  / /_/  >  |");
            Console.WriteLine(@"|_______ \____/|__\___  /|__|");
            Console.WriteLine(@"        \/       /_____/     ");
            Console.WriteLine();
        }
    }
}
