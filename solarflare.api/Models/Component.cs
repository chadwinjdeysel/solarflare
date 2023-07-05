namespace solarflare.api.Models {
    public class Component : DomainModel
    {
        public ComponentType ComponentType { get; set; }

        public decimal Price { get; set; }

        public string Name { get; set; }

        public Guid Id { get; set; }
    }
}