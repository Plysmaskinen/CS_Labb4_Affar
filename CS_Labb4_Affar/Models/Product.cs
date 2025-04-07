using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Labb4_Affar.Models {
	public abstract class Product {

		public int ID			{ get; set; }
		public string Name		{ get; private set; }
		public int Price		{ get; private set; }
		public int Amount		{ get; set; }
		public Product(int id, string name, int price, int amount) {
			ID = id;
			Name = name;
			Price = price;
			Amount = amount;
		}

		public override string ToString() {
			return $"{Amount}st. {Name}, {Price,-1}";
		}
	}
}
