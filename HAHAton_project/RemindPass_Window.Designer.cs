namespace HAHAton_project
{
    partial class RemindPass_Window
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
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Label_Login = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Label_Mail = new System.Windows.Forms.Label();
            this.Button_recovery = new System.Windows.Forms.Button();
            this.Label_Or = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(212, 18);
            this.closeButton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(20, 19);
            this.closeButton.TabIndex = 8;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.CloseButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.CloseButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.CloseButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 30);
            this.label1.TabIndex = 9;
            this.label1.Text = "Восстанавление";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(17, 133);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 2;
            // 
            // Label_Login
            // 
            this.Label_Login.AutoSize = true;
            this.Label_Login.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Login.Location = new System.Drawing.Point(14, 66);
            this.Label_Login.Name = "Label_Login";
            this.Label_Login.Size = new System.Drawing.Size(40, 13);
            this.Label_Login.TabIndex = 13;
            this.Label_Login.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // Label_Mail
            // 
            this.Label_Mail.AutoSize = true;
            this.Label_Mail.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Mail.Location = new System.Drawing.Point(15, 117);
            this.Label_Mail.Name = "Label_Mail";
            this.Label_Mail.Size = new System.Drawing.Size(40, 13);
            this.Label_Mail.TabIndex = 15;
            this.Label_Mail.Text = "Почта";
            // 
            // Button_recovery
            // 
            this.Button_recovery.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_recovery.Location = new System.Drawing.Point(54, 182);
            this.Button_recovery.Name = "Button_recovery";
            this.Button_recovery.Size = new System.Drawing.Size(131, 23);
            this.Button_recovery.TabIndex = 3;
            this.Button_recovery.Text = "Восстановить";
            this.Button_recovery.UseVisualStyleBackColor = true;
            // 
            // Label_Or
            // 
            this.Label_Or.AutoSize = true;
            this.Label_Or.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_Or.Location = new System.Drawing.Point(159, 109);
            this.Label_Or.Name = "Label_Or";
            this.Label_Or.Size = new System.Drawing.Size(30, 13);
            this.Label_Or.TabIndex = 22;
            this.Label_Or.Text = "ИЛИ";
            // 
            // RemindPass_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(248, 236);
            this.Controls.Add(this.Label_Or);
            this.Controls.Add(this.Button_recovery);
            this.Controls.Add(this.Label_Mail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label_Login);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RemindPass_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Registration_Window_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Registration_Window_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label Label_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Label_Mail;
        private System.Windows.Forms.Button Button_recovery;
        private System.Windows.Forms.Label Label_Or;
    }
}