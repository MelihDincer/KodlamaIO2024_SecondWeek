namespace Kodlama.ioSimulation.Business.Dtos.Requests.CourseRequests
{
    public class CreateCourseRequest
    {
        public int CategoryId { get; set; }
        public int InstructorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string CompletionRate { get; set; }
        public string Price { get; set; }
    }
}