using System.ComponentModel.DataAnnotations;

namespace gigabite.Models
{
    public class Job
    {
      public int Id {get; set;}
      [Required]
      [MinLength(3)]
      public string Location {get; set;}
      public string Description {get; set;}
      public string Contact {get; set;}

      public int Hours {get; set;}
    }
}