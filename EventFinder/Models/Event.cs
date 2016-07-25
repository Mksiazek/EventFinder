using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EventFinder.Models
{
  public class Event
  {
    public int Id { get; set; }
    public ApplicationUser Owner { get; set; }

    public DateTime DateTime { get; set; }

    public string Venue { get; set; }
    public Sport Sport { get; set; }
  }
}