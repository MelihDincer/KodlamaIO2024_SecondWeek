using Kodlama.ioSimulation.Business.Dtos.Requests.CourseRequests;
using Kodlama.ioSimulation.Business.Dtos.Responses.CourseResponses;

namespace Business.Abstracts
{
    public interface ICourseService
    {
        void Add(CreateCourseRequest course);
        void Delete(DeleteCourseRequest course);
        void Update(UpdateCourseRequest course);
        List<GetAllCourseResponse> GetAll();
        GetByIdCourseResponse GetById(int id);
    }
}
