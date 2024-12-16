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
            label1 = new Label();
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
            labelINSERT = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(210, 32);
            label1.TabIndex = 0;
            label1.Text = "Financial Planner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 67);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Total Income:";
            // 
            // txtboxTotalIncome
            // 
            txtboxTotalIncome.Location = new Point(104, 59);
            txtboxTotalIncome.Name = "txtboxTotalIncome";
            txtboxTotalIncome.Size = new Size(170, 23);
            txtboxTotalIncome.TabIndex = 2;
            // 
            // txtboxTotalExpenses
            // 
            txtboxTotalExpenses.Location = new Point(104, 88);
            txtboxTotalExpenses.Name = "txtboxTotalExpenses";
            txtboxTotalExpenses.Size = new Size(170, 23);
            txtboxTotalExpenses.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 96);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 3;
            label3.Text = "Total Expenses:";
            // 
            // txtboxSavingsGoal
            // 
            txtboxSavingsGoal.Location = new Point(104, 117);
            txtboxSavingsGoal.Name = "txtboxSavingsGoal";
            txtboxSavingsGoal.Size = new Size(170, 23);
            txtboxSavingsGoal.TabIndex = 6;
            txtboxSavingsGoal.TextChanged += textBox3_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 125);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 5;
            label4.Text = "Savings Goal:";
            // 
            // txtboxTimeFrame
            // 
            txtboxTimeFrame.Location = new Point(204, 146);
            txtboxTimeFrame.Name = "txtboxTimeFrame";
            txtboxTimeFrame.Size = new Size(70, 23);
            txtboxTimeFrame.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(25, 154);
            label5.Name = "label5";
            label5.Size = new Size(73, 15);
            label5.TabIndex = 7;
            label5.Text = "Time Frame:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(296, 58);
            label6.Name = "label6";
            label6.Size = new Size(77, 20);
            label6.TabIndex = 9;
            label6.Text = "SAVINGS:";
            // 
            // lblSavings
            // 
            lblSavings.AutoSize = true;
            lblSavings.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSavings.Location = new Point(468, 59);
            lblSavings.Name = "lblSavings";
            lblSavings.Size = new Size(26, 20);
            lblSavings.TabIndex = 10;
            lblSavings.Text = "₱0";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(296, 78);
            label8.Name = "label8";
            label8.Size = new Size(166, 20);
            label8.TabIndex = 11;
            label8.Text = "SAVINGS PER PERIOD:";
            // 
            // lblSavingsPerPeriod
            // 
            lblSavingsPerPeriod.AutoSize = true;
            lblSavingsPerPeriod.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSavingsPerPeriod.Location = new Point(468, 78);
            lblSavingsPerPeriod.Name = "lblSavingsPerPeriod";
            lblSavingsPerPeriod.Size = new Size(26, 20);
            lblSavingsPerPeriod.TabIndex = 12;
            lblSavingsPerPeriod.Text = "₱0";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(296, 98);
            label10.Name = "label10";
            label10.Size = new Size(171, 20);
            label10.TabIndex = 14;
            label10.Text = "BUDGET ALLOCATION:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEmergencyFund);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtElectricWaterBill);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtFoodAllocation);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(12, 184);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(552, 55);
            groupBox1.TabIndex = 15;
            groupBox1.TabStop = false;
            groupBox1.Text = "Budget Allocations in %:";
            // 
            // txtEmergencyFund
            // 
            txtEmergencyFund.Location = new Point(481, 22);
            txtEmergencyFund.Name = "txtEmergencyFund";
            txtEmergencyFund.Size = new Size(48, 23);
            txtEmergencyFund.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(376, 25);
            label13.Name = "label13";
            label13.Size = new Size(99, 15);
            label13.TabIndex = 21;
            label13.Text = "Emergency Fund:";
            // 
            // txtElectricWaterBill
            // 
            txtElectricWaterBill.Location = new Point(279, 22);
            txtElectricWaterBill.Name = "txtElectricWaterBill";
            txtElectricWaterBill.Size = new Size(48, 23);
            txtElectricWaterBill.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(170, 26);
            label12.Name = "label12";
            label12.Size = new Size(103, 15);
            label12.TabIndex = 19;
            label12.Text = "Electric/Water Bill:";
            // 
            // txtFoodAllocation
            // 
            txtFoodAllocation.Location = new Point(56, 22);
            txtFoodAllocation.Name = "txtFoodAllocation";
            txtFoodAllocation.Size = new Size(48, 23);
            txtFoodAllocation.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(13, 26);
            label11.Name = "label11";
            label11.Size = new Size(37, 15);
            label11.TabIndex = 17;
            label11.Text = "Food:";
            // 
            // cbTimeOption
            // 
            cbTimeOption.FormattingEnabled = true;
            cbTimeOption.Location = new Point(104, 146);
            cbTimeOption.Name = "cbTimeOption";
            cbTimeOption.Size = new Size(94, 23);
            cbTimeOption.TabIndex = 16;
            // 
            // buttonRun
            // 
            buttonRun.Location = new Point(357, 245);
            buttonRun.Name = "buttonRun";
            buttonRun.Size = new Size(75, 23);
            buttonRun.TabIndex = 17;
            buttonRun.Text = "Run";
            buttonRun.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(296, 120);
            label7.Name = "label7";
            label7.Size = new Size(37, 15);
            label7.TabIndex = 22;
            label7.Text = "Food:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(296, 137);
            label9.Name = "label9";
            label9.Size = new Size(103, 15);
            label9.TabIndex = 22;
            label9.Text = "Electric/Water Bill:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(296, 154);
            label14.Name = "label14";
            label14.Size = new Size(99, 15);
            label14.TabIndex = 22;
            label14.Text = "Emergency Fund:";
            // 
            // lblFoodAllocation
            // 
            lblFoodAllocation.AutoSize = true;
            lblFoodAllocation.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFoodAllocation.Location = new Point(339, 117);
            lblFoodAllocation.Name = "lblFoodAllocation";
            lblFoodAllocation.Size = new Size(26, 20);
            lblFoodAllocation.TabIndex = 23;
            lblFoodAllocation.Text = "₱0";
            // 
            // lblElectricWaterAllocation
            // 
            lblElectricWaterAllocation.AutoSize = true;
            lblElectricWaterAllocation.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblElectricWaterAllocation.Location = new Point(401, 133);
            lblElectricWaterAllocation.Name = "lblElectricWaterAllocation";
            lblElectricWaterAllocation.Size = new Size(26, 20);
            lblElectricWaterAllocation.TabIndex = 24;
            lblElectricWaterAllocation.Text = "₱0";
            // 
            // lblEmergencyFundAllocation
            // 
            lblEmergencyFundAllocation.AutoSize = true;
            lblEmergencyFundAllocation.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmergencyFundAllocation.Location = new Point(401, 152);
            lblEmergencyFundAllocation.Name = "lblEmergencyFundAllocation";
            lblEmergencyFundAllocation.Size = new Size(26, 20);
            lblEmergencyFundAllocation.TabIndex = 25;
            lblEmergencyFundAllocation.Text = "₱0";
            // 
            // btnReset
            // 
            btnReset.Location = new Point(276, 245);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(75, 23);
            btnReset.TabIndex = 26;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // btnSaveToAccount
            // 
            btnSaveToAccount.Location = new Point(438, 245);
            btnSaveToAccount.Name = "btnSaveToAccount";
            btnSaveToAccount.Size = new Size(126, 23);
            btnSaveToAccount.TabIndex = 27;
            btnSaveToAccount.Text = "Save to Account";
            btnSaveToAccount.UseVisualStyleBackColor = true;
            btnSaveToAccount.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(468, 9);
            button2.Name = "button2";
            button2.Size = new Size(96, 23);
            button2.TabIndex = 28;
            button2.Text = "Open Plans";
            button2.UseVisualStyleBackColor = true;
            // 
            // labelINSERT
            // 
            labelINSERT.AutoSize = true;
            labelINSERT.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelINSERT.Location = new Point(228, 9);
            labelINSERT.Name = "labelINSERT";
            labelINSERT.Size = new Size(210, 32);
            labelINSERT.TabIndex = 29;
            labelINSERT.Text = "Financial Planner";
            // 
            // PlannerForum
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 276);
            Controls.Add(labelINSERT);
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
            Controls.Add(label1);
            Name = "PlannerForum";
            Text = "PlannerForum";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
        private Label labelINSERT;
    }
}