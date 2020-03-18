using System;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class FrmWallet : Form
    {
        private FrmPlayer prevForm;
        private double cashResult;

        #region Constructor
        public FrmWallet(FrmPlayer form)
        {
            InitializeComponent();
            prevForm = form;
            cashResult = prevForm.CashInWallet;

            RefreshWindow();
        }
        #endregion
        private void RefreshWindow()
        {
            tbxCashAmount.Text = "0";
            tbxCashAmount.Focus();
            tbxInWallet.Text = cashResult.ToString();
        }

        #region Buttons
        private void btnCloseWallet_Click(object sender, EventArgs e)
        {
            prevForm.CashInWallet = double.Parse(tbxInWallet.Text);
            Close();
        }

        private void btnAddCash_Click(object sender, EventArgs e)
        {
            double.TryParse(tbxCashAmount.Text, out var cash);
            cashResult += cash;

            RefreshWindow();
        }

        private void btnRemoveCash_Click(object sender, EventArgs e)
        {
            double.TryParse(tbxCashAmount.Text, out var cash);

            if (cashResult >= cash)
            {
                cashResult -= cash;
                RefreshWindow();
            }
            else
            {
                MessageBox.Show("Cash amount is more than cash in the wallet.","Game Keeper",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void btnTakeAllMoney_Click(object sender, EventArgs e)
        {
            cashResult = 0;
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
