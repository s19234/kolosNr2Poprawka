using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolosProprawkowynr2.Models
{
    public class Organizer
    {
        [Key]
        public int? IdOrganiser { get; set; }
        
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
