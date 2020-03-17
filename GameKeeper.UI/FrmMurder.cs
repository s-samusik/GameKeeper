using GameKeeper.BL.Controller;
using System;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class FrmMurder : Form
    {
        private PlayerController playerController;

        private int hours;
        private int minutes;

        public FrmMurder(PlayerController currentPlayer)
        {
            InitializeComponent();
            playerController = currentPlayer;

            Text = $"GameKeeper: kill {playerController.CurrentPlayer.NickName}";
            tbxTimeLeft.Text = $"{hours} hours, {minutes} minutes";

            numMinutes.ValueChanged += TimeLeft_ValueChanged;
            numHours.ValueChanged += TimeLeft_ValueChanged;
        }

        private void TimeLeft_ValueChanged(object sender, EventArgs e)
        {
            hours = (int)numHours.Value;
            minutes = (int)numMinutes.Value;

            tbxTimeLeft.Text = $"{hours} hours, {minutes} minutes";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKillPlayer_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show($"{playerController.CurrentPlayer.NickName} will be dead {tbxTimeLeft.Text}.\nAre you sure?", "Game keeper", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {
                lblSummary.Text = "time before respawn:";
                numHours.Enabled = false;
                numMinutes.Enabled = false;
                btnKillPlayer.Enabled = false;
            }
        }
    }
}
