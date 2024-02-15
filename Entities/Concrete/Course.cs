using Kodlama.io.Simulation.Entities.Abstract;

namespace Kodlama.io.Simulation.Entities.Concrete
{
    //Çıplak class kalmasın.
    public class Course : IEntity
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CompletionRate { get; set; }       
        public string Price { get; set; }       
        public Category Category { get; set; }
        public Instructor Instructor { get; set; }

        public Course()
        {
            
        }

        public Course(int id, int categoryId, int instructorId, string courseName, string description, 
            string completionRate, string price, string imageUrl)
        {
            Id = id;
            CategoryId = categoryId;
            InstructorId = instructorId;
            Name = courseName;
            Description = description;
            CompletionRate = completionRate;  
            Price = price;
            ImageUrl = imageUrl;
        }
    }
}
