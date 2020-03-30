using System.Collections.Generic;

namespace Travel.Models
{
  public class Review
  {
    public int ReviewId {get; set;}
    public int Rating {get; set;}
    public string Description {get; set;}
    public Destination Destination {get; set;}

  }
}