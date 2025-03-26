namespace FreelancePlatform.Models
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string? ProjectTitle { get; set; }
        public string? ProjectDescription { get; set; }
        public decimal ProjectBudget { get; set; }
        public string? ProjectDeadline { get; set; }
        public string? ProjectSkills { get; set; }
        public int RelatedClientID { get; set; }
        public int isDone { get; set; }
        public int isApply { get; set; }
    }
}
