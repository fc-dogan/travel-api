using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Models;

namespace Travel.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationsController : ControllerBase
  {
    private TravelContext _db;

    public DestinationsController(TravelContext db)
    {
      _db = db;
    }

    // GET api/Destination
    [HttpGet]
    public ActionResult<IEnumerable<Destination>> Get(string country, string city)
    {
      var query = _db.Destinations.AsQueryable();
      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }
       if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }

      return query.ToList();
      //  return query.Include(destination => destination.Reviews).ToList();
    }

    // POST api/Destination
    [HttpPost]
    public void Post([FromBody] Destination destination)
    {
      _db.Destinations.Add(destination);
      _db.SaveChanges();
    }

     [HttpGet("{id}")]
    public ActionResult<Destination> Get(int id)
    {
      return _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
    }

    // PUT api/destinations/3
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Destination destination)
    {
        destination.DestinationId = id;
        _db.Entry(destination).State = EntityState.Modified;
        _db.SaveChanges();
    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var destinationToDelete = _db.Destinations.FirstOrDefault(entry => entry.DestinationId == id);
      _db.Destinations.Remove(destinationToDelete);
      _db.SaveChanges();
    }
  }
}