using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Email : BaseEntity
    {
        [Required]
        public string Tile { get; set; }
        [Required]
        public EmailType EmailType { get; set; }
    }
}