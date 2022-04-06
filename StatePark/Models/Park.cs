using System;
using System.Collections.Generic;

namespace StatePark.Models
{
  public class Park
  {
    public Park()
    {
    }
    public int ParkId { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public bool Camping { get; set; }
    public string NearestCity { get; set; }
    public int RegionId { get; set; }
  }
}