using Kodlama.io.Simulation.Entities.Concrete;
using Kodlama.ioSimulation.DataAccess.Abstracts;

namespace Kodlama.ioSimulation.DataAccess.Concretes.InMemory
{
    public class ImInstructorDal : IInstructorDal
    {
        List<Instructor> instructors;
        public ImInstructorDal()
        {
            Instructor instructor1 = new Instructor(1, "Melih", "Dinçer", "Açıklama1", "image1.png");
            Instructor instructor2 = new Instructor(2, "Hasan", "Kaya", "Açıklama2", "image2.png");
            Instructor instructor3 = new Instructor(3, "Cemil", "Zorlu", "Açıklama3", "image3.png");
            instructors = new List<Instructor> { instructor1, instructor2, instructor3 };
        }
        public void Add(Instructor instructor)
        {
            instructors.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            var value = instructors.FirstOrDefault(i => i.Id == instructor.Id);
            instructors.Remove(value);
        }

        public List<Instructor> GetAll()
        {
            return instructors;
        }

        public Instructor GetById(int id)
        {
            return instructors.FirstOrDefault(i => i.Id == id);
        }

        public void Update(Instructor instructor)
        {
            var value = instructors.FirstOrDefault(i => i.Id == instructor.Id);
            value.Id = instructor.Id;
            value.FirstName = instructor.FirstName;
            value.LastName = instructor.LastName;;
            value.Description = instructor.Description;
            value.ImageUrl = instructor.ImageUrl;
        }
    }
}
