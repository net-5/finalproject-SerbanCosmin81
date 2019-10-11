using Conference.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Models
{
    public class SponsorViewModel
    {

        public int Id { get; set; }
        [Required]
        [MinLength(2)]
        public string Name { get; set; }
        public string Website { get; set; }
        public string Facebook { get; set; }
        [Required]
        [MaxLength(20)]
        public string Description { get; set; }
        public string PageSlug { get; set; }
        [Required]
        public int SponsorTypeId { get; set; }
        public bool Active { get; set; }
        [Required]
        public string Edition { get; set; }

        public virtual SponsorTypes SponsorType { get; set; }
        public virtual ICollection<SponsorPhoto> SponsorPhoto { get; set; }



    }
}
