using KolosProprawkowynr2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KolosProprawkowynr2.Services
{
    public interface IDbService
    {
        public Artist_Event GetArtist(int id);
    }
}
