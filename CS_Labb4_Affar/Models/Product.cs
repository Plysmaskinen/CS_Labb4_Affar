using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Labb4_Affar.Models {
	public abstract class Product : INotifyPropertyChanged{

		public int ID			{ get; set; }
		public string Name		{ get; /*private*/ set; }
		public int Price		{ get; /*private*/ set; }

		private int amount;
		public int Amount {
			get => amount;
			set { 
				if (amount != value) {
					amount = value;
					OnPropertyChanged(nameof(Amount));
					OnPropertyChanged(nameof(KassaDisp));
				}
			} 
		}
		public Product(int id, string name, int price, int amount) {
			ID = id;
			Name = name;
			Price = price;
			Amount = amount;
		}

		public event PropertyChangedEventHandler? PropertyChanged;

		protected void OnPropertyChanged(string propName) =>
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));

		public string KassaDisp => 
			Amount > 0 ?
			$"{Amount}x {Name}, {Price}kr" :
			string.Empty;

		public abstract override string ToString();
	}
}
