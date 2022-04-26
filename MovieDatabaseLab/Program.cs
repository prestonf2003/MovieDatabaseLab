using System.Linq;

namespace MovieDatabaseLab
{
    public class Program
    {
        public static void Main()
        {
            bool DidNotFuckUp = true;
            Movie thisMovie;
            while (true)
            {
                List<Movie> movieList = new List<Movie>();
                movieList.Add(new Movie("Star Wars", "Fantasy"));
                movieList.Add(new Movie("Enders Game", "Science Fiction"));
                movieList.Add(new Movie("The Mummy", "Action"));
                movieList.Add(new Movie("Daddy Day Care", "Comedy"));
                movieList.Add(new Movie("water Boy", "Comedy"));
                movieList.Add(new Movie("8 Mile", "Drama"));
                movieList.Add(new Movie("Poccahontas", "Animation"));
                movieList.Add(new Movie("A Cabin in the woods", "Horror"));
                movieList.Add(new Movie("Free Willy", "Drama"));
                movieList.Add(new Movie("Freaky Friday", "Comedy"));

                string Category = GetUserInput("Please enter a category for a movie");




                bool foundOne = false;
                for (int i = 0; i < movieList.Count; i++)
                {
                     thisMovie = movieList[i];
                    if (thisMovie.category == Category)
                    {
                        Console.WriteLine(thisMovie.title);
                        foundOne = true;
                    }
                }
                if (foundOne)
                {
                    break;
                }


            }

        }
        public static string GetUserInput(string prompt)
        {
            Console.WriteLine(prompt);
            string output = Console.ReadLine();
            return output;
        }
    }
}
