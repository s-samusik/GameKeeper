namespace GameKeeper.UI
{
    partial class FrmMurder
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
            this.tlpMurder = new System.Windows.Forms.TableLayoutPanel();
            this.btnKillPlayer = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSummary = new System.Windows.Forms.Label();
            this.tbxTimeLeft = new System.Windows.Forms.TextBox();
            this.numHours = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numMinutes = new System.Windows.Forms.NumericUpDown();
            this.tlpMurder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpMurder
            // 
            this.tlpMurder.ColumnCount = 4;
            this.tlpMurder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMurder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMurder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpMurder.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpMurder.Controls.Add(this.btnKillPlayer, 1, 4);
            this.tlpMurder.Controls.Add(this.btnBack, 2, 4);
            this.tlpMurder.Controls.Add(this.label1, 1, 0);
            this.tlpMurder.Controls.Add(this.lblSummary, 1, 2);
            this.tlpMurder.Controls.Add(this.tbxTimeLeft, 2, 2);
            this.tlpMurder.Controls.Add(this.numHours, 2, 0);
            this.tlpMurder.Controls.Add(this.label2, 1, 1);
            this.tlpMurder.Controls.Add(this.numMinutes, 2, 1);
            this.tlpMurder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMurder.Location = new System.Drawing.Point(0, 0);
            this.tlpMurder.Name = "tlpMurder";
            this.tlpMurder.RowCount = 5;
            this.tlpMurder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMurder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMurder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMurder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMurder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMurder.Size = new System.Drawing.Size(452, 329);
            this.tlpMurder.TabIndex = 0;
            // 
            // btnKillPlayer
            // 
            this.btnKillPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKillPlayer.FlatAppearance.BorderSize = 0;
            this.btnKillPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKillPlayer.Location = new System.Drawing.Point(48, 263);
            this.btnKillPlayer.Name = "btnKillPlayer";
            this.btnKillPlayer.Size = new System.Drawing.Size(174, 63);
            this.btnKillPlayer.TabIndex = 0;
            this.btnKillPlayer.Text = "Kill";
            this.btnKillPlayer.UseVisualStyleBackColor = true;
            this.btnKillPlayer.Click += new System.EventHandler(this.btnKillPlayer_Click);
            // 
            // btnBack
            // 
            this.btnBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(228, 263);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(174, 63);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Close window";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(48, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "enter hours:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblSummary
            // 
            this.lblSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSummary.Location = new System.Drawing.Point(48, 133);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(174, 62);
            this.lblSummary.TabIndex = 6;
            this.lblSummary.Text = "summary time:";
            this.lblSummary.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // tbxTimeLeft
            // 
            this.tbxTimeLeft.BackColor = System.Drawing.Color.Silver;
            this.tbxTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTimeLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tbxTimeLeft.Enabled = false;
            this.tbxTimeLeft.Location = new System.Drawing.Point(228, 166);
            this.tbxTimeLeft.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.tbxTimeLeft.MaxLength = 30;
            this.tbxTimeLeft.Name = "tbxTimeLeft";
            this.tbxTimeLeft.Size = new System.Drawing.Size(174, 29);
            this.tbxTimeLeft.TabIndex = 7;
            this.tbxTimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numHours
            // 
            this.numHours.BackColor = System.Drawing.Color.Silver;
            this.numHours.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numHours.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.numHours.Location = new System.Drawing.Point(228, 36);
            this.numHours.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.numHours.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numHours.Name = "numHours";
            this.numHours.Size = new System.Drawing.Size(174, 29);
            this.numHours.TabIndex = 8;
            this.numHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(48, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 65);
            this.label2.TabIndex = 9;
            this.label2.Text = "enter minutes:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numMinutes
            // 
            this.numMinutes.BackColor = System.Drawing.Color.Silver;
            this.numMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numMinutes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.numMinutes.Location = new System.Drawing.Point(228, 85);
            this.numMinutes.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.numMinutes.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numMinutes.Name = "numMinutes";
            this.numMinutes.Size = new System.Drawing.Size(174, 29);
            this.numMinutes.TabIndex = 10;
            this.numMinutes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmMurder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(452, 329);
            this.ControlBox = false;
            this.Controls.Add(this.tlpMurder);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMurder";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameKeeper: kill current player";
            this.tlpMurder.ResumeLayout(false);
            this.tlpMurder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHours)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMinutes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMurder;
        private System.Windows.Forms.Button btnKillPlayer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.TextBox tbxTimeLeft;
        private System.Windows.Forms.NumericUpDown numHours;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numMinutes;
    }
}