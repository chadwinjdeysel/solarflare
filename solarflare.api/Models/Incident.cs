namespace solarflare.api.Models
{
    public class Incident : DomainModel
    {
        public DateTime DateUpdated { get; set; }

        public IncidentStatus IncidentStatus { get; set; }

        public IncidentType IncidentType { get; set; }

        public Guid Id { get; set; }

        public string IncidentNumber { get; set; }

        public string Description { get; set; }

        public DateTime DateReported { get; set; }

        public virtual ICollection<Models.Incident> Incidents { get; set; }

        public virtual ICollection<Models.Client> Clients { get; set; }
    }
}