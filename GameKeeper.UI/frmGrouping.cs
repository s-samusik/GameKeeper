using GameKeeper.BL.Controller;
using System;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class frmGrouping : Form
    {
        private Form prevForm;
        GroupingController groupingController;

        public frmGrouping()
        {
            InitializeComponent();
            
            prevForm = new FrmGame();
            tbxNewGrouping.Focus();

            groupingController = new GroupingController();
            RefreshGroupingList();
        }

        /// <summary>
        /// Updating data in the listbox "GroupingsList".
        /// </summary>
        private void RefreshGroupingList()
        {
            lbxGroupingsList.DataSource = null;
            lbxGroupingsList.DataSource = groupingController.Groupings;
            lbxGroupingsList.DisplayMember = "Name";
        }

        #region Buttons
        private void btnAddGrouping_Click(object sender, EventArgs e)
        {
            var newGroupingName = tbxNewGrouping.Text;

            if (!string.IsNullOrWhiteSpace(newGroupingName))
            {
                groupingController.AddGrouping(newGroupingName);
                MessageBox.Show($"Grouping \"{newGroupingName}\" successfully added.", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Information);
                RefreshGroupingList();
            }

            tbxNewGrouping.Text = string.Empty;
            tbxNewGrouping.Focus();
        }
    
        private void btnDelAllGroupings_Click(object sender, EventArgs e)
        {
            groupingController.DelAllGroupings();
            RefreshGroupingList();

            tbxNewGrouping.Text = string.Empty;
            tbxNewGrouping.Focus();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
            prevForm.Show();
        }
        #endregion

        private void tbxNewGrouping_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddGrouping_Click(this,null);
            }
        }
    }
}
