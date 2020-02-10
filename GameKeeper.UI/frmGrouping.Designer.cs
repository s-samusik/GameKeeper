namespace GameKeeper.UI
{
    partial class frmGrouping
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
            this.tlpMainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tlpButtons = new System.Windows.Forms.TableLayoutPanel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNewGrouping = new System.Windows.Forms.Button();
            this.btnDelGrouping = new System.Windows.Forms.Button();
            this.tbxNewGrouping = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelAllGroupings = new System.Windows.Forms.Button();
            this.tlpViewList = new System.Windows.Forms.TableLayoutPanel();
            this.lbxGroupingsList = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tlpMainPanel.SuspendLayout();
            this.tlpButtons.SuspendLayout();
            this.tlpViewList.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMainPanel
            // 
            this.tlpMainPanel.ColumnCount = 2;
            this.tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMainPanel.Controls.Add(this.tlpButtons, 0, 0);
            this.tlpMainPanel.Controls.Add(this.tlpViewList, 1, 0);
            this.tlpMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMainPanel.Location = new System.Drawing.Point(0, 0);
            this.tlpMainPanel.Name = "tlpMainPanel";
            this.tlpMainPanel.RowCount = 1;
            this.tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 510F));
            this.tlpMainPanel.Size = new System.Drawing.Size(684, 510);
            this.tlpMainPanel.TabIndex = 0;
            // 
            // tlpButtons
            // 
            this.tlpButtons.ColumnCount = 3;
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpButtons.Controls.Add(this.btnBack, 1, 7);
            this.tlpButtons.Controls.Add(this.btnNewGrouping, 1, 2);
            this.tlpButtons.Controls.Add(this.btnDelGrouping, 1, 3);
            this.tlpButtons.Controls.Add(this.tbxNewGrouping, 1, 1);
            this.tlpButtons.Controls.Add(this.label2, 1, 0);
            this.tlpButtons.Controls.Add(this.btnDelAllGroupings, 1, 4);
            this.tlpButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpButtons.Location = new System.Drawing.Point(3, 3);
            this.tlpButtons.Name = "tlpButtons";
            this.tlpButtons.RowCount = 8;
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpButtons.Size = new System.Drawing.Size(336, 504);
            this.tlpButtons.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(36, 444);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(262, 57);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back to main window";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btnNewGrouping
            // 
            this.btnNewGrouping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewGrouping.FlatAppearance.BorderSize = 0;
            this.btnNewGrouping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGrouping.Location = new System.Drawing.Point(36, 129);
            this.btnNewGrouping.Name = "btnNewGrouping";
            this.btnNewGrouping.Size = new System.Drawing.Size(262, 57);
            this.btnNewGrouping.TabIndex = 1;
            this.btnNewGrouping.Text = "Add new grouping";
            this.btnNewGrouping.UseVisualStyleBackColor = true;
            // 
            // btnDelGrouping
            // 
            this.btnDelGrouping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelGrouping.FlatAppearance.BorderSize = 0;
            this.btnDelGrouping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelGrouping.Location = new System.Drawing.Point(36, 192);
            this.btnDelGrouping.Name = "btnDelGrouping";
            this.btnDelGrouping.Size = new System.Drawing.Size(262, 57);
            this.btnDelGrouping.TabIndex = 2;
            this.btnDelGrouping.Text = "Delete changed grouping";
            this.btnDelGrouping.UseVisualStyleBackColor = true;
            // 
            // tbxNewGrouping
            // 
            this.tbxNewGrouping.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxNewGrouping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxNewGrouping.Location = new System.Drawing.Point(36, 66);
            this.tbxNewGrouping.MaxLength = 30;
            this.tbxNewGrouping.Name = "tbxNewGrouping";
            this.tbxNewGrouping.Size = new System.Drawing.Size(262, 29);
            this.tbxNewGrouping.TabIndex = 3;
            this.tbxNewGrouping.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(36, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 63);
            this.label2.TabIndex = 4;
            this.label2.Text = "name of grouping:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelAllGroupings
            // 
            this.btnDelAllGroupings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelAllGroupings.FlatAppearance.BorderSize = 0;
            this.btnDelAllGroupings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelAllGroupings.Location = new System.Drawing.Point(36, 255);
            this.btnDelAllGroupings.Name = "btnDelAllGroupings";
            this.btnDelAllGroupings.Size = new System.Drawing.Size(262, 57);
            this.btnDelAllGroupings.TabIndex = 5;
            this.btnDelAllGroupings.Text = "Delete all groupings";
            this.btnDelAllGroupings.UseVisualStyleBackColor = true;
            // 
            // tlpViewList
            // 
            this.tlpViewList.ColumnCount = 3;
            this.tlpViewList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpViewList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpViewList.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpViewList.Controls.Add(this.lbxGroupingsList, 1, 1);
            this.tlpViewList.Controls.Add(this.label1, 1, 0);
            this.tlpViewList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpViewList.Location = new System.Drawing.Point(345, 3);
            this.tlpViewList.Name = "tlpViewList";
            this.tlpViewList.RowCount = 2;
            this.tlpViewList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpViewList.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tlpViewList.Size = new System.Drawing.Size(336, 504);
            this.tlpViewList.TabIndex = 1;
            // 
            // lbxGroupingsList
            // 
            this.lbxGroupingsList.BackColor = System.Drawing.SystemColors.Window;
            this.lbxGroupingsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbxGroupingsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxGroupingsList.FormattingEnabled = true;
            this.lbxGroupingsList.ItemHeight = 21;
            this.lbxGroupingsList.Location = new System.Drawing.Point(36, 66);
            this.lbxGroupingsList.Name = "lbxGroupingsList";
            this.lbxGroupingsList.Size = new System.Drawing.Size(262, 435);
            this.lbxGroupingsList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(36, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 63);
            this.label1.TabIndex = 1;
            this.label1.Text = "groupings in the game:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmGrouping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 510);
            this.Controls.Add(this.tlpMainPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGrouping";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Groupings in the game";
            this.tlpMainPanel.ResumeLayout(false);
            this.tlpButtons.ResumeLayout(false);
            this.tlpButtons.PerformLayout();
            this.tlpViewList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMainPanel;
        private System.Windows.Forms.TableLayoutPanel tlpButtons;
        private System.Windows.Forms.TableLayoutPanel tlpViewList;
        private System.Windows.Forms.ListBox lbxGroupingsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNewGrouping;
        private System.Windows.Forms.Button btnDelGrouping;
        private System.Windows.Forms.TextBox tbxNewGrouping;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelAllGroupings;
    }
}