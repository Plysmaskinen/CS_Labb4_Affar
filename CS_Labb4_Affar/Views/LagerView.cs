using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS_Labb4_Affar.Controllers;

namespace CS_Labb4_Affar {
    public partial class LagerView : UserControl
    {
        LagerController LagerController;
		public event EventHandler? SaveToFile;
		public event EventHandler? ReadFromFile;

		public LagerView(LagerController lagerController) {
			InitializeComponent();
			LagerController = lagerController;

			BookTable.DataSource = lagerController.BooksTable;
			GameTable.DataSource = lagerController.GamesTable;
			MovieTable.DataSource = lagerController.MoviesTable;

		}

		private void LagerHelpButton_Click(object sender, EventArgs e)
        {
			Save();
		}

        private void LagerAddProductButton_Click(object sender, EventArgs e)
        {
            AddProductDialog addProductDialog = new AddProductDialog(LagerController);
            LagerController.AddProdListenerAttach(addProductDialog);
            addProductDialog.ShowDialog();
        }

        private void LagerOrderProductsButton_Click(object sender, EventArgs e)
        {
            OrderProductsDialog orderProductsDialog = new OrderProductsDialog(LagerController);
            orderProductsDialog.ShowDialog();
        }

        private void LagerDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {

		}

		public void Save() {
			SaveToFile?.Invoke(this, EventArgs.Empty);
		}

		public void Load() {
			ReadFromFile?.Invoke(this, EventArgs.Empty);
		}
	}
}
