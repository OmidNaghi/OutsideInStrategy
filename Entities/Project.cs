using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Project : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public ProjectType ProjectType { get; set; }
    }
}
