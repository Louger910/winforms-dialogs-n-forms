using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MultiForm.Form1;

namespace MultiForm
{
    public partial class SignInForm : Form
    {
        private OnResult onResultCallback;
        public SignInForm(OnResult onResultCallback)
        {
            InitializeComponent();
            this.onResultCallback = onResultCallback;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Dictionary<string, object> resultArgs = new Dictionary<string, object>();
            resultArgs["password"] = passwordTextBox.Text;
            onResultCallback(resultArgs);
            DialogResult = DialogResult.OK;
        }
    }
}
