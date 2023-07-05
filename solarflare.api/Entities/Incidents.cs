namespace solarflare.api.Entities {
    [Table("incidents")]
    public class Incident : BaseModel
    {
        [Column("date_updated")]
        public DateTime DateUpdated { get; set; }

        [Column("incident_status")]
        public IncidentStatus IncidentStatus { get; set; }

        [Column("incident_type")]
        public IncidentType IncidentType { get; set; }

        [PrimaryKey("id")]
        public Guid Id { get; set; }

        [Column("incident_number")]
        public string IncidentNumber { get; set; }

        [Column("description")]
        public string Description { get; set; }

        [Column("date_reported")]
        public DateTime DateReported { get; set; }

        public virtual ICollection<Entities.Incident> Incidents { get; set; }

        public virtual ICollection<Entities.Client> Clients { get; set; }
    }
}