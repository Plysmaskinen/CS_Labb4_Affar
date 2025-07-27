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
	public partial class AddProductDialog : Form {
		List<string> inputs = [];
		public event EventHandler<List<string>> ProductAdded;
		LagerController LagerController;
		AddBook addBook;	//0
		AddGame addGame;	//1
		AddMovie addMovie;	//2
		int ActiveType = 0;
		public AddProductDialog(LagerController lagerController) {
			InitializeComponent();
			LagerController = lagerController;
			addBook = new(LagerController);
			ProductTypeComboBox.SelectedIndex = 0;
			splitContainer2.Panel1.Controls.Add(addBook);
		}

		private void ProductTypeComboBox_SelectedIndexChanged(object sender, EventArgs e) {
			var s = splitContainer2.Panel1.Controls;
			var p = ProductTypeComboBox.SelectedIndex;
			s.Clear();
			if (p == 0) {
				s.Add(addBook = new(LagerController));
				ActiveType = 0;
			}
			else if (p == 1) {
				s.Add(addGame = new(LagerController));
				ActiveType = 1;
			}
			else if (p == 2) {
				s.Add(addMovie = new(LagerController));
				ActiveType = 2;
			}
		}

		private void AddProductAcceptButton_Click(object sender, EventArgs e) {
			switch (ActiveType) { 
				case 0: inputs = addBook.getInfo();  break;
				case 1: inputs = addGame.getInfo(); break;
				case 2: inputs = addMovie.getInfo(); break;
			}
			if (inputs[1] == "" || inputs[2] == "") {
				MessageBox.Show("Var vänlig fyll i alla obligatoriska fält markerade (*)", "Ogiltig Inmatning");
				return;
			}

			ProductAdded?.Invoke(this, inputs);
			Close();
		}

		private void AddProductCancelButton_Click(object sender, EventArgs e) {
			Close();
		}
	}
}
