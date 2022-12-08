using System.ComponentModel.DataAnnotations;

namespace NFTMarketplace_webapplicaties_opnieuw.Models
{
    public class CollectieCreator
    {
        public int CollectieCreatorId { get; set; }

        [Required]
        public int CreatorId { get; set; }

        [Required]
        public int CollectieId { get; set; }

        //navigation properties

        public Creator Creator { get; set; }
        public Collectie Collectie { get; set; }
    }
}
