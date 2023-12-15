 namespace ApiBen10.Domain.Entities
{

    public abstract class Entity
    {
         public Guid Id { get; private set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }
    }

    public class Alien : Entity
    {
        public string NomeAlien { get; set; }
        public int NumeroDoAlien { get; set; }

        public DateTime HorarioDeCadastro { get; set; }
    }
}