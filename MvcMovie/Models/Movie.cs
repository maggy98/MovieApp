using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Movie
    {
    [Key]
    public int Id { get; set; }
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Title { get; set; }
    [RegularExpression(@"(18|19|20)\d\d", ErrorMessage = "Given year is wrong.")]
    public string? ReleaseDate { get; set; }
    
    [StringLength(60, MinimumLength = 3)]
    [Required]
    public string? Genre { get; set; }

    [DataType(DataType.Date)]
    public  DateTime SystemDate  { get; set; } = DateTime.Now;

    }
}