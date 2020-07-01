using KolosProprawkowynr2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolosProprawkowynr2.Services
{
    public class DbService : IDbService
    {
        //public
        ArtistDbContext _context;

        public DbService(ArtistDbContext context)
        {
            this._context = context;
        }

        public Artist_Event GetArtist(int id)
        {
            try
            {
                return null;
            }
            catch(SqlException)
            {
                return null;
            }
        }
    }
}
