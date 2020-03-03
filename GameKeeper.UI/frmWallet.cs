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
            tbxInWallet.Text = playerController.CurrentPlayer.Cash.ToString();
            tbxCashAmount.Text = "0";
            tbxCashAmount.Focus();
        }

        #region Buttons
        private void btnCloseWallet_Click(object sender, EventArgs e)
        {
            Close();
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
            playerController.WithdrawFromWallet(cash);
            RefreshWindow();
        }
        #endregion

        private void tbxCashAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
