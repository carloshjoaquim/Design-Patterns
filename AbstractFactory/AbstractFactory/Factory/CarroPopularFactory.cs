using AbstractFactory.Entity.Roda;
using AbstractFactory.Entity.Som;
using AbstractFactory.Factory.Base;

namespace AbstractFactory.Factory
{
    public class CarroPopularFactory : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaComum()
            {
                Tamanho = 19,
                Tipo = "Comum"
            };
        }

        public override Som MontarSom()
        {
            return new CDPlayer()
            {
                Tipo = "Comum"
            };
        }
    }
}
