namespace Group2MiniSystem_FinancialPlanner.FinancialPlanner
{
    partial class NamePlanner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NamePlanner));
            label1 = new Label();
            txtPlanName = new TextBox();
            buttonSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLight;
            label1.Location = new Point(94, 58);
            label1.Name = "label1";
            label1.Size = new Size(77, 15);
            label1.TabIndex = 0;
            label1.Text = "Plan Name:";
            // 
            // txtPlanName
            // 
            txtPlanName.Location = new Point(96, 76);
            txtPlanName.Name = "txtPlanName";
            txtPlanName.Size = new Size(230, 23);
            txtPlanName.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonSave.Location = new Point(176, 105);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // NamePlanner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(435, 197);
            Controls.Add(buttonSave);
            Controls.Add(txtPlanName);
            Controls.Add(label1);
            Name = "NamePlanner";
            Text = "NamePlanner";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlanName;
        private Button buttonSave;
    }
}