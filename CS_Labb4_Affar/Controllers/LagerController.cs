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
		public BindingList<Book> BooksTable { get; set; } = [];
		public BindingList<Game> GamesTable { get; set; } = [];
		public BindingList<Movie> MoviesTable { get; set; } = [];
		public BindingList<Product> prods { get; set; } = [];
		public event EventHandler KassaAttachList;

		public LagerController() {

		}

		public void AddProdListenerAttach(AddProductDialog view) {
			view.ProductAdded += OnProductAdded;
		}

		public void OrderProdListenerAttach(OrderProductsDialog view) {
			view.OrderInfo += OnOrderInfo;
		}

		public void LoadKassaListsListenerAttach(LagerView view) {
			view.KassaListsLoad += OnLoadKassaLists;
		}

		public void OnLoadKassaLists(object? sender, EventArgs e) {
			prods.Clear();
			foreach (Book prod in BooksTable) {
				if (prod.Amount != 0 && !prods.Contains(prod))
					prods.Add(prod);
			}
			foreach (Game prod in GamesTable) {
				if (prod.Amount != 0 && !prods.Contains(prod))
					prods.Add(prod);
			}
			foreach (Movie prod in MoviesTable) {
				if (prod.Amount != 0 && !prods.Contains(prod))
					prods.Add(prod);
			}
			KassaAttachList?.Invoke(this, EventArgs.Empty);
		}

		private void OnProductAdded(object? sender, List<string> e) {
			string type = e.First();
			e.Remove(e.First());
			switch (type){
				case "Book": BuildBook(e); break;
				case "Game": BuildGame(e); break;
				case "Movie": BuildMovie(e); break;
			}
		}

		private void OnOrderInfo(object? sender, Dictionary<int, int> e) {
			foreach(var item in e) {
				foreach (var prod in BooksTable) {
					if (item.Key == prod.ID) {
						prod.Amount += item.Value;
					}
				}
				foreach (var prod in GamesTable) {
					if (item.Key == prod.ID) {
						prod.Amount += item.Value;
					}
				}
				foreach (var prod in MoviesTable) {
					if (item.Key == prod.ID) {
						prod.Amount += item.Value;
					}
				}
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
