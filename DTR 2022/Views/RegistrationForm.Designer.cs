namespace DTR_2022.Views
{
    partial class RegistrationForm
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
            labelName = new Label();
            textBoxName = new TextBox();
            labelAddress = new Label();
            textBoxAddress = new TextBox();
            labelSex = new Label();
            comboBoxSex = new ComboBox();
            labelBirthdate = new Label();
            dateTimePickerBirthdate = new DateTimePicker();
            labelContactInfo = new Label();
            textBoxContactInfo = new TextBox();
            labelPosition = new Label();
            textBoxPosition = new TextBox();
            labelHourlyRate = new Label();
            textBoxHourlyRate = new TextBox();
            labelPassword = new Label();
            textBoxPassword = new TextBox();
            labelProfileImage = new Label();
            textBoxProfileImage = new TextBox();
            labelRole = new Label();
            comboBoxRole = new ComboBox();
            buttonRegister = new Button();
            pictureBoxProfileImage = new PictureBox();
            buttonSelectImage = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfileImage).BeginInit();
            SuspendLayout();
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Segoe UI", 10F);
            labelName.ForeColor = Color.White;
            labelName.Location = new Point(15, 20);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(60, 22);
            labelName.TabIndex = 0;
            labelName.Text = "Name:";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = Color.LightGray;
            textBoxName.Font = new Font("Segoe UI", 9F);
            textBoxName.Location = new Point(154, 16);
            textBoxName.Margin = new Padding(4, 4, 4, 4);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(282, 27);
            textBoxName.TabIndex = 1;
            // 
            // labelAddress
            // 
            labelAddress.AutoSize = true;
            labelAddress.Font = new Font("Segoe UI", 10F);
            labelAddress.ForeColor = Color.White;
            labelAddress.Location = new Point(15, 60);
            labelAddress.Margin = new Padding(4, 0, 4, 0);
            labelAddress.Name = "labelAddress";
            labelAddress.Size = new Size(90, 22);
            labelAddress.TabIndex = 2;
            labelAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            textBoxAddress.BackColor = Color.LightGray;
            textBoxAddress.Font = new Font("Segoe UI", 9F);
            textBoxAddress.Location = new Point(154, 56);
            textBoxAddress.Margin = new Padding(4, 4, 4, 4);
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(282, 27);
            textBoxAddress.TabIndex = 3;
            // 
            // labelSex
            // 
            labelSex.AutoSize = true;
            labelSex.Font = new Font("Segoe UI", 10F);
            labelSex.ForeColor = Color.White;
            labelSex.Location = new Point(15, 100);
            labelSex.Margin = new Padding(4, 0, 4, 0);
            labelSex.Name = "labelSex";
            labelSex.Size = new Size(50, 22);
            labelSex.TabIndex = 4;
            labelSex.Text = "Sex:";
            // 
            // comboBoxSex
            // 
            comboBoxSex.BackColor = Color.LightGray;
            comboBoxSex.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSex.Font = new Font("Segoe UI", 9F);
            comboBoxSex.FormattingEnabled = true;
            comboBoxSex.Items.AddRange(new object[] { "Male", "Female", "Other" });
            comboBoxSex.Location = new Point(154, 96);
            comboBoxSex.Margin = new Padding(4, 4, 4, 4);
            comboBoxSex.Name = "comboBoxSex";
            comboBoxSex.Size = new Size(282, 28);
            comboBoxSex.TabIndex = 5;
            // 
            // labelBirthdate
            // 
            labelBirthdate.AutoSize = true;
            labelBirthdate.Font = new Font("Segoe UI", 10F);
            labelBirthdate.ForeColor = Color.White;
            labelBirthdate.Location = new Point(15, 140);
            labelBirthdate.Margin = new Padding(4, 0, 4, 0);
            labelBirthdate.Name = "labelBirthdate";
            labelBirthdate.Size = new Size(110, 22);
            labelBirthdate.TabIndex = 6;
            labelBirthdate.Text = "Birthdate:";
            // 
            // dateTimePickerBirthdate
            // 
            dateTimePickerBirthdate.Location = new Point(154, 136);
            dateTimePickerBirthdate.Margin = new Padding(4, 4, 4, 4);
            dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            dateTimePickerBirthdate.Size = new Size(282, 27);
            dateTimePickerBirthdate.TabIndex = 7;
            // 
            // labelContactInfo
            // 
            labelContactInfo.AutoSize = true;
            labelContactInfo.Font = new Font("Segoe UI", 10F);
            labelContactInfo.ForeColor = Color.White;
            labelContactInfo.Location = new Point(15, 180);
            labelContactInfo.Margin = new Padding(4, 0, 4, 0);
            labelContactInfo.Name = "labelContactInfo";
            labelContactInfo.Size = new Size(140, 22);
            labelContactInfo.TabIndex = 8;
            labelContactInfo.Text = "Contact Info:";
            // 
            // textBoxContactInfo
            // 
            textBoxContactInfo.BackColor = Color.LightGray;
            textBoxContactInfo.Font = new Font("Segoe UI", 9F);
            textBoxContactInfo.Location = new Point(154, 176);
            textBoxContactInfo.Margin = new Padding(4, 4, 4, 4);
            textBoxContactInfo.Name = "textBoxContactInfo";
            textBoxContactInfo.Size = new Size(282, 27);
            textBoxContactInfo.TabIndex = 9;
            // 
            // labelPosition
            // 
            labelPosition.AutoSize = true;
            labelPosition.Font = new Font("Segoe UI", 10F);
            labelPosition.ForeColor = Color.White;
            labelPosition.Location = new Point(15, 220);
            labelPosition.Margin = new Padding(4, 0, 4, 0);
            labelPosition.Name = "labelPosition";
            labelPosition.Size = new Size(100, 22);
            labelPosition.TabIndex = 10;
            labelPosition.Text = "Position:";
            // 
            // textBoxPosition
            // 
            textBoxPosition.BackColor = Color.LightGray;
            textBoxPosition.Font = new Font("Segoe UI", 9F);
            textBoxPosition.Location = new Point(154, 216);
            textBoxPosition.Margin = new Padding(4, 4, 4, 4);
            textBoxPosition.Name = "textBoxPosition";
            textBoxPosition.Size = new Size(282, 27);
            textBoxPosition.TabIndex = 11;
            // 
            // labelHourlyRate
            // 
            labelHourlyRate.AutoSize = true;
            labelHourlyRate.Font = new Font("Segoe UI", 10F);
            labelHourlyRate.ForeColor = Color.White;
            labelHourlyRate.Location = new Point(15, 260);
            labelHourlyRate.Margin = new Padding(4, 0, 4, 0);
            labelHourlyRate.Name = "labelHourlyRate";
            labelHourlyRate.Size = new Size(130, 22);
            labelHourlyRate.TabIndex = 12;
            labelHourlyRate.Text = "Hourly Rate:";
            // 
            // textBoxHourlyRate
            // 
            textBoxHourlyRate.BackColor = Color.LightGray;
            textBoxHourlyRate.Font = new Font("Segoe UI", 9F);
            textBoxHourlyRate.Location = new Point(154, 256);
            textBoxHourlyRate.Margin = new Padding(4, 4, 4, 4);
            textBoxHourlyRate.Name = "textBoxHourlyRate";
            textBoxHourlyRate.Size = new Size(282, 27);
            textBoxHourlyRate.TabIndex = 13;
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 10F);
            labelPassword.ForeColor = Color.White;
            labelPassword.Location = new Point(15, 300);
            labelPassword.Margin = new Padding(4, 0, 4, 0);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(100, 22);
            labelPassword.TabIndex = 14;
            labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.LightGray;
            textBoxPassword.Font = new Font("Segoe UI", 9F);
            textBoxPassword.Location = new Point(154, 296);
            textBoxPassword.Margin = new Padding(4, 4, 4, 4);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(282, 27);
            textBoxPassword.TabIndex = 15;
            // 
            // labelProfileImage
            // 
            labelProfileImage.AutoSize = true;
            labelProfileImage.Font = new Font("Segoe UI", 10F);
            labelProfileImage.ForeColor = Color.White;
            labelProfileImage.Location = new Point(15, 340);
            labelProfileImage.Margin = new Padding(4, 0, 4, 0);
            labelProfileImage.Name = "labelProfileImage";
            labelProfileImage.Size = new Size(150, 22);
            labelProfileImage.TabIndex = 16;
            labelProfileImage.Text = "Profile Image:";
            // 
            // textBoxProfileImage
            // 
            textBoxProfileImage.BackColor = Color.LightGray;
            textBoxProfileImage.Font = new Font("Segoe UI", 9F);
            textBoxProfileImage.Location = new Point(154, 336);
            textBoxProfileImage.Margin = new Padding(4, 4, 4, 4);
            textBoxProfileImage.Name = "textBoxProfileImage";
            textBoxProfileImage.Size = new Size(282, 27);
            textBoxProfileImage.TabIndex = 17;
            // 
            // labelRole
            // 
            labelRole.AutoSize = true;
            labelRole.Font = new Font("Segoe UI", 10F);
            labelRole.ForeColor = Color.White;
            labelRole.Location = new Point(15, 380);
            labelRole.Margin = new Padding(4, 0, 4, 0);
            labelRole.Name = "labelRole";
            labelRole.Size = new Size(60, 22);
            labelRole.TabIndex = 18;
            labelRole.Text = "Role:";
            // 
            // comboBoxRole
            // 
            comboBoxRole.BackColor = Color.LightGray;
            comboBoxRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxRole.Font = new Font("Segoe UI", 9F);
            comboBoxRole.FormattingEnabled = true;
            comboBoxRole.Items.AddRange(new object[] { "Employee", "Admin", "HR" });
            comboBoxRole.Location = new Point(154, 376);
            comboBoxRole.Margin = new Padding(4, 4, 4, 4);
            comboBoxRole.Name = "comboBoxRole";
            comboBoxRole.Size = new Size(282, 28);
            comboBoxRole.TabIndex = 19;
            // 
            // buttonRegister
            // 
            buttonRegister.BackColor = Color.DarkSeaGreen;
            buttonRegister.FlatStyle = FlatStyle.Flat;
            buttonRegister.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            buttonRegister.ForeColor = Color.White;
            buttonRegister.Location = new Point(154, 427);
            buttonRegister.Margin = new Padding(4, 4, 4, 4);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(283, 47);
            buttonRegister.TabIndex = 20;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = false;
            // 
            // pictureBoxProfileImage
            // 
            pictureBoxProfileImage.BackColor = Color.LightGray;
            pictureBoxProfileImage.Location = new Point(450, 336);
            pictureBoxProfileImage.Name = "pictureBoxProfileImage";
            pictureBoxProfileImage.Size = new Size(100, 100);
            pictureBoxProfileImage.TabIndex = 21;
            pictureBoxProfileImage.TabStop = false;
            // 
            // buttonSelectImage
            // 
            buttonSelectImage.BackColor = Color.DarkSeaGreen;
            buttonSelectImage.FlatStyle = FlatStyle.Flat;
            buttonSelectImage.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonSelectImage.ForeColor = Color.White;
            buttonSelectImage.Location = new Point(450, 442);
            buttonSelectImage.Name = "buttonSelectImage";
            buttonSelectImage.Size = new Size(100, 30);
            buttonSelectImage.TabIndex = 22;
            buttonSelectImage.Text = "Select Image";
            buttonSelectImage.UseVisualStyleBackColor = false;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(566, 507); // Increased width for picture box
            Controls.Add(buttonSelectImage);
            Controls.Add(pictureBoxProfileImage);
            Controls.Add(buttonRegister);
            Controls.Add(comboBoxRole);
            Controls.Add(labelRole);
            Controls.Add(textBoxProfileImage);
            Controls.Add(labelProfileImage);
            Controls.Add(textBoxPassword);
            Controls.Add(labelPassword);
            Controls.Add(textBoxHourlyRate);
            Controls.Add(labelHourlyRate);
            Controls.Add(textBoxPosition);
            Controls.Add(labelPosition);
            Controls.Add(textBoxContactInfo);
            Controls.Add(labelContactInfo);
            Controls.Add(dateTimePickerBirthdate);
            Controls.Add(labelBirthdate);
            Controls.Add(comboBoxSex);
            Controls.Add(labelSex);
            Controls.Add(textBoxAddress);
            Controls.Add(labelAddress);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "RegistrationForm";
            Text = "User Registration";
            ((System.ComponentModel.ISupportInitialize)pictureBoxProfileImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelSex;
        private System.Windows.Forms.ComboBox comboBoxSex;
        private System.Windows.Forms.Label labelBirthdate;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        private System.Windows.Forms.Label labelContactInfo;
        private System.Windows.Forms.TextBox textBoxContactInfo;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label labelHourlyRate;
        private System.Windows.Forms.TextBox textBoxHourlyRate;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelProfileImage;
        private System.Windows.Forms.TextBox textBoxProfileImage;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.PictureBox pictureBoxProfileImage;
        private System.Windows.Forms.Button buttonSelectImage;
    }
}