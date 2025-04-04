using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Labb4_Affar {
	public class Game : Product {
		//public productType Type;
		public string Platform { get; private set; }
		public Game(int id, string name, int price, int amount, string platform) : 
			   base(id, name, price, /*Product.productType.Game,*/ amount) {
			//Type = productType.Game;
			Platform = platform;
		}
	}
}
