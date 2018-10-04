using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ContactNumber: BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public ContactNumType ContactNumType { get; set; }
    }
}