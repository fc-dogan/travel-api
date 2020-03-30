using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Models;

namespace Travel.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class DestinationController : ControllerBase
  {
    private TravelContext _db;

    public DestinationController(TravelContext db)
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
  }
}