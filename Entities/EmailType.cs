using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class EmailType : BaseEntity
    {
        [Required]
        public string Title { get; set; }
    }
}