using Kodlama.ioSimulation.Business.Dtos.Requests.InstructorRequests;
using Kodlama.ioSimulation.Business.Dtos.Responses.InstructorResponses;

namespace Business.Abstracts
{
    public interface IInstructorService
    {
        void Add(CreateInstructorRequest instructor);
        void Delete(DeleteInstructorRequest instructor);
        void Update(UpdateInstructorRequest instructor);
        List<GetAllInstructorResponse> GetAll();
        GetByIdInstructorResponse GetById(int id);
    }
}
