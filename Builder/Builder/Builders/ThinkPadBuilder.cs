using Builder.Entity;
using Builder.Interface;

namespace Builder.Builders
{
    public class ThinkPadBuilder : INotebook
    {
        Notebook notebook;

        public ThinkPadBuilder()
        {
            this.notebook = new Notebook("Think Pad");
        }

        public void BuildCPU()
        {
            this.notebook.Cpu = "Core i7";
        }

        public void BuildMemoria()
        {
            this.notebook.Memoria = "32GB";
        }

        public void BuildTela()
        {
            this.notebook.Tela = "16'";
        }

        public void BuildVGA()
        {
            this.notebook.Vga = "Nvidia GTX 1080 TI";
        }

        public Notebook Notebook
        {
            get { return this.notebook; }
        }
    }
}
