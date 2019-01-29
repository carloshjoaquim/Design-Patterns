using Builder.Entity;

namespace Builder.Interface
{
    public interface INotebook
    {
        void BuildTela();
        void BuildMemoria();
        void BuildCPU();
        void BuildVGA();

        Notebook Notebook { get; }
    }
}
