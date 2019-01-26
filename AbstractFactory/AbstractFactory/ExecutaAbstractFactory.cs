using AbstractFactory.Factory;
using AbstractFactory.Factory.Base;

namespace AbstractFactory
{
    public static class ExecutaAbstractFactory
    {
        public static Carro MontaCarro(string tipo)
        {
            CarroFactory factory;

            switch(tipo.ToLowerInvariant())
            {
                case "luxo":
                    factory = new CarroLuxoFactory();
                    break;
                case "popular":
                    factory = new CarroPopularFactory();
                    break;
                default:
                    factory = null;
                    break;
            }

            var carro = new Carro
            {
                Roda = factory?.MontarRoda(),
                Som = factory?.MontarSom()
            };

            return carro;
        }
    }
}
