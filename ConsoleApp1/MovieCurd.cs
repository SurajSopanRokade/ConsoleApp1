using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string Name { get; set; }
        public double TicketCost { get; set; }
        public string ProducerName { get; set; }

        public Movie(int movieId, string name, double ticketCost, string producerName)
        {
            MovieId = movieId;
            Name = name;
            TicketCost = ticketCost;
            ProducerName = producerName;
        }
    }


    public class MovieArray
    {

        private Movie[] movies;
        private int size;
        private const int CapacityIncrement = 10;

        public MovieArray()
        {

            movies = new Movie[CapacityIncrement];
            size = 0;
        }

        public void Insert(Movie movie)
        {

            if (size >= movies.Length)
            {
                Array.Resize(ref movies, movies.Length + CapacityIncrement);
            }

            movies[size++] = movie;
        }

        public void Update(int movieId, Movie updatedMovie)
        {

            for (int i = 0; i < size; i++)
            {
                if (movies[i].MovieId == movieId)
                {
                    movies[i] = updatedMovie;
                    return;
                }
            }
            Console.WriteLine($"Movie with ID {movieId} not found.");

        }

        public void Delete(int movieId)
        {

            for (int i = 0; i < size; i++)
            {
                if (movies[i].MovieId == movieId)
                {
                    for (int j = i; j < size - 1; j++)
                    {
                        movies[j] = movies[j + 1];
                    }
                    size--;
                    movies[size] = null;
                    return;
                }
            }
            Console.WriteLine($"Movie with ID {movieId} not found.");

        }

        public void DisplayByID(int movieId)
        {

            for (int i = 0; i < size; i++)
            {
                if (movies[i].MovieId == movieId)
                {
                    Console.WriteLine($"Movie ID: {movies[i].MovieId}, Name: {movies[i].Name}, Ticket Cost: {movies[i].TicketCost}, Producer: {movies[i].ProducerName}");
                    return;

                }

            }
            Console.WriteLine($"Movie with ID {movieId} not found.");

        }

        public void DisplayAll()
        {
            foreach (var movie in movies)
            {
                if (movie != null)
                {
                    Console.WriteLine($"Movie ID: {movie.MovieId}, Name: {movie.Name}, Ticket Cost: {movie.TicketCost}, Producer: {movie.ProducerName}");
                }
            }
        }

        public void SearchByMovieName(string movieName)
        {
            foreach (var movie in movies)
            {
                if (movie!=null && movie.Name == movieName)
                {
                    Console.WriteLine($"Movie ID: {movie.MovieId}, Name: {movie.Name}, Ticket Cost: {movie.TicketCost}, Producer: {movie.ProducerName}");
                }
            }
            
        }


    }

    public class PerformCRUDMoviesArray
    {

        
        
            static void Main(string[] args)
            {
                MovieArray movies = new MovieArray();

                movies.Insert(new Movie(1, "Bahubali", 499, " S.S.Rajamouli"));
                movies.Insert(new Movie(2, "3 Idiots", 350, "Rajkumar Hirani"));
                movies.Insert(new Movie(3, "Avengers Endgame", 500, "Walt Disney Studios Motion Pictures"));
                movies.Insert(new Movie(4, "oppenheimer", 550, "Universal Pictures"));

                int choice;
                do
                {
                    Console.WriteLine("1. Insert Movie");
                    Console.WriteLine("2. Update Movie");
                    Console.WriteLine("3. Delete Movie");
                    Console.WriteLine("4. Display Movie by ID");
                    Console.WriteLine("5. Display All Movies");
                    Console.WriteLine("6. Search by Movie name");
                    Console.WriteLine("7. Exit");
                    Console.Write("Enter your choice: ");

                    choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {

                        case 1:
                            Console.Write("Enter Movie ID: ");
                            int id = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter Movie Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Enter Ticket Cost: ");
                            double ticketCost = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter Producer Name: ");
                            string producerName = Console.ReadLine();
                            movies.Insert(new Movie(id, name, ticketCost, producerName));
                            break;

                        case 2:
                            Console.Write("Enter Movie ID to update: ");
                            int updateId = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Enter New Movie Name: ");
                            string newName = Console.ReadLine();
                            Console.Write("Enter New Ticket Cost: ");
                            double newTicketCost = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter New Producer Name: ");
                            string newProducerName = Console.ReadLine();
                            movies.Update(updateId, new Movie(updateId, newName, newTicketCost, newProducerName));
                            break;

                        case 3:
                            Console.Write("Enter Movie ID to delete: ");
                            int deleteId = Convert.ToInt32(Console.ReadLine());
                            movies.Delete(deleteId);
                            break;

                        case 4:
                            Console.Write("Enter Movie ID to display: ");
                            int displayId = Convert.ToInt32(Console.ReadLine());
                            movies.DisplayByID(displayId);
                            break;

                        case 5:
                            Console.WriteLine("All Movies:");
                            movies.DisplayAll();
                            break;
                        
                        case 6:
                            Console.WriteLine("Enter movie name...");
                            string movieName=Console.ReadLine();
                            movies.SearchByMovieName(movieName);
                            break;

                        case 7:
                            Console.WriteLine("Exiting...");
                            break;


                        default:
                            Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                            break;

                    }

                } while (choice>0 || choice<=7);

            }
        }
    }

