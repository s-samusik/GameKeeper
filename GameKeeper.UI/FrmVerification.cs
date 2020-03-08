using GameKeeper.BL.Controller;
using System;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class FrmVerification : Form
    {
        private FrmGame frmGame;
        private GameController gameController;

        #region Constructor
        public FrmVerification(FrmGame form)
        {
            InitializeComponent();
            gameController = new GameController();
            frmGame = form;
        }
        #endregion

        #region Buttons
        private void btnOk_Click(object sender, EventArgs e)
        {
            var password = tbxPassword.Text.Trim();
            bool resultVerification = gameController.VerificationGame(password);

            if (resultVerification)
            {
                frmGame.IsVerification = resultVerification;
                Close();
            }
            else
            {
                tbxPassword.Text = string.Empty;
                MessageBox.Show("Password incorrect. Please retry again","Game Keeper", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        private void tbxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOk_Click(sender, e);
            }
        }
    }
}
