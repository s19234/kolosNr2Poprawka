using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KolosProprawkowynr2.Models
{
    public class Event_Organiser
    {
        public int? id { get; set; }

        [ForeignKey("Event")]
        public int? IdEvent { get; set; }


        [ForeignKey("IdOrganiser")]
        public int? IdOrganiser { get; set; }

        public Event Event { get; set; }

        public Organizer Organizer { get; set; }
    }
}
