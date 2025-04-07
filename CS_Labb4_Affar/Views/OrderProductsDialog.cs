using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS_Labb4_Affar.Controllers;

namespace CS_Labb4_Affar {
	public partial class OrderProductsDialog : Form {
		LagerController LagerController;
		public OrderProductsDialog(LagerController lagerController) {
			InitializeComponent();
			LagerController = lagerController;
		}
	}
}
