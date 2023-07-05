namespace solarflare.api.Entities {
    [Table("component_kits")]
    public class ComponentKit : BaseModel
    {
        [PrimaryKey("component_id")]
        public Guid ComponentId { get; set; }

        [PrimaryKey("kit_id")]
        public Guid KitId { get; set; }

        [Column("quantity")]
        public short Quantity { get; set; }
    }
}