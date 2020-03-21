using GameKeeper.BL.Controller;
using System;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class FrmMurder : Form
    {
        private PlayerController playerController;
        private FrmPlayer prevForm;
        private int hours;
        private int minutes;

        #region Constructor
        public FrmMurder(PlayerController currentPlayer, FrmPlayer frmPlayer)
        {
            InitializeComponent();
            playerController = currentPlayer;
            prevForm = frmPlayer;

            Text = $"GameKeeper: kill {playerController.CurrentPlayer.NickName}";
            tbxTimeLeft.Text = $"{hours} hours, {minutes} minutes";
            btnKillPlayer.Enabled = false;

            tbxPunishment.Text = "0";
            numMinutes.ValueChanged += TimeLeft_ValueChanged;
            numHours.ValueChanged += TimeLeft_ValueChanged;
        }
        #endregion

        #region Buttons
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKillPlayer_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"{playerController.CurrentPlayer.NickName} will be dead {tbxTimeLeft.Text}.\nAre you sure?", "Game keeper", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                if (playerController.PutPunishmentForDeath(tbxPunishment.Text))
                {
                    playerController.CurrentPlayer.DeadTimeInSecond = (hours * 60 + minutes) * 60;
                    playerController.CurrentPlayer.IsDead = true;
                    playerController.CurrentPlayer.CountOfDeaths += 1;
                    playerController.DeadTimeAsync();

                    MessageBox.Show($"{playerController.CurrentPlayer.NickName} got punishment {playerController.Punishment} for him death.", "GameKeeper", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    prevForm.CashInWallet = playerController.CurrentPlayer.Cash;
                }
                else
                {
                    MessageBox.Show($"{playerController.CurrentPlayer.NickName} haven't money for this punishment.", "GameKeeper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                Close();
            }
        }
        #endregion

        private void TimeLeft_ValueChanged(object sender, EventArgs e)
        {
            hours = (int)numHours.Value;
            minutes = (int)numMinutes.Value;

            tbxTimeLeft.Text = $"{hours} hours, {minutes} minutes";

            btnKillPlayer.Enabled = hours != 0 || minutes != 0;
        }

        private void tbxPunishment_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;
        }
    }
}
