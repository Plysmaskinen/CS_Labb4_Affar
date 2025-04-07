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
			LagerOrderProductsButton = new Button();
			LagerRemoveProductButton = new Button();
			LagerAddProductButton = new Button();
			LagerHelpButton = new Button();
			tabControl1 = new TabControl();
			BookTab = new TabPage();
			GameTab = new TabPage();
			MovieTab = new TabPage();
			BookTable = new DataGridView();
			GameTable = new DataGridView();
			MovieTable = new DataGridView();
			((System.ComponentModel.ISupportInitialize)LagerSplitPanel).BeginInit();
			LagerSplitPanel.Panel1.SuspendLayout();
			LagerSplitPanel.Panel2.SuspendLayout();
			LagerSplitPanel.SuspendLayout();
			tabControl1.SuspendLayout();
			BookTab.SuspendLayout();
			GameTab.SuspendLayout();
			MovieTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)BookTable).BeginInit();
			((System.ComponentModel.ISupportInitialize)GameTable).BeginInit();
			((System.ComponentModel.ISupportInitialize)MovieTable).BeginInit();
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
			LagerSplitPanel.Panel1.Controls.Add(tabControl1);
			// 
			// LagerSplitPanel.Panel2
			// 
			LagerSplitPanel.Panel2.Controls.Add(LagerOrderProductsButton);
			LagerSplitPanel.Panel2.Controls.Add(LagerRemoveProductButton);
			LagerSplitPanel.Panel2.Controls.Add(LagerAddProductButton);
			LagerSplitPanel.Panel2.Controls.Add(LagerHelpButton);
			LagerSplitPanel.Size = new Size(792, 422);
			LagerSplitPanel.SplitterDistance = 396;
			LagerSplitPanel.SplitterWidth = 1;
			LagerSplitPanel.TabIndex = 0;
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
			// tabControl1
			// 
			tabControl1.Controls.Add(BookTab);
			tabControl1.Controls.Add(GameTab);
			tabControl1.Controls.Add(MovieTab);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(792, 396);
			tabControl1.TabIndex = 0;
			// 
			// BookTab
			// 
			BookTab.Controls.Add(BookTable);
			BookTab.Location = new Point(4, 24);
			BookTab.Name = "BookTab";
			BookTab.Padding = new Padding(3);
			BookTab.Size = new Size(784, 368);
			BookTab.TabIndex = 0;
			BookTab.Text = "Böcker";
			BookTab.UseVisualStyleBackColor = true;
			// 
			// GameTab
			// 
			GameTab.Controls.Add(GameTable);
			GameTab.Location = new Point(4, 24);
			GameTab.Name = "GameTab";
			GameTab.Padding = new Padding(3);
			GameTab.Size = new Size(784, 368);
			GameTab.TabIndex = 1;
			GameTab.Text = "Dataspel";
			GameTab.UseVisualStyleBackColor = true;
			// 
			// MovieTab
			// 
			MovieTab.Controls.Add(MovieTable);
			MovieTab.Location = new Point(4, 24);
			MovieTab.Name = "MovieTab";
			MovieTab.Size = new Size(784, 368);
			MovieTab.TabIndex = 2;
			MovieTab.Text = "Filmer";
			MovieTab.UseVisualStyleBackColor = true;
			// 
			// BookTable
			// 
			BookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			BookTable.Dock = DockStyle.Fill;
			BookTable.Location = new Point(3, 3);
			BookTable.Name = "BookTable";
			BookTable.Size = new Size(778, 362);
			BookTable.TabIndex = 0;
			// 
			// GameTable
			// 
			GameTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			GameTable.Dock = DockStyle.Fill;
			GameTable.Location = new Point(3, 3);
			GameTable.Name = "GameTable";
			GameTable.Size = new Size(778, 362);
			GameTable.TabIndex = 0;
			// 
			// MovieTable
			// 
			MovieTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			MovieTable.Dock = DockStyle.Fill;
			MovieTable.Location = new Point(0, 0);
			MovieTable.Name = "MovieTable";
			MovieTable.Size = new Size(784, 368);
			MovieTable.TabIndex = 0;
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
			((System.ComponentModel.ISupportInitialize)LagerSplitPanel).EndInit();
			LagerSplitPanel.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			BookTab.ResumeLayout(false);
			GameTab.ResumeLayout(false);
			MovieTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)BookTable).EndInit();
			((System.ComponentModel.ISupportInitialize)GameTable).EndInit();
			((System.ComponentModel.ISupportInitialize)MovieTable).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer LagerSplitPanel;
		private Button LagerRemoveProductButton;
		private Button LagerAddProductButton;
		private Button LagerHelpButton;
		private Button LagerOrderProductsButton;
		private TabControl tabControl1;
		private TabPage BookTab;
		private DataGridView BookTable;
		private TabPage GameTab;
		private DataGridView GameTable;
		private TabPage MovieTab;
		private DataGridView MovieTable;
	}
}
