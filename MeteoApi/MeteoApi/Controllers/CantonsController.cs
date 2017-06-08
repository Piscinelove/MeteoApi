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
using MeteoApi;

namespace MeteoApi.Controllers
{
    public class CantonsController : ApiController
    {
        private ModelContainer db = new ModelContainer();


        // GET: api/Cantons
        public IQueryable<Canton> GetCantons()
        {

            var query = from canton in db.Cantons.OrderBy(c => c.Name )
                        select canton;
            return query;
          


        }

        // GET: api/Cantons/5
        [ResponseType(typeof(Canton))]
        public IHttpActionResult GetCanton(int id)
        {
            Canton canton = db.Cantons.Find(id);
            if (canton == null)

            {
                return NotFound();
            }

            return Ok(canton);
        }

        // PUT: api/Cantons/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCanton(int id, Canton c)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != c.Id)
            {
                return BadRequest();
            }

            Canton canton = db.Cantons.Where(ca => ca.Id == c.Id).First();
            canton.Name = c.Name;


            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CantonExists(id))
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

        // POST: api/Cantons
        [ResponseType(typeof(Canton))]
        public IHttpActionResult PostCanton(Canton canton)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Cantons.Add(canton);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = canton.Id }, canton);
        }

        // DELETE: api/Cantons/5
        [ResponseType(typeof(Canton))]
        public IHttpActionResult DeleteCanton(int id)
        {
            Canton canton = db.Cantons.Find(id);
            if (canton == null)
            {
                return NotFound();
            }

            db.Cantons.Remove(canton);
            db.SaveChanges();

            return Ok(canton);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CantonExists(int id)
        {
            return db.Cantons.Count(e => e.Id == id) > 0;
        }
    }
}