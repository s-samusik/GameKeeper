﻿using GameKeeper.BL.Controller;
using System;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class FrmPlayer : Form
    {
        private Form prevForm;
        private Form frmWallet;
        PlayerController playerController;

        #region constructor
        public FrmPlayer(string playerID)
        {
            InitializeComponent();

            prevForm = new FrmGame();
            
            playerController = new PlayerController(playerID);

            if (playerController.IsCurrentPlayerNew)
            {
                ViewPanelNewPlayer(playerController);
            }
            else
            {
                ViewPanelCurrentPlayer(playerController);
            }

        }
        #endregion

        private void ViewPanelNewPlayer(PlayerController playerController)
        {
            spcNewCurrent.Panel2Collapsed = true;
            Text = "Game keeper: create new player";
            
            tbxID.Text = playerController.CurrentPlayer.Id;
            tbxPincode.Text = playerController.CreatePincode();
        }

        private void ViewPanelCurrentPlayer(PlayerController playerController)
        {
            spcNewCurrent.Panel1Collapsed = true;

            RefreshWindow();
        }

        public void RefreshWindow()
        {
            lblNickname.Text = playerController.CurrentPlayer.NickName;
            lblId.Text = playerController.CurrentPlayer.Id;
            tbxCash.Text = playerController.CurrentPlayer.Cash.ToString();
        }

        #region Buttons - create player
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            var name = tbxName.Text;
            var grouping = cbxGrouping.Text;
            var pincode = tbxPincode.Text;
            var cash = double.Parse(tbxStartCash.Text);

            playerController.SetNewPlayerData(name, grouping, pincode, cash);
            Close();
            prevForm.Show();
        }
        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
            prevForm.Show();
        }

        #endregion

        #region Buttons - current player
        private void btnWallet_Click(object sender, EventArgs e)
        {
            frmWallet = new FrmWallet(playerController);
            frmWallet.ShowDialog();
        }

        private void btnQuests_Click(object sender, EventArgs e)
        {

        }

        private void btnKillPlayer_Click(object sender, EventArgs e)
        {

        }

        private void btnViewPin_Click(object sender, EventArgs e)
        {
            var name = playerController.CurrentPlayer.NickName;
            var pincode = playerController.CurrentPlayer.PinCode;
            MessageBox.Show($"{name} have pincode: {pincode}", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            prevForm.Show();
        }
        #endregion
    }
}