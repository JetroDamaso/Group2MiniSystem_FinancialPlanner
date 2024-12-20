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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
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
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Transparent;
            label5.Location = new Point(272, 178);
            label5.Name = "label5";
            label5.Size = new Size(98, 14);
            label5.TabIndex = 15;
            label5.Text = "back to login";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(200, 110);
            label4.Name = "label4";
            label4.Size = new Size(70, 14);
            label4.TabIndex = 14;
            label4.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(202, 71);
            label3.Name = "label3";
            label3.Size = new Size(70, 14);
            label3.TabIndex = 13;
            label3.Text = "Username:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(202, 123);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(232, 23);
            textBoxPassword.TabIndex = 12;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(203, 85);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(232, 23);
            textBoxUsername.TabIndex = 11;
            // 
            // buttonRegister
            // 
            buttonRegister.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRegister.Location = new Point(283, 149);
            buttonRegister.Name = "buttonRegister";
            buttonRegister.Size = new Size(74, 22);
            buttonRegister.TabIndex = 10;
            buttonRegister.Text = "Register";
            buttonRegister.UseVisualStyleBackColor = true;
            buttonRegister.Click += buttonRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(206, 32);
            label2.Name = "label2";
            label2.Size = new Size(209, 32);
            label2.TabIndex = 9;
            label2.Text = "Register Account";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(635, 263);
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