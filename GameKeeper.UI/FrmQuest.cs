﻿using System;
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
    public partial class FrmQuest : Form
    {
        public FrmQuest()
        {
            InitializeComponent();
        }

        private void btnCloseWindow_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
