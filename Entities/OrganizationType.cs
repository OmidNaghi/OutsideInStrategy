using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class OrganizationType : BaseEntity
    {
        [Required]
        public string Title { get; set; }
    }
}