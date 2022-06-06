#nullable disable
using eMovie.Models.Data.Base;
using eMovie.Models.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eMovie.Models
{
    public class Movie : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }

        public double Price { get; set; }

        public string ImageURL { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public MovieCategory MovieCategory { get; set; } //enum

        public List<Actor_Movie> Actors_Movies { get; set; }

        public int TheaterId { get; set; }
        [ForeignKey("TheaterId")]

        public Theaters Theaters { get; set; }

        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]

        public Producer Producer{ get; set; }
        //public object Actors_Movies { get; internal set; }
    }
}
