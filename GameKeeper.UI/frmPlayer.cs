using GameKeeper.BL.Controller;
using GameKeeper.BL.Model;
using System;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class FrmPlayer : Form
    {
        public bool IsPlayerNew { get; } = true;
        public double CashInWallet { get; set; }

        private Form prevForm;
        private PlayerController playerController;
        private GroupingController groupingController;

        #region Constructor
        public FrmPlayer(string playerID)
        {
            InitializeComponent();

            prevForm = new FrmGame();
            playerController = new PlayerController(playerID);
            groupingController = new GroupingController();

            if (playerController.IsCurrentPlayerNew) ViewPanelNewPlayer(playerController);
            else
            {
                IsPlayerNew = false;
                ViewPanelCurrentPlayer(playerController);
                playerController.OnRespawn += PlayerController_OnRespawn;
                timer.Enabled = true;
                timer.Start();

                if (playerController.CurrentPlayer.IsDead) _ = playerController.DeadTimeAsync();
            }
        }
        #endregion

        private void ViewPanelNewPlayer(PlayerController playerController)
        {
            spcNewCurrent.Panel2Collapsed = true;
            Text = "Game keeper: create new player";

            tbxID.Text = playerController.CurrentPlayer.Id;
            tbxPincode.Text = playerController.CreatePincode();

            RefreshGroupingList(cbxNewGrouping);
        }

        private void ViewPanelCurrentPlayer(PlayerController playerController)
        {
            spcNewCurrent.Panel1Collapsed = true;
            Text = $"Game keeper: {playerController.CurrentPlayer.NickName}";
            CashInWallet = playerController.CurrentPlayer.Cash;
        }

        public void RefreshWindow()
        {
            lblNickname.Text = playerController.CurrentPlayer.NickName;
            lblId.Text = playerController.CurrentPlayer.Id;
            tbxCashInWallet.Text = CashInWallet.ToString();
            RefreshGroupingList(cbxCurrentGrouping);
            cbxCurrentGrouping.Text = playerController.CurrentPlayer.Grouping.Name;
            tbxPlayersState.Text = playerController.ReturnPlayerState();

            btnKillPlayer.Enabled = !playerController.CurrentPlayer.IsDead;
        }

        private void PlayerController_OnRespawn()
        {
            MessageBox.Show($"Time of dead for { playerController.CurrentPlayer.NickName} completed. He's alive.", "GameKeeper", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefreshGroupingList(ComboBox comboBox)
        {
            comboBox.DataSource = null;
            comboBox.DataSource = groupingController.Groupings;
            comboBox.DisplayMember = "Name";
        }

        #region Buttons - create player
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            var name = tbxName.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Please enter nickname for this player.", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                var grouping = cbxNewGrouping.SelectedItem.ToString();
                var pincode = tbxPincode.Text;
                double.TryParse(tbxStartCash.Text, out double cash);

                playerController.SetNewPlayerData(name, grouping, pincode, cash);

                MessageBox.Show($"\"{name}\" successfully added to game.", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                prevForm.Show();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            prevForm.Show();
        }

        #endregion

        #region Buttons - current player
        private void btnWallet_Click(object sender, EventArgs e)
        {
            FrmWallet frmWallet = new FrmWallet(this);
            frmWallet.ShowDialog();
        }

        private void btnQuests_Click(object sender, EventArgs e)
        {

        }

        private void btnKillPlayer_Click(object sender, EventArgs e)
        {
            FrmMurder frmMurder = new FrmMurder(playerController, this);
            frmMurder.ShowDialog();
        }

        private void btnViewPin_Click(object sender, EventArgs e)
        {
            var name = playerController.CurrentPlayer.NickName;
            var pincode = playerController.CurrentPlayer.PinCode;
            MessageBox.Show($"{name} have pincode: {pincode}", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Current player will be deleted.\nAre you sure?", "Game keeper", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                playerController.DelCurrentPlayer();
                Close();
                prevForm.Show();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            playerController.CurrentPlayer.Grouping = new Grouping(cbxCurrentGrouping.Text);
            playerController.CurrentPlayer.Cash = double.Parse(tbxCashInWallet.Text);
            playerController.SavePlayersData();

            Close();
            prevForm.Show();
        }
        #endregion

        private void tbxStartCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            RefreshWindow();
        }
    }
}
