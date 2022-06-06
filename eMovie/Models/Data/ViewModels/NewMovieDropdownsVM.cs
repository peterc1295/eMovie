namespace eMovie.Models.Data.ViewModels
{
    public class NewMovieDropdownsVM
    {
        public NewMovieDropdownsVM()
        {
            Producers = new List<Producer>();
            Theaters = new List<Theaters>();
             Actors = new List<Actor>();
        }
        public List<Producer> Producers { get; set; }
        public List<Theaters> Theaters { get; set; }
        public List<Actor> Actors { get; set; }

    }
}
