using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Labb4_Affar.Models;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Windows.Forms.LinkLabel;

namespace CS_Labb4_Affar.Controllers {
	public class DatabaseController {
		int id;
		LagerController LagerController;
		public DatabaseController(LagerController lagerController) {
			LagerController = lagerController;
		}

		public void DatabaseWriteListenerAttach(LagerView view) {
			view.SaveToFile += WriteDatabase;
		}

		public void DatabaseReadListenerAttach(LagerView view) {
			view.ReadFromFile += ReadDatabase;
		}

		public void ReadDatabase(object? sender, EventArgs e) {
			//MessageBox.Show("Read");
			//LagerController.BooksTable = ReadBooks();
			ReadBooks();
			//LagerController.GamesTable = ReadGames();
			ReadGames();
			//LagerController.MoviesTable = ReadMovies();
			ReadMovies();
			UpdateID();
		}

		private void UpdateID() {
			int booksID = 0;
			int gamesID = 0;
			int moviesID = 0;
			List<int> IDs = [];
			foreach (Book book in LagerController.BooksTable) {
				booksID = booksID < book.ID ? book.ID : booksID;
			}
			foreach (Game game in LagerController.GamesTable) {
				gamesID = gamesID < game.ID ? game.ID : gamesID;
			}
			foreach (Movie movie in LagerController.MoviesTable) {
				moviesID = moviesID < movie.ID ? movie.ID : moviesID;
			}
			IDs.Add(booksID);
			IDs.Add(gamesID);
			IDs.Add(moviesID);
			LagerController.nextID = IDs.Max()+1;
		}

		public void WriteDatabase(object? sender, EventArgs e) {
			MessageBox.Show("Saved");
			WriteBooks(LagerController.BooksTable);
			WriteGames(LagerController.GamesTable);
			WriteMovies(LagerController.MoviesTable);
		}

		//private BindingList<Book> ReadBooks() {
		//	var books = new BindingList<Book>();
		//	List<string> rows = ReadLinesFromCSV("books");

		//	foreach (string row in rows) {
		//		string[] columns = row.Split(',');
		//		Book book = new Book(
		//			int.Parse(columns[0]),
		//			columns[1],
		//			int.Parse(columns[2]),
		//			int.Parse(columns[3]),
		//			columns[4],
		//			columns[5],
		//			columns[6],
		//			columns[7]
		//			);
		//		books.Add(book);
		//		LagerController.AddBook(book);
		//	}
		//	return books;
		//}
		private void ReadBooks() {
			List<string> rows = ReadLinesFromCSV("books");

			foreach (string row in rows) {
				string[] columns = row.Split(',');
				Book book = new Book(
					int.Parse(columns[0]),
					columns[1],
					int.Parse(columns[2]),
					int.Parse(columns[3]),
					columns[4],
					columns[5],
					columns[6],
					columns[7]
				);
				LagerController.AddBook(book);
			}
		}

		//private BindingList<Game> ReadGames() {
		//	var games = new BindingList<Game>();
		//	List<string> rows = ReadLinesFromCSV("games");

		//	foreach (string row in rows) {
		//		string[] columns = row.Split(',');
		//		Game game = new Game(
		//			int.Parse(columns[0]),
		//			columns[1],
		//			int.Parse(columns[2]),
		//			int.Parse(columns[3]),
		//			columns[4]
		//		);
		//		games.Add(game);
		//		LagerController.AddGame(game);
		//	}
		//	return games;
		//}

		private void ReadGames() {
			List<string> rows = ReadLinesFromCSV("games");

			foreach (string row in rows) {
				string[] columns = row.Split(',');
				Game game = new Game(
					int.Parse(columns[0]),
					columns[1],
					int.Parse(columns[2]),
					int.Parse(columns[3]),
					columns[4]
				);
				LagerController.AddGame(game);
			}
		}

		//private BindingList<Movie> ReadMovies() {
		//	var movies = new BindingList<Movie>();
		//	List<string> rows = ReadLinesFromCSV("movies");

		//	foreach (string row in rows) {
		//		string[] columns = row.Split(',');
		//		Movie movie = new Movie(
		//			int.Parse(columns[0]),
		//			columns[1],
		//			int.Parse(columns[2]),
		//			int.Parse(columns[3]),
		//			columns[4],
		//			int.Parse(columns[3])
		//		);
		//		movies.Add(movie);
		//		LagerController.AddMovie(movie);
		//	}
		//	return movies;
		//}

		private void ReadMovies() {
			List<string> rows = ReadLinesFromCSV("movies");

			foreach (string row in rows) {
				string[] columns = row.Split(',');
				Movie movie = new Movie(
					int.Parse(columns[0]),
					columns[1],
					int.Parse(columns[2]),
					int.Parse(columns[3]),
					columns[4],
					int.Parse(columns[3])
				);
				LagerController.AddMovie(movie);
			}
		}

		private void WriteBooks(BindingList<Book> Books) {
			if (Books.Count > 0)
				MessageBox.Show("Books ej tom");
			var lines = new List<string> {
				GetHeader(typeof(Book))
			};
			foreach (Book book in Books) {
				lines.Add(book.ToString());
			}
			WriteLinesToCSV("books", lines);
		}

		private void WriteGames(BindingList<Game> Games) {
			if (Games.Count > 0)
				MessageBox.Show("games ej tom");
			var lines = new List<string> {
				GetHeader(typeof(Game))
			};
			foreach (Game game in Games) {
				lines.Add(game.ToString());
			}
			WriteLinesToCSV("games", lines);
		}

		private void WriteMovies(BindingList<Movie> Movies) {
			if (Movies.Count > 0)
				MessageBox.Show("Movies ej tom");
			var lines = new List<string> {
				GetHeader(typeof(Movie))
			};
			foreach (Movie movie in Movies) {
				lines.Add(movie.ToString());
			}
			WriteLinesToCSV("movies", lines);
		}

		private List<string> ReadLinesFromCSV(string fileName) {
			try {
				string[] rows = File.ReadAllLines(@"..\..\..\CSVDatabase\" + fileName + ".csv");
				if (rows.Length > 1) {
					var rowList = rows.ToList();
					rowList.RemoveAt(0); //ta bort första raden med kolumntitlar
					return rowList;
				}
			}
			catch (Exception ex) {
				MessageBox.Show("Error under läsningen av CSV: " + ex.Message);
			}

			return new List<string>();
		}

		public void WriteLinesToCSV(string fileName, List<string> lines) {
			try {
				File.WriteAllLines(@"..\..\..\CSVDatabase\" + fileName + ".csv", lines);
			}
			catch (Exception ex) {
				MessageBox.Show("Error under skrivningen till CSV: " + ex.Message);
			}
		}

		private string GetHeader(Type type) {
			List<string> colNames = type.GetProperties().Select(p => p.Name).ToList();
			while(colNames.First() != "ID") {
				colNames = colNames.Skip(1).Concat(colNames.Take(1)).ToList();
			}
			return string.Join(",", colNames);
		}
	}
}
