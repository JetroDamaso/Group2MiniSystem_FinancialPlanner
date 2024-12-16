namespace Group2MiniSystem_FinancialPlanner
{
    partial class RegisterForm
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
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            buttonRegister = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(115, 119);
            label5.Name = "label5";
            label5.Size = new Size(76, 15);
            label5.TabIndex = 15;
            label5.Text = "back to login";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 89);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 60);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 13;
            label3.Text = "Username:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(81, 86);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(191, 23);
            textBoxPassword.TabIndex = 12;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(81, 57);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(191, 23);
            textBoxUsername.TabIndex = 11;
            // 
            // buttonRegister
            // 
            buttonRegister.Location = new Point(197, 115);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(75, 23);
            buttonRegister.TabIndex = 10;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(209, 32);
            label2.TabIndex = 9;
            label2.Text = "Register Account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(280, 148);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonRegister);
            Controls.Add(label2);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Button buttonRegister;
        private Label label2;
    }
}