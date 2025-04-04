namespace CS_Labb4_Affar {
	partial class AddGame {
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
			AddGamePlatformTextBox = new TextBox();
			label3 = new Label();
			AddGamePriceTextBox = new TextBox();
			label2 = new Label();
			AddGameNameTextBox = new TextBox();
			label1 = new Label();
			SuspendLayout();
			// 
			// AddGamePlatformTextBox
			// 
			AddGamePlatformTextBox.Location = new Point(65, 61);
			AddGamePlatformTextBox.Name = "AddGamePlatformTextBox";
			AddGamePlatformTextBox.Size = new Size(127, 23);
			AddGamePlatformTextBox.TabIndex = 11;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(3, 64);
			label3.Name = "label3";
			label3.Size = new Size(60, 15);
			label3.TabIndex = 5;
			label3.Text = "Plattform:";
			// 
			// AddGamePriceTextBox
			// 
			AddGamePriceTextBox.Location = new Point(65, 32);
			AddGamePriceTextBox.Name = "AddGamePriceTextBox";
			AddGamePriceTextBox.Size = new Size(127, 23);
			AddGamePriceTextBox.TabIndex = 12;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(3, 35);
			label2.Name = "label2";
			label2.Size = new Size(34, 15);
			label2.TabIndex = 6;
			label2.Text = "Pris*:";
			// 
			// AddGameNameTextBox
			// 
			AddGameNameTextBox.Location = new Point(65, 3);
			AddGameNameTextBox.Name = "AddGameNameTextBox";
			AddGameNameTextBox.Size = new Size(127, 23);
			AddGameNameTextBox.TabIndex = 13;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(3, 6);
			label1.Name = "label1";
			label1.Size = new Size(48, 15);
			label1.TabIndex = 7;
			label1.Text = "Namn*:";
			// 
			// AddGame
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(AddGamePlatformTextBox);
			Controls.Add(label3);
			Controls.Add(AddGamePriceTextBox);
			Controls.Add(label2);
			Controls.Add(AddGameNameTextBox);
			Controls.Add(label1);
			Name = "AddGame";
			Size = new Size(196, 90);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox AddGamePlatformTextBox;
		private Label label3;
		private TextBox AddGamePriceTextBox;
		private Label label2;
		private TextBox AddGameNameTextBox;
		private Label label1;
	}
}
