using CS_Labb4_Affar.Controllers;

namespace CS_Labb4_Affar
{
	public partial class AffarProgramForm : Form {
		LagerController lagerController;
		DatabaseController databaseController;
		LagerView lagerUI;
		KassaView kassaUI;
		public AffarProgramForm() {
			InitializeComponent();
			lagerController = new LagerController();
			databaseController = new DatabaseController(lagerController);

			lagerUI = new LagerView(lagerController);
			kassaUI = new KassaView(lagerController, lagerUI);
			kassaUI.Dock = DockStyle.Fill;
			lagerUI.Dock = DockStyle.Fill;
			KassaTab.Controls.Add(kassaUI);
			LagerTab.Controls.Add(lagerUI);
			databaseController.DatabaseWriteListenerAttach(lagerUI);
			databaseController.DatabaseReadListenerAttach(lagerUI);
			lagerController.LoadKassaListsListenerAttach(lagerUI);
			kassaUI.KassaListAttachListenerattach(lagerController);
		}

		private void AffarProgramForm_Load(object sender, EventArgs e) {
			lagerUI.Load();
		}

		private void tabControl1_Selected(object sender, TabControlEventArgs e) {
			if (e.TabPage == KassaTab)
				//kassaUI.Load();
				return;
				
		}
	}
}
