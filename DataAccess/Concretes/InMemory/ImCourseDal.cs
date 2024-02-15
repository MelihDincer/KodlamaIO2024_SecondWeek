using Kodlama.io.Simulation.Entities.Concrete;
using Kodlama.ioSimulation.DataAccess.Abstracts;

namespace Kodlama.ioSimulation.DataAccess.Concretes.InMemory
{
    public class ImCourseDal : ICourseDal
    {
        List<Course> courses;
        public ImCourseDal()
        {
            Course course1 = new Course(1, 2, 1, "C# ve Angular", "Description1", "%79" , "image1.png", "Ücretsiz");
            Course course2 = new Course(2, 2, 2, "JavaScript", "Description2", "%0", "image2.png", "Ücretsiz");
            Course course3 = new Course(3, 2, 3, "2024 Yazılımcı Yetiştirme Kampı (C#)", "Description3", "%20" , "image3.png", "Ücretsiz");
            Course course4 = new Course(4, 2, 4, "2023 Yazılımcı Yetiştirme Kampı (Python & Selenium)", "Description4", "%41", "image4.png", "Ücretsiz");
            courses = new List<Course> { course1, course2, course3, course4 };
        }
        public void Add(Course course)
        {
            courses.Add(course);
        }

        public void Delete(Course course)
        {
            var value = courses.FirstOrDefault(c => c.Id == course.Id);
            courses.Remove(course);
        }

        public List<Course> GetAll()
        {
            return courses;
        }

        public Course GetById(int id)
        {
            return courses.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Course course)
        {
            var value = courses.FirstOrDefault(c => c.Id == course.Id);
            value.Id = course.Id;
            value.CategoryId = course.CategoryId;
            value.InstructorId = course.InstructorId;
            value.Name = course.Name;
            value.Description = course.Description;
            value.CompletionRate = course.CompletionRate;
            value.ImageUrl = course.ImageUrl;
            value.Price = course.Price;
        }
    }
}
