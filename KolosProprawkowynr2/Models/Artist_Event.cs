using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KolosProprawkowynr2.Models
{
    public class Artist_Event
    {
        public int? id { get; set; }

        [ForeignKey("IdEvent")]
        public int? IdEvent { get; set; }


        [ForeignKey("IdArtist")]
        public int? IdArtist { get; set; }
        public DateTime PerformanceDate { get; set; }

        public Artist Artist { get; set; }

        public Event Event { get; set; }
    }
}
