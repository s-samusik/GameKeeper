using GameKeeper.BL.Controller;
using System;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class FrmWallet : Form
    {
        PlayerController playerController;

        public FrmWallet(PlayerController player)
        {
            InitializeComponent();

            playerController = player;

            RefreshWindow();
        }

        private void RefreshWindow()
        {
            tbxWallet.Text = playerController.CurrentPlayer.Cash.ToString();
            tbxAddCash.Text = string.Empty;
            tbxAddCash.Focus();
        }

        #region Buttons
        private void btnCloseWallet_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddCash_Click(object sender, EventArgs e)
        {
            var cash = double.Parse(tbxAddCash.Text);
            playerController.CurrentPlayer.Cash += cash;
            playerController.SavePlayersData();

            RefreshWindow();
        }

        private void btnRemoveCash_Click(object sender, EventArgs e)
        {
            var cash = double.Parse(tbxAddCash.Text);

            if (playerController.CurrentPlayer.Cash >= cash)
            {
                playerController.CurrentPlayer.Cash -= cash;
            }
            playerController.SavePlayersData();

            RefreshWindow();
        }

        #endregion
    }
}
