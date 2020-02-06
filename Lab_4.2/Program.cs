using System;
using System.Collections.Generic;

namespace Lab_4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            bool flag = true;


            List<Movie> movieList = new List<Movie>();
            movieList.Add(new Movie("Cowboy BeBop", "Sci-Fi"));
            movieList.Add(new Movie("Interstella 5555", "Sci-Fi"));
            movieList.Add(new Movie("Serenity", "Sci-Fi"));
            movieList.Add(new Movie("Animatrix, The", "Sci-Fi"));
            movieList.Add(new Movie("Pulp Fiction", "Drama"));
            movieList.Add(new Movie("Resevoir Dogs", "Drama"));
            movieList.Add(new Movie("Memento", "Mystery"));
            movieList.Add(new Movie("The Game", "Mystery"));
            movieList.Add(new Movie("Kill Bill: Vol 1", "Action"));
            movieList.Add(new Movie("Kill Bill: Vol 2", "Action"));

            Console.WriteLine("Welcome to the Movie List Application!");
            Console.WriteLine();
            Console.WriteLine($"There are {movieList.Count} movies in this list");
            do
            {
                /**/
                Console.Write("What category are you interested in? ");
                input = Console.ReadLine();
                foreach (Movie m in movieList)
                {
                    if (m.Genre.Contains(input))
                    {
                        Console.WriteLine(m);
                    }
                }
                flag = GoAgain();

            } while (flag);

        }

        private static bool GoAgain()
        {
            char input = ' ';

            while(!"YyNn".Contains(input))
            {
                /**/
                Console.Write("Continue? (y/n) ");
                input = Console.ReadKey().KeyChar;
                Console.WriteLine();
                if ("YyNn".Contains(input))
                {
                    break;
                }
                Console.WriteLine("Invalid Input!");

            } 
            if ("Nn".Contains(input))
            {
                return false;
            }

            return true;
        }
    }
}
