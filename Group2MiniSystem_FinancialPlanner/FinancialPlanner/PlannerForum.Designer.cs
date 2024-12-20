namespace Group2MiniSystem_FinancialPlanner.FinancialPlanner
{
    partial class PlannerForum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlannerForum));
            label2 = new Label();
            txtboxTotalIncome = new TextBox();
            txtboxTotalExpenses = new TextBox();
            label3 = new Label();
            txtboxSavingsGoal = new TextBox();
            label4 = new Label();
            txtboxTimeFrame = new TextBox();
            label5 = new Label();
            label6 = new Label();
            lblSavings = new Label();
            label8 = new Label();
            lblSavingsPerPeriod = new Label();
            label10 = new Label();
            groupBox1 = new GroupBox();
            txtEmergencyFund = new TextBox();
            label13 = new Label();
            txtElectricWaterBill = new TextBox();
            label12 = new Label();
            txtFoodAllocation = new TextBox();
            label11 = new Label();
            cbTimeOption = new ComboBox();
            buttonRun = new Button();
            label7 = new Label();
            label9 = new Label();
            label14 = new Label();
            lblFoodAllocation = new Label();
            lblElectricWaterAllocation = new Label();
            lblEmergencyFundAllocation = new Label();
            btnReset = new Button();
            btnSaveToAccount = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlLight;
            label2.Location = new Point(99, 91);
            label2.Name = "label2";
            label2.Size = new Size(98, 16);
            label2.TabIndex = 1;
            label2.Text = "Total Income:";
            // 
            // txtboxTotalIncome
            // 
            txtboxTotalIncome.Location = new Point(211, 86);
            txtboxTotalIncome.Name = "txtboxTotalIncome";
            txtboxTotalIncome.Size = new Size(170, 23);
            txtboxTotalIncome.TabIndex = 2;
            // 
            // txtboxTotalExpenses
            // 
            txtboxTotalExpenses.Location = new Point(211, 119);
            txtboxTotalExpenses.Name = "txtboxTotalExpenses";
            txtboxTotalExpenses.Size = new Size(170, 23);
            txtboxTotalExpenses.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ControlLight;
            label3.Location = new Point(83, 124);
            label3.Name = "label3";
            label3.Size = new Size(112, 16);
            label3.TabIndex = 3;
            label3.Text = "Total Expenses:";
            // 
            // txtboxSavingsGoal
            // 
            txtboxSavingsGoal.Location = new Point(211, 153);
            txtboxSavingsGoal.Name = "txtboxSavingsGoal";
            txtboxSavingsGoal.Size = new Size(170, 23);
            txtboxSavingsGoal.TabIndex = 6;
            txtboxSavingsGoal.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ControlLight;
            label4.Location = new Point(99, 158);
            label4.Name = "label4";
            label4.Size = new Size(98, 16);
            label4.TabIndex = 5;
            label4.Text = "Savings Goal:";
            // 
            // txtboxTimeFrame
            // 
            txtboxTimeFrame.Location = new Point(312, 187);
            txtboxTimeFrame.Name = "txtboxTimeFrame";
            txtboxTimeFrame.Size = new Size(70, 23);
            txtboxTimeFrame.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlLight;
            label5.Location = new Point(114, 192);
            label5.Name = "label5";
            label5.Size = new Size(84, 16);
            label5.TabIndex = 7;
            label5.Text = "Time Frame:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ControlLight;
            label6.Location = new Point(419, 86);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 9;
            label6.Text = "SAVINGS:";
            // 
            // lblSavings
            // 
            lblSavings.AutoSize = true;
            lblSavings.BackColor = Color.Transparent;
            lblSavings.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSavings.ForeColor = SystemColors.ControlLight;
            lblSavings.Location = new Point(609, 112);
            lblSavings.Name = "lblSavings";
            lblSavings.Size = new Size(25, 19);
            lblSavings.TabIndex = 10;
            lblSavings.Text = "₱0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = SystemColors.ControlLight;
            label8.Location = new Point(420, 110);
            label8.Name = "label8";
            label8.Size = new Size(166, 20);
            label8.TabIndex = 11;
            label8.Text = "SAVINGS PER PERIOD:";
            // 
            // lblSavingsPerPeriod
            // 
            lblSavingsPerPeriod.AutoSize = true;
            lblSavingsPerPeriod.BackColor = Color.Transparent;
            lblSavingsPerPeriod.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSavingsPerPeriod.ForeColor = SystemColors.ControlLight;
            lblSavingsPerPeriod.Location = new Point(609, 88);
            lblSavingsPerPeriod.Name = "lblSavingsPerPeriod";
            lblSavingsPerPeriod.Size = new Size(25, 19);
            lblSavingsPerPeriod.TabIndex = 12;
            lblSavingsPerPeriod.Text = "₱0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = SystemColors.ControlLight;
            label10.Location = new Point(419, 134);
            label10.Name = "label10";
            label10.Size = new Size(171, 20);
            label10.TabIndex = 14;
            label10.Text = "BUDGET ALLOCATION:";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(txtEmergencyFund);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtElectricWaterBill);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtFoodAllocation);
            groupBox1.Controls.Add(label11);
            groupBox1.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = SystemColors.ControlLight;
            groupBox1.Location = new Point(83, 224);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 55);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Budget Allocations in %:";
            // 
            // txtEmergencyFund
            // 
            txtEmergencyFund.Location = new Point(494, 20);
            txtEmergencyFund.Name = "txtEmergencyFund";
            txtEmergencyFund.Size = new Size(48, 21);
            txtEmergencyFund.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = SystemColors.ControlLight;
            label13.Location = new Point(367, 23);
            label13.Name = "label13";
            label13.Size = new Size(112, 16);
            label13.TabIndex = 21;
            label13.Text = "Emergency Fund:";
            // 
            // txtElectricWaterBill
            // 
            txtElectricWaterBill.Location = new Point(292, 22);
            txtElectricWaterBill.Name = "txtElectricWaterBill";
            txtElectricWaterBill.Size = new Size(48, 21);
            txtElectricWaterBill.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = SystemColors.ControlLightLight;
            label12.Location = new Point(125, 25);
            label12.Name = "label12";
            label12.Size = new Size(147, 16);
            label12.TabIndex = 19;
            label12.Text = "Electric/Water Bill:";
            // 
            // txtFoodAllocation
            // 
            txtFoodAllocation.Location = new Point(57, 22);
            txtFoodAllocation.Name = "txtFoodAllocation";
            txtFoodAllocation.Size = new Size(48, 21);
            txtFoodAllocation.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = SystemColors.ControlLightLight;
            label11.Location = new Point(8, 25);
            label11.Name = "label11";
            label11.Size = new Size(42, 16);
            label11.TabIndex = 17;
            label11.Text = "Food:";
            // 
            // cbTimeOption
            // 
            cbTimeOption.FormattingEnabled = true;
            cbTimeOption.Location = new Point(210, 186);
            cbTimeOption.Name = "cbTimeOption";
            cbTimeOption.Size = new Size(97, 23);
            cbTimeOption.TabIndex = 16;
            // 
            // buttonRun
            // 
            buttonRun.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonRun.Location = new Point(424, 302);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(75, 20);
            buttonRun.TabIndex = 17;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            buttonRun.Click += buttonRun_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = SystemColors.ControlLight;
            label7.Location = new Point(422, 160);
            label7.Name = "label7";
            label7.Size = new Size(42, 16);
            label7.TabIndex = 22;
            label7.Text = "Food:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = SystemColors.ControlLight;
            label9.Location = new Point(422, 178);
            label9.Name = "label9";
            label9.Size = new Size(147, 16);
            label9.TabIndex = 22;
            label9.Text = "Electric/Water Bill:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.BackColor = Color.Transparent;
            label14.Font = new Font("Courier New", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.ForeColor = Color.Transparent;
            label14.Location = new Point(422, 196);
            label14.Name = "label14";
            label14.Size = new Size(112, 16);
            label14.TabIndex = 22;
            label14.Text = "Emergency Fund:";
            // 
            // lblFoodAllocation
            // 
            lblFoodAllocation.AutoSize = true;
            lblFoodAllocation.BackColor = Color.Transparent;
            lblFoodAllocation.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFoodAllocation.ForeColor = SystemColors.ControlLight;
            lblFoodAllocation.Location = new Point(609, 159);
            lblFoodAllocation.Name = "lblFoodAllocation";
            lblFoodAllocation.Size = new Size(23, 16);
            lblFoodAllocation.TabIndex = 23;
            lblFoodAllocation.Text = "₱0";
            // 
            // lblElectricWaterAllocation
            // 
            lblElectricWaterAllocation.AutoSize = true;
            lblElectricWaterAllocation.BackColor = Color.Transparent;
            lblElectricWaterAllocation.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblElectricWaterAllocation.ForeColor = SystemColors.ControlLight;
            lblElectricWaterAllocation.Location = new Point(609, 176);
            lblElectricWaterAllocation.Name = "lblElectricWaterAllocation";
            lblElectricWaterAllocation.Size = new Size(23, 16);
            lblElectricWaterAllocation.TabIndex = 24;
            lblElectricWaterAllocation.Text = "₱0";
            // 
            // lblEmergencyFundAllocation
            // 
            lblEmergencyFundAllocation.AutoSize = true;
            lblEmergencyFundAllocation.BackColor = Color.Transparent;
            lblEmergencyFundAllocation.Font = new Font("Courier New", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmergencyFundAllocation.ForeColor = SystemColors.ControlLight;
            lblEmergencyFundAllocation.Location = new Point(609, 194);
            lblEmergencyFundAllocation.Name = "lblEmergencyFundAllocation";
            lblEmergencyFundAllocation.Size = new Size(23, 16);
            lblEmergencyFundAllocation.TabIndex = 25;
            lblEmergencyFundAllocation.Text = "₱0";
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnReset.Location = new Point(334, 302);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 20);
            btnReset.TabIndex = 26;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSaveToAccount
            // 
            btnSaveToAccount.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSaveToAccount.Location = new Point(513, 302);
            btnSaveToAccount.Name = "btnSaveToAccount";
            btnSaveToAccount.Size = new Size(126, 20);
            btnSaveToAccount.TabIndex = 27;
            btnSaveToAccount.Text = "Save to Account";
            btnSaveToAccount.UseVisualStyleBackColor = true;
            btnSaveToAccount.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Courier New", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(87, 302);
            button2.Name = "button2";
            button2.Size = new Size(87, 20);
            button2.TabIndex = 28;
            button2.Text = "Open Plans";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(159, 27);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 34);
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // PlannerForum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(723, 369);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(btnSaveToAccount);
            Controls.Add(btnReset);
            Controls.Add(lblEmergencyFundAllocation);
            Controls.Add(lblElectricWaterAllocation);
            Controls.Add(lblFoodAllocation);
            Controls.Add(label14);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(buttonRun);
            Controls.Add(cbTimeOption);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(lblSavingsPerPeriod);
            Controls.Add(label8);
            Controls.Add(lblSavings);
            Controls.Add(label6);
            Controls.Add(txtboxTimeFrame);
            Controls.Add(label5);
            Controls.Add(txtboxSavingsGoal);
            Controls.Add(label4);
            Controls.Add(txtboxTotalExpenses);
            Controls.Add(label3);
            Controls.Add(txtboxTotalIncome);
            Controls.Add(label2);
            Name = "PlannerForum";
            Text = "PlannerForum";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private TextBox txtboxTotalIncome;
        private TextBox txtboxTotalExpenses;
        private Label label3;
        private TextBox txtboxSavingsGoal;
        private Label label4;
        private TextBox txtboxTimeFrame;
        private Label label5;
        private Label label6;
        private Label lblSavings;
        private Label label8;
        private Label lblSavingsPerPeriod;
        private Label label10;
        private GroupBox groupBox1;
        private ComboBox cbTimeOption;
        private TextBox txtEmergencyFund;
        private Label label13;
        private TextBox txtElectricWaterBill;
        private Label label12;
        private TextBox txtFoodAllocation;
        private Label label11;
        private Button buttonRun;
        private Label label7;
        private Label label9;
        private Label label14;
        private Label lblFoodAllocation;
        private Label lblElectricWaterAllocation;
        private Label lblEmergencyFundAllocation;
        private Button btnReset;
        private Button btnSaveToAccount;
        private Button button2;
        private PictureBox pictureBox1;
    }
}