using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Demographic : BaseEntity
    {
        [Required]
        public string AddressLine { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string PostalCode { get; set; }
        
        public ICollection<ContactNumber> ContactNumber { get; set; }
        public ICollection<Email> Email { get; set; }
    }
}