using AbstractFactory.Entity.Roda;
using AbstractFactory.Entity.Som;

namespace AbstractFactory.Factory.Base
{
    public abstract class CarroFactory
    {
        public abstract Roda MontarRoda();
        public abstract Som MontarSom();
    }
}
