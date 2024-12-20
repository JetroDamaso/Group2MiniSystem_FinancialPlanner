using System.ComponentModel;

namespace Group2MiniSystem_FinancialPlanner.FinancialPlanner
{
    public partial class PlanOpener : Form
    {
        LoginForm loginForm = new LoginForm();
        LoginHandler loginHandler = new LoginHandler();
        ConnectionString connectString = new ConnectionString();
        DatabaseHandler databaseHandler = new DatabaseHandler();
        private Label label1;
        private static int PlanID;



        public PlanOpener()
        {
            InitializeComponent();
            cbSelectPlan.Items.Clear();
            foreach (string items in databaseHandler.getPlanNames())
            {
                cbSelectPlan.Items.Add(items);
            }
        }

        private ComboBox cbSelectPlan;
        private Button button1;

        private void InitializeComponent()
        {
            cbSelectPlan = new ComboBox();
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // cbSelectPlan
            // 
            cbSelectPlan.FormattingEnabled = true;
            cbSelectPlan.Location = new Point(96, 76);
            cbSelectPlan.Name = "cbSelectPlan";
            cbSelectPlan.Size = new Size(230, 23);
            cbSelectPlan.TabIndex = 0;
            // 
            // button1
            // 
            button1.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(176, 105);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Open";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
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
            label1.TabIndex = 2;
            label1.Text = "Open Plan:";
            // 
            // PlanOpener
            // 
            BackgroundImage = Properties.Resources.SMALL_BOX;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(435, 197);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(cbSelectPlan);
            Name = "PlanOpener";
            Text = "Open Plan";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            PlanID = databaseHandler.getPlanID(cbSelectPlan.Text);
            this.Close();

        }

        public int getSelectedPlanID()
        {
            return PlanID;
        }
    }
}
