using GameKeeper.BL.Controller;
using System;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class FrmGrouping : Form
    {
        private Form prevForm;
        private GroupingController groupingController;

        #region Constructor
        public FrmGrouping()
        {
            InitializeComponent();

            prevForm = new FrmGame();
            tbxNewGrouping.Focus();

            groupingController = new GroupingController();
            RefreshGroupingList();
        }
        #endregion

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
            var newGroupingName = tbxNewGrouping.Text.Trim();

            if (!string.IsNullOrWhiteSpace(newGroupingName))
            {
                if (groupingController.IsGroupingAlreadyExists(newGroupingName))
                {
                    MessageBox.Show($"Grouping \"{newGroupingName}\" already exists.", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    groupingController.AddGrouping(newGroupingName);
                    MessageBox.Show($"Grouping \"{newGroupingName}\" successfully added.", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshGroupingList();
                }
            }

            tbxNewGrouping.Text = string.Empty;
            tbxNewGrouping.Focus();
        }

        private void btnDelGrouping_Click(object sender, EventArgs e)
        {
            int selectedIndex = lbxGroupingsList.SelectedIndex;
            int count = groupingController.Groupings.Count;

            if (selectedIndex != -1 & count > 1)
            {
                if (groupingController.DelSelectedGrouping(selectedIndex))
                {
                    RefreshGroupingList();
                    MessageBox.Show($"Selected grouping has been deleted.", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show($"It's not grouping.", "Game keeper", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnDelAllGroupings_Click(object sender, EventArgs e)
        {
            int count = groupingController.Groupings.Count;

            if (count > 1)
            {
                groupingController.DelAllGroupings();
                RefreshGroupingList();

                tbxNewGrouping.Text = string.Empty;
                tbxNewGrouping.Focus();
            }

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
                btnAddGrouping_Click(this, null);
            }
        }

    }
}
