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
    public ActionResult<IEnumerable<Destination>> Get()
    {
      return _db.Destinations.ToList();
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

    // PUT api/destinations/5
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