namespace CS_Labb4_Affar {
	partial class KassaView {
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
			splitContainer1 = new SplitContainer();
			KassaInventoryListBox = new ListBox();
			splitContainer2 = new SplitContainer();
			KassaSummaLabel = new Label();
			KassaPrisLabel = new Label();
			KorgTillKassaButton = new Button();
			KassaTillKorgButton = new Button();
			splitContainer4 = new SplitContainer();
			KassaKorgListBox = new ListBox();
			KassaTransaktionButton = new Button();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
			splitContainer2.Panel1.SuspendLayout();
			splitContainer2.Panel2.SuspendLayout();
			splitContainer2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
			splitContainer4.Panel1.SuspendLayout();
			splitContainer4.Panel2.SuspendLayout();
			splitContainer4.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.IsSplitterFixed = true;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(KassaInventoryListBox);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(splitContainer2);
			splitContainer1.Size = new Size(792, 422);
			splitContainer1.SplitterDistance = 264;
			splitContainer1.TabIndex = 0;
			// 
			// KassaInventoryListBox
			// 
			KassaInventoryListBox.Dock = DockStyle.Fill;
			KassaInventoryListBox.FormattingEnabled = true;
			KassaInventoryListBox.ItemHeight = 15;
			KassaInventoryListBox.Location = new Point(0, 0);
			KassaInventoryListBox.Name = "KassaInventoryListBox";
			KassaInventoryListBox.Size = new Size(264, 422);
			KassaInventoryListBox.TabIndex = 1;
			KassaInventoryListBox.SelectedIndexChanged += KassaInventoryListBox_SelectedIndexChanged;
			// 
			// splitContainer2
			// 
			splitContainer2.Dock = DockStyle.Fill;
			splitContainer2.IsSplitterFixed = true;
			splitContainer2.Location = new Point(0, 0);
			splitContainer2.Name = "splitContainer2";
			// 
			// splitContainer2.Panel1
			// 
			splitContainer2.Panel1.Controls.Add(KassaSummaLabel);
			splitContainer2.Panel1.Controls.Add(KassaPrisLabel);
			splitContainer2.Panel1.Controls.Add(KorgTillKassaButton);
			splitContainer2.Panel1.Controls.Add(KassaTillKorgButton);
			// 
			// splitContainer2.Panel2
			// 
			splitContainer2.Panel2.Controls.Add(splitContainer4);
			splitContainer2.Size = new Size(524, 422);
			splitContainer2.SplitterDistance = 264;
			splitContainer2.TabIndex = 0;
			// 
			// KassaSummaLabel
			// 
			KassaSummaLabel.AutoSize = true;
			KassaSummaLabel.Location = new Point(93, 291);
			KassaSummaLabel.Name = "KassaSummaLabel";
			KassaSummaLabel.Size = new Size(13, 15);
			KassaSummaLabel.TabIndex = 3;
			KassaSummaLabel.Text = "0";
			// 
			// KassaPrisLabel
			// 
			KassaPrisLabel.AutoSize = true;
			KassaPrisLabel.Location = new Point(93, 266);
			KassaPrisLabel.Name = "KassaPrisLabel";
			KassaPrisLabel.Size = new Size(69, 15);
			KassaPrisLabel.TabIndex = 2;
			KassaPrisLabel.Text = "Prissumma:";
			// 
			// KorgTillKassaButton
			// 
			KorgTillKassaButton.Enabled = false;
			KorgTillKassaButton.Location = new Point(66, 179);
			KorgTillKassaButton.Name = "KorgTillKassaButton";
			KorgTillKassaButton.Size = new Size(133, 23);
			KorgTillKassaButton.TabIndex = 1;
			KorgTillKassaButton.Text = "Ta Bort Från Varukorg";
			KorgTillKassaButton.UseVisualStyleBackColor = true;
			KorgTillKassaButton.Click += KorgTillKassaButton_Click;
			// 
			// KassaTillKorgButton
			// 
			KassaTillKorgButton.Enabled = false;
			KassaTillKorgButton.Location = new Point(66, 77);
			KassaTillKorgButton.Name = "KassaTillKorgButton";
			KassaTillKorgButton.Size = new Size(133, 23);
			KassaTillKorgButton.TabIndex = 0;
			KassaTillKorgButton.Text = "Lägg Till I Varukorg";
			KassaTillKorgButton.UseVisualStyleBackColor = true;
			KassaTillKorgButton.Click += KassaTillKorgButton_Click;
			// 
			// splitContainer4
			// 
			splitContainer4.Dock = DockStyle.Fill;
			splitContainer4.FixedPanel = FixedPanel.Panel2;
			splitContainer4.IsSplitterFixed = true;
			splitContainer4.Location = new Point(0, 0);
			splitContainer4.Name = "splitContainer4";
			splitContainer4.Orientation = Orientation.Horizontal;
			// 
			// splitContainer4.Panel1
			// 
			splitContainer4.Panel1.Controls.Add(KassaKorgListBox);
			// 
			// splitContainer4.Panel2
			// 
			splitContainer4.Panel2.Controls.Add(KassaTransaktionButton);
			splitContainer4.Size = new Size(256, 422);
			splitContainer4.SplitterDistance = 393;
			splitContainer4.TabIndex = 1;
			// 
			// KassaKorgListBox
			// 
			KassaKorgListBox.Dock = DockStyle.Fill;
			KassaKorgListBox.FormattingEnabled = true;
			KassaKorgListBox.ItemHeight = 15;
			KassaKorgListBox.Location = new Point(0, 0);
			KassaKorgListBox.Name = "KassaKorgListBox";
			KassaKorgListBox.Size = new Size(256, 393);
			KassaKorgListBox.TabIndex = 1;
			KassaKorgListBox.SelectedIndexChanged += KassaKorgListBox_SelectedIndexChanged;
			// 
			// KassaTransaktionButton
			// 
			KassaTransaktionButton.Dock = DockStyle.Fill;
			KassaTransaktionButton.Location = new Point(0, 0);
			KassaTransaktionButton.Name = "KassaTransaktionButton";
			KassaTransaktionButton.Size = new Size(256, 25);
			KassaTransaktionButton.TabIndex = 0;
			KassaTransaktionButton.Text = "Genomför Transaktion";
			KassaTransaktionButton.UseVisualStyleBackColor = true;
			KassaTransaktionButton.Click += KassaTransaktionButton_Click;
			// 
			// KassaView
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(splitContainer1);
			Name = "KassaView";
			Size = new Size(792, 422);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			splitContainer2.Panel1.ResumeLayout(false);
			splitContainer2.Panel1.PerformLayout();
			splitContainer2.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
			splitContainer2.ResumeLayout(false);
			splitContainer4.Panel1.ResumeLayout(false);
			splitContainer4.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
			splitContainer4.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private SplitContainer splitContainer2;
		private Label KassaSummaLabel;
		private Label KassaPrisLabel;
		private Button KorgTillKassaButton;
		private Button KassaTillKorgButton;
		private SplitContainer splitContainer4;
		private ListBox KassaKorgListBox;
		private Button KassaTransaktionButton;
		private ListBox KassaInventoryListBox;
	}
}
