namespace GameKeeper.UI
{
    partial class frmPlayer
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
            this.spcNewCurrent = new System.Windows.Forms.SplitContainer();
            this.tlpNewPlayer = new System.Windows.Forms.TableLayoutPanel();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPincode = new System.Windows.Forms.Label();
            this.lblGrouping = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.tbxPincode = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxCash = new System.Windows.Forms.TextBox();
            this.cbxGrouping = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.spcNewCurrent)).BeginInit();
            this.spcNewCurrent.Panel1.SuspendLayout();
            this.spcNewCurrent.SuspendLayout();
            this.tlpNewPlayer.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcNewCurrent
            // 
            this.spcNewCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcNewCurrent.Location = new System.Drawing.Point(0, 0);
            this.spcNewCurrent.Margin = new System.Windows.Forms.Padding(1);
            this.spcNewCurrent.Name = "spcNewCurrent";
            // 
            // spcNewCurrent.Panel1
            // 
            this.spcNewCurrent.Panel1.Controls.Add(this.tlpNewPlayer);
            this.spcNewCurrent.Panel2Collapsed = true;
            this.spcNewCurrent.Size = new System.Drawing.Size(684, 511);
            this.spcNewCurrent.SplitterDistance = 228;
            this.spcNewCurrent.SplitterWidth = 1;
            this.spcNewCurrent.TabIndex = 0;
            // 
            // tlpNewPlayer
            // 
            this.tlpNewPlayer.ColumnCount = 4;
            this.tlpNewPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNewPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpNewPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpNewPlayer.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNewPlayer.Controls.Add(this.btnCancel, 2, 7);
            this.tlpNewPlayer.Controls.Add(this.lblCash, 1, 5);
            this.tlpNewPlayer.Controls.Add(this.lblGrouping, 1, 4);
            this.tlpNewPlayer.Controls.Add(this.lblPincode, 1, 1);
            this.tlpNewPlayer.Controls.Add(this.lblName, 1, 3);
            this.tlpNewPlayer.Controls.Add(this.lblID, 1, 0);
            this.tlpNewPlayer.Controls.Add(this.btnAddPlayer, 1, 7);
            this.tlpNewPlayer.Controls.Add(this.tbxID, 2, 0);
            this.tlpNewPlayer.Controls.Add(this.tbxPincode, 2, 1);
            this.tlpNewPlayer.Controls.Add(this.tbxName, 2, 3);
            this.tlpNewPlayer.Controls.Add(this.tbxCash, 2, 5);
            this.tlpNewPlayer.Controls.Add(this.cbxGrouping, 2, 4);
            this.tlpNewPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNewPlayer.Location = new System.Drawing.Point(0, 0);
            this.tlpNewPlayer.Name = "tlpNewPlayer";
            this.tlpNewPlayer.RowCount = 8;
            this.tlpNewPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewPlayer.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpNewPlayer.Size = new System.Drawing.Size(684, 511);
            this.tlpNewPlayer.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblID.Location = new System.Drawing.Point(71, 0);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(267, 63);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "unique  ID:";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(71, 189);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(267, 63);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "enter nickname:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPincode
            // 
            this.lblPincode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPincode.Location = new System.Drawing.Point(71, 63);
            this.lblPincode.Name = "lblPincode";
            this.lblPincode.Size = new System.Drawing.Size(267, 63);
            this.lblPincode.TabIndex = 3;
            this.lblPincode.Text = "unique  pincode:";
            this.lblPincode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGrouping
            // 
            this.lblGrouping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrouping.Location = new System.Drawing.Point(71, 252);
            this.lblGrouping.Name = "lblGrouping";
            this.lblGrouping.Size = new System.Drawing.Size(267, 63);
            this.lblGrouping.TabIndex = 4;
            this.lblGrouping.Text = "change grouping:";
            this.lblGrouping.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblCash
            // 
            this.lblCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCash.Location = new System.Drawing.Point(71, 315);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(267, 63);
            this.lblCash.TabIndex = 5;
            this.lblCash.Text = "start-up cash:";
            this.lblCash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddPlayer.FlatAppearance.BorderSize = 0;
            this.btnAddPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPlayer.Location = new System.Drawing.Point(71, 444);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(267, 64);
            this.btnAddPlayer.TabIndex = 3;
            this.btnAddPlayer.Text = "Add player to game";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(344, 444);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(267, 64);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbxID
            // 
            this.tbxID.BackColor = System.Drawing.Color.Silver;
            this.tbxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxID.Enabled = false;
            this.tbxID.Location = new System.Drawing.Point(344, 15);
            this.tbxID.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tbxID.MaxLength = 30;
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(267, 29);
            this.tbxID.TabIndex = 8;
            // 
            // tbxPincode
            // 
            this.tbxPincode.BackColor = System.Drawing.Color.Silver;
            this.tbxPincode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPincode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPincode.Enabled = false;
            this.tbxPincode.Location = new System.Drawing.Point(344, 78);
            this.tbxPincode.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tbxPincode.MaxLength = 4;
            this.tbxPincode.Name = "tbxPincode";
            this.tbxPincode.Size = new System.Drawing.Size(267, 29);
            this.tbxPincode.TabIndex = 9;
            // 
            // tbxName
            // 
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxName.Location = new System.Drawing.Point(344, 204);
            this.tbxName.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tbxName.MaxLength = 30;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(267, 29);
            this.tbxName.TabIndex = 0;
            // 
            // tbxCash
            // 
            this.tbxCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCash.Location = new System.Drawing.Point(344, 330);
            this.tbxCash.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tbxCash.MaxLength = 30;
            this.tbxCash.Name = "tbxCash";
            this.tbxCash.Size = new System.Drawing.Size(267, 29);
            this.tbxCash.TabIndex = 2;
            // 
            // cbxGrouping
            // 
            this.cbxGrouping.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbxGrouping.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxGrouping.FormattingEnabled = true;
            this.cbxGrouping.Location = new System.Drawing.Point(344, 267);
            this.cbxGrouping.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.cbxGrouping.Name = "cbxGrouping";
            this.cbxGrouping.Size = new System.Drawing.Size(267, 29);
            this.cbxGrouping.TabIndex = 1;
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.spcNewCurrent);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPlayer";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Keeper";
            this.spcNewCurrent.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcNewCurrent)).EndInit();
            this.spcNewCurrent.ResumeLayout(false);
            this.tlpNewPlayer.ResumeLayout(false);
            this.tlpNewPlayer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcNewCurrent;
        private System.Windows.Forms.TableLayoutPanel tlpNewPlayer;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPincode;
        private System.Windows.Forms.Label lblGrouping;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxPincode;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxCash;
        private System.Windows.Forms.ComboBox cbxGrouping;
    }
}