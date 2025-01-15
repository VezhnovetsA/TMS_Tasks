namespace HTcinema
{
    internal class Movies
    {
        private Dictionary<string, string> movies = new Dictionary<string, string>()
       {
             {"Дюна", "Фантастика"},
             {"Круэлла", "Комедия"},
             {"Алита", "Боевик"},
             {"Интерстеллар", "Фантастика"},
             {"Начало", "Триллер"},
             {"Матрица", "Фантастика"},
             {"Джокер", "Драма"},
             {"Аватар", "Фантастика"},
             {"Гарри Поттер", "Фэнтези"},
             {"Темный рыцарь", "Боевик"}

        };

        public void ShowAllMovies()
        {
            Console.WriteLine("Список фильмов в прокате: \n");

            foreach (var movie in movies)
            {
                Console.WriteLine($"Название фильма: {movie.Key}, Жанр: {movie.Value}");
            }
        }

        public void ShowAllThatGenreMovies(string genre)
        {
            Console.WriteLine($"Список фильмов жанра {genre}: \n");

            foreach (var movie in movies)
            {
                if (movie.Value.Contains(genre))
                Console.WriteLine($"Название фильма: {movie.Key}");

            }
        }
        public void AddMovie(string name, string genre) //?
        {
            movies.Add(name, genre);
        }

        public void RemoveMovie(string name) //?
        {
            movies.Remove(name);
        }

        public Dictionary<string, string> GetMoviesDictionary()
        {
            return movies;
        }

    }
}
