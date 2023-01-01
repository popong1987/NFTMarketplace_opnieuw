using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace NFTMarketplace_webapplicaties_opnieuw.Models
{
    public class Creator
    {
        public int CreatorId { get; set; }

        [Required]
        public string Voornaam { get; set; }

        [Required]
        public string Achternaam { get; set; }
        public string Pseudoniem { get; set; }
        public string Biografie { get; set; }

        //navigation properties

        public ICollection<CollectieCreator> CollectieCreators { get; set; }
    }
}
