using Kodlama.io.Simulation.Entities.Concrete;
using Kodlama.ioSimulation.DataAccess.Abstracts;

namespace Kodlama.ioSimulation.DataAccess.Concretes.InMemory
{
    public class ImCategoryDal : ICategoryDal
    {
        List<Category> categories;
        public ImCategoryDal()
        {
            Category category1 = new Category(1, "Tümü");
            Category category2 = new Category(2, "Programlama");
            categories = new List<Category> { category1, category2 };
        }
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(Category category)
        {
            var value = categories.FirstOrDefault(c => c.Id == category.Id);
            categories.Remove(category);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetById(int id)
        {
            return categories.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Category category)
        {
            var value = categories.FirstOrDefault(c => c.Id == category.Id);
            value.Id = category.Id;
            value.Name = category.Name;
        }
    }
}
