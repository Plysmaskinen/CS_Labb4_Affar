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
		public event EventHandler<string> TypeSelected; 
		public LagerView(LagerController lagerController) {
			InitializeComponent();
			LagerController = lagerController;
			LagerDataGridView.DataSource = lagerController.productBindingSource;
			LagerComboBox.SelectedIndex = 0;
		}
		private void LagerComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			string selectedType;
			if (LagerComboBox.SelectedIndex == 1) selectedType = "Book";
			else if (LagerComboBox.SelectedIndex == 2) selectedType = "Game";
			else if (LagerComboBox.SelectedIndex == 3) selectedType = "Movie";
			else selectedType = "";
			TypeSelected?.Invoke(this, selectedType);
		}

		private void LagerHelpButton_Click(object sender, EventArgs e) {

		}

		private void LagerAddProductButton_Click(object sender, EventArgs e) {
			AddProductDialog addProductDialog = new AddProductDialog();
			addProductDialog.ShowDialog();
		}

		private void LagerOrderProductsButton_Click(object sender, EventArgs e) {
			OrderProductsDialog orderProductsDialog = new OrderProductsDialog();
			orderProductsDialog.ShowDialog();
		}

	}
}
