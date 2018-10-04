using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class OfficialOrganization : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public OrganizationType OrganizationType { get; set; }
        public int? ParentId { get; set; }
    }
}
