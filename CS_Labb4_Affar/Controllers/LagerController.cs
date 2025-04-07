using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CS_Labb4_Affar.Controllers;
using CS_Labb4_Affar.Models;

namespace CS_Labb4_Affar {
	public class LagerController {

		public int nextID = 1;
		public BindingList<Book> BooksTable { get; set; } = new BindingList<Book>();
		public BindingList<Game> GamesTable { get; set; } = new BindingList<Game>();
		public BindingList<Movie> MoviesTable { get; set; } = new BindingList<Movie>();

		public LagerController() {
			//AddBook(new Book(0, "Bello Gallico et Civili", 449, 0, "Julius Caesar", "Historia", "Inbunden", "Latin"));
			//AddBook(new Book(0, "How to Read a Book", 149, 0, "Mortimer J. Adler", "Kursliteratur", "Pocket", ""));
			//AddBook(new Book(0, "Moby Dick", 49, 0, "Herman Melville", "Äventyr", "Pocket", ""));
			//AddBook(new Book(0, "The Great Gatsby", 79, 0, "F. Scott Fitzgerald", "Noir", "E-Bok", ""));
			//AddBook(new Book(0, "House of Leaves", 49, 0, "Mark Z. Danielewski", "Skräck", "", ""));
			//AddGame(new Game(0, "Elden Ring", 599, 0, "Playstation 5"));
			//AddGame(new Game(0, "Demon's Souls", 499, 0, "Playstation 5"));
			//AddGame(new Game(0, "Microsoft Flight Simulator", 499, 0, "PC"));
			//AddGame(new Game(0, "Planescape Torment", 99, 0, "PC"));
			//AddGame(new Game(0, "Disco Elysium", 399, 0, "PC"));
			//AddMovie(new Movie(0, "Schindler's List", 99, 0, "DVD", 0));
			//AddMovie(new Movie(0, "Nyckeln till Frihet", 99, 0, "DVD", 142));
			//AddMovie(new Movie(0, "Gudfadern", 99, 0, "DVD", 152));
			//AddMovie(new Movie(0, "Konungens Återkomst", 199, 0, "Blu-Ray", 154));
			//AddMovie(new Movie(0, "Pulp Fiction", 199, 0, "Blu-Ray", 0));
			//MessageBox.Show("böcker: " + BooksTable.Count());
		}

		public void AddProdListenerAttach(AddProductDialog view) {
			view.ProductAdded += OnProductAdded;
		}

		private void OnProductAdded(object? sender, List<string> e)
        {
            string type = e.First();
            e.Remove(e.First());
            switch (type)
            {
                case "Book": BuildBook(e); break;
                case "Game": BuildGame(e); break;
                case "Movie": BuildMovie(e); break;
            }
        }

        public void BuildMovie(List<string> e) {
			string name = e[0];
			if (!int.TryParse(e[1], out int price)) return;
			string format = e[2];
			if (!int.TryParse(e[3], out int run)) return;
			AddMovie(new Movie(0, name, price, 0, format, run));
		}

		public void BuildGame(List<string> e) {
			string name = e[0];
			if (!int.TryParse(e[1], out int price)) return;
			string plat = e[2];
			AddGame(new Game(0, name, price, 0, plat));
		}

		public void BuildBook(List<string> e) {
			string name = e[0];
			if (!int.TryParse(e[1], out int price)) return;
			string auth = e[2];
			string genre = e[3];
			string format = e[4];
			string lang = e[5];
			AddBook(new Book(0, name, price, 0, auth, genre, format, lang));
		}

		public void AddBook(Book book) {
			if(book.ID == 0)
				book.ID = nextID++;
			BooksTable.Add(book);
		}
		public void AddGame(Game game) {
			if (game.ID == 0)
				game.ID = nextID++;
			GamesTable.Add(game);
		}
		public void AddMovie(Movie movie) {
			if (movie.ID == 0)
				movie.ID = nextID++;
			MoviesTable.Add(movie);
		}

	}
}
