using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Labb4_Affar.Models {
	public class Movie : Product {
		public string Format { get; private set; }
		public int? Runtime { get; private set; }
		public Movie(int id, string name, int price, int amount, string format, int runtime) : 
			   base(id, name, price, amount) {
			Format = format;
			Runtime = runtime;
		}
		public override string ToString() {
			return $"{ID},{Name},{Price},{Amount},{Format},{Runtime}";
		}
	}
}
