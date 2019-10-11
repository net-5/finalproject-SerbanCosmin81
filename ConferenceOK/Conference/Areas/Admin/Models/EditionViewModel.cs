using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Conference.Areas.Admin.Models
{
    public class EditionViewModel
    {
       
        public int Id { get; set; }

 
        [MinLength(2, ErrorMessage="Name can't be less than 2 characters")]
        public string Name { get; set; }
        
        [DisplayName("Tag Line")]
        public string TagLine { get; set; }
        
        [Range(2010,2019)]
       
        public int Year { get; set; }
       
        public bool Active { get; set; }

    }
}
