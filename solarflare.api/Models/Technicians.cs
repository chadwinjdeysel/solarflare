namespace solarflare.api.Models
{
    public class Technician : DomainModel
    {
        public List<string> Qualifications { get; set; } 

        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string ContactNumber { get; set; }

        public virtual ICollection<Models.Incident> Incidents { get; set; }
    }
}