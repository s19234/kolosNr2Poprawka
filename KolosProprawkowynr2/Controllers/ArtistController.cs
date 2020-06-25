using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KolosProprawkowynr2.Models;
using KolosProprawkowynr2.Services;
using Microsoft.AspNetCore.Mvc;

namespace KolosProprawkowynr2.Controllers
{
    [Route("api/artists")]
    public class ArtistController : ControllerBase
    {
        private IDbService _service;

        public ArtistController(IDbService _service)
        {
            this._service = _service;
        }

        [HttpGet("{id}")]
        public IActionResult GetArtist(int id)
        {
           /* Artist value = _service.GetArtist(id);
            if (value != null)
            {
                Artist_Event artist_Event = _service.
                return Ok();
            }*/
                

            return NotFound("Artist not found");
        }
    }
}