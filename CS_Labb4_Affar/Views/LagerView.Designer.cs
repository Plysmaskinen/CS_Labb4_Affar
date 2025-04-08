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
			tabControl1 = new TabControl();
			BookTab = new TabPage();
			BookTable = new DataGridView();
			GameTab = new TabPage();
			GameTable = new DataGridView();
			MovieTab = new TabPage();
			MovieTable = new DataGridView();
			LagerOrderProductsButton = new Button();
			LagerRemoveProductButton = new Button();
			LagerAddProductButton = new Button();
			LagerHelpButton = new Button();
			((System.ComponentModel.ISupportInitialize)LagerSplitPanel).BeginInit();
			LagerSplitPanel.Panel1.SuspendLayout();
			LagerSplitPanel.Panel2.SuspendLayout();
			LagerSplitPanel.SuspendLayout();
			tabControl1.SuspendLayout();
			BookTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)BookTable).BeginInit();
			GameTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)GameTable).BeginInit();
			MovieTab.SuspendLayout();
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
			tabControl1.Selected += tabControl1_Selected;
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
			// BookTable
			// 
			BookTable.AllowUserToAddRows = false;
			BookTable.AllowUserToDeleteRows = false;
			BookTable.AllowUserToResizeColumns = false;
			BookTable.AllowUserToResizeRows = false;
			BookTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			BookTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			BookTable.Dock = DockStyle.Fill;
			BookTable.Location = new Point(3, 3);
			BookTable.MultiSelect = false;
			BookTable.Name = "BookTable";
			BookTable.ReadOnly = true;
			BookTable.RowHeadersVisible = false;
			BookTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			BookTable.Size = new Size(778, 362);
			BookTable.TabIndex = 0;
			BookTable.DataBindingComplete += BookTable_DataBindingComplete;
			BookTable.SelectionChanged += BookTable_SelectionChanged;
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
			// GameTable
			// 
			GameTable.AllowUserToAddRows = false;
			GameTable.AllowUserToDeleteRows = false;
			GameTable.AllowUserToResizeColumns = false;
			GameTable.AllowUserToResizeRows = false;
			GameTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			GameTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			GameTable.Dock = DockStyle.Fill;
			GameTable.Location = new Point(3, 3);
			GameTable.MultiSelect = false;
			GameTable.Name = "GameTable";
			GameTable.ReadOnly = true;
			GameTable.RowHeadersVisible = false;
			GameTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			GameTable.Size = new Size(778, 362);
			GameTable.TabIndex = 0;
			GameTable.DataBindingComplete += GameTable_DataBindingComplete;
			GameTable.SelectionChanged += GameTable_SelectionChanged;
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
			// MovieTable
			// 
			MovieTable.AllowUserToAddRows = false;
			MovieTable.AllowUserToDeleteRows = false;
			MovieTable.AllowUserToResizeColumns = false;
			MovieTable.AllowUserToResizeRows = false;
			MovieTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			MovieTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			MovieTable.Dock = DockStyle.Fill;
			MovieTable.Location = new Point(0, 0);
			MovieTable.MultiSelect = false;
			MovieTable.Name = "MovieTable";
			MovieTable.ReadOnly = true;
			MovieTable.RowHeadersVisible = false;
			MovieTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			MovieTable.Size = new Size(784, 368);
			MovieTable.TabIndex = 0;
			MovieTable.DataBindingComplete += MovieTable_DataBindingComplete;
			MovieTable.SelectionChanged += MovieTable_SelectionChanged;
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
			LagerRemoveProductButton.Click += LagerRemoveProductButton_Click;
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
			((System.ComponentModel.ISupportInitialize)LagerSplitPanel).EndInit();
			LagerSplitPanel.ResumeLayout(false);
			tabControl1.ResumeLayout(false);
			BookTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)BookTable).EndInit();
			GameTab.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)GameTable).EndInit();
			MovieTab.ResumeLayout(false);
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
