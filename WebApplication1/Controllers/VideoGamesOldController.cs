﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class VideoGamesOldController : ApiController
    {
        private VideoGame[] vgs = new VideoGame[]
        {
            new VideoGame { Id = 1, System = Platform.SegaGenesis, Title = "Sonic 3" },
            new VideoGame { Id = 2, System = Platform.SegaGenesis, Title = "Dynamite Headdy" },
            new VideoGame { Id = 666, System = Platform.Pc, Title = "Doom II" },
        };

        public IEnumerable<VideoGame> GetAllVideoGames()
        {
            return vgs;
        }

        public IEnumerable<VideoGame> GetGenesisVideoGames()
        {
            return vgs.Where(p => p.System == Platform.SegaGenesis);
        }

        public IHttpActionResult GetVideoGame(int id)
        {
            var vg = vgs.FirstOrDefault(p => p.Id == id);
            if (vg == null) { return NotFound(); }
            return Ok(vg);
        }
    }
}
