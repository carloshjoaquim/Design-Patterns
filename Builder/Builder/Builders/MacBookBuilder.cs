using Builder.Entity;
using Builder.Interface;

namespace Builder.Builders
{
    public class MacBookBuilder : INotebook
    {
        Notebook notebook;

        public MacBookBuilder()
        {
            this.notebook = new Notebook("MacBook");
        }

        public void BuildCPU()
        {
            this.notebook.Cpu = "Core i7";
        }

        public void BuildMemoria()
        {
            this.notebook.Memoria = "16GB";
        }

        public void BuildTela()
        {
            this.notebook.Tela = "15' - Retina";
        }

        public void BuildVGA()
        {
            this.notebook.Vga = "Nvidia GTX 1080";
        }

        public Notebook Notebook
        {
            get { return this.notebook;}
        }
    }
}
