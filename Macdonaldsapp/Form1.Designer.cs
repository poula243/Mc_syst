namespace Macdonaldsapp
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Lable_username = new System.Windows.Forms.Label();
            this.Lable_password = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_massage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lable_username
            // 
            this.Lable_username.AutoSize = true;
            this.Lable_username.BackColor = System.Drawing.Color.Black;
            this.Lable_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_username.ForeColor = System.Drawing.Color.Gold;
            this.Lable_username.Location = new System.Drawing.Point(12, 131);
            this.Lable_username.Name = "Lable_username";
            this.Lable_username.Size = new System.Drawing.Size(192, 38);
            this.Lable_username.TabIndex = 0;
            this.Lable_username.Text = "User Name";
            // 
            // Lable_password
            // 
            this.Lable_password.AutoSize = true;
            this.Lable_password.BackColor = System.Drawing.Color.Black;
            this.Lable_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lable_password.ForeColor = System.Drawing.Color.Gold;
            this.Lable_password.Location = new System.Drawing.Point(12, 298);
            this.Lable_password.Name = "Lable_password";
            this.Lable_password.Size = new System.Drawing.Size(170, 38);
            this.Lable_password.TabIndex = 1;
            this.Lable_password.Text = "Password";
            // 
            // textBox_username
            // 
            this.textBox_username.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_username.Location = new System.Drawing.Point(235, 130);
            this.textBox_username.Multiline = true;
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(213, 39);
            this.textBox_username.TabIndex = 2;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.SystemColors.Info;
            this.textBox_password.Location = new System.Drawing.Point(235, 297);
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(213, 39);
            this.textBox_password.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(297, 519);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 72);
            this.button1.TabIndex = 4;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_massage
            // 
            this.label_massage.AutoSize = true;
            this.label_massage.BackColor = System.Drawing.Color.Black;
            this.label_massage.ForeColor = System.Drawing.Color.Red;
            this.label_massage.Location = new System.Drawing.Point(173, 388);
            this.label_massage.Name = "label_massage";
            this.label_massage.Size = new System.Drawing.Size(420, 36);
            this.label_massage.TabIndex = 5;
            this.label_massage.Text = "Invalid password or user name";
            this.label_massage.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(814, 603);
            this.Controls.Add(this.label_massage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.Lable_password);
            this.Controls.Add(this.Lable_username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lable_username;
        private System.Windows.Forms.Label Lable_password;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_massage;
    }
}

