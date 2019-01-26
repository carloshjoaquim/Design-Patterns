using AbstractFactory.Entity.Roda;
using AbstractFactory.Entity.Som;
using AbstractFactory.Factory.Base;

namespace AbstractFactory.Factory
{
    public class CarroLuxoFactory : CarroFactory
    {
        public override Roda MontarRoda()
        {
            return new RodaLigaLeve()
            {
                Tamanho = 20,
                Tipo = "Liga Leve"
            };
        }

        public override Som MontarSom()
        {
            return new Bluetooth()
            {
                Tipo = "Bluetooth",                
            };
        }
    }
}
