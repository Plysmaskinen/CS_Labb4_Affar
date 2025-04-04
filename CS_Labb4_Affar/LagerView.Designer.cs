namespace CS_Labb4_Affar {
	partial class LagerView {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			LagerSplitPanel = new SplitContainer();
			LagerDataGridView = new DataGridView();
			label1 = new Label();
			LagerComboBox = new ComboBox();
			LagerOrderProductsButton = new Button();
			LagerRemoveProductButton = new Button();
			LagerAddProductButton = new Button();
			LagerHelpButton = new Button();
			((System.ComponentModel.ISupportInitialize)LagerSplitPanel).BeginInit();
			LagerSplitPanel.Panel1.SuspendLayout();
			LagerSplitPanel.Panel2.SuspendLayout();
			LagerSplitPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)LagerDataGridView).BeginInit();
			SuspendLayout();
			// 
			// LagerSplitPanel
			// 
			LagerSplitPanel.Dock = DockStyle.Fill;
			LagerSplitPanel.FixedPanel = FixedPanel.Panel2;
			LagerSplitPanel.IsSplitterFixed = true;
			LagerSplitPanel.Location = new Point(0, 0);
			LagerSplitPanel.Name = "LagerSplitPanel";
			LagerSplitPanel.Orientation = Orientation.Horizontal;
			// 
			// LagerSplitPanel.Panel1
			// 
			LagerSplitPanel.Panel1.Controls.Add(LagerDataGridView);
			// 
			// LagerSplitPanel.Panel2
			// 
			LagerSplitPanel.Panel2.Controls.Add(label1);
			LagerSplitPanel.Panel2.Controls.Add(LagerComboBox);
			LagerSplitPanel.Panel2.Controls.Add(LagerOrderProductsButton);
			LagerSplitPanel.Panel2.Controls.Add(LagerRemoveProductButton);
			LagerSplitPanel.Panel2.Controls.Add(LagerAddProductButton);
			LagerSplitPanel.Panel2.Controls.Add(LagerHelpButton);
			LagerSplitPanel.Size = new Size(792, 422);
			LagerSplitPanel.SplitterDistance = 396;
			LagerSplitPanel.SplitterWidth = 1;
			LagerSplitPanel.TabIndex = 0;
			// 
			// LagerDataGridView
			// 
			LagerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			LagerDataGridView.Dock = DockStyle.Fill;
			LagerDataGridView.Location = new Point(0, 0);
			LagerDataGridView.Name = "LagerDataGridView";
			LagerDataGridView.Size = new Size(792, 396);
			LagerDataGridView.TabIndex = 0;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(430, 7);
			label1.Name = "label1";
			label1.Size = new Size(93, 15);
			label1.TabIndex = 2;
			label1.Text = "Kollapsa Till Typ:";
			// 
			// LagerComboBox
			// 
			LagerComboBox.Font = new Font("Segoe UI", 8F);
			LagerComboBox.FormattingEnabled = true;
			LagerComboBox.Items.AddRange(new object[] { "Kollapsa ej", "Böcker", "Dataspel", "Filmer" });
			LagerComboBox.Location = new Point(529, 3);
			LagerComboBox.Name = "LagerComboBox";
			LagerComboBox.Size = new Size(121, 21);
			LagerComboBox.TabIndex = 1;
			LagerComboBox.SelectedIndexChanged += LagerComboBox_SelectedIndexChanged;
			// 
			// LagerOrderProductsButton
			// 
			LagerOrderProductsButton.Location = new Point(287, 3);
			LagerOrderProductsButton.Name = "LagerOrderProductsButton";
			LagerOrderProductsButton.Size = new Size(138, 23);
			LagerOrderProductsButton.TabIndex = 0;
			LagerOrderProductsButton.Text = "Beställ Produkter";
			LagerOrderProductsButton.UseVisualStyleBackColor = true;
			LagerOrderProductsButton.Click += LagerOrderProductsButton_Click;
			// 
			// LagerRemoveProductButton
			// 
			LagerRemoveProductButton.Enabled = false;
			LagerRemoveProductButton.Location = new Point(144, 3);
			LagerRemoveProductButton.Name = "LagerRemoveProductButton";
			LagerRemoveProductButton.Size = new Size(138, 23);
			LagerRemoveProductButton.TabIndex = 0;
			LagerRemoveProductButton.Text = "Ta Bort Produkt ";
			LagerRemoveProductButton.UseVisualStyleBackColor = true;
			// 
			// LagerAddProductButton
			// 
			LagerAddProductButton.Location = new Point(0, 3);
			LagerAddProductButton.Name = "LagerAddProductButton";
			LagerAddProductButton.Size = new Size(138, 23);
			LagerAddProductButton.TabIndex = 0;
			LagerAddProductButton.Text = "Lägg Till Ny Produkt";
			LagerAddProductButton.UseVisualStyleBackColor = true;
			LagerAddProductButton.Click += LagerAddProductButton_Click;
			// 
			// LagerHelpButton
			// 
			LagerHelpButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			LagerHelpButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
			LagerHelpButton.Location = new Point(770, 3);
			LagerHelpButton.Name = "LagerHelpButton";
			LagerHelpButton.Size = new Size(23, 23);
			LagerHelpButton.TabIndex = 0;
			LagerHelpButton.Text = "?";
			LagerHelpButton.UseVisualStyleBackColor = true;
			LagerHelpButton.Click += LagerHelpButton_Click;
			// 
			// LagerView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(LagerSplitPanel);
			Name = "LagerView";
			Size = new Size(792, 422);
			LagerSplitPanel.Panel1.ResumeLayout(false);
			LagerSplitPanel.Panel2.ResumeLayout(false);
			LagerSplitPanel.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)LagerSplitPanel).EndInit();
			LagerSplitPanel.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)LagerDataGridView).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer LagerSplitPanel;
		private DataGridView LagerDataGridView;
		private Button LagerRemoveProductButton;
		private Button LagerAddProductButton;
		private Button LagerHelpButton;
		private Button LagerOrderProductsButton;
		private Label label1;
		private ComboBox LagerComboBox;
	}
}
