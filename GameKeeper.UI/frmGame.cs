using GameKeeper.BL.Controller;
using System;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class FrmGame : Form
    {
        public bool IsVerification { get; set; } = false;

        private FrmPlayer frmPlayer;
        private Form frmVerification;
        private GameController gameController;

        #region Constructor
        public FrmGame()
        {
            InitializeComponent();

            gameController = new GameController();

            if (gameController.IsGameNew)
            {
                ViewPanelNewGame();
            }
            else
            {
                ViewPanelCurrentGame(gameController);
            }
        }
        #endregion

        private void ViewPanelNewGame()
        {
            spcNewCurrent.Panel2Collapsed = true;
            Text = "Game keeper: create new game";
        }

        private void ViewPanelCurrentGame(GameController gameController)
        {
            spcNewCurrent.Panel1Collapsed = true;
            Text = "Game keeper: " + gameController.CurrentGame.Name;
        }

        #region Buttons - Create game
        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            var name = tbxName.Text;
            var password = tbxPassword.Text;
            var rePassword = tbxRePassword.Text;

            if (!string.IsNullOrWhiteSpace(name))
            {
                if (!string.IsNullOrEmpty(password) && password.GetHashCode() == rePassword.GetHashCode())
                {
                    gameController = new GameController(name, password);

                    MessageBox.Show($"\"{name}\" successfully created.", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    ViewPanelCurrentGame(gameController);
                }
                else
                {
                    tbxPassword.Text = string.Empty;
                    tbxRePassword.Text = string.Empty;

                    MessageBox.Show("Please enter and confirm correct password.", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please enter correct name of game.", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Do you want to exit?\nAre you sure?\nThe game wont be created.", "Game keeper", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                gameController.DeleteCurrentGame(Application.StartupPath);
                Application.Exit();
            }
        }
        #endregion

        #region Buttons - Current game
        private void btnGroupings_Click(object sender, EventArgs e)
        {
            Hide();
            FrmGrouping frmGrouping = new FrmGrouping();
            frmGrouping.ShowDialog();
        }

        private void btnGetStatisic_Click(object sender, EventArgs e)
        {
        }

        private void btnCompleteGame_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Current game will be deleted.\nAre you sure?", "Game keeper", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                gameController.DeleteCurrentGame(Application.StartupPath);

                Application.Exit();
            }
        }

        private void btnCloseKeeper_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Current game will be saved.\nSee you later.", "Game keeper", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        #endregion

        private void tbxID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                frmPlayer = new FrmPlayer(tbxID.Text);

                if (frmPlayer.IsPlayerNew)
                {
                    Hide();
                    frmPlayer.Show();
                }
                else
                {
                    frmVerification = new FrmVerification(this);
                    frmVerification.ShowDialog();

                    tbxID.Text = string.Empty;

                    if (IsVerification)
                    {
                        Hide();
                        frmPlayer.Show();
                    }
                }
            }
        }
    }
}
