using Kodlama.io.Simulation.Entities.Concrete;

namespace Kodlama.ioSimulation.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        void Add(Course course);
        void Delete(Course course);
        void Update(Course course);
        Course GetById(int id);
        List<Course> GetAll();  
    }
}
