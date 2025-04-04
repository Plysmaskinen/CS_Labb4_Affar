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
			AddBookNameTextBox = new TextBox();
			label2 = new Label();
			AddBookPriceTextBox = new TextBox();
			label3 = new Label();
			AddBookAuthTextBox = new TextBox();
			label4 = new Label();
			AddBookGenreTextBox = new TextBox();
			label5 = new Label();
			AddBookFormatTextBox = new TextBox();
			label6 = new Label();
			AddBookLangTextBox = new TextBox();
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
			// AddBookNameTextBox
			// 
			AddBookNameTextBox.Location = new Point(65, 4);
			AddBookNameTextBox.Name = "AddBookNameTextBox";
			AddBookNameTextBox.Size = new Size(127, 23);
			AddBookNameTextBox.TabIndex = 0;
			AddBookNameTextBox.Text = "ett";
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
			// AddBookPriceTextBox
			// 
			AddBookPriceTextBox.Location = new Point(65, 33);
			AddBookPriceTextBox.Name = "AddBookPriceTextBox";
			AddBookPriceTextBox.Size = new Size(127, 23);
			AddBookPriceTextBox.TabIndex = 1;
			AddBookPriceTextBox.Text = "123";
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
			// AddBookAuthTextBox
			// 
			AddBookAuthTextBox.Location = new Point(65, 62);
			AddBookAuthTextBox.Name = "AddBookAuthTextBox";
			AddBookAuthTextBox.Size = new Size(127, 23);
			AddBookAuthTextBox.TabIndex = 2;
			AddBookAuthTextBox.Text = "två";
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
			// AddBookGenreTextBox
			// 
			AddBookGenreTextBox.Location = new Point(65, 91);
			AddBookGenreTextBox.Name = "AddBookGenreTextBox";
			AddBookGenreTextBox.Size = new Size(127, 23);
			AddBookGenreTextBox.TabIndex = 3;
			AddBookGenreTextBox.Text = "tre";
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
			// AddBookFormatTextBox
			// 
			AddBookFormatTextBox.Location = new Point(65, 120);
			AddBookFormatTextBox.Name = "AddBookFormatTextBox";
			AddBookFormatTextBox.Size = new Size(127, 23);
			AddBookFormatTextBox.TabIndex = 4;
			AddBookFormatTextBox.Text = "fyra";
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
			// AddBookLangTextBox
			// 
			AddBookLangTextBox.Location = new Point(65, 149);
			AddBookLangTextBox.Name = "AddBookLangTextBox";
			AddBookLangTextBox.Size = new Size(127, 23);
			AddBookLangTextBox.TabIndex = 5;
			AddBookLangTextBox.Text = "fem";
			// 
			// AddBook
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(AddBookLangTextBox);
			Controls.Add(label6);
			Controls.Add(AddBookFormatTextBox);
			Controls.Add(label5);
			Controls.Add(AddBookGenreTextBox);
			Controls.Add(label4);
			Controls.Add(AddBookAuthTextBox);
			Controls.Add(label3);
			Controls.Add(AddBookPriceTextBox);
			Controls.Add(label2);
			Controls.Add(AddBookNameTextBox);
			Controls.Add(label1);
			Name = "AddBook";
			Size = new Size(195, 176);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox AddBookNameTextBox;
		private Label label2;
		private TextBox AddBookPriceTextBox;
		private Label label3;
		private TextBox AddBookAuthTextBox;
		private Label label4;
		private TextBox AddBookGenreTextBox;
		private Label label5;
		private TextBox AddBookFormatTextBox;
		private Label label6;
		private TextBox AddBookLangTextBox;
	}
}
