namespace CS_Labb4_Affar {
	partial class AddBook {
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			maskedTextBox1 = new MaskedTextBox();
			maskedTextBox2 = new MaskedTextBox();
			maskedTextBox3 = new MaskedTextBox();
			maskedTextBox4 = new MaskedTextBox();
			maskedTextBox5 = new MaskedTextBox();
			maskedTextBox6 = new MaskedTextBox();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 7);
			label1.Name = "label1";
			label1.Size = new Size(48, 15);
			label1.TabIndex = 10;
			label1.Text = "Namn*:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 36);
			label2.Name = "label2";
			label2.Size = new Size(34, 15);
			label2.TabIndex = 10;
			label2.Text = "Pris*:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 65);
			label3.Name = "label3";
			label3.Size = new Size(61, 15);
			label3.TabIndex = 10;
			label3.Text = "Författare:";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(3, 94);
			label4.Name = "label4";
			label4.Size = new Size(41, 15);
			label4.TabIndex = 10;
			label4.Text = "Genre:";
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(3, 123);
			label5.Name = "label5";
			label5.Size = new Size(48, 15);
			label5.TabIndex = 10;
			label5.Text = "Format:";
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(3, 152);
			label6.Name = "label6";
			label6.Size = new Size(39, 15);
			label6.TabIndex = 10;
			label6.Text = "Språk:";
			// 
			// maskedTextBox1
			// 
			maskedTextBox1.Location = new Point(65, 4);
			maskedTextBox1.Name = "maskedTextBox1";
			maskedTextBox1.Size = new Size(127, 23);
			maskedTextBox1.TabIndex = 1;
			// 
			// maskedTextBox2
			// 
			maskedTextBox2.Location = new Point(65, 33);
			maskedTextBox2.Mask = "999999999999";
			maskedTextBox2.Name = "maskedTextBox2";
			maskedTextBox2.Size = new Size(127, 23);
			maskedTextBox2.TabIndex = 2;
			maskedTextBox2.ValidatingType = typeof(int);
			// 
			// maskedTextBox3
			// 
			maskedTextBox3.Location = new Point(65, 62);
			maskedTextBox3.Name = "maskedTextBox3";
			maskedTextBox3.Size = new Size(127, 23);
			maskedTextBox3.TabIndex = 3;
			// 
			// maskedTextBox4
			// 
			maskedTextBox4.Location = new Point(65, 91);
			maskedTextBox4.Name = "maskedTextBox4";
			maskedTextBox4.Size = new Size(127, 23);
			maskedTextBox4.TabIndex = 4;
			// 
			// maskedTextBox5
			// 
			maskedTextBox5.Location = new Point(65, 120);
			maskedTextBox5.Name = "maskedTextBox5";
			maskedTextBox5.Size = new Size(127, 23);
			maskedTextBox5.TabIndex = 5;
			// 
			// maskedTextBox6
			// 
			maskedTextBox6.Location = new Point(65, 149);
			maskedTextBox6.Name = "maskedTextBox6";
			maskedTextBox6.Size = new Size(127, 23);
			maskedTextBox6.TabIndex = 6;
			// 
			// AddBook
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(maskedTextBox6);
			Controls.Add(maskedTextBox5);
			Controls.Add(maskedTextBox4);
			Controls.Add(maskedTextBox3);
			Controls.Add(maskedTextBox2);
			Controls.Add(maskedTextBox1);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "AddBook";
			Size = new Size(195, 176);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private MaskedTextBox maskedTextBox1;
		private MaskedTextBox maskedTextBox2;
		private MaskedTextBox maskedTextBox3;
		private MaskedTextBox maskedTextBox4;
		private MaskedTextBox maskedTextBox5;
		private MaskedTextBox maskedTextBox6;
	}
}
