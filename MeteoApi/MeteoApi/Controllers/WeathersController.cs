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
        [HttpGet]
        [Route("api/weathers")]
        public IQueryable<Weather> GetWeathers()
        {
            DateTime now = DateTime.Now.Date;
            var query = from weather in db.Weathers.Include("City").Where(w => w.Date >= now).OrderBy(w => w.Date)
                        select weather;
            return query;
        }

        [HttpGet]
        [Route("api/weathers/search/{city}")]
        public IQueryable<Weather> GetWeathersByCity(string city)
        {
            DateTime now = DateTime.Now.Date;
            var query = from weather in db.Weathers.Include("City").Where(w => w.City.Name.ToLower().Contains(city)).Where(w => w.Date >= now).OrderBy(w => w.Date)
                        select weather;
            return query;
        }


        // GET: api/Weathers/5
        [HttpGet]
        [Route("api/weathers/{id}")]
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
        [HttpPut]
        [Route("api/weathers/{id}")]
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWeather(int id, Weather w)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != w.Id)
            {
                return BadRequest();
            }



            Weather weather = db.Weathers.Where(we => we.Id == w.Id).First();
            db.Cities.Attach(w.City);
            db.States.Attach(w.State);
            weather.Date = w.Date;
            weather.TemperatureMin = w.TemperatureMin;
            weather.TemperatureMax = w.TemperatureMax;
            weather.Humidity = w.Humidity;
            weather.Precipitation = w.Humidity;
            weather.State = w.State;
            weather.City = w.City;

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
        [HttpPost]
        [Route("api/weathers")]
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
        [HttpDelete]
        [Route("api/weathers/{id}")]
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