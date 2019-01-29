namespace Builder.Entity
{
    public class Notebook
    {
        public string NomeNotebook;

        public Notebook(string nome)
        {
            this.NomeNotebook = nome;
        }

        public string Tela { get; set; }
        public string Cpu { get; set; }
        public string Memoria { get; set; }
        public string Vga { get; set; }

    }
}