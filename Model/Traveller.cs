using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace PSA_AB_YM_JS.Model
{
    public class Traveller
    {
        
        public string? GivenName { get; set; }
        public string? Surname{ get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.EmailAddress)]
        public string? email { get; set; }
        public string? postcode { get; set; }

        public string? TheBookings { get; set; }
        public string? Password { get; set; }
    }
}
