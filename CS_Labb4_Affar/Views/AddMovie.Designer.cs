namespace CS_Labb4_Affar {
	partial class AddMovie {
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
			label4 = new Label();
			label3 = new Label();
			label2 = new Label();
			label1 = new Label();
			maskedTextBox1 = new MaskedTextBox();
			maskedTextBox2 = new MaskedTextBox();
			maskedTextBox3 = new MaskedTextBox();
			maskedTextBox4 = new MaskedTextBox();
			SuspendLayout();
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(4, 93);
			label4.Name = "label4";
			label4.Size = new Size(46, 15);
			label4.TabIndex = 10;
			label4.Text = "Speltid:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(4, 64);
			label3.Name = "label3";
			label3.Size = new Size(48, 15);
			label3.TabIndex = 10;
			label3.Text = "Format:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(4, 35);
			label2.Name = "label2";
			label2.Size = new Size(34, 15);
			label2.TabIndex = 10;
			label2.Text = "Pris*:";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(4, 6);
			label1.Name = "label1";
			label1.Size = new Size(48, 15);
			label1.TabIndex = 10;
			label1.Text = "Namn*:";
			// 
			// maskedTextBox1
			// 
			maskedTextBox1.Location = new Point(66, 3);
			maskedTextBox1.Name = "maskedTextBox1";
			maskedTextBox1.Size = new Size(127, 23);
			maskedTextBox1.TabIndex = 1;
			// 
			// maskedTextBox2
			// 
			maskedTextBox2.Location = new Point(66, 32);
			maskedTextBox2.Mask = "999999999999";
			maskedTextBox2.Name = "maskedTextBox2";
			maskedTextBox2.Size = new Size(127, 23);
			maskedTextBox2.TabIndex = 2;
			maskedTextBox2.ValidatingType = typeof(int);
			// 
			// maskedTextBox3
			// 
			maskedTextBox3.Location = new Point(66, 61);
			maskedTextBox3.Name = "maskedTextBox3";
			maskedTextBox3.Size = new Size(127, 23);
			maskedTextBox3.TabIndex = 3;
			// 
			// maskedTextBox4
			// 
			maskedTextBox4.Location = new Point(66, 90);
			maskedTextBox4.Mask = "999999999999";
			maskedTextBox4.Name = "maskedTextBox4";
			maskedTextBox4.Size = new Size(127, 23);
			maskedTextBox4.TabIndex = 4;
			maskedTextBox4.ValidatingType = typeof(int);
			// 
			// AddMovie
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(maskedTextBox4);
			Controls.Add(maskedTextBox3);
			Controls.Add(maskedTextBox2);
			Controls.Add(maskedTextBox1);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "AddMovie";
			Size = new Size(197, 118);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Label label4;
		private Label label3;
		private Label label2;
		private Label label1;
		private MaskedTextBox maskedTextBox1;
		private MaskedTextBox maskedTextBox2;
		private MaskedTextBox maskedTextBox3;
		private MaskedTextBox maskedTextBox4;
	}
}
