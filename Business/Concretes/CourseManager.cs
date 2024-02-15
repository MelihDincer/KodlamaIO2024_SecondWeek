using Business.Abstracts;
using Kodlama.io.Simulation.Entities.Concrete;
using Kodlama.ioSimulation.Business.Dtos.Requests.CourseRequests;
using Kodlama.ioSimulation.Business.Dtos.Responses.CourseResponses;
using Kodlama.ioSimulation.DataAccess.Abstracts;

namespace Workshop_2.Business.Concretes
{
    public class CourseManager : ICourseService
    {
        private ICourseDal _courseDal;

        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Add(CreateCourseRequest course)
        {
            Course courseToCreate = new();
            courseToCreate.CategoryId = course.CategoryId;
            courseToCreate.InstructorId = course.InstructorId;
            courseToCreate.Name = course.Name;
            courseToCreate.Description = course.Description;
            courseToCreate.ImageUrl = course.ImageUrl;
            courseToCreate.Price = course.Price;
            courseToCreate.CompletionRate = course.CompletionRate;
            _courseDal.Add(courseToCreate);
        }

        public void Delete(DeleteCourseRequest course)
        {
            Course courseToDelete = new();
            courseToDelete.Id = course.Id;
            _courseDal.Delete(courseToDelete);
        }

        public List<GetAllCourseResponse> GetAll()
        {
            List<GetAllCourseResponse> courses = new List<GetAllCourseResponse>();
            foreach (var course in _courseDal.GetAll())
            {
                GetAllCourseResponse getAllCourseResponse = new();
                getAllCourseResponse.Id = course.Id;
                getAllCourseResponse.CategoryId = course.CategoryId;
                getAllCourseResponse.InstructorId = course.InstructorId;
                getAllCourseResponse.Name = course.Name;
                getAllCourseResponse.Description = course.Description;
                getAllCourseResponse.ImageUrl = course.ImageUrl;
                getAllCourseResponse.Price = course.Price;
                getAllCourseResponse.CompletionRate = course.CompletionRate;
                courses.Add(getAllCourseResponse);
            }
            return courses;
        }

        public GetByIdCourseResponse GetById(int id)
        {
            GetByIdCourseResponse course = new();
            Course courseEntity = _courseDal.GetById(id);
            course.Id = courseEntity.Id;
            course.CategoryId = courseEntity.CategoryId;
            course.InstructorId = courseEntity.InstructorId;
            course.Name = courseEntity.Name;
            course.Description = courseEntity.Description;
            course.ImageUrl = courseEntity.ImageUrl;
            course.Price = courseEntity.Price;
            course.CompletionRate = course.CompletionRate;
            return course;
        }

        public void Update(UpdateCourseRequest course)
        {
            Course courseToUpdate = new();
            courseToUpdate.Id = course.Id;
            courseToUpdate.CategoryId = course.CategoryId;
            courseToUpdate.InstructorId = course.InstructorId;
            courseToUpdate.Name = course.Name;
            courseToUpdate.Description = course.Description;
            courseToUpdate.ImageUrl = course.ImageUrl;
            courseToUpdate.Price = course.Price;
            courseToUpdate.CompletionRate = course.CompletionRate;
            _courseDal.Update(courseToUpdate);
        }
    }
}