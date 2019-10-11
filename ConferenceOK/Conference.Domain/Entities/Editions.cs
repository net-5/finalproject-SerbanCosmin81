using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Conference.Domain.Entities
{
    public partial class Editions
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [DisplayName("Tag Line")]
        public string TagLine { get; set; }
        public int Year { get; set; }
        public bool Active { get; set; }
    }
}
