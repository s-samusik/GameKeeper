namespace GameKeeper.UI
{
    partial class FrmStatistic
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTotalPlayers = new System.Windows.Forms.Label();
            this.lblTotalMoney = new System.Windows.Forms.Label();
            this.lblQuests = new System.Windows.Forms.Label();
            this.lblKilledPlayers = new System.Windows.Forms.Label();
            this.tlpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMain.Controls.Add(this.label1, 1, 1);
            this.tlpMain.Controls.Add(this.label2, 1, 2);
            this.tlpMain.Controls.Add(this.label3, 1, 3);
            this.tlpMain.Controls.Add(this.label4, 1, 4);
            this.tlpMain.Controls.Add(this.btnBack, 1, 6);
            this.tlpMain.Controls.Add(this.lblTotalPlayers, 2, 1);
            this.tlpMain.Controls.Add(this.lblTotalMoney, 2, 2);
            this.tlpMain.Controls.Add(this.lblQuests, 2, 3);
            this.tlpMain.Controls.Add(this.lblKilledPlayers, 2, 4);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 7;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tlpMain.Size = new System.Drawing.Size(484, 487);
            this.tlpMain.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(51, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "total players:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(51, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 69);
            this.label2.TabIndex = 1;
            this.label2.Text = "total money:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(51, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 69);
            this.label3.TabIndex = 2;
            this.label3.Text = "total active quests:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(51, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 69);
            this.label4.TabIndex = 3;
            this.label4.Text = "total killed players:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(51, 417);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(187, 67);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back to main window";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTotalPlayers
            // 
            this.lblTotalPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalPlayers.Location = new System.Drawing.Point(244, 69);
            this.lblTotalPlayers.Name = "lblTotalPlayers";
            this.lblTotalPlayers.Size = new System.Drawing.Size(187, 69);
            this.lblTotalPlayers.TabIndex = 5;
            this.lblTotalPlayers.Text = "0";
            this.lblTotalPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalMoney
            // 
            this.lblTotalMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalMoney.Location = new System.Drawing.Point(244, 138);
            this.lblTotalMoney.Name = "lblTotalMoney";
            this.lblTotalMoney.Size = new System.Drawing.Size(187, 69);
            this.lblTotalMoney.TabIndex = 6;
            this.lblTotalMoney.Text = "0";
            this.lblTotalMoney.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblQuests
            // 
            this.lblQuests.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuests.Location = new System.Drawing.Point(244, 207);
            this.lblQuests.Name = "lblQuests";
            this.lblQuests.Size = new System.Drawing.Size(187, 69);
            this.lblQuests.TabIndex = 7;
            this.lblQuests.Text = "0";
            this.lblQuests.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKilledPlayers
            // 
            this.lblKilledPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKilledPlayers.Location = new System.Drawing.Point(244, 276);
            this.lblKilledPlayers.Name = "lblKilledPlayers";
            this.lblKilledPlayers.Size = new System.Drawing.Size(187, 69);
            this.lblKilledPlayers.TabIndex = 8;
            this.lblKilledPlayers.Text = "0";
            this.lblKilledPlayers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmStatistic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(484, 487);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMain);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmStatistic";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmStatistic";
            this.Load += new System.EventHandler(this.FrmStatistic_Load);
            this.tlpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTotalPlayers;
        private System.Windows.Forms.Label lblTotalMoney;
        private System.Windows.Forms.Label lblQuests;
        private System.Windows.Forms.Label lblKilledPlayers;
    }
}