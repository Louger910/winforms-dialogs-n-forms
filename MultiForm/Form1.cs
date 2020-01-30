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
    public partial class Form1 : Form
    {
        private string password;
        public delegate void OnResult(Dictionary<string, object> resultArgs);
        public static BindingList<Good> GoodsModel { get; } =
            new BindingList<Good>();
        public static int SelectedGoodId { get; set; } = -1;

        public Form1()
        {
            InitializeComponent();
            password = "123456";
            SignInForm signInForm = new SignInForm();
            signInForm.OnResultCallback = (resultArgs) => {
                if (resultArgs["password"] as string == password)
                {
                    signInForm.Close();
                    // signInForm.ShowDialog();
                }
                else {
                    MessageBox.Show("Wrong password!");
                    return;
                }
                this.passwordLabel.Text = resultArgs["password"] as string;
            };
            signInForm.ShowDialog();
            goodsListBox.DataSource = GoodsModel;
            goodsListBox.SelectedValueChanged += (s, a) => {
                SelectedGoodId = (goodsListBox.SelectedItem as Good).Id;
            };
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            
        }

        private void addGoodButton_Click(object sender, EventArgs e)
        {
            GoodForm goodForm = new GoodForm() { CurrentMode = GoodForm.Mode.Add };
            goodForm.ShowDialog();
        }

        private void editGoodButton_Click(object sender, EventArgs e)
        {
            GoodForm goodForm = new GoodForm() { CurrentMode = GoodForm.Mode.Edit };
            goodForm.ShowDialog();
        }
    }
}
