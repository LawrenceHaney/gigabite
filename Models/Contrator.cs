using System.ComponentModel.DataAnnotations;

namespace gigabite.Models
{
  public class Contractor
  {
    public int Id {get; set;}
    [Required]
    [MinLength(3)]
    public string Name {get; set;}
    public string Address {get; set;}
    public string Contact {get; set;}
    public string Skills {get; set;}
  }
}
