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
            this.tbxInWallet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxCashAmount = new System.Windows.Forms.TextBox();
            this.btnAddCash = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTakeAllMoney = new System.Windows.Forms.Button();
            this.tplWallet.SuspendLayout();
            this.SuspendLayout();
            // 
            // tplWallet
            // 
            this.tplWallet.ColumnCount = 4;
            this.tplWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tplWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tplWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tplWallet.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tplWallet.Controls.Add(this.btnCloseWallet, 2, 5);
            this.tplWallet.Controls.Add(this.btnRemoveCash, 2, 4);
            this.tplWallet.Controls.Add(this.tbxInWallet, 2, 1);
            this.tplWallet.Controls.Add(this.label1, 1, 1);
            this.tplWallet.Controls.Add(this.tbxCashAmount, 2, 2);
            this.tplWallet.Controls.Add(this.btnAddCash, 1, 4);
            this.tplWallet.Controls.Add(this.label2, 1, 2);
            this.tplWallet.Controls.Add(this.btnTakeAllMoney, 1, 5);
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
            this.tplWallet.Size = new System.Drawing.Size(480, 357);
            this.tplWallet.TabIndex = 0;
            // 
            // btnCloseWallet
            // 
            this.btnCloseWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseWallet.FlatAppearance.BorderSize = 0;
            this.btnCloseWallet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseWallet.Location = new System.Drawing.Point(243, 298);
            this.btnCloseWallet.Name = "btnCloseWallet";
            this.btnCloseWallet.Size = new System.Drawing.Size(186, 56);
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
            this.btnRemoveCash.Location = new System.Drawing.Point(243, 239);
            this.btnRemoveCash.Name = "btnRemoveCash";
            this.btnRemoveCash.Size = new System.Drawing.Size(186, 53);
            this.btnRemoveCash.TabIndex = 4;
            this.btnRemoveCash.Text = "Remove from wallet";
            this.btnRemoveCash.UseVisualStyleBackColor = true;
            this.btnRemoveCash.Click += new System.EventHandler(this.btnRemoveCash_Click);
            // 
            // tbxInWallet
            // 
            this.tbxInWallet.BackColor = System.Drawing.Color.Silver;
            this.tbxInWallet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxInWallet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxInWallet.Enabled = false;
            this.tbxInWallet.Location = new System.Drawing.Point(243, 74);
            this.tbxInWallet.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tbxInWallet.MaxLength = 15;
            this.tbxInWallet.Name = "tbxInWallet";
            this.tbxInWallet.Size = new System.Drawing.Size(186, 29);
            this.tbxInWallet.TabIndex = 0;
            this.tbxInWallet.Text = "0";
            this.tbxInWallet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(51, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 59);
            this.label1.TabIndex = 1;
            this.label1.Text = "total in wallet:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tbxCashAmount
            // 
            this.tbxCashAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxCashAmount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxCashAmount.Location = new System.Drawing.Point(243, 133);
            this.tbxCashAmount.Margin = new System.Windows.Forms.Padding(3, 15, 3, 3);
            this.tbxCashAmount.MaxLength = 15;
            this.tbxCashAmount.Name = "tbxCashAmount";
            this.tbxCashAmount.Size = new System.Drawing.Size(186, 29);
            this.tbxCashAmount.TabIndex = 2;
            this.tbxCashAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxCashAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxCashAmount_KeyPress);
            // 
            // btnAddCash
            // 
            this.btnAddCash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddCash.FlatAppearance.BorderSize = 0;
            this.btnAddCash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCash.Location = new System.Drawing.Point(51, 239);
            this.btnAddCash.Name = "btnAddCash";
            this.btnAddCash.Size = new System.Drawing.Size(186, 53);
            this.btnAddCash.TabIndex = 3;
            this.btnAddCash.Text = "Put in wallet";
            this.btnAddCash.UseVisualStyleBackColor = true;
            this.btnAddCash.Click += new System.EventHandler(this.btnAddCash_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(51, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 59);
            this.label2.TabIndex = 6;
            this.label2.Text = "enter cash amount:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnTakeAllMoney
            // 
            this.btnTakeAllMoney.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTakeAllMoney.FlatAppearance.BorderSize = 0;
            this.btnTakeAllMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTakeAllMoney.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTakeAllMoney.Location = new System.Drawing.Point(51, 298);
            this.btnTakeAllMoney.Name = "btnTakeAllMoney";
            this.btnTakeAllMoney.Size = new System.Drawing.Size(186, 56);
            this.btnTakeAllMoney.TabIndex = 7;
            this.btnTakeAllMoney.Text = "Take all money";
            this.btnTakeAllMoney.UseVisualStyleBackColor = true;
            // 
            // FrmWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(480, 357);
            this.ControlBox = false;
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
        private System.Windows.Forms.TextBox tbxInWallet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxCashAmount;
        private System.Windows.Forms.Button btnAddCash;
        private System.Windows.Forms.Button btnCloseWallet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTakeAllMoney;
    }
}