namespace GameKeeper.UI
{
    partial class FrmGame
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
            this.tlpNewGame = new System.Windows.Forms.TableLayoutPanel();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnExitGame = new System.Windows.Forms.Button();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.tbxRePassword = new System.Windows.Forms.TextBox();
            this.tlpCurrentGame = new System.Windows.Forms.TableLayoutPanel();
            this.lblEnterID = new System.Windows.Forms.Label();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.btnCompleteGame = new System.Windows.Forms.Button();
            this.btnGetStatisic = new System.Windows.Forms.Button();
            this.btnGroupings = new System.Windows.Forms.Button();
            this.btnCloseKeeper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spcNewCurrent)).BeginInit();
            this.spcNewCurrent.Panel1.SuspendLayout();
            this.spcNewCurrent.Panel2.SuspendLayout();
            this.spcNewCurrent.SuspendLayout();
            this.tlpNewGame.SuspendLayout();
            this.tlpCurrentGame.SuspendLayout();
            this.SuspendLayout();
            // 
            // spcNewCurrent
            // 
            this.spcNewCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spcNewCurrent.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spcNewCurrent.Location = new System.Drawing.Point(0, 0);
            this.spcNewCurrent.Margin = new System.Windows.Forms.Padding(1);
            this.spcNewCurrent.Name = "spcNewCurrent";
            // 
            // spcNewCurrent.Panel1
            // 
            this.spcNewCurrent.Panel1.Controls.Add(this.tlpNewGame);
            this.spcNewCurrent.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // spcNewCurrent.Panel2
            // 
            this.spcNewCurrent.Panel2.Controls.Add(this.tlpCurrentGame);
            this.spcNewCurrent.Size = new System.Drawing.Size(684, 511);
            this.spcNewCurrent.SplitterDistance = 294;
            this.spcNewCurrent.SplitterWidth = 1;
            this.spcNewCurrent.TabIndex = 0;
            // 
            // tlpNewGame
            // 
            this.tlpNewGame.ColumnCount = 3;
            this.tlpNewGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNewGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpNewGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpNewGame.Controls.Add(this.lblRePassword, 1, 4);
            this.tlpNewGame.Controls.Add(this.lblPassword, 1, 2);
            this.tlpNewGame.Controls.Add(this.lblName, 1, 0);
            this.tlpNewGame.Controls.Add(this.btnCreateGame, 1, 6);
            this.tlpNewGame.Controls.Add(this.btnExitGame, 1, 7);
            this.tlpNewGame.Controls.Add(this.tbxName, 1, 1);
            this.tlpNewGame.Controls.Add(this.tbxPassword, 1, 3);
            this.tlpNewGame.Controls.Add(this.tbxRePassword, 1, 5);
            this.tlpNewGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpNewGame.Location = new System.Drawing.Point(0, 0);
            this.tlpNewGame.Name = "tlpNewGame";
            this.tlpNewGame.RowCount = 8;
            this.tlpNewGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpNewGame.Size = new System.Drawing.Size(294, 511);
            this.tlpNewGame.TabIndex = 0;
            // 
            // lblRePassword
            // 
            this.lblRePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRePassword.Location = new System.Drawing.Point(32, 252);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(229, 63);
            this.lblRePassword.TabIndex = 2;
            this.lblRePassword.Text = "re-enter password";
            this.lblRePassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPassword.Location = new System.Drawing.Point(32, 126);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(229, 63);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "enter password";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Location = new System.Drawing.Point(32, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(229, 63);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "enter name of game";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateGame.FlatAppearance.BorderSize = 0;
            this.btnCreateGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGame.Location = new System.Drawing.Point(32, 381);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(229, 57);
            this.btnCreateGame.TabIndex = 3;
            this.btnCreateGame.Text = "Create new game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // btnExitGame
            // 
            this.btnExitGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnExitGame.FlatAppearance.BorderSize = 0;
            this.btnExitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExitGame.Location = new System.Drawing.Point(32, 444);
            this.btnExitGame.Name = "btnExitGame";
            this.btnExitGame.Size = new System.Drawing.Size(229, 64);
            this.btnExitGame.TabIndex = 4;
            this.btnExitGame.Text = "Close game keeper";
            this.btnExitGame.UseVisualStyleBackColor = true;
            this.btnExitGame.Click += new System.EventHandler(this.btExit_Click);
            // 
            // tbxName
            // 
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxName.Location = new System.Drawing.Point(29, 63);
            this.tbxName.Margin = new System.Windows.Forms.Padding(0);
            this.tbxName.MaxLength = 30;
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(235, 29);
            this.tbxName.TabIndex = 5;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPassword
            // 
            this.tbxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxPassword.Location = new System.Drawing.Point(29, 189);
            this.tbxPassword.Margin = new System.Windows.Forms.Padding(0);
            this.tbxPassword.MaxLength = 30;
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.Size = new System.Drawing.Size(235, 29);
            this.tbxPassword.TabIndex = 6;
            this.tbxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // tbxRePassword
            // 
            this.tbxRePassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxRePassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxRePassword.Location = new System.Drawing.Point(29, 315);
            this.tbxRePassword.Margin = new System.Windows.Forms.Padding(0);
            this.tbxRePassword.MaxLength = 30;
            this.tbxRePassword.Name = "tbxRePassword";
            this.tbxRePassword.Size = new System.Drawing.Size(235, 29);
            this.tbxRePassword.TabIndex = 7;
            this.tbxRePassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxRePassword.UseSystemPasswordChar = true;
            // 
            // tlpCurrentGame
            // 
            this.tlpCurrentGame.ColumnCount = 3;
            this.tlpCurrentGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpCurrentGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpCurrentGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpCurrentGame.Controls.Add(this.lblEnterID, 1, 2);
            this.tlpCurrentGame.Controls.Add(this.tbxID, 1, 3);
            this.tlpCurrentGame.Controls.Add(this.btnCompleteGame, 1, 6);
            this.tlpCurrentGame.Controls.Add(this.btnGetStatisic, 1, 5);
            this.tlpCurrentGame.Controls.Add(this.btnGroupings, 1, 4);
            this.tlpCurrentGame.Controls.Add(this.btnCloseKeeper, 1, 7);
            this.tlpCurrentGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCurrentGame.Location = new System.Drawing.Point(0, 0);
            this.tlpCurrentGame.Name = "tlpCurrentGame";
            this.tlpCurrentGame.RowCount = 8;
            this.tlpCurrentGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCurrentGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCurrentGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCurrentGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCurrentGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCurrentGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCurrentGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCurrentGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tlpCurrentGame.Size = new System.Drawing.Size(389, 511);
            this.tlpCurrentGame.TabIndex = 0;
            // 
            // lblEnterID
            // 
            this.lblEnterID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEnterID.Location = new System.Drawing.Point(41, 126);
            this.lblEnterID.Name = "lblEnterID";
            this.lblEnterID.Size = new System.Drawing.Size(305, 63);
            this.lblEnterID.TabIndex = 0;
            this.lblEnterID.Text = "enter unique player\'s ID";
            this.lblEnterID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxID
            // 
            this.tbxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxID.Location = new System.Drawing.Point(38, 189);
            this.tbxID.Margin = new System.Windows.Forms.Padding(0);
            this.tbxID.MaxLength = 30;
            this.tbxID.Name = "tbxID";
            this.tbxID.Size = new System.Drawing.Size(311, 29);
            this.tbxID.TabIndex = 1;
            this.tbxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxID_KeyDown);
            // 
            // btnCompleteGame
            // 
            this.btnCompleteGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCompleteGame.FlatAppearance.BorderSize = 0;
            this.btnCompleteGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompleteGame.Location = new System.Drawing.Point(41, 381);
            this.btnCompleteGame.Name = "btnCompleteGame";
            this.btnCompleteGame.Size = new System.Drawing.Size(305, 57);
            this.btnCompleteGame.TabIndex = 2;
            this.btnCompleteGame.Text = "Complete current game";
            this.btnCompleteGame.UseVisualStyleBackColor = true;
            this.btnCompleteGame.Click += new System.EventHandler(this.btnCompleteGame_Click);
            // 
            // btnGetStatisic
            // 
            this.btnGetStatisic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGetStatisic.FlatAppearance.BorderSize = 0;
            this.btnGetStatisic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetStatisic.Location = new System.Drawing.Point(41, 318);
            this.btnGetStatisic.Name = "btnGetStatisic";
            this.btnGetStatisic.Size = new System.Drawing.Size(305, 57);
            this.btnGetStatisic.TabIndex = 3;
            this.btnGetStatisic.Text = "Get statistic of game";
            this.btnGetStatisic.UseVisualStyleBackColor = true;
            this.btnGetStatisic.Click += new System.EventHandler(this.btnGetStatisic_Click);
            // 
            // btnGroupings
            // 
            this.btnGroupings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGroupings.FlatAppearance.BorderSize = 0;
            this.btnGroupings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGroupings.Location = new System.Drawing.Point(41, 255);
            this.btnGroupings.Name = "btnGroupings";
            this.btnGroupings.Size = new System.Drawing.Size(305, 57);
            this.btnGroupings.TabIndex = 4;
            this.btnGroupings.Text = "Groupings";
            this.btnGroupings.UseVisualStyleBackColor = true;
            this.btnGroupings.Click += new System.EventHandler(this.btnGroupings_Click);
            // 
            // btnCloseKeeper
            // 
            this.btnCloseKeeper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseKeeper.FlatAppearance.BorderSize = 0;
            this.btnCloseKeeper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseKeeper.Location = new System.Drawing.Point(41, 444);
            this.btnCloseKeeper.Name = "btnCloseKeeper";
            this.btnCloseKeeper.Size = new System.Drawing.Size(305, 64);
            this.btnCloseKeeper.TabIndex = 5;
            this.btnCloseKeeper.Text = "Close game keeper";
            this.btnCloseKeeper.UseVisualStyleBackColor = true;
            this.btnCloseKeeper.Click += new System.EventHandler(this.btnCloseKeeper_Click);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(684, 511);
            this.Controls.Add(this.spcNewCurrent);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game keeper:";
            this.spcNewCurrent.Panel1.ResumeLayout(false);
            this.spcNewCurrent.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spcNewCurrent)).EndInit();
            this.spcNewCurrent.ResumeLayout(false);
            this.tlpNewGame.ResumeLayout(false);
            this.tlpNewGame.PerformLayout();
            this.tlpCurrentGame.ResumeLayout(false);
            this.tlpCurrentGame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spcNewCurrent;
        private System.Windows.Forms.TableLayoutPanel tlpNewGame;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblRePassword;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.Button btnExitGame;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.TextBox tbxRePassword;
        private System.Windows.Forms.TableLayoutPanel tlpCurrentGame;
        private System.Windows.Forms.Label lblEnterID;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.Button btnCompleteGame;
        private System.Windows.Forms.Button btnGetStatisic;
        private System.Windows.Forms.Button btnGroupings;
        private System.Windows.Forms.Button btnCloseKeeper;
    }
}