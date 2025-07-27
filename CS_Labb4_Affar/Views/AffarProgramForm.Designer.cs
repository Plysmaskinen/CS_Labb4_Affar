namespace CS_Labb4_Affar
{
    partial class AffarProgramForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			tabControl1 = new TabControl();
			KassaTab = new TabPage();
			LagerTab = new TabPage();
			tabControl1.SuspendLayout();
			SuspendLayout();
			// 
			// tabControl1
			// 
			tabControl1.Controls.Add(KassaTab);
			tabControl1.Controls.Add(LagerTab);
			tabControl1.Dock = DockStyle.Fill;
			tabControl1.Location = new Point(0, 0);
			tabControl1.Name = "tabControl1";
			tabControl1.SelectedIndex = 0;
			tabControl1.Size = new Size(800, 450);
			tabControl1.TabIndex = 0;
			tabControl1.Selected += tabControl1_Selected;
			// 
			// KassaTab
			// 
			KassaTab.Location = new Point(4, 24);
			KassaTab.Name = "KassaTab";
			KassaTab.Padding = new Padding(3);
			KassaTab.Size = new Size(792, 422);
			KassaTab.TabIndex = 0;
			KassaTab.Text = "Kassa";
			KassaTab.UseVisualStyleBackColor = true;
			// 
			// LagerTab
			// 
			LagerTab.Location = new Point(4, 24);
			LagerTab.Name = "LagerTab";
			LagerTab.Padding = new Padding(3);
			LagerTab.Size = new Size(792, 422);
			LagerTab.TabIndex = 1;
			LagerTab.Text = "Lager";
			LagerTab.UseVisualStyleBackColor = true;
			// 
			// AffarProgramForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(tabControl1);
			Name = "AffarProgramForm";
			Text = "Affärssystem2000";
			Load += AffarProgramForm_Load;
			tabControl1.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private TabControl tabControl1;
		private TabPage KassaTab;
		private TabPage LagerTab;
	}
}
