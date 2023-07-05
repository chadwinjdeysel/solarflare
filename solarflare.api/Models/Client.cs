namespace solarflare.api.Models
{
    public class Client : DomainModel
    {
        public string Name { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;

        public ClientType ClientType { get; set; }

        public string ContactNumber { get; set; } = string.Empty;

        public string ContactEmailAddress { get; set; } = string.Empty;

        public Guid Id { get; set; }

        public virtual ICollection<Models.Kit> Kits { get; set; }
    }
}