namespace solarflare.api.Entities { 
    [Table("components")]
    public class Component : BaseModel
    {
        [Column("component_type")]
        public ComponentType ComponentType { get; set; }

        [Column("price")]
        public decimal Price { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [PrimaryKey("id")]
        public Guid Id { get; set; }

        public virtual ICollection<Entities.Kit> Kits { get; set; }
    }
}