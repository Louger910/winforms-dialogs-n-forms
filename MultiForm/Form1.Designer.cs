namespace MultiForm
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.signInButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.goodsListBox = new System.Windows.Forms.ListBox();
            this.addGoodButton = new System.Windows.Forms.Button();
            this.editGoodButton = new System.Windows.Forms.Button();
            this.deleteGoodButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(13, 13);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(75, 23);
            this.signInButton.TabIndex = 0;
            this.signInButton.Text = "SignIn";
            this.signInButton.UseVisualStyleBackColor = true;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(95, 13);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(0, 13);
            this.passwordLabel.TabIndex = 1;
            // 
            // goodsListBox
            // 
            this.goodsListBox.FormattingEnabled = true;
            this.goodsListBox.Location = new System.Drawing.Point(13, 43);
            this.goodsListBox.Name = "goodsListBox";
            this.goodsListBox.Size = new System.Drawing.Size(313, 95);
            this.goodsListBox.TabIndex = 2;
            // 
            // addGoodButton
            // 
            this.addGoodButton.Location = new System.Drawing.Point(332, 43);
            this.addGoodButton.Name = "addGoodButton";
            this.addGoodButton.Size = new System.Drawing.Size(75, 23);
            this.addGoodButton.TabIndex = 3;
            this.addGoodButton.Text = "Add";
            this.addGoodButton.UseVisualStyleBackColor = true;
            this.addGoodButton.Click += new System.EventHandler(this.addGoodButton_Click);
            // 
            // editGoodButton
            // 
            this.editGoodButton.Location = new System.Drawing.Point(413, 43);
            this.editGoodButton.Name = "editGoodButton";
            this.editGoodButton.Size = new System.Drawing.Size(75, 23);
            this.editGoodButton.TabIndex = 4;
            this.editGoodButton.Text = "Edit";
            this.editGoodButton.UseVisualStyleBackColor = true;
            this.editGoodButton.Click += new System.EventHandler(this.editGoodButton_Click);
            // 
            // deleteGoodButton
            // 
            this.deleteGoodButton.Location = new System.Drawing.Point(495, 43);
            this.deleteGoodButton.Name = "deleteGoodButton";
            this.deleteGoodButton.Size = new System.Drawing.Size(75, 23);
            this.deleteGoodButton.TabIndex = 5;
            this.deleteGoodButton.Text = "Delete";
            this.deleteGoodButton.UseVisualStyleBackColor = true;
            this.deleteGoodButton.Click += new System.EventHandler(this.DeleteGoodButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteGoodButton);
            this.Controls.Add(this.editGoodButton);
            this.Controls.Add(this.addGoodButton);
            this.Controls.Add(this.goodsListBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.signInButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.ListBox goodsListBox;
        private System.Windows.Forms.Button addGoodButton;
        private System.Windows.Forms.Button editGoodButton;
        private System.Windows.Forms.Button deleteGoodButton;
    }
}

