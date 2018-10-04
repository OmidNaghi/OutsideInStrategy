using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class ProjectType
    {
        [Required]
        public string Title { get; set; }
    }
}