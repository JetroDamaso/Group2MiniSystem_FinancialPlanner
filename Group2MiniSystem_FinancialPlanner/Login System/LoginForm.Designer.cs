namespace Group2MiniSystem_FinancialPlanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            label1 = new Label();
            label2 = new Label();
            buttonLogin = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Transparent;
            label1.Location = new Point(244, 201);
            label1.Name = "label1";
            label1.Size = new Size(147, 14);
            label1.TabIndex = 0;
            label1.Text = "Group 2 - MiniSystem";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(178, 34);
            label2.Name = "label2";
            label2.Size = new Size(260, 32);
            label2.TabIndex = 1;
            label2.Text = "FINANCIAL PLANNER";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.WhiteSmoke;
            buttonLogin.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonLogin.Location = new Point(282, 151);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(67, 19);
            buttonLogin.TabIndex = 2;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(204, 85);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(227, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(205, 123);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(227, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(202, 70);
            label3.Name = "label3";
            label3.Size = new Size(70, 14);
            label3.TabIndex = 5;
            label3.Text = "Username:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Transparent;
            label4.Location = new Point(202, 110);
            label4.Name = "label4";
            label4.Size = new Size(70, 14);
            label4.TabIndex = 6;
            label4.Text = "Password:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Courier New", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(266, 176);
            label5.Name = "label5";
            label5.Size = new Size(105, 14);
            label5.TabIndex = 7;
            label5.Text = "Create Account";
            label5.Click += label5_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(635, 259);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(buttonLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button buttonLogin;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
