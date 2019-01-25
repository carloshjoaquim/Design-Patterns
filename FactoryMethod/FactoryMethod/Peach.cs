using System;

namespace FactoryMethod
{
    public class Peach : IPersonagem
    {
        public void ShowAttributes()
        {
            Console.WriteLine("Roupas : Vestido Rosa com joias azuis e coroa.");
            Console.WriteLine("Princesa !.");

        }

        public void ShowName()
        {
            Console.WriteLine("Nome: Peach");
        }

        public void ShowImage()
        {
            Console.WriteLine(@"__________                     .__     ");
            Console.WriteLine(@"\______   \ ____ _____    ____ |  |__  ");
            Console.WriteLine(@" |     ___// __ \\__  \ _/ ___\|  |  \ ");
            Console.WriteLine(@" |    |   \  ___/ / __ \\  \___|   Y  \");
            Console.WriteLine(@" |____|    \___  >____  /\___  >___|  /");
            Console.WriteLine(@"               \/     \/     \/     \/ ");
            Console.WriteLine();
        }
    }
}
