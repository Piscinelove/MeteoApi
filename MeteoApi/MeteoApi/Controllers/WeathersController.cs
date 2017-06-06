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
    public class WeathersController : ApiController
    {
        private ModelContainer db = new ModelContainer();

        // GET: api/Weathers
        public IQueryable<Weather> GetWeathers()
        {
            var query = from weather in db.Weathers.Include("City")
                        select weather;
            return query;
        }


        // GET: api/Weathers/5
        [ResponseType(typeof(Weather))]
        public IHttpActionResult GetWeather(int id)
        {
            Weather weather = db.Weathers.Find(id);
            if (weather == null)
            {
                return NotFound();
            }

            return Ok(weather);
        }

        // PUT: api/Weathers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWeather(int id, Weather weather)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != weather.Id)
            {
                return BadRequest();
            }

            db.Cities.Attach(weather.City);
            db.States.Attach(weather.State);

            db.Entry(weather).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WeatherExists(id))
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

        // POST: api/Weathers
        [ResponseType(typeof(Weather))]
        public IHttpActionResult PostWeather(Weather weather)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Cities.Attach(weather.City);
            db.States.Attach(weather.State);
            db.Weathers.Add(weather);

            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = weather.Id }, weather);
        }

        // DELETE: api/Weathers/5
        [ResponseType(typeof(Weather))]
        public IHttpActionResult DeleteWeather(int id)
        {
            Weather weather = db.Weathers.Find(id);
            if (weather == null)
            {
                return NotFound();
            }

            db.Weathers.Remove(weather);
            db.SaveChanges();

            return Ok(weather);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool WeatherExists(int id)
        {
            return db.Weathers.Count(e => e.Id == id) > 0;
        }
    }
}