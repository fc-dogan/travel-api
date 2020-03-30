using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Travel.Models
{
  public class Review
  {
    public int ReviewId {get; set;}
    [Required]
    [StringLength(20)]
    public string Author {get; set;}
    [Required]
    public int Rating {get; set;}
    [Required]
    public string Description {get; set;}
    public int DestinationId {get; set;}
    public Destination Destination {get; set;}

  }
}