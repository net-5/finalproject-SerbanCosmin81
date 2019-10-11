using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class SponsorTypesViewModel
    {
        public int Id { get; set; }
        
        [MinLength(2)]
        public string Name { get; set; }
        public int Order { get; set; }
        
        public string Edition { get; set; }

        public virtual ICollection<Sponsors> Sponsors { get; set; }


    }
}
