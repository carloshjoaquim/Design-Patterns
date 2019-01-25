using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Mario | Luigi | Peach ");
            Console.WriteLine();

            do
            {
                Console.WriteLine();
                Console.WriteLine("Escolha um personagem: ");
                var escolha = Console.ReadLine();

                IPersonagem personagem = new PersonagemFactoryMethod().Escolher_Personagem(escolha);
                Console.WriteLine();
                Console.WriteLine("Você irá jogar com: ");

                personagem.ShowImage();
                personagem.ShowName();
                personagem.ShowAttributes();

                Console.WriteLine();
                Console.WriteLine("Escolher novo personagem ? (Sim (s) ou Não (n):  ");
                var repeat = Console.ReadLine().ToLower();

                if (repeat.Equals("n"))
                    break;

            } while (true);
        }
    }
}
