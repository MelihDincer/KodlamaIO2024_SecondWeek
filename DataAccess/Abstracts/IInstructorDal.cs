using Kodlama.io.Simulation.Entities.Concrete;

namespace Kodlama.ioSimulation.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        void Add(Instructor instructor);
        void Delete(Instructor instructor);
        void Update(Instructor instructor);
        Instructor GetById(int id);
        List<Instructor> GetAll();
    }
}
