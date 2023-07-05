namespace solarflare.api.Entities {
    [Table("technicians")]
    public class Technician : BaseModel
    {
        [Column("qualifications")]
        public List<string> Qualifications { get; set; } 

        [PrimaryKey("id")]
        public Guid Id { get; set; }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("contact_number")]
        public string ContactNumber { get; set; }

        public virtual ICollection<Entities.Incident> Incidents { get; set; }
    }
}