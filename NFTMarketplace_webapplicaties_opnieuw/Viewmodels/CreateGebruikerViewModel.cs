using System;
using System.ComponentModel.DataAnnotations;

namespace NFTMarketplace_webapplicaties_opnieuw.Viewmodels
{
    public class CreateGebruikerViewModel
    {
        public string Naam { get; set; }
        public string UserName { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
