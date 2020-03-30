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
    public partial class FrmStatistic : Form
    {
        private PlayerController playerController;

        #region Constructor
        public FrmStatistic(GameController gameController)
        {
            InitializeComponent();
            Text = $"Game Keeper: statistic of {gameController.CurrentGame.Name}";

            playerController = new PlayerController();
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmStatistic_Load(object sender, EventArgs e)
        {
            lblTotalPlayers.Text = playerController.GetTotalPlayers().ToString();
            lblTotalMoney.Text = playerController.GetTotalMoney().ToString();
            lblKilledPlayers.Text = playerController.GetNumberOfKilledPlayers().ToString();
        }
    }
}
