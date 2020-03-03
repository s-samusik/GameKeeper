using GameKeeper.BL.Controller;
using System;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class FrmWallet : Form
    {
        PlayerController playerController;
        FrmPlayer prevForm;
        public FrmWallet(PlayerController player)
        {
            InitializeComponent();
            playerController = player;
            prevForm = new FrmPlayer(playerController.CurrentPlayer.Id);

            RefreshWindow();
        }

        private void RefreshWindow()
        {
            tbxInWallet.Text = playerController.CurrentPlayer.Cash.ToString();
            tbxCashAmount.Text = "0";
            tbxCashAmount.Focus();
        }

        #region Buttons
        private void btnCloseWallet_Click(object sender, EventArgs e)
        {
            Close();
            prevForm.Show();
        }

        private void btnAddCash_Click(object sender, EventArgs e)
        {
            var cash = double.Parse(tbxCashAmount.Text);
            playerController.PutInWallet(cash);
            RefreshWindow();
        }

        private void btnRemoveCash_Click(object sender, EventArgs e)
        {
            var cash = double.Parse(tbxCashAmount.Text);

            if (playerController.WithdrawFromWallet(cash))
            {
                RefreshWindow();
            }
            else
            {
                MessageBox.Show("Cash amount is more than cash in the wallet.","Game Keeper",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
        #endregion

        private void tbxCashAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
