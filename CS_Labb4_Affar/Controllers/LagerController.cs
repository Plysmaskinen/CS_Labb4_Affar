using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CS_Labb4_Affar {
	public class LagerController {
		int nextID = 0;
		public BindingList<Product> ProductList { get; set; } = [];
		public BindingSource ProductBindingSource { get; set; } = [];
		public LagerController() {
			AddProduct(new Book(0, "Bello Gallico et Civili", 449, 0, "Julius Caesar", "Historia", "Inbunden", "Latin"));
			AddProduct(new Book(0, "How to Read a Book", 149, 0, "Mortimer J. Adler", "Kursliteratur", "Pocket", ""));
			AddProduct(new Book(0, "Moby Dick", 49, 0, "Herman Melville", "Äventyr", "Pocket", ""));
			AddProduct(new Book(0, "The Great Gatsby", 79, 0, "F. Scott Fitzgerald", "Noir", "E-Bok", ""));
			AddProduct(new Book(0, "House of Leaves", 49, 0, "Mark Z. Danielewski", "Skräck", "", ""));
			AddProduct(new Game(0, "Elden Ring", 599, 0, "Playstation 5"));
			AddProduct(new Game(0, "Demon's Souls", 499, 0, "Playstation 5"));
			AddProduct(new Game(0, "Microsoft Flight Simulator", 499, 0, "PC"));
			AddProduct(new Game(0, "Planescape Torment", 99, 0, "PC"));
			AddProduct(new Game(0, "Disco Elysium", 399, 0, "PC"));
			AddProduct(new Movie(0, "Nyckeln till Frihet", 99, 0, "DVD", 142));
			AddProduct(new Movie(0, "Gudfadern", 99, 0, "DVD", 152));
			AddProduct(new Movie(0, "Konungens Återkomst", 199, 0, "Blu-Ray", 154));
			AddProduct(new Movie(0, "Pulp Fiction", 199, 0, "Blu-Ray", 0));
			AddProduct(new Movie(0, "Schindler's List", 99, 0, "DVD", 0));
			UpdateProductsTable();
		}

		public void LagerListenerAttach(LagerView view) {
			
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
            UpdateProductsTable();
        }

        private void UpdateProductsTable()
        {
            ProductBindingSource.DataSource = new BindingList<ProductViewModel>(ProductList.Select(p => new ProductViewModel(p)).ToList());
        }

        private void BuildMovie(List<string> e) {
			string name = e[0];
			if (!int.TryParse(e[1], out int price)) return;
			string format = e[2];
			if (!int.TryParse(e[3], out int run)) return;
			AddProduct(new Movie(0, name, price, 0, format, run));
		}

		private void BuildGame(List<string> e) {
			string name = e[0];
			if (!int.TryParse(e[1], out int price)) return;
			string plat = e[2];
			AddProduct(new Game(0, name, price, 0, plat));
		}

		private void BuildBook(List<string> e) {
			MessageBox.Show(string.Join(", ", e));
			MessageBox.Show("Book");
			string name = e[0];
			if (!int.TryParse(e[1], out int price)) return;
			string auth = e[2];
			string genre = e[3];
			string format = e[4];
			string lang = e[5];
			AddProduct(new Book(0, name, price, 0, auth, genre, format, lang));
		}

		private void AddProduct(Product product) {
			product.ID = nextID++;
			ProductList.Add(product);
		}

	}
}
