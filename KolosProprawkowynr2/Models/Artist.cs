using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KolosProprawkowynr2.Models
{
    public class Artist
    {
        [Key]
        public int? IDArtist { get; set; }

        [MaxLength(30)]
        public string NickName { get; set; }

        public ICollection<Artist_Event> Events { get; set; }
    }
}
