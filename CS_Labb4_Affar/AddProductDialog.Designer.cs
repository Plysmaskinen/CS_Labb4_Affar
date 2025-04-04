namespace CS_Labb4_Affar {
	partial class AddProductDialog {
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			splitContainer1 = new SplitContainer();
			ProductTypeLabel = new Label();
			ProductTypeComboBox = new ComboBox();
			splitContainer2 = new SplitContainer();
			splitContainer3 = new SplitContainer();
			AddProductCancelButton = new Button();
			AddProductAcceptButton = new Button();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
			splitContainer3.Panel1.SuspendLayout();
			splitContainer3.Panel2.SuspendLayout();
			splitContainer3.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(ProductTypeLabel);
			splitContainer1.Panel1.Controls.Add(ProductTypeComboBox);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(splitContainer2);
			splitContainer1.Size = new Size(218, 311);
			splitContainer1.SplitterDistance = 43;
			splitContainer1.TabIndex = 0;
			// 
			// ProductTypeLabel
			// 
			ProductTypeLabel.AutoSize = true;
			ProductTypeLabel.Location = new Point(14, 13);
			ProductTypeLabel.Name = "ProductTypeLabel";
			ProductTypeLabel.Size = new Size(69, 15);
			ProductTypeLabel.TabIndex = 3;
			ProductTypeLabel.Text = "Produkttyp:";
			// 
			// ProductTypeComboBox
			// 
			ProductTypeComboBox.FormattingEnabled = true;
			ProductTypeComboBox.Items.AddRange(new object[] { "Bok", "Dataspel", "Film" });
			ProductTypeComboBox.Location = new Point(89, 10);
			ProductTypeComboBox.Name = "ProductTypeComboBox";
			ProductTypeComboBox.Size = new Size(121, 23);
			ProductTypeComboBox.TabIndex = 2;
			// 
			// splitContainer2
			// 
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.Location = new Point(0, 0);
			splitContainer2.Name = "splitContainer2";
			splitContainer2.Orientation = Orientation.Horizontal;
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(splitContainer3);
			splitContainer2.Size = new Size(218, 264);
			splitContainer2.SplitterDistance = 231;
			splitContainer2.TabIndex = 0;
			// 
			// splitContainer3
			// 
			splitContainer3.Dock = DockStyle.Fill;
			splitContainer3.Location = new Point(0, 0);
			splitContainer3.Name = "splitContainer3";
			// 
			// splitContainer3.Panel1
			// 
			splitContainer3.Panel1.Controls.Add(AddProductCancelButton);
			// 
			// splitContainer3.Panel2
			// 
			splitContainer3.Panel2.Controls.Add(AddProductAcceptButton);
			splitContainer3.Size = new Size(218, 29);
			splitContainer3.SplitterDistance = 99;
			splitContainer3.TabIndex = 0;
			// 
			// AddProductCancelButton
			// 
			AddProductCancelButton.Dock = DockStyle.Fill;
			AddProductCancelButton.Location = new Point(0, 0);
			AddProductCancelButton.Name = "AddProductCancelButton";
			AddProductCancelButton.Size = new Size(99, 29);
			AddProductCancelButton.TabIndex = 0;
			AddProductCancelButton.Text = "Avbryt";
			AddProductCancelButton.UseVisualStyleBackColor = true;
			// 
			// AddProductAcceptButton
			// 
			AddProductAcceptButton.Dock = DockStyle.Fill;
			AddProductAcceptButton.Location = new Point(0, 0);
			AddProductAcceptButton.Name = "AddProductAcceptButton";
			AddProductAcceptButton.Size = new Size(115, 29);
			AddProductAcceptButton.TabIndex = 1;
			AddProductAcceptButton.Text = "Lägg Till";
			AddProductAcceptButton.UseVisualStyleBackColor = true;
			// 
			// AddProductDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(218, 311);
			Controls.Add(splitContainer1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "AddProductDialog";
			StartPosition = FormStartPosition.CenterParent;
			Text = "Lägg Till Ny Produkt";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			splitContainer3.Panel1.ResumeLayout(false);
			splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
			splitContainer3.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private Label ProductTypeLabel;
		private ComboBox ProductTypeComboBox;
		private SplitContainer splitContainer2;
		private SplitContainer splitContainer3;
		private Button AddProductCancelButton;
		private Button AddProductAcceptButton;
	}
}