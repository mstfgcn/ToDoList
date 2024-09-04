using Infrastructure.Model;

namespace TD.Model.Entities
{
    public class User:IEntity
    {
        public string Name{ get; set; }
        public string Password { get; set; }
    }
}
