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

			var LVMs = ProductList.Select(p => new ProductViewModel(p)).ToList();
			ProductBindingSource.DataSource = new BindingList<ProductViewModel>(LVMs);
		}

		public void ListenerAttach(LagerView view) {

		}


		private void AddProduct(Product product) {
			product.ID = nextID++;
			ProductList.Add(product);
		}

	}
}
