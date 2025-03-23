namespace FreelancePlatform.Models
{
    public class ProjectRequest
    {

        public int ID { get; set; }
        public int RelatedProject { get; set; }
        public string? RelatedProjectTitle { get; set; }
        public int RelatedFreelancer { get; set; }
        public string? Status { get; set; }

    }
}
