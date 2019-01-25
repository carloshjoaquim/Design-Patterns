namespace FactoryMethod
{
    public class PersonagemFactoryMethod
    {
        public IPersonagem Escolher_Personagem(string nome)
        {
            switch(nome)
            {
                case "Mario": return new Mario();
                case "Luigi": return new Luigi();
                case "Peach": return new Peach();
                default: return null;
            }
        }
    }
}
