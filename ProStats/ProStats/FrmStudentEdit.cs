﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProStats
{
    public partial class FrmStudentEdit : Form
    {
        public FrmStudentEdit()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            FrmStudentSearch stuSearch = new FrmStudentSearch();
            stuSearch.ShowDialog();
        }
    }
}
