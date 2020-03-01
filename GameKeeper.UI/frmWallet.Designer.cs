namespace GameKeeper.UI
{
    partial class FrmWallet
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
            this.tplWallet = new System.Windows.Forms.TableLayoutPanel();
            this.btnCloseWallet = new System.Windows.Forms.Button();
            this.btnRemoveCash = new System.Windows.Forms.Button();
            this.tbxWallet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAddCash = new System.Windows.Forms.TextBox();
            this.btnAddCash = new System.Windows.Forms.Button();
            this.tplWallet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tplWallet
            // 
            this.tplWallet.ColumnCount = 3;
            this.tplWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tplWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.66666F));
            this.tplWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tplWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplWallet.Controls.Add(this.btnCloseWallet, 1, 5);
            this.tplWallet.Controls.Add(this.btnRemoveCash, 1, 4);
            this.tplWallet.Controls.Add(this.tbxWallet, 1, 1);
            this.tplWallet.Controls.Add(this.label1, 1, 0);
            this.tplWallet.Controls.Add(this.tbxAddCash, 1, 2);
            this.tplWallet.Controls.Add(this.btnAddCash, 1, 3);
            this.tplWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tplWallet.Location = new System.Drawing.Point(0, 0);
            this.tplWallet.Name = "tplWallet";
            this.tplWallet.RowCount = 6;
            this.tplWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tplWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tplWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tplWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tplWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tplWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tplWallet.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tplWallet.Size = new System.Drawing.Size(484, 361);
            this.tplWallet.TabIndex = 0;
            // 
            // btnCloseWallet
            // 
            this.btnCloseWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseWallet.FlatAppearance.BorderSize = 0;
            this.btnCloseWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWallet.Location = new System.Drawing.Point(83, 303);
            this.btnCloseWallet.Name = "btnCloseWallet";
            this.btnCloseWallet.Size = new System.Drawing.Size(316, 55);
            this.btnCloseWallet.TabIndex = 5;
            this.btnCloseWallet.Text = "Close wallet";
            this.btnCloseWallet.UseVisualStyleBackColor = true;
            this.btnCloseWallet.Click += new System.EventHandler(this.btnCloseWallet_Click);
            // 
            // btnRemoveCash
            // 
            this.btnRemoveCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemoveCash.FlatAppearance.BorderSize = 0;
            this.btnRemoveCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveCash.Location = new System.Drawing.Point(83, 243);
            this.btnRemoveCash.Name = "btnRemoveCash";
            this.btnRemoveCash.Size = new System.Drawing.Size(316, 54);
            this.btnRemoveCash.TabIndex = 4;
            this.btnRemoveCash.Text = "Remove from wallet";
            this.btnRemoveCash.UseVisualStyleBackColor = true;
            this.btnRemoveCash.Click += new System.EventHandler(this.btnRemoveCash_Click);
            // 
            // tbxWallet
            // 
            this.tbxWallet.BackColor = System.Drawing.Color.Silver;
            this.tbxWallet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxWallet.Enabled = false;
            this.tbxWallet.Location = new System.Drawing.Point(83, 75);
            this.tbxWallet.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tbxWallet.Name = "tbxWallet";
            this.tbxWallet.Size = new System.Drawing.Size(316, 29);
            this.tbxWallet.TabIndex = 0;
            this.tbxWallet.Text = "0";
            this.tbxWallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(83, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 60);
            this.label1.TabIndex = 1;
            this.label1.Text = "wallet:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbxAddCash
            // 
            this.tbxAddCash.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxAddCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxAddCash.Location = new System.Drawing.Point(83, 135);
            this.tbxAddCash.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tbxAddCash.MaxLength = 30;
            this.tbxAddCash.Name = "tbxAddCash";
            this.tbxAddCash.Size = new System.Drawing.Size(316, 29);
            this.tbxAddCash.TabIndex = 2;
            this.tbxAddCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddCash
            // 
            this.btnAddCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCash.FlatAppearance.BorderSize = 0;
            this.btnAddCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCash.Location = new System.Drawing.Point(83, 183);
            this.btnAddCash.Name = "btnAddCash";
            this.btnAddCash.Size = new System.Drawing.Size(316, 54);
            this.btnAddCash.TabIndex = 3;
            this.btnAddCash.Text = "Put in wallet";
            this.btnAddCash.UseVisualStyleBackColor = true;
            this.btnAddCash.Click += new System.EventHandler(this.btnAddCash_Click);
            // 
            // FrmWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.tplWallet);
            this.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWallet";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Keeper: Wallet";
            this.tplWallet.ResumeLayout(false);
            this.tplWallet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tplWallet;
        private System.Windows.Forms.Button btnRemoveCash;
        private System.Windows.Forms.TextBox tbxWallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxAddCash;
        private System.Windows.Forms.Button btnAddCash;
        private System.Windows.Forms.Button btnCloseWallet;
    }
}