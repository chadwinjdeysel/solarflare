namespace solarflare.api.Entities {
    [Table("technician_incidents")]
    public class TechnicianIncident : BaseModel
    {
        [PrimaryKey("incident_id")]
        public Guid IncidentId { get; set; }

        [PrimaryKey("technician_id")]
        public Guid TechnicianId { get; set; }
    }
}