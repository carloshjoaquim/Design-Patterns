using Builder.Builders;
using Builder.Interface;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var fabricante = new Fabricante();

            INotebook notebookBuilder = null;

            notebookBuilder = new MacBookBuilder();
            fabricante.Construtor(notebookBuilder);

            Console.WriteLine($"Notebook Construido: {notebookBuilder.Notebook.NomeNotebook}\n" +
                              $"Tela: {notebookBuilder.Notebook.Tela}\n" +
                              $"CPU: {notebookBuilder.Notebook.Cpu}\n" +
                              $"VGA: {notebookBuilder.Notebook.Vga}");
            Console.ReadKey();
        }
    }
}
