using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CS_Labb4_Affar.Models;
using Microsoft.VisualBasic;

namespace CS_Labb4_Affar {
	public class ProductViewModel {
		public int ID { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public int Amount { get; set; }
		public string Type { get; set; }
		public string? Author { get; set; }
		public string? Genre { get; set; }
		public string? Format { get; set; }
		public string? Lang { get; set; }
		public string? Platform { get; set; }
		public int? Runtime { get; set; }
		public ProductViewModel(Product prod) {
			ID = prod.ID;
			Name = prod.Name;
			Price = prod.Price;
			Amount = prod.Amount;
			var TypeS = prod.GetType().ToString().Split('.');
			Type = TypeS[1];

			if (prod is Book b) {
				Author = b.Author;
				Genre = b.Genre;
				Format = b.Format;
				Lang = b.Lang;
			}
			else if (prod is Game g) {
				Platform = g.Platform;
			}
			else if (prod is Movie m) {
				Format = m.Format;
				Runtime = m.Runtime;
			}
		}
	}
}
