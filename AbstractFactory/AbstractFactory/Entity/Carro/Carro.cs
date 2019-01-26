using AbstractFactory.Entity.Roda;
using AbstractFactory.Entity.Som;

namespace AbstractFactory
{
    public class Carro
    {
        public Roda Roda { get; set; }
        public Som Som { get; set; }

        public override string ToString()
        {
            return $"Roda: {Roda?.Tipo.ToString()}\nSom: {Som?.Tipo.ToString()}";
        }

    }
}
