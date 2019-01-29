using Builder.Entity;
using Builder.Interface;

namespace Builder.Builders
{
    public class DellNotebookBuilder : INotebook
    {
        Notebook notebook;

        public DellNotebookBuilder()
        {
            this.notebook = new Notebook("Dell - Inspiron");
        }

        public void BuildCPU()
        {
            this.notebook.Cpu = "Core I5";
        }

        public void BuildMemoria()
        {
            this.notebook.Memoria = "8GB";
        }

        public void BuildTela()
        {
            this.notebook.Tela = "15'";
        }

        public void BuildVGA()
        {
            this.notebook.Vga = "Nvidia GTX 1050 TI";
        }

        public Notebook Notebook
        {
            get { return this.notebook;}
        }
    }
}
