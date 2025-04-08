namespace CS_Labb4_Affar {
	partial class OrderProductsDialog {
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
			flowLayoutPanel1 = new FlowLayoutPanel();
			CancelButton = new Button();
			AcceptButton = new Button();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// splitContainer1
			// 
			splitContainer1.Dock = DockStyle.Fill;
			splitContainer1.FixedPanel = FixedPanel.Panel2;
			splitContainer1.IsSplitterFixed = true;
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Name = "splitContainer1";
			splitContainer1.Orientation = Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(CancelButton);
			splitContainer1.Panel2.Controls.Add(AcceptButton);
			splitContainer1.Size = new Size(295, 570);
			splitContainer1.SplitterDistance = 540;
			splitContainer1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			flowLayoutPanel1.AutoScroll = true;
			flowLayoutPanel1.Dock = DockStyle.Fill;
			flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
			flowLayoutPanel1.Location = new Point(0, 0);
			flowLayoutPanel1.Name = "flowLayoutPanel1";
			flowLayoutPanel1.Size = new Size(295, 540);
			flowLayoutPanel1.TabIndex = 0;
			flowLayoutPanel1.WrapContents = false;
			flowLayoutPanel1.SizeChanged += flowLayoutPanel1_SizeChanged;
			// 
			// CancelButton
			// 
			CancelButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			CancelButton.Location = new Point(136, 0);
			CancelButton.Name = "CancelButton";
			CancelButton.Size = new Size(75, 23);
			CancelButton.TabIndex = 1;
			CancelButton.Text = "Avbryt";
			CancelButton.UseVisualStyleBackColor = true;
			CancelButton.Click += CancelButton_Click;
			// 
			// AcceptButton
			// 
			AcceptButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			AcceptButton.Enabled = false;
			AcceptButton.Location = new Point(217, 0);
			AcceptButton.Name = "AcceptButton";
			AcceptButton.Size = new Size(75, 23);
			AcceptButton.TabIndex = 0;
			AcceptButton.Text = "Beställ";
			AcceptButton.UseVisualStyleBackColor = true;
			AcceptButton.Click += AcceptButton_Click;
			// 
			// OrderProductsDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(295, 570);
			Controls.Add(splitContainer1);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "OrderProductsDialog";
			Text = "Beställ Varor";
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private SplitContainer splitContainer1;
		private Button CancelButton;
		private Button AcceptButton;
		private FlowLayoutPanel flowLayoutPanel1;
	}
}