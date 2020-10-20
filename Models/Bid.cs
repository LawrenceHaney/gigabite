using System.ComponentModel.DataAnnotations;

namespace gigabite.Models
{
  public class Bid
  {
    public int Id {get; set;}
    [Required]
    [MinLength(3)]
    public int ContractorId {get; set;}
    public int JobId {get; set;}
    public double BidAmount {get; set;}
  }
}