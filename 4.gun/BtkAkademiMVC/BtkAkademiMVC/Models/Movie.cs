namespace BtkAkademiMVC.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string movieName { get; set; }
        public string category { get; set; }

        public string movieLength { get; set; }

        public string publishedDate { get; set; }

        public string image { get; set; }
    }
}
