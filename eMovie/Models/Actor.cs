#nullable disable
using eMovie.Models.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMovie.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        [Required(ErrorMessage = "Profile picture is required")]
        public string ProfilePicture { get; set; }
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full name is required")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
