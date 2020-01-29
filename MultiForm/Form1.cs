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
        public delegate void OnResult(Dictionary<string, object> resultArgs);

        public Form1()
        {
            InitializeComponent();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm((resultArgs) => {
                this.passwordLabel.Text = resultArgs["password"] as string;
            });

            signInForm.ShowDialog();
        }
    }
}
