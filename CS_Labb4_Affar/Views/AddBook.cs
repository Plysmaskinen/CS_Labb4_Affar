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
	public partial class AddBook : UserControl {
		LagerController LagerController;
		public AddBook(LagerController lagerController) {
			InitializeComponent();
			LagerController = lagerController;
		}

		public List<string> getInfo() {
			List<string> info = new List<string>() { "Book" };
			var tb = this.Controls.OfType<TextBox>().OrderBy(i => i.TabIndex);
			foreach (var text in tb) {
				info.Add(text.Text.ToString());
			}
			return info;
		}
	}
}
