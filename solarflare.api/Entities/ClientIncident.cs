[Table("client_incidents")]
public class ClientIncident : BaseModel
{
    [PrimaryKey("incident_id")]
    public Guid IncidentId { get; set; }

    [PrimaryKey("client_id")]
    public Guid ClientId { get; set; }
}