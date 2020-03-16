using GameKeeper.BL.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class FrmMurder : Form
    {
        private PlayerController playerController;
        public FrmMurder(PlayerController currentPlayer)
        {
            InitializeComponent();
            playerController = currentPlayer;

            Text = $"GameKeeper: kill {playerController.CurrentPlayer.NickName}";
            tbTime.Scroll += TbTime_Scroll;
        }

        private void TbTime_Scroll(object sender, EventArgs e)
        {
            playerController.DeadTime = tbTime.Value;
            lblDeadTime.Text = $"{playerController.DeadTime} min.";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKillPlayer_Click(object sender, EventArgs e)
        {
            lblDeadTime.ForeColor = Color.DarkGray;
            tbTime.Enabled = false;
            tbxTimeLeft.BackColor = Color.Red;
            tbxTimeLeft.ForeColor = Color.White;
            tbxTimeLeft.Text = lblDeadTime.Text;
        }
    }
}
