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
            this.tbTime = new System.Windows.Forms.TrackBar();
            this.lblDeadTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxTimeLeft = new System.Windows.Forms.TextBox();
            this.tlpMurder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).BeginInit();
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
            this.tlpMurder.Controls.Add(this.tbTime, 2, 1);
            this.tlpMurder.Controls.Add(this.lblDeadTime, 2, 0);
            this.tlpMurder.Controls.Add(this.label1, 1, 0);
            this.tlpMurder.Controls.Add(this.label2, 1, 1);
            this.tlpMurder.Controls.Add(this.label3, 1, 2);
            this.tlpMurder.Controls.Add(this.tbxTimeLeft, 2, 2);
            this.tlpMurder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMurder.Location = new System.Drawing.Point(0, 0);
            this.tlpMurder.Name = "tlpMurder";
            this.tlpMurder.RowCount = 5;
            this.tlpMurder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMurder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMurder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMurder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMurder.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpMurder.Size = new System.Drawing.Size(468, 345);
            this.tlpMurder.TabIndex = 0;
            // 
            // btnKillPlayer
            // 
            this.btnKillPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKillPlayer.FlatAppearance.BorderSize = 0;
            this.btnKillPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKillPlayer.Location = new System.Drawing.Point(49, 279);
            this.btnKillPlayer.Name = "btnKillPlayer";
            this.btnKillPlayer.Size = new System.Drawing.Size(181, 63);
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
            this.btnBack.Location = new System.Drawing.Point(236, 279);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(181, 63);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Close window";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // tbTime
            // 
            this.tbTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTime.Location = new System.Drawing.Point(236, 84);
            this.tbTime.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tbTime.Maximum = 59;
            this.tbTime.Minimum = 1;
            this.tbTime.Name = "tbTime";
            this.tbTime.Size = new System.Drawing.Size(181, 51);
            this.tbTime.TabIndex = 2;
            this.tbTime.Tag = "";
            this.tbTime.TickFrequency = 12;
            this.tbTime.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.tbTime.Value = 1;
            // 
            // lblDeadTime
            // 
            this.lblDeadTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDeadTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDeadTime.Location = new System.Drawing.Point(236, 0);
            this.lblDeadTime.Name = "lblDeadTime";
            this.lblDeadTime.Size = new System.Drawing.Size(181, 69);
            this.lblDeadTime.TabIndex = 3;
            this.lblDeadTime.Text = "1 min.";
            this.lblDeadTime.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(49, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 69);
            this.label1.TabIndex = 4;
            this.label1.Text = "dead time:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(49, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 69);
            this.label2.TabIndex = 5;
            this.label2.Text = "drag track bar:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(49, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 69);
            this.label3.TabIndex = 6;
            this.label3.Text = "time left:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxTimeLeft
            // 
            this.tbxTimeLeft.BackColor = System.Drawing.Color.Silver;
            this.tbxTimeLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxTimeLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxTimeLeft.Enabled = false;
            this.tbxTimeLeft.Location = new System.Drawing.Point(236, 153);
            this.tbxTimeLeft.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tbxTimeLeft.MaxLength = 30;
            this.tbxTimeLeft.Name = "tbxTimeLeft";
            this.tbxTimeLeft.Size = new System.Drawing.Size(181, 29);
            this.tbxTimeLeft.TabIndex = 7;
            this.tbxTimeLeft.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmMurder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(468, 345);
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
            this.Text = "GameKeeper: kill";
            this.tlpMurder.ResumeLayout(false);
            this.tlpMurder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMurder;
        private System.Windows.Forms.Button btnKillPlayer;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TrackBar tbTime;
        private System.Windows.Forms.Label lblDeadTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxTimeLeft;
    }
}