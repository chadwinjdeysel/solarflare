
namespace solarflare.api.Entities {
    [Table("clients")]
    public class Client : BaseModel
    {
        [Column("name")]
        public string Name { get; set; }

        [Column("address")]
        public string Address { get; set; }

        [Column("client_type")]
        public ClientType ClientType { get; set; }

        [Column("contact_number")]
        public string ContactNumber { get; set; }

        [Column("contact_email_address")]
        public string ContactEmailAddress { get; set; }

        [PrimaryKey("id")]
        public Guid Id { get; set; }

        public virtual ICollection<Entities.Kit> Kits { get; set; }

        public virtual ICollection<Entities.Incident> Incidents { get; set; }
    }
}