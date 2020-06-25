using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolosProprawkowynr2.Models
{
    public class Event
    {
        [Key]
        public int? IdEvent { get; set; }

        [MaxLength(100)]
        public string Name { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public ICollection<Artist_Event> Artists { get; set; }
    }
}
