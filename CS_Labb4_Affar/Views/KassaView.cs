using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS_Labb4_Affar.Controllers;
using CS_Labb4_Affar.Models;

namespace CS_Labb4_Affar {
	public partial class KassaView : UserControl {
		LagerController LagerController;
		LagerView LagerView;
		private BindingList<Product> KassaInventory = [];
		private BindingList<Product> KassaKorg = [];
		public KassaView(LagerController lagerController, LagerView lagerView) {
			InitializeComponent();
			LagerController = lagerController;
			LagerView = lagerView;
			KassaKorgListBox.DataSource = KassaKorg;
			KassaKorgListBox.DisplayMember = "KassaDisp";
		}

		public void KassaListAttachListenerattach(LagerController cont) {
			cont.KassaAttachList += OnKassaAttachList;
		}

		private void OnKassaAttachList(object? sender, EventArgs e) {
			KassaInventory = LagerController.prods;
			KassaInventoryListBox.DataSource = KassaInventory;
			KassaInventoryListBox.DisplayMember = "KassaDisp";
			KassaInventoryListBox.SelectedIndex = -1;
			KassaTillKorgButton.Enabled = false;
			KorgTillKassaButton.Enabled = false;
		}

		private void KassaTillKorgButton_Click(object sender, EventArgs e) {
			var selected = (Product)KassaInventoryListBox.SelectedItem;
			if (selected == null || selected.Amount == 0)
				return;
			selected.Amount--;
			var prodInKassaKorg = KassaKorg.FirstOrDefault(prod => prod.ID == selected.ID);
			if (prodInKassaKorg != null) {
				prodInKassaKorg.Amount++;
			}
			else {
				KassaKorg.Add(new Game(
					selected.ID,
					selected.Name,
					selected.Price,
					1,
					""
				));
			}
			if (selected.Amount == 0) {
				KassaInventory.Remove(selected);
				KassaInventoryListBox.SelectedIndex = -1;
				KassaTillKorgButton.Enabled = false;

			}
			KassaKorgListBox.SelectedIndex = -1;
			KorgTillKassaButton.Enabled = false;
			UpdateTotalPrice();
		}

		private void KorgTillKassaButton_Click(object sender, EventArgs e) {
			var selected = (Product)KassaKorgListBox.SelectedItem;
			if (selected == null || selected.Amount == 0)
				return;
			selected.Amount--;
			var prodInKassaInventory = KassaInventory.FirstOrDefault(prod => prod.ID == selected.ID);
			if (prodInKassaInventory != null) {
				prodInKassaInventory.Amount++;
			}
			else {
				KassaInventory.Add(new Game(
					selected.ID,
					selected.Name,
					selected.Price,
					1,
					""
				));
			}
			if (selected.Amount == 0) {
				KassaKorg.Remove(selected);
				KassaKorgListBox.SelectedIndex = -1;
				KorgTillKassaButton.Enabled = false;

			}
			KassaInventoryListBox.SelectedIndex = -1;
			KassaTillKorgButton.Enabled = false;
			UpdateTotalPrice();
		}

		private void KassaTransaktionButton_Click(object sender, EventArgs e) {
			KassaKorg.Clear();
			LagerView.Save();
		}

		private void UpdateTotalPrice() {
			int k = 0;
			foreach (var item in KassaKorg) {
				k += item.Price * item.Amount;
			}
			KassaSummaLabel.Text = k.ToString();
		}

		private void KassaKorgListBox_SelectedIndexChanged(object sender, EventArgs e) {
			KorgTillKassaButton.Enabled = true;
		}

		private void KassaInventoryListBox_SelectedIndexChanged(object sender, EventArgs e) {
			KassaTillKorgButton.Enabled = true;
		}
	}
}
