using Kodlama.ioSimulation.Business.Dtos.Requests.CategoryRequests;
using Kodlama.ioSimulation.Business.Dtos.Responses.CategoryResponses;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        void Add(CreateCategoryRequest category);
        void Delete(DeleteCategoryRequest category);
        void Update(UpdateCategoryRequest category);
        List<GetAllCategoryResponse> GetAll();
        GetByIdCategoryResponse GetById(int id);
    }
}
