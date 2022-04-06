namespace StatePark.Models
{
  public class ParkRegion
  {
    public int ParkRegionId { get; set; }
    public int ParkId { get; set; }
    public int RegionId { get; set; }
    public virtual Park Park { get; set; }
    public virtual Region Region { get; set; }
  }
}