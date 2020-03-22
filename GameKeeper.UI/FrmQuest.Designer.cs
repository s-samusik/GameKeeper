namespace GameKeeper.UI
{
    partial class FrmQuest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1",
            "test quest 1",
            "100",
            "150",
            "00:32:15",
            "in process"}, -1);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new System.Windows.Forms.ListViewItem.ListViewSubItem[] {
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "2"),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "test quest 2", System.Drawing.Color.Green, System.Drawing.Color.Silver, new System.Drawing.Font("Segoe UI", 9F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "30", System.Drawing.Color.Green, System.Drawing.Color.Silver, new System.Drawing.Font("Segoe UI", 9F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "0", System.Drawing.Color.Green, System.Drawing.Color.Silver, new System.Drawing.Font("Segoe UI", 9F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "00:00:00", System.Drawing.Color.Green, System.Drawing.Color.Silver, new System.Drawing.Font("Segoe UI", 9F)),
            new System.Windows.Forms.ListViewItem.ListViewSubItem(null, "completed", System.Drawing.Color.Green, System.Drawing.Color.Silver, new System.Drawing.Font("Segoe UI", 9F))}, -1);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            "3",
            "test quest 3",
            "0",
            "80",
            "00:00:00",
            "failed"}, -1);
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.lstQuests = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colReward = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPunishment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTimeLeft = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnCloseWindow = new System.Windows.Forms.Button();
            this.btnComplete = new System.Windows.Forms.Button();
            this.btnFailSelected = new System.Windows.Forms.Button();
            this.btnDelQuest = new System.Windows.Forms.Button();
            this.tlpNewQuest = new System.Windows.Forms.TableLayoutPanel();
            this.btnAddQuest = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxReward = new System.Windows.Forms.TextBox();
            this.tbxPunishment = new System.Windows.Forms.TextBox();
            this.tbxLifeTime = new System.Windows.Forms.MaskedTextBox();
            this.tlpMain.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpNewQuest.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 3;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpMain.Controls.Add(this.lstQuests, 1, 1);
            this.tlpMain.Controls.Add(this.tlpButtons, 1, 2);
            this.tlpMain.Controls.Add(this.tlpNewQuest, 1, 0);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 3;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpMain.Size = new System.Drawing.Size(624, 451);
            this.tlpMain.TabIndex = 0;
            // 
            // lstQuests
            // 
            this.lstQuests.BackColor = System.Drawing.Color.Silver;
            this.lstQuests.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstQuests.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colName,
            this.colReward,
            this.colPunishment,
            this.colTimeLeft,
            this.colStatus});
            this.lstQuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstQuests.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lstQuests.FullRowSelect = true;
            this.lstQuests.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstQuests.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            listViewItem3.StateImageIndex = 0;
            this.lstQuests.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lstQuests.Location = new System.Drawing.Point(34, 228);
            this.lstQuests.MultiSelect = false;
            this.lstQuests.Name = "lstQuests";
            this.lstQuests.ShowGroups = false;
            this.lstQuests.Size = new System.Drawing.Size(555, 106);
            this.lstQuests.TabIndex = 0;
            this.lstQuests.UseCompatibleStateImageBehavior = false;
            this.lstQuests.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "№";
            this.colId.Width = 30;
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 150;
            // 
            // colReward
            // 
            this.colReward.Text = "Reward";
            this.colReward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colReward.Width = 90;
            // 
            // colPunishment
            // 
            this.colPunishment.Text = "Punishment";
            this.colPunishment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colPunishment.Width = 90;
            // 
            // colTimeLeft
            // 
            this.colTimeLeft.Text = "Time left";
            this.colTimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colTimeLeft.Width = 90;
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            this.colStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.colStatus.Width = 105;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 2;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Controls.Add(this.btnCloseWindow, 1, 1);
            this.tlpButtons.Controls.Add(this.btnComplete, 1, 0);
            this.tlpButtons.Controls.Add(this.btnFailSelected, 0, 0);
            this.tlpButtons.Controls.Add(this.btnDelQuest, 0, 1);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(34, 340);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 2;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpButtons.Size = new System.Drawing.Size(555, 108);
            this.tlpButtons.TabIndex = 1;
            // 
            // btnCloseWindow
            // 
            this.btnCloseWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseWindow.FlatAppearance.BorderSize = 0;
            this.btnCloseWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWindow.Location = new System.Drawing.Point(280, 57);
            this.btnCloseWindow.Name = "btnCloseWindow";
            this.btnCloseWindow.Size = new System.Drawing.Size(272, 48);
            this.btnCloseWindow.TabIndex = 0;
            this.btnCloseWindow.Text = "Close window";
            this.btnCloseWindow.UseVisualStyleBackColor = true;
            this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
            // 
            // btnComplete
            // 
            this.btnComplete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnComplete.FlatAppearance.BorderSize = 0;
            this.btnComplete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplete.Location = new System.Drawing.Point(280, 3);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(272, 48);
            this.btnComplete.TabIndex = 1;
            this.btnComplete.Text = "Complete selected quest";
            this.btnComplete.UseVisualStyleBackColor = true;
            // 
            // btnFailSelected
            // 
            this.btnFailSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnFailSelected.FlatAppearance.BorderSize = 0;
            this.btnFailSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFailSelected.Location = new System.Drawing.Point(3, 3);
            this.btnFailSelected.Name = "btnFailSelected";
            this.btnFailSelected.Size = new System.Drawing.Size(271, 48);
            this.btnFailSelected.TabIndex = 2;
            this.btnFailSelected.Text = "Fail selected quest";
            this.btnFailSelected.UseVisualStyleBackColor = true;
            // 
            // btnDelQuest
            // 
            this.btnDelQuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelQuest.FlatAppearance.BorderSize = 0;
            this.btnDelQuest.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnDelQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelQuest.Location = new System.Drawing.Point(3, 57);
            this.btnDelQuest.Name = "btnDelQuest";
            this.btnDelQuest.Size = new System.Drawing.Size(271, 48);
            this.btnDelQuest.TabIndex = 3;
            this.btnDelQuest.Text = "Delete selected quest";
            this.btnDelQuest.UseVisualStyleBackColor = true;
            // 
            // tlpNewQuest
            // 
            this.tlpNewQuest.ColumnCount = 2;
            this.tlpNewQuest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNewQuest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpNewQuest.Controls.Add(this.tbxPunishment, 1, 2);
            this.tlpNewQuest.Controls.Add(this.tbxReward, 1, 1);
            this.tlpNewQuest.Controls.Add(this.btnAddQuest, 1, 4);
            this.tlpNewQuest.Controls.Add(this.btnClearFields, 0, 4);
            this.tlpNewQuest.Controls.Add(this.label1, 0, 0);
            this.tlpNewQuest.Controls.Add(this.label2, 0, 1);
            this.tlpNewQuest.Controls.Add(this.label3, 0, 2);
            this.tlpNewQuest.Controls.Add(this.label4, 0, 3);
            this.tlpNewQuest.Controls.Add(this.tbxName, 1, 0);
            this.tlpNewQuest.Controls.Add(this.tbxLifeTime, 1, 3);
            this.tlpNewQuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNewQuest.Location = new System.Drawing.Point(34, 3);
            this.tlpNewQuest.Name = "tlpNewQuest";
            this.tlpNewQuest.RowCount = 5;
            this.tlpNewQuest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpNewQuest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpNewQuest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpNewQuest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpNewQuest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpNewQuest.Size = new System.Drawing.Size(555, 219);
            this.tlpNewQuest.TabIndex = 2;
            // 
            // btnAddQuest
            // 
            this.btnAddQuest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddQuest.FlatAppearance.BorderSize = 0;
            this.btnAddQuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddQuest.Location = new System.Drawing.Point(280, 175);
            this.btnAddQuest.Name = "btnAddQuest";
            this.btnAddQuest.Size = new System.Drawing.Size(272, 41);
            this.btnAddQuest.TabIndex = 0;
            this.btnAddQuest.Text = "Add new quest";
            this.btnAddQuest.UseVisualStyleBackColor = true;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnClearFields.FlatAppearance.BorderSize = 0;
            this.btnClearFields.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearFields.Location = new System.Drawing.Point(3, 175);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(271, 41);
            this.btnClearFields.TabIndex = 1;
            this.btnClearFields.Text = "Clear all fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 43);
            this.label1.TabIndex = 2;
            this.label1.Text = "enter name of quest:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(3, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 43);
            this.label2.TabIndex = 3;
            this.label2.Text = "enter reward:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(271, 43);
            this.label3.TabIndex = 4;
            this.label3.Text = "enter punishment:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 43);
            this.label4.TabIndex = 5;
            this.label4.Text = "enter lifetime of quest:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxName
            // 
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxName.Location = new System.Drawing.Point(280, 7);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.tbxName.MaxLength = 30;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(272, 29);
            this.tbxName.TabIndex = 6;
            // 
            // tbxReward
            // 
            this.tbxReward.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxReward.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxReward.Location = new System.Drawing.Point(280, 50);
            this.tbxReward.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.tbxReward.MaxLength = 30;
            this.tbxReward.Name = "tbxReward";
            this.tbxReward.Size = new System.Drawing.Size(272, 29);
            this.tbxReward.TabIndex = 7;
            this.tbxReward.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPunishment
            // 
            this.tbxPunishment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPunishment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPunishment.Location = new System.Drawing.Point(280, 93);
            this.tbxPunishment.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.tbxPunishment.MaxLength = 30;
            this.tbxPunishment.Name = "tbxPunishment";
            this.tbxPunishment.Size = new System.Drawing.Size(272, 29);
            this.tbxPunishment.TabIndex = 8;
            this.tbxPunishment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxLifeTime
            // 
            this.tbxLifeTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxLifeTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxLifeTime.Location = new System.Drawing.Point(280, 136);
            this.tbxLifeTime.Margin = new System.Windows.Forms.Padding(3, 7, 3, 3);
            this.tbxLifeTime.Mask = "00:00:00";
            this.tbxLifeTime.Name = "tbxLifeTime";
            this.tbxLifeTime.Size = new System.Drawing.Size(272, 29);
            this.tbxLifeTime.TabIndex = 9;
            this.tbxLifeTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxLifeTime.ValidatingType = typeof(System.DateTime);
            // 
            // FrmQuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(624, 451);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmQuest";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Keeper";
            this.TopMost = true;
            this.tlpMain.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tlpNewQuest.ResumeLayout(false);
            this.tlpNewQuest.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.ListView lstQuests;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colTimeLeft;
        private System.Windows.Forms.ColumnHeader colReward;
        private System.Windows.Forms.ColumnHeader colPunishment;
        private System.Windows.Forms.ColumnHeader colStatus;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.Button btnCloseWindow;
        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button btnFailSelected;
        private System.Windows.Forms.Button btnDelQuest;
        private System.Windows.Forms.TableLayoutPanel tlpNewQuest;
        private System.Windows.Forms.Button btnAddQuest;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxPunishment;
        private System.Windows.Forms.TextBox tbxReward;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.MaskedTextBox tbxLifeTime;
    }
}