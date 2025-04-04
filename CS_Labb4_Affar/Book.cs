using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Labb4_Affar {
	public class Book : Product {
		public string Author { get; private set; }
		public string Genre { get; private set; }
		public string? Format { get; private set; }
		public string? Lang { get; private set; }

		public Book(int id, string name, int price, int amount, string author, string genre, string format, string lang) :
			   base(id, name, price, amount) {

			Author = author;
			Genre = genre;
			Format = format;
			Lang = lang;
		}
	}
}
