using System.ComponentModel.DataAnnotations;

namespace gigabite.Models
{
  public class Review
  {
    public int Id {get; set;}
    [Required]
    [MinLength(3)]
    public string Title {get; set;}
    public string Body {get; set;}
    public string Rating {get; set;}
    public string Date {get; set;}

    public int ContractorId {get; set;}
  }
}