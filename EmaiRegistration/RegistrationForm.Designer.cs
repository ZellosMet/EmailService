namespace EmaiRegistration
{
    partial class RegistrationForm
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
            components = new System.ComponentModel.Container();
            b_Send_Code = new Button();
            l_Status = new Label();
            b_New_Registration = new Button();
            l_User_Name = new Label();
            l_Password = new Label();
            l_Email = new Label();
            tb_User_Name = new TextBox();
            tb_Password = new TextBox();
            tb_Email = new TextBox();
            tb_Confirmed_Code = new TextBox();
            l_Code = new Label();
            b_Register = new Button();
            b_Cancel = new Button();
            l_Success = new Label();
            b_Get_Code = new Button();
            tm_Get_Code = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // b_Send_Code
            // 
            b_Send_Code.Location = new Point(28, 172);
            b_Send_Code.Name = "b_Send_Code";
            b_Send_Code.RightToLeft = RightToLeft.No;
            b_Send_Code.Size = new Size(135, 29);
            b_Send_Code.TabIndex = 0;
            b_Send_Code.Text = "Send Code";
            b_Send_Code.UseVisualStyleBackColor = true;
            b_Send_Code.Visible = false;
            b_Send_Code.Click += Send_Code_Click;
            // 
            // l_Status
            // 
            l_Status.AutoSize = true;
            l_Status.Location = new Point(178, 181);
            l_Status.Name = "l_Status";
            l_Status.Size = new Size(0, 20);
            l_Status.TabIndex = 1;
            l_Status.Visible = false;
            // 
            // b_New_Registration
            // 
            b_New_Registration.Location = new Point(23, 12);
            b_New_Registration.Name = "b_New_Registration";
            b_New_Registration.Size = new Size(140, 29);
            b_New_Registration.TabIndex = 2;
            b_New_Registration.Text = "New Registration";
            b_New_Registration.UseVisualStyleBackColor = true;
            b_New_Registration.Click += b_New_Registration_Click;
            // 
            // l_User_Name
            // 
            l_User_Name.AutoSize = true;
            l_User_Name.Location = new Point(28, 54);
            l_User_Name.Name = "l_User_Name";
            l_User_Name.Size = new Size(82, 20);
            l_User_Name.TabIndex = 3;
            l_User_Name.Text = "User Name";
            l_User_Name.Visible = false;
            // 
            // l_Password
            // 
            l_Password.AutoSize = true;
            l_Password.Location = new Point(28, 93);
            l_Password.Name = "l_Password";
            l_Password.Size = new Size(70, 20);
            l_Password.TabIndex = 4;
            l_Password.Text = "Password";
            l_Password.Visible = false;
            // 
            // l_Email
            // 
            l_Email.AutoSize = true;
            l_Email.Location = new Point(28, 133);
            l_Email.Name = "l_Email";
            l_Email.Size = new Size(46, 20);
            l_Email.TabIndex = 5;
            l_Email.Text = "Email";
            l_Email.Visible = false;
            // 
            // tb_User_Name
            // 
            tb_User_Name.Location = new Point(124, 51);
            tb_User_Name.Name = "tb_User_Name";
            tb_User_Name.Size = new Size(224, 27);
            tb_User_Name.TabIndex = 6;
            tb_User_Name.Visible = false;
            tb_User_Name.TextChanged += tb_User_Name_TextChanged;
            // 
            // tb_Password
            // 
            tb_Password.Location = new Point(124, 90);
            tb_Password.Name = "tb_Password";
            tb_Password.Size = new Size(224, 27);
            tb_Password.TabIndex = 7;
            tb_Password.Visible = false;
            tb_Password.TextChanged += tb_Password_TextChanged;
            // 
            // tb_Email
            // 
            tb_Email.Location = new Point(124, 130);
            tb_Email.Name = "tb_Email";
            tb_Email.Size = new Size(224, 27);
            tb_Email.TabIndex = 8;
            tb_Email.Visible = false;
            tb_Email.TextChanged += tb_Email_TextChanged;
            // 
            // tb_Confirmed_Code
            // 
            tb_Confirmed_Code.Location = new Point(124, 255);
            tb_Confirmed_Code.Name = "tb_Confirmed_Code";
            tb_Confirmed_Code.Size = new Size(224, 27);
            tb_Confirmed_Code.TabIndex = 9;
            tb_Confirmed_Code.Visible = false;
            tb_Confirmed_Code.TextChanged += tb_Confirmed_Code_TextChanged;
            // 
            // l_Code
            // 
            l_Code.AutoSize = true;
            l_Code.Location = new Point(28, 258);
            l_Code.Name = "l_Code";
            l_Code.Size = new Size(44, 20);
            l_Code.TabIndex = 10;
            l_Code.Text = "Code";
            l_Code.Visible = false;
            // 
            // b_Register
            // 
            b_Register.Enabled = false;
            b_Register.Location = new Point(28, 303);
            b_Register.Name = "b_Register";
            b_Register.Size = new Size(150, 29);
            b_Register.TabIndex = 11;
            b_Register.Text = "Register";
            b_Register.UseVisualStyleBackColor = true;
            b_Register.Visible = false;
            b_Register.Click += b_Register_Click;
            // 
            // b_Cancel
            // 
            b_Cancel.Location = new Point(184, 303);
            b_Cancel.Name = "b_Cancel";
            b_Cancel.Size = new Size(164, 29);
            b_Cancel.TabIndex = 12;
            b_Cancel.Text = "Cancel";
            b_Cancel.UseVisualStyleBackColor = true;
            b_Cancel.Visible = false;
            b_Cancel.Click += b_Cancel_Click;
            // 
            // l_Success
            // 
            l_Success.AutoSize = true;
            l_Success.Location = new Point(30, 343);
            l_Success.Name = "l_Success";
            l_Success.Size = new Size(0, 20);
            l_Success.TabIndex = 13;
            // 
            // b_Get_Code
            // 
            b_Get_Code.Location = new Point(28, 210);
            b_Get_Code.Name = "b_Get_Code";
            b_Get_Code.Size = new Size(320, 29);
            b_Get_Code.TabIndex = 14;
            b_Get_Code.Text = "Get Code Automatically";
            b_Get_Code.UseVisualStyleBackColor = true;
            b_Get_Code.Visible = false;
            b_Get_Code.Click += b_Start_Get_Code_Click;
            // 
            // tm_Get_Code
            // 
            tm_Get_Code.Interval = 10000;
            tm_Get_Code.Tick += tm_Get_Code_Tick;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(388, 386);
            Controls.Add(b_Get_Code);
            Controls.Add(l_Success);
            Controls.Add(b_Cancel);
            Controls.Add(b_Register);
            Controls.Add(l_Code);
            Controls.Add(tb_Confirmed_Code);
            Controls.Add(tb_Email);
            Controls.Add(tb_Password);
            Controls.Add(tb_User_Name);
            Controls.Add(l_Email);
            Controls.Add(l_Password);
            Controls.Add(l_User_Name);
            Controls.Add(b_New_Registration);
            Controls.Add(l_Status);
            Controls.Add(b_Send_Code);
            Name = "RegistrationForm";
            Text = "RegistrationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_Send_Code;
        private Label l_Status;
        private Button b_New_Registration;
        private Label l_User_Name;
        private Label l_Password;
        private Label l_Email;
        private TextBox tb_User_Name;
        private TextBox tb_Password;
        private TextBox tb_Email;
        private TextBox tb_Confirmed_Code;
        private Label l_Code;
        private Button b_Register;
        private Button b_Cancel;
        private Label l_Success;
        private Button b_Get_Code;
        private System.Windows.Forms.Timer tm_Get_Code;
    }
}
