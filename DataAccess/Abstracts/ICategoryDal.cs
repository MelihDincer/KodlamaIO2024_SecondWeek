using Kodlama.io.Simulation.Entities.Concrete;

namespace Kodlama.ioSimulation.DataAccess.Abstracts
{
    public interface ICategoryDal
    {
        void Add(Category category);
        void Delete(Category category);
        void Update(Category category);
        Category GetById(int id);
        List<Category> GetAll();
    }
}
