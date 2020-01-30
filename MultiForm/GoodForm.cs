using MultiForm.model;
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
    public partial class GoodForm : Form
    {
        public enum Mode {
            Add,
            Edit
        }
        private Mode mode;

        private Good CurentGood;
        public Mode CurrentMode {
            private get { return mode; }
            set {
                mode = value;
                if (mode == Mode.Edit)
                {
                    CurentGood =
                        Form1.GoodsModel.Where(
                            g => g.Id == Form1.SelectedGoodId
                        ).SingleOrDefault();
                    titleTextBox.Text = CurentGood.Title;
                    priceTextBox.Text = CurentGood.Price.ToString();
                }
            }
        }
        public GoodForm()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (CurrentMode == Mode.Add)
            {
                Form1.GoodsModel.Add(
                new model.Good()
                {
                    Title = titleTextBox.Text,
                    Price = Decimal.Parse(priceTextBox.Text)
                });
            }
            else if (CurrentMode == Mode.Edit)
            {
                CurentGood.Title = titleTextBox.Text;
                CurentGood.Price = Decimal.Parse(priceTextBox.Text);
                // Form1.GoodsModel.OnListChanged(new ListChangedEventArgs(ListChangedType.ItemChanged, Form1.GoodsModel.IndexOf(CurentGood)));
                Form1.GoodsModel.ResetBindings();
            }
            
            DialogResult = DialogResult.OK;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
