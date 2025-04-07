using CS_Labb4_Affar.Controllers;

namespace CS_Labb4_Affar
{
	public partial class AffarProgramForm : Form {
		LagerController lagerController;
		KassaController kassaController;
		DatabaseController databaseController;
		LagerView lagerUI;
		KassaView kassaUI;
		public AffarProgramForm() {
			InitializeComponent();
			lagerController = new LagerController();
			kassaController = new KassaController();
			databaseController = new DatabaseController(lagerController);

			lagerUI = new LagerView(lagerController);
			kassaUI = new KassaView(kassaController);
			kassaUI.Dock = DockStyle.Fill;
			lagerUI.Dock = DockStyle.Fill;
			KassaTab.Controls.Add(kassaUI);
			LagerTab.Controls.Add(lagerUI);
			databaseController.DatabaseWriteListenerAttach(lagerUI);
			databaseController.DatabaseReadListenerAttach(lagerUI);
		}

		private void AffarProgramForm_Load(object sender, EventArgs e) {
			lagerUI.Load();
		}
	}
}
