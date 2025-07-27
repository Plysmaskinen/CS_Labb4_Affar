using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CS_Labb4_Affar.Controllers;
using CS_Labb4_Affar.Models;

namespace CS_Labb4_Affar {
	public partial class OrderProductsDialog : Form {
		LagerController LagerController;
		List<NumericUpDown> Nuds = new List<NumericUpDown>();
		Dictionary<int, int> IDAmtPairs = [];
		public event EventHandler<Dictionary<int, int>>? OrderInfo;
		public OrderProductsDialog(LagerController lagerController) {
			InitializeComponent();
			LagerController = lagerController;
			AddToFlow(LagerController.BooksTable);
			AddToFlow(LagerController.GamesTable);
			AddToFlow(LagerController.MoviesTable);
		}

		private void AcceptButton_Click(object sender, EventArgs e) {
			StringBuilder sb = new StringBuilder();
			int ID = -1;
			int Amt = 0;
			foreach (Control c in flowLayoutPanel1.Controls) {
				if (c is Panel panel) {
					foreach (Control c2 in panel.Controls) {
						if (c2.TabIndex != 0 && c2 is Label) {
							ID = (int)c2.Tag;
						}
						else if (c2 is NumericUpDown nud) {
							Amt = (int)nud.Value;
							if (!string.IsNullOrEmpty(Name))
								IDAmtPairs[ID] = Amt;
						}
					}
				}
			}
			OrderInfo?.Invoke(this, IDAmtPairs);
			Close();
		}

		private void CancelButton_Click(object sender, EventArgs e) {
			Close();
		}

		private void AddToFlow<T>(BindingList<T> prod) where T : Product {
			int tab = 1;
			foreach (Product product in prod) {
				Panel itemPanel = new();
				itemPanel.AutoSize = true;
				itemPanel.Height = 30;
				itemPanel.Width = flowLayoutPanel1.Width - 25;
				itemPanel.Margin = new Padding(3);

				Label typelabel = new();
				typelabel.Text = "(" + product.GetType().Name + ")";
				typelabel.AutoSize = true;
				typelabel.TextAlign = ContentAlignment.MiddleLeft;
				typelabel.TabIndex = 0;

				Label namelabel = new();
				namelabel.Text = product.Name;
				namelabel.AutoSize = true;
				namelabel.Tag = product.ID;
				namelabel.TextAlign = ContentAlignment.MiddleLeft;
				namelabel.TabIndex = tab++;

				NumericUpDown nud = new();
				nud.Width = 60;
				nud.Minimum = 0;
				nud.Value = 0;
				nud.DecimalPlaces = 0;
				nud.Tag = product;
				nud.ValueChanged += NumericUpDown_ValueChanged;

				itemPanel.Controls.Add(typelabel);
				itemPanel.Controls.Add(namelabel);
				itemPanel.Controls.Add(nud);

				int flowWidth = typelabel.Width + namelabel.Width + nud.Width + 5;
				if (flowLayoutPanel1.Width < flowWidth)
					flowLayoutPanel1.Width = flowWidth + 5;

				typelabel.Location = new Point(0, 5);
				namelabel.Location = new Point(typelabel.Width + 3, 5);
				nud.Location = new Point(flowLayoutPanel1.Width - nud.Width - 25, 2);

				flowLayoutPanel1.Controls.Add(itemPanel);
				Nuds.Add(nud);
			}
		}

		private void NumericUpDown_ValueChanged(object? sender, EventArgs e) {
			AcceptButton.Enabled = Nuds.Any(n => n.Value > 0);
		}

		private void flowLayoutPanel1_SizeChanged(object sender, EventArgs e) {
			this.Width = flowLayoutPanel1.Width + 20;
		}
	}
}
