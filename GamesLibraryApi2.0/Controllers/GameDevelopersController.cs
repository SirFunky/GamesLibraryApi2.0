using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using GamesLibraryApi2._0.Models;

namespace GamesLibraryApi2._0.Controllers
{
    public class GameDevelopersController : ApiController
    {
        private GamesDBEntities db = new GamesDBEntities();

        // GET: api/GameDevelopers
        public IQueryable<GameDeveloper> GetGameDevelopers()
        {
            return db.GameDevelopers;
        }

        // GET: api/GameDevelopers/5
        [ResponseType(typeof(GameDeveloper))]
        public IHttpActionResult GetGameDeveloper(int id)
        {
            GameDeveloper gameDeveloper = db.GameDevelopers.Find(id);
            if (gameDeveloper == null)
            {
                return NotFound();
            }

            return Ok(gameDeveloper);
        }

        // PUT: api/GameDevelopers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutGameDeveloper(int id, GameDeveloper gameDeveloper)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != gameDeveloper.GameId)
            {
                return BadRequest();
            }

            db.Entry(gameDeveloper).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GameDeveloperExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/GameDevelopers
        [ResponseType(typeof(GameDeveloper))]
        public IHttpActionResult PostGameDeveloper(GameDeveloper gameDeveloper)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.GameDevelopers.Add(gameDeveloper);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (GameDeveloperExists(gameDeveloper.GameId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = gameDeveloper.GameId }, gameDeveloper);
        }

        // DELETE: api/GameDevelopers/5
        [ResponseType(typeof(GameDeveloper))]
        public IHttpActionResult DeleteGameDeveloper(int id)
        {
            GameDeveloper gameDeveloper = db.GameDevelopers.Find(id);
            if (gameDeveloper == null)
            {
                return NotFound();
            }

            db.GameDevelopers.Remove(gameDeveloper);
            db.SaveChanges();

            return Ok(gameDeveloper);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool GameDeveloperExists(int id)
        {
            return db.GameDevelopers.Count(e => e.GameId == id) > 0;
        }
    }
}