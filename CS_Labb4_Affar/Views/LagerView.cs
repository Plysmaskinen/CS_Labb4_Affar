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
using CS_Labb4_Affar.Models;

namespace CS_Labb4_Affar {
	public partial class LagerView : UserControl {
		LagerController LagerController;
		public event EventHandler? SaveToFile;
		public event EventHandler? ReadFromFile;
		public event EventHandler? KassaListsLoad;
		private List<string> BookColumnOrder = ["ID", "Name", "Price", "Amount", "Author", "Genre", "Format", "Lang"];
		private List<string> GameColumnOrder = ["ID", "Name", "Price", "Amount", "Platform"];
		private List<string> MovieColumnOrder = ["ID", "Name", "Price", "Amount", "Format", "Runtime"];


		public int ActiveTableTab;

		public LagerView(LagerController lagerController) {
			InitializeComponent();
			LagerController = lagerController;

			BookTable.DataSource = LagerController.BooksTable;
			GameTable.DataSource = LagerController.GamesTable;
			MovieTable.DataSource = LagerController.MoviesTable;
			SetColumnOrder(BookTable, BookColumnOrder);
			SetColumnOrder(GameTable, GameColumnOrder);
			SetColumnOrder(MovieTable, MovieColumnOrder);

			ActiveTableTab = tabControl1.SelectedIndex;
		}

		private void LagerAddProductButton_Click(object sender, EventArgs e) {
			AddProductDialog addProductDialog = new AddProductDialog(LagerController);
			LagerController.AddProdListenerAttach(addProductDialog);
			addProductDialog.ShowDialog();
			Reload();
		}

		private void LagerRemoveProductButton_Click(object sender, EventArgs e) {
			switch (ActiveTableTab) {
				case 0:
					RemoveSelectedProduct(BookTable, LagerController.BooksTable);
					break;
				case 1:
					RemoveSelectedProduct(GameTable, LagerController.GamesTable);
					break;
				case 2:
					RemoveSelectedProduct(MovieTable, LagerController.MoviesTable);
					break;
			}
			DeselectActiveTable();
			Reload();
		}

		private void LagerOrderProductsButton_Click(object sender, EventArgs e) {
			OrderProductsDialog orderProductsDialog = new OrderProductsDialog(LagerController);
			LagerController.OrderProdListenerAttach(orderProductsDialog);
			orderProductsDialog.ShowDialog();
			Reload();
		}

		private void LagerHelpButton_Click(object sender, EventArgs e) {
			MessageBox.Show(
				"Klicka på den vänstar knappen längst ner på fönstret för att lägga till en ny produkt för försäljning. Klicka på den högra knappen istället för att beställa exemplar av de befintliga produkterna. Klicka på knappen i mitten, med en vara i listan vald, för att ta bort den från lagret.",
				"Lagerhjälp",
				MessageBoxButtons.OK
			);
		}

		private void RemoveSelectedProduct<T>(DataGridView data, BindingList<T> table) where T : class {
			var row = data.SelectedRows[0];
			var remove = row.DataBoundItem as T;
			if (Convert.ToInt32(row.Cells["Amount"].Value) != 0) {
				var res = MessageBox.Show("Det finns exemplar kvar i lagret av produkten du försöker ta bort. Vill du fortsätta?", "Borttagning av icke-tom produkt", MessageBoxButtons.YesNo);
				if (res == DialogResult.No) {
					return;
				}
			}

			if (remove != null)
				table.Remove(remove);
		}

		private void SetColumnOrder(DataGridView table, List<string> order) {
			for (int i = 0; i < order.Count; i++) {
				if (table.Columns.Contains(order[i])) {
					table.Columns[order[i]].DisplayIndex = i;
				}
			}
		}

		public void Save() {
			SaveToFile?.Invoke(this, EventArgs.Empty);
		}

		public void Load() {
			ReadFromFile?.Invoke(this, EventArgs.Empty);
			KassaListsLoad?.Invoke(this, EventArgs.Empty);
		}

		public void Reload() {
			Save();
			Load();
		}

		private void BookTable_SelectionChanged(object sender, EventArgs e) {
			LagerRemoveProductButton.Enabled = true;
		}

		private void GameTable_SelectionChanged(object sender, EventArgs e) {
			LagerRemoveProductButton.Enabled = true;

		}

		private void MovieTable_SelectionChanged(object sender, EventArgs e) {
			LagerRemoveProductButton.Enabled = true;

		}
		private void tabControl1_Selected(object sender, TabControlEventArgs e) {
			DeselectActiveTable();
			ActiveTableTab = tabControl1.SelectedIndex;
		}

		private void DeselectActiveTable() {
			switch (ActiveTableTab) {
				case 0: BookTableDeselect(); break;
				case 1: GameTableDeselect(); break;
				case 2: MovieTableDeselect(); break;
			}
		}

		private void BookTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
			BookTableDeselect();
		}

		private void BookTableDeselect() {
			BookTable.ClearSelection();
			LagerRemoveProductButton.Enabled = false;
		}

		private void GameTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
			GameTableDeselect();
		}

		private void GameTableDeselect() {
			GameTable.ClearSelection();
			LagerRemoveProductButton.Enabled = false;
		}

		private void MovieTable_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e) {
			MovieTableDeselect();
		}

		private void MovieTableDeselect() {
			MovieTable.ClearSelection();
			LagerRemoveProductButton.Enabled = false;
		}

	}
}
