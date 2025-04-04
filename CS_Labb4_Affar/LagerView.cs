using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS_Labb4_Affar {
	public partial class LagerView : UserControl {
		LagerController LagerController;
		public LagerView(LagerController lagerController) {
			InitializeComponent();
			LagerController = lagerController;
			LagerDataGridView.DataSource = lagerController.ProductBindingSource;

		}

		private void LagerHelpButton_Click(object sender, EventArgs e) {

		}

		private void LagerAddProductButton_Click(object sender, EventArgs e) {
			AddProductDialog addProductDialog = new AddProductDialog(LagerController);
			addProductDialog.ShowDialog();
		}

		private void LagerOrderProductsButton_Click(object sender, EventArgs e) {
			OrderProductsDialog orderProductsDialog = new OrderProductsDialog(LagerController);
			orderProductsDialog.ShowDialog();
		}

	}
}
