using System;
using System.Collections.Generic;

namespace StatePark.Models
{
  public class Park
  {
    public Park()
    {
      this.JoinEntities = new HashSet<ParkRegion>();
    }
    public int ParkId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<ParkRegion> JoinEntities { get; }
    public string Type { get; set; }
    public bool Camping { get; set; }
    public string NearestCity { get; set; }
  }
}