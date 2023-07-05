namespace solarflare.api.Entities {
    [Table("kits")]
    public class Kit : BaseModel {
        [PrimaryKey("id")]
        public string Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("description")]
        public string Description { get; set; }

        public virtual ICollection<Entities.Component> Components { get; set; }
        public virtual ICollection<Entities.Client> Clients { get; set; }
    }
}

