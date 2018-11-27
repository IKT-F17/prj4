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
using TDDB.Models;

namespace TDDB.Controllers
{
    public class MapsController : ApiController
    {
        private TDDBContext db = new TDDBContext();

        // GET: api/Maps
        public IQueryable<Map> GetMaps()
        {
            return db.Maps;
        }

        // GET: api/Maps/5
        [ResponseType(typeof(Map))]
        public IHttpActionResult GetMap(string id)
        {
            Map map = db.Maps.Find(id);
            if (map == null)
            {
                return NotFound();
            }

            return Ok(map);
        }

        // PUT: api/Maps/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutMap(string id, Map map)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != map.MapName)
            {
                return BadRequest();
            }

            db.Entry(map).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MapExists(id))
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

        // POST: api/Maps
        [ResponseType(typeof(Map))]
        public IHttpActionResult PostMap(Map map)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Maps.Add(map);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (MapExists(map.MapName))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = map.MapName }, map);
        }

        // DELETE: api/Maps/5
        [ResponseType(typeof(Map))]
        public IHttpActionResult DeleteMap(string id)
        {
            Map map = db.Maps.Find(id);
            if (map == null)
            {
                return NotFound();
            }

            db.Maps.Remove(map);
            db.SaveChanges();

            return Ok(map);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MapExists(string id)
        {
            return db.Maps.Count(e => e.MapName == id) > 0;
        }
    }
}