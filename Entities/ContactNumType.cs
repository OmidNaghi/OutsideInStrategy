using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ContactNumType : BaseEntity
    {
        [Required]
        public string Title { get; set; }
    }
}