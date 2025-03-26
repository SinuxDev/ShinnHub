namespace FreelancePlatform.Models
{
    public class Client
    {
        public int ClientID { get; set; }
        public string? ClientName { get; set; }
        public string? ClientEmail { get; set; }
        public string? ClientCompany { get; set; }
        public string? ClientIndustry { get; set; }
        public int RelatedUser { get; set; }
    }
}
