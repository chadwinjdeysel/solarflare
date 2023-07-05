
namespace solarflare.api.Entities {
    [Table("client_kits")]
    public class ClientKit : BaseModel
    {
        [PrimaryKey("client_id")]
        public Guid ClientId { get; set; }

        [PrimaryKey("kit_id")]
        public Guid KitId { get; set; }
    }
}