using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
			ReadBooks();
			ReadGames();
			ReadMovies();
			UpdateID();
		}

		public void WriteDatabase(object? sender, EventArgs e) {
			WriteBooks(LagerController.BooksTable);
			WriteGames(LagerController.GamesTable);
			WriteMovies(LagerController.MoviesTable);
		}

		private void UpdateID() {
			List<int> IDs = [];
			foreach (Book book in LagerController.BooksTable) {
				IDs.Add(book.ID);
			}
			foreach (Game game in LagerController.GamesTable) {
				IDs.Add(game.ID);
			}
			foreach (Movie movie in LagerController.MoviesTable) {
				IDs.Add(movie.ID);
			}
			LagerController.nextID = IDs.Max() + 1;
		}

		private void ReadBooks() {
			LagerController.BooksTable.Clear();
			List<string> rows = ReadLinesFromCSV("books");

			foreach (string row in rows) {
				string[] columns = ParseCSVLine(row);

				for (int i = 0; i < columns.Length; i++) {
					columns[i] = UnescapeCSV(columns[i]);
				}

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

		private void ReadGames() {
			LagerController.GamesTable.Clear();
			List<string> rows = ReadLinesFromCSV("games");

			foreach (string row in rows) {
				string[] columns = ParseCSVLine(row);

				for (int i = 0; i < columns.Length; i++) {
					columns[i] = UnescapeCSV(columns[i]);
				}

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

		private void ReadMovies() {
			LagerController.MoviesTable.Clear();
			List<string> rows = ReadLinesFromCSV("movies");

			foreach (string row in rows) {
				string[] columns = ParseCSVLine(row);

				for (int i = 0; i < columns.Length; i++) {
					columns[i] = UnescapeCSV(columns[i]);
				}

				int? runtime = string.IsNullOrEmpty(columns[5]) ? null : int.Parse(columns[5]);
				Movie movie = new Movie(
					int.Parse(columns[0]),
					columns[1],
					int.Parse(columns[2]),
					int.Parse(columns[3]),
					columns[4],
					runtime
				);
				LagerController.AddMovie(movie);
			}
		}

		private void WriteBooks(BindingList<Book> Books) {
			var lines = new List<string> {
				GetHeader(typeof(Book))
			};
			foreach (Book book in Books) {
				var str = ToCSVLine(
					book.ID.ToString(),
					book.Name,
					book.Price.ToString(),
					book.Amount.ToString(),
					book.Author,
					book.Genre,
					book.Format ?? "",
					book.Lang ?? ""
				);
				lines.Add(str);
			}
			WriteLinesToCSV("books", lines);
		}

		private void WriteGames(BindingList<Game> Games) {
			var lines = new List<string> {
				GetHeader(typeof(Game))
			};
			foreach (Game game in Games) {
				var str = ToCSVLine(
					game.ID.ToString(),
					game.Name,
					game.Price.ToString(),
					game.Amount.ToString(),
					game.Platform
				);
				lines.Add(str);
			}
			WriteLinesToCSV("games", lines);
		}

		private void WriteMovies(BindingList<Movie> Movies) {
			var lines = new List<string> {
				GetHeader(typeof(Movie))
			};
			foreach (Movie movie in Movies) {
				var str = ToCSVLine(
					movie.ID.ToString(),
					movie.Name,
					movie.Price.ToString(),
					movie.Amount.ToString(),
					movie.Format,
					movie.Runtime?.ToString() ?? ""
				);
				lines.Add(str);
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

			return [];
		}

		private string[] ParseCSVLine(string row) {
			var pattern = @",(?=(?:[^""]*""[^""]*"")*[^""]*$)";
			var columns = Regex.Split(row, pattern);

			for (int i = 0; i < columns.Length; i++) {
				columns[i] = columns[i].Trim();
			}
			return columns;
		}

		public void WriteLinesToCSV(string fileName, List<string> lines) {
			try {
				File.WriteAllLines(@"..\..\..\CSVDatabase\" + fileName + ".csv", lines);
			}
			catch (Exception ex) {
				MessageBox.Show("Error under skrivningen till CSV: " + ex.Message);
			}
		}

		private string EscapeCSV(string s) {
			if (s == null) return "";
			if (s.Contains(',') || s.Contains('\n') || s.Contains('\r') || s.Contains('"')) {
				s = s.Replace("\"", "\"\"");
				return $"\"{s}\"";
			}
			return s;
		}

		private string UnescapeCSV(string s) {
			if (s.StartsWith("\"") && s.EndsWith("\""))
				s = s.Substring(1, s.Length - 2).Replace("\"\"", "\"");
			return s;
		}

		private string ToCSVLine(params string[] columns) {
			return string.Join(",", columns.Select(EscapeCSV));
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
