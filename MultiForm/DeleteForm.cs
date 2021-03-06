﻿using MultiForm.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultiForm
{
    public partial class DeleteForm : Form
    {
        int selected = Form1.SelectedGoodId;
        public DeleteForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Form1.GoodsModel.RemoveAt(selected-1);
            selected++;
            //Form1.GoodsModel.RemoveAt()
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
