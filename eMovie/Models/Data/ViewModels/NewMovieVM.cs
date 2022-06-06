#nullable disable
using eMovie.Models.Data.Base;
using eMovie.Models.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMovie.Models
{
    public class NewMovieVM 
    {
        public int Id { get; set; }
        [Display(Name = "Movie name")]
        [Required(ErrorMessage="Name is required")]
        public string Name { get; set; }

        [Display(Name = "Movie desscription")]
        [Required(ErrorMessage = "Description is required")]
        public string Description{ get; set; }

        [Display(Name = "Movie price")]
        [Required(ErrorMessage = "Price is required")]
        public double Price { get; set; }

        [Display(Name = "Movie image")]
        [Required(ErrorMessage = "Image is required")]
        public string ImageURL { get; set; }

        [Display(Name = "Movie start date")]
        [Required(ErrorMessage = "Start date is required")]

        public DateTime StartDate { get; set; }
        [Display(Name = "Movie end date")]
        [Required(ErrorMessage = "End date is required")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Movie genre")]
        [Required(ErrorMessage = "Genre is required")]
        public MovieCategory MovieCategory { get; set; } //enum

        [Display(Name = "Select actor(s)")]
        [Required(ErrorMessage = "Actor(s) is required")]
        public List<int> ActorsIds { get; set; }

        [Display(Name = "Select a theater")]
        [Required(ErrorMessage = "Theater is required")]
        public int TheaterId { get; set; }

        [Display(Name = "Select a director")]
        [Required(ErrorMessage = "Director is required")]
        public int ProducerId { get; set; }

    }
}
