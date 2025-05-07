
namespace DTR_2022
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfileImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxProfileImage
            // 
            pictureBoxProfileImage.Location = new Point(91, 109);
            pictureBoxProfileImage.Margin = new Padding(4, 4, 4, 4);
            pictureBoxProfileImage.Name = "pictureBoxProfileImage";
            pictureBoxProfileImage.Size = new Size(129, 67);
            pictureBoxProfileImage.TabIndex = 0;
            pictureBoxProfileImage.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(91, 275);
            dataGridView1.Margin = new Padding(4, 4, 4, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(309, 200);
            dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(783, 109);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 2;
            label1.Text = "Starbuko";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(783, 201);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 3;
            label2.Text = "ID Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(783, 315);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 4;
            label3.Text = "Password";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(783, 360);
            textBoxPassword.Margin = new Padding(4, 4, 4, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(127, 27);
            textBoxPassword.TabIndex = 5;
            // 
            // textBoxIDNumber
            // 
            textBoxIDNumber.Location = new Point(783, 243);
            textBoxIDNumber.Margin = new Padding(4, 4, 4, 4);
            textBoxIDNumber.Name = "textBoxIDNumber";
            textBoxIDNumber.Size = new Size(127, 27);
            textBoxIDNumber.TabIndex = 6;
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(783, 477);
            buttonLogin.Margin = new Padding(4, 4, 4, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.RightToLeft = RightToLeft.No;
            buttonLogin.Size = new Size(96, 31);
            buttonLogin.TabIndex = 7;
            buttonLogin.Text = "LOGIN";
            buttonLogin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(783, 143);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(162, 20);
            label4.TabIndex = 8;
            label4.Text = "Daily Time Record";
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Location = new Point(342, 143);
            labelWelcome.Margin = new Padding(4, 0, 4, 0);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(198, 20);
            labelWelcome.TabIndex = 9;
            labelWelcome.Text = "Good morning Kromyko!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1029, 600);
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
            Margin = new Padding(4, 4, 4, 4);
            Name = "LoginForm";
            Text = "Form1";
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
    }
}

