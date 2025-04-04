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
	public partial class AddProductDialog : Form {
		List<string> inputs = new List<string>();
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
			ProductAdded.Invoke(this, inputs);
			this.Close();
		}

		private void AddProductCancelButton_Click(object sender, EventArgs e) {
			this.Close();
		}
	}
}
