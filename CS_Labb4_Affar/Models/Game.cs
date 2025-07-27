using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.DataFormats;

namespace CS_Labb4_Affar.Models {
	public class Game : Product {
		public string Platform { get; set; }
		public Game(int id, string name, int price, int amount, string platform) : 
			   base(id, name, price, amount) {
			Platform = platform;
		}
		public override string ToString() {
			return $"{ID},{Name},{Price},{Amount},{Platform}";
		}
	}
}
