﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Labb4_Affar {
	public class Movie : Product {
		//public productType Type;
		public string Format { get; private set; }
		public int Runtime { get; private set; }
		public Movie(int id, string name, int price, int amount, string format, int runtime) : 
			   base(id, name, price, /*Product.productType.Movie,*/ amount) {
			//Type = productType.Movie;
			Format = format;
			Runtime = runtime;
		}
	}
}
