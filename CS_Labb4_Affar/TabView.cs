namespace CS_Labb4_Affar
{
	public partial class TabView : Form {
		LagerController lagerController;
		KassaController kassaController;
		LagerView lagerUI;
		KassaView kassaUI;
		public TabView() {
			InitializeComponent();
			lagerController = new LagerController();
			kassaController = new KassaController();
			lagerUI = new LagerView(lagerController);
			kassaUI = new KassaView(kassaController);
			kassaUI.Dock = DockStyle.Fill;
			lagerUI.Dock = DockStyle.Fill;
			KassaTab.Controls.Add(kassaUI);
			LagerTab.Controls.Add(lagerUI);
			lagerController.LagerListenerAttach(lagerUI);
		}

		private void TabView_Load(object sender, EventArgs e) {

		}
	}
}
