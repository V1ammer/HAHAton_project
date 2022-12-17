namespace HAHAton_project
{
    partial class Authentication_Window
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
            this.Label_Login = new System.Windows.Forms.Label();
            this.Label_Pass = new System.Windows.Forms.Label();
            this.loginField = new System.Windows.Forms.TextBox();
            this.passField = new System.Windows.Forms.TextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.Auth_button = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Label();
            this.Label_loginError = new System.Windows.Forms.Label();
            this.Label_passError = new System.Windows.Forms.Label();
            this.Button_helpDev = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Login.Location = new System.Drawing.Point(27, 38);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(84, 25);
            this.Label_Login.TabIndex = 0;
            this.Label_Login.Text = "Логин ¬";
            // 
            // Label_Pass
            // 
            this.Label_Pass.AutoSize = true;
            this.Label_Pass.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Pass.Location = new System.Drawing.Point(27, 95);
            this.Label_Pass.Name = "Label_Pass";
            this.Label_Pass.Size = new System.Drawing.Size(97, 25);
            this.Label_Pass.TabIndex = 1;
            this.Label_Pass.Text = "Пароль ¬";
            // 
            // loginField
            // 
            this.loginField.Location = new System.Drawing.Point(32, 67);
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(150, 20);
            this.loginField.TabIndex = 2;
            this.loginField.Enter += new System.EventHandler(this.loginField_Enter);
            this.loginField.Leave += new System.EventHandler(this.LoginField_Leave);
            // 
            // passField
            // 
            this.passField.Location = new System.Drawing.Point(32, 123);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(150, 20);
            this.passField.TabIndex = 3;
            this.passField.Enter += new System.EventHandler(this.passField_Enter);
            this.passField.Leave += new System.EventHandler(this.PassField_Leave);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(62, 220);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(91, 13);
            this.linkLabel2.TabIndex = 5;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Забыли пароль?";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemindPass_LinkClicked);
            // 
            // Auth_button
            // 
            this.Auth_button.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Auth_button.Location = new System.Drawing.Point(15, 179);
            this.Auth_button.Name = "Auth_button";
            this.Auth_button.Size = new System.Drawing.Size(184, 38);
            this.Auth_button.TabIndex = 6;
            this.Auth_button.Text = "Войти";
            this.Auth_button.UseVisualStyleBackColor = true;
            this.Auth_button.Click += new System.EventHandler(this.Auth_button_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(184, 9);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 19);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // Label_loginError
            // 
            this.Label_loginError.AutoSize = true;
            this.Label_loginError.ForeColor = System.Drawing.Color.Red;
            this.Label_loginError.Location = new System.Drawing.Point(85, 70);
            this.Label_loginError.Name = "Label_loginError";
            this.Label_loginError.Size = new System.Drawing.Size(0, 13);
            this.Label_loginError.TabIndex = 9;
            // 
            // Label_passError
            // 
            this.Label_passError.AutoSize = true;
            this.Label_passError.ForeColor = System.Drawing.Color.Red;
            this.Label_passError.Location = new System.Drawing.Point(85, 126);
            this.Label_passError.Name = "Label_passError";
            this.Label_passError.Size = new System.Drawing.Size(0, 13);
            this.Label_passError.TabIndex = 10;
            // 
            // Button_helpDev
            // 
            this.Button_helpDev.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Button_helpDev.Location = new System.Drawing.Point(174, 227);
            this.Button_helpDev.Name = "Button_helpDev";
            this.Button_helpDev.Size = new System.Drawing.Size(25, 25);
            this.Button_helpDev.TabIndex = 11;
            this.Button_helpDev.UseVisualStyleBackColor = false;
            this.Button_helpDev.Click += new System.EventHandler(this.Button_helpDev_Click);
            // 
            // Authentication_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(215, 264);
            this.Controls.Add(this.Button_helpDev);
            this.Controls.Add(this.Label_passError);
            this.Controls.Add(this.Label_loginError);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.Auth_button);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.Label_Pass);
            this.Controls.Add(this.Label_Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Authentication_Window";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Authentication_Window_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Authentication_Window_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.Label Label_Pass;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button Auth_button;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label Label_loginError;
        private System.Windows.Forms.Label Label_passError;
        private System.Windows.Forms.Button Button_helpDev;
    }
}