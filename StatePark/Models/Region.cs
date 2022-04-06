using System;
using System.Collections.Generic;

namespace StatePark.Models
{
  public class Region
  {
    public Region()
    {
      this.JoinEntities = new HashSet<ParkRegion>();
    }
    public int RegionId { get; set; }
    public string Name { get; set; }

    public virtual ICollection<ParkRegion> JoinEntities { get; }

  }
}