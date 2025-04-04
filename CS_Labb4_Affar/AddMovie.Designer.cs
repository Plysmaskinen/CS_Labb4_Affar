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
			AddMovieRuntimeTextBox = new TextBox();
			label4 = new Label();
			AddMovieFormatTextBox = new TextBox();
			label3 = new Label();
			AddMoviePriceTextBox = new TextBox();
			label2 = new Label();
			AddMovieNameTextBox = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// AddMovieRuntimeTextBox
			// 
			AddMovieRuntimeTextBox.Location = new Point(66, 90);
			AddMovieRuntimeTextBox.Name = "AddMovieRuntimeTextBox";
			AddMovieRuntimeTextBox.Size = new Size(127, 23);
			AddMovieRuntimeTextBox.TabIndex = 10;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(4, 93);
			label4.Name = "label4";
			label4.Size = new Size(46, 15);
			label4.TabIndex = 4;
			label4.Text = "Speltid:";
			// 
			// AddMovieFormatTextBox
			// 
			AddMovieFormatTextBox.Location = new Point(66, 61);
			AddMovieFormatTextBox.Name = "AddMovieFormatTextBox";
			AddMovieFormatTextBox.Size = new Size(127, 23);
			AddMovieFormatTextBox.TabIndex = 11;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(4, 64);
			label3.Name = "label3";
			label3.Size = new Size(48, 15);
			label3.TabIndex = 5;
			label3.Text = "Format:";
			// 
			// AddMoviePriceTextBox
			// 
			AddMoviePriceTextBox.Location = new Point(66, 32);
			AddMoviePriceTextBox.Name = "AddMoviePriceTextBox";
			AddMoviePriceTextBox.Size = new Size(127, 23);
			AddMoviePriceTextBox.TabIndex = 12;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(4, 35);
			label2.Name = "label2";
			label2.Size = new Size(34, 15);
			label2.TabIndex = 6;
			label2.Text = "Pris*:";
			// 
			// AddMovieNameTextBox
			// 
			AddMovieNameTextBox.Location = new Point(66, 3);
			AddMovieNameTextBox.Name = "AddMovieNameTextBox";
			AddMovieNameTextBox.Size = new Size(127, 23);
			AddMovieNameTextBox.TabIndex = 13;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(4, 6);
			label1.Name = "label1";
			label1.Size = new Size(48, 15);
			label1.TabIndex = 7;
			label1.Text = "Namn*:";
			// 
			// AddMovie
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(AddMovieRuntimeTextBox);
			Controls.Add(label4);
			Controls.Add(AddMovieFormatTextBox);
			Controls.Add(label3);
			Controls.Add(AddMoviePriceTextBox);
			Controls.Add(label2);
			Controls.Add(AddMovieNameTextBox);
			Controls.Add(label1);
			Name = "AddMovie";
			Size = new Size(197, 120);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox AddMovieRuntimeTextBox;
		private Label label4;
		private TextBox AddMovieFormatTextBox;
		private Label label3;
		private TextBox AddMoviePriceTextBox;
		private Label label2;
		private TextBox AddMovieNameTextBox;
		private Label label1;
	}
}
