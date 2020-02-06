using System;
namespace Lab_4._2
{
    public class Movie
    {
        private string title;
        private string genre;

        

        public string Title { get => title; set => title = value; }
        public string Genre { get => genre; set => genre = value; }



        public Movie(string title, string genre)
        {
            this.title = title;
            this.genre = genre;
        }

        public override string ToString()
        {
            return string.Format("{0,16} {1,8}", title, genre);
        }
    }
}
