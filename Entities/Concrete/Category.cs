using Kodlama.io.Simulation.Entities.Abstract;

namespace Kodlama.io.Simulation.Entities.Concrete
{
    //Çıplak class kalmasın.
    public class Category : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        public Category()
        {
            
        }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
