#nullable disable
using eMovie.Models.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eMovie.Models
{
    public class Theaters : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Logo")]
        [Required(ErrorMessage = "Logo is required")]
        public string Logo { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }

        public List<Movie> Movies { get; set; }
    }
}
