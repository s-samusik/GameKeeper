using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameKeeper.UI
{
    public partial class frmGrouping : Form
    {
        private Form prevForm;

        public frmGrouping()
        {
            InitializeComponent();

            tbxNewGrouping.Focus();
            prevForm = new FrmGame();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Close();
            prevForm.Show();
        }
    }
}
