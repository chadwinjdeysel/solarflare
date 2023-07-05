
namespace solarflare.api.Models {
    public class Kit : DomainModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Models.Component> Components { get; set; }
    }      
}
