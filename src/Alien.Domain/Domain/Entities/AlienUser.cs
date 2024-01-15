using ApiBen10.Domain.Entities;

namespace Api_Ben10.Domain.Entities
{
    public class AlienUser : Entity
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
