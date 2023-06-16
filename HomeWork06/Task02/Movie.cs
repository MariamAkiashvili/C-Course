namespace MyMovies
{
    public class Movie
    {
        private string _title;
        private string _description;
        private int _releaseYear;
        private string _director;

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public int ReleaseYear
        {
            get { return _releaseYear; }
            set { _releaseYear = value; }
        }

        public string Director
        {
            get { return _director; }
            set { _director = value; }
        }
    }

}
