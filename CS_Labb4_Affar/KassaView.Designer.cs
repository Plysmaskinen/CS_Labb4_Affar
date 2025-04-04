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
			splitContainer3 = new SplitContainer();
			KassaInventoryListBox = new ListBox();
			KassaIdSearchRTB = new RichTextBox();
			splitContainer2 = new SplitContainer();
			KassaSummaLabel = new Label();
			KassaPrisLabel = new Label();
			KassaTillKassaButton = new Button();
			KassaTillKorgButton = new Button();
			splitContainer4 = new SplitContainer();
			KassaKorgListBox = new ListBox();
			KassaTransaktionButton = new Button();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
			splitContainer3.Panel1.SuspendLayout();
			splitContainer3.Panel2.SuspendLayout();
			splitContainer3.SuspendLayout();
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
			splitContainer1.Panel1.Controls.Add(splitContainer3);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(splitContainer2);
			splitContainer1.Size = new Size(792, 422);
			splitContainer1.SplitterDistance = 264;
			splitContainer1.TabIndex = 0;
			// 
			// splitContainer3
			// 
			splitContainer3.Dock = DockStyle.Fill;
			splitContainer3.FixedPanel = FixedPanel.Panel2;
			splitContainer3.IsSplitterFixed = true;
			splitContainer3.Location = new Point(0, 0);
			splitContainer3.Name = "splitContainer3";
			splitContainer3.Orientation = Orientation.Horizontal;
			// 
			// splitContainer3.Panel1
			// 
			splitContainer3.Panel1.Controls.Add(KassaInventoryListBox);
			// 
			// splitContainer3.Panel2
			// 
			splitContainer3.Panel2.Controls.Add(KassaIdSearchRTB);
			splitContainer3.Size = new Size(264, 422);
			splitContainer3.SplitterDistance = 393;
			splitContainer3.TabIndex = 0;
			// 
			// KassaInventoryListBox
			// 
			KassaInventoryListBox.Dock = DockStyle.Fill;
			KassaInventoryListBox.FormattingEnabled = true;
			KassaInventoryListBox.ItemHeight = 15;
			KassaInventoryListBox.Location = new Point(0, 0);
			KassaInventoryListBox.Name = "KassaInventoryListBox";
			KassaInventoryListBox.Size = new Size(264, 393);
			KassaInventoryListBox.TabIndex = 0;
			// 
			// KassaIdSearchRTB
			// 
			KassaIdSearchRTB.Dock = DockStyle.Fill;
			KassaIdSearchRTB.Location = new Point(0, 0);
			KassaIdSearchRTB.Multiline = false;
			KassaIdSearchRTB.Name = "KassaIdSearchRTB";
			KassaIdSearchRTB.Size = new Size(264, 25);
			KassaIdSearchRTB.TabIndex = 0;
			KassaIdSearchRTB.Text = "ID:";
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
			splitContainer2.Panel1.Controls.Add(KassaTillKassaButton);
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
			// KassaTillKassaButton
			// 
			KassaTillKassaButton.Enabled = false;
			KassaTillKassaButton.Location = new Point(66, 179);
			KassaTillKassaButton.Name = "KassaTillKassaButton";
			KassaTillKassaButton.Size = new Size(133, 23);
			KassaTillKassaButton.TabIndex = 1;
			KassaTillKassaButton.Text = "Ta Bort Från Varukorg";
			KassaTillKassaButton.UseVisualStyleBackColor = true;
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
			splitContainer3.Panel1.ResumeLayout(false);
			splitContainer3.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
			splitContainer3.ResumeLayout(false);
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
		private SplitContainer splitContainer3;
		private ListBox KassaInventoryListBox;
		private SplitContainer splitContainer2;
		private Label KassaSummaLabel;
		private Label KassaPrisLabel;
		private Button KassaTillKassaButton;
		private Button KassaTillKorgButton;
		private SplitContainer splitContainer4;
		private ListBox KassaKorgListBox;
		private Button KassaTransaktionButton;
		private RichTextBox KassaIdSearchRTB;
	}
}
