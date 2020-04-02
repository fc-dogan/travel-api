using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Travel.Models;
using Travel.Services;
using Microsoft.AspNetCore.Authorization;

namespace Travel.Controllers
{
  [ApiVersion("1.0")]
  [Route("api/[controller]")]
  [ApiController]
  public class ReviewsController : ControllerBase
  {
    private TravelContext _db;
    private IUserService _userService;

    public ReviewsController(TravelContext db, IUserService userService)
    {
      _db = db;
      _userService = userService;
    }

    
    [HttpGet]
    public ActionResult<IEnumerable<Review>> Get(string country, string city, int rating, string description)
    {
      var query = _db.Reviews.AsQueryable();
      if (country != null)
      {
        query = query.Where(entry => entry.Country == country);
      }
      if (city != null)
      {
        query = query.Where(entry => entry.City == city);
      }
       if (rating != 0 )
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      if (description != null)
      {
        query = query.Where(entry => entry.Description == description);
      }

      return query.ToList();
    }

    // [HttpGet] 
    // public ActionResult<IEnumerable<Review>> GetRandom()
    // {
    //   var query = _db.Reviews.AsQueryable();
    //   Random rand = new Random();
    //   int randomId = rand.Next(query.Count<Review>());
    //   query = query.Where(r => r.ReviewId == randomId);
    //   return query.ToList();
    // }

  //  [Authorize]
    [HttpPost]
    public void Post([FromBody] Review review)
    {
      _db.Reviews.Add(review);
      _db.SaveChanges();
    }

   
    [HttpGet("{id}")]
    public ActionResult<Review> Get(int id)
    {
      return _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
    }

    // [Authorize]
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Review review)
    {
      review.ReviewId = id;
      _db.Entry(review).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // [Authorize]  
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var reviewToDelete = _db.Reviews.FirstOrDefault(entry => entry.ReviewId == id);
      _db.Reviews.Remove(reviewToDelete);
      _db.SaveChanges();
    }
  }
}    