using Builder.Interface;

namespace Builder
{
    public class Fabricante
    {
        public void Construtor(INotebook notebookBuilder)
        {
            notebookBuilder.BuildCPU();
            notebookBuilder.BuildMemoria();
            notebookBuilder.BuildTela();
            notebookBuilder.BuildVGA();
        }
    }
}
