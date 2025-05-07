namespace DTR_2022
{
    partial class LoginForm
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            pictureBoxProfileImage = new PictureBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxPassword = new TextBox();
            textBoxIDNumber = new TextBox();
            buttonLogin = new Button();
            label4 = new Label();
            labelWelcome = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfileImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProfileImage
            // 
            pictureBoxProfileImage.BackColor = Color.Gray;
            pictureBoxProfileImage.Location = new Point(50, 23);
            pictureBoxProfileImage.Margin = new Padding(4);
            pictureBoxProfileImage.Name = "pictureBoxProfileImage";
            pictureBoxProfileImage.Size = new Size(168, 173);
            pictureBoxProfileImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxProfileImage.TabIndex = 0;
            pictureBoxProfileImage.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Arial", 10F);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightGray;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Location = new Point(41, 215);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(592, 400);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 20.8F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(666, 46);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(181, 48);
            label1.TabIndex = 2;
            label1.Text = "Starbuko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 16.8F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(667, 94);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(274, 39);
            label2.TabIndex = 3;
            label2.Text = "Daily Time Record";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 13.7999992F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(667, 207);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 32);
            label3.TabIndex = 4;
            label3.Text = "ID Number";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.DarkGray;
            textBoxPassword.Font = new Font("Arial", 16F);
            textBoxPassword.ForeColor = Color.Black;
            textBoxPassword.Location = new Point(667, 429);
            textBoxPassword.Margin = new Padding(4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(256, 38);
            textBoxPassword.TabIndex = 5;
            // 
            // textBoxIDNumber
            // 
            textBoxIDNumber.BackColor = Color.DarkGray;
            textBoxIDNumber.Font = new Font("Arial", 16F);
            textBoxIDNumber.ForeColor = Color.Black;
            textBoxIDNumber.Location = new Point(667, 250);
            textBoxIDNumber.Margin = new Padding(4);
            textBoxIDNumber.Name = "textBoxIDNumber";
            textBoxIDNumber.Size = new Size(256, 38);
            textBoxIDNumber.TabIndex = 6;
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.DarkSeaGreen;
            buttonLogin.FlatStyle = FlatStyle.Flat;
            buttonLogin.Font = new Font("Arial", 10F, FontStyle.Bold);
            buttonLogin.ForeColor = Color.White;
            buttonLogin.Location = new Point(666, 562);
            buttonLogin.Margin = new Padding(4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(257, 53);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 12F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(450, 107);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(0, 24);
            label4.TabIndex = 8;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Montserrat", 18F);
            labelWelcome.ForeColor = Color.White;
            labelWelcome.Location = new Point(242, 76);
            labelWelcome.Margin = new Padding(4, 0, 4, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(391, 41);
            labelWelcome.TabIndex = 9;
            labelWelcome.Text = "Good morning Kromyko!";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 13.7999992F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(667, 379);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(126, 32);
            label5.TabIndex = 10;
            label5.Text = "Password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(945, 640);
            Controls.Add(label5);
            Controls.Add(labelWelcome);
            Controls.Add(label4);
            Controls.Add(buttonLogin);
            Controls.Add(textBoxIDNumber);
            Controls.Add(textBoxPassword);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(pictureBoxProfileImage);
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoginForm";
            Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfileImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxProfileImage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxIDNumber;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelWelcome;
        private Label label5;
    }
}