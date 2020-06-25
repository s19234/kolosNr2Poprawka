using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolosProprawkowynr2.Models
{
    public class ArtistDbContext :DbContext
    {
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Organizer> Organizers { get; set; }
        public DbSet<Artist_Event> Artist_Events { get; set; }

        public ArtistDbContext()
        { }

        public ArtistDbContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder model)
        {
            base.OnModelCreating(model);

            var artists = new List<Artist>
            {
                new Artist
                {
                    IDArtist = 1,
                    NickName = "DiStefano"
                },
                new Artist
                {
                    IDArtist = 2,
                    NickName = "DandaPerszo"
                },
                new Artist
                {
                    IDArtist = 3,
                    NickName = "BananaWhite"
                }
            };


            var events = new List<Event>
            {
                new Event
                {
                    IdEvent = 1,
                    Name = "DiscoPoloWLesie"
                },
                new Event
                {
                    IdEvent = 2,
                    Name = "RapDlaPrzedszkolaków"
                },
                new Event
                {
                    IdEvent = 3,
                    Name = "RockAndRollWKlubieSeniora"
                }
            };

            var organizers = new List<Organizer>
            {
                new Organizer
                {
                    IdOrganiser = 1,
                    Name = "LasyPaństwowe"
                },
                new Organizer
                {
                    IdOrganiser = 2,
                    Name = "Przedszkole nr 3"
                },
                new Organizer
                {
                    IdOrganiser = 3,
                    Name = "Klub Seniora"
                }
            };

            var events1 = new List<Artist_Event>
            {
                new Artist_Event
                {
                    id = 1,
                    IdEvent = 1,
                    IdArtist = 2,
                }
            };

            model.Entity<Artist>().HasData(artists);
            model.Entity<Event>().HasData(events);
            model.Entity<Organizer>().HasData(organizers);
            model.Entity<Artist_Event>().HasData(events1);
        }
    }
}
