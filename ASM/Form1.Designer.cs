namespace ASM

{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            txtCustomerName = new TextBox();
            txtNumberOfPeople = new TextBox();
            txtThisMonthWater = new TextBox();
            txtLastMonthWater = new TextBox();
            label1 = new Label();
            btnCalculate = new Button();
            cbTypeOfCustomer = new ComboBox();
            lvWaterBill = new ListView();
            txtSearch = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cboSort = new ComboBox();
            Search = new Label();
            label2 = new Label();
            label3 = new Label();
            btnReset = new Button();
            SuspendLayout();
            // 
            // txtCustomerName
            // 
            txtCustomerName.BackColor = Color.Bisque;
            txtCustomerName.Location = new Point(65, 47);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.PlaceholderText = "Enter your Customer name";
            txtCustomerName.Size = new Size(217, 27);
            txtCustomerName.TabIndex = 0;
            // 
            // txtNumberOfPeople
            // 
            txtNumberOfPeople.BackColor = Color.Bisque;
            txtNumberOfPeople.Enabled = false;
            txtNumberOfPeople.Location = new Point(68, 134);
            txtNumberOfPeople.Name = "txtNumberOfPeople";
            txtNumberOfPeople.PlaceholderText = "Enter your Number People";
            txtNumberOfPeople.Size = new Size(214, 27);
            txtNumberOfPeople.TabIndex = 2;
            // 
            // txtThisMonthWater
            // 
            txtThisMonthWater.BackColor = Color.Bisque;
            txtThisMonthWater.Location = new Point(65, 251);
            txtThisMonthWater.Name = "txtThisMonthWater";
            txtThisMonthWater.PlaceholderText = "Enter this month's water meter";
            txtThisMonthWater.Size = new Size(214, 27);
            txtThisMonthWater.TabIndex = 3;
            // 
            // txtLastMonthWater
            // 
            txtLastMonthWater.BackColor = Color.Bisque;
            txtLastMonthWater.Location = new Point(65, 180);
            txtLastMonthWater.Name = "txtLastMonthWater";
            txtLastMonthWater.PlaceholderText = "Enter last month's water meter";
            txtLastMonthWater.Size = new Size(214, 27);
            txtLastMonthWater.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(65, 228);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 5;
            label1.Text = "This month's water meter";
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Transparent;
            btnCalculate.BackgroundImage = Properties.Resources._5701371;
            btnCalculate.Location = new Point(188, 302);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(94, 29);
            btnCalculate.TabIndex = 6;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // cbTypeOfCustomer
            // 
            cbTypeOfCustomer.BackColor = Color.Bisque;
            cbTypeOfCustomer.FormattingEnabled = true;
            cbTypeOfCustomer.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            cbTypeOfCustomer.Location = new Point(68, 90);
            cbTypeOfCustomer.Name = "cbTypeOfCustomer";
            cbTypeOfCustomer.Size = new Size(214, 28);
            cbTypeOfCustomer.TabIndex = 7;
            cbTypeOfCustomer.SelectedIndexChanged += cbTypeOfCustomer_SelectedIndexChanged_1;
            // 
            // lvWaterBill
            // 
            lvWaterBill.BackgroundImage = (Image)resources.GetObject("lvWaterBill.BackgroundImage");
            lvWaterBill.Font = new Font("Segoe UI", 11F);
            lvWaterBill.ForeColor = Color.DarkSlateGray;
            lvWaterBill.Location = new Point(298, 47);
            lvWaterBill.Name = "lvWaterBill";
            lvWaterBill.Size = new Size(943, 386);
            lvWaterBill.TabIndex = 8;
            lvWaterBill.UseCompatibleStateImageBehavior = false;
            lvWaterBill.ItemActivate += lvWaterBill_ItemActivate;
            lvWaterBill.SelectedIndexChanged += lvWaterBill_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Bisque;
            txtSearch.Location = new Point(415, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(187, 27);
            txtSearch.TabIndex = 9;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // cboSort
            // 
            cboSort.BackColor = Color.Moccasin;
            cboSort.FormattingEnabled = true;
            cboSort.Items.AddRange(new object[] { "Total Bill (Small To Large)", "Total Bill (Large To Small)" });
            cboSort.Location = new Point(710, 11);
            cboSort.Name = "cboSort";
            cboSort.Size = new Size(151, 28);
            cboSort.TabIndex = 10;
            cboSort.SelectedIndexChanged += cboSort_SelectedIndexChanged;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(343, 14);
            Search.Name = "Search";
            Search.Size = new Size(0, 20);
            Search.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(349, 14);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 12;
            label2.Text = "Search :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(657, 14);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 13;
            label3.Text = "Sort : ";
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Transparent;
            btnReset.BackgroundImage = Properties.Resources._5701371;
            btnReset.Location = new Point(68, 302);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 14;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FloralWhite;
            BackgroundImage = Properties.Resources._1050201;
            ClientSize = new Size(1280, 450);
            Controls.Add(btnReset);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(Search);
            Controls.Add(cboSort);
            Controls.Add(txtSearch);
            Controls.Add(lvWaterBill);
            Controls.Add(cbTypeOfCustomer);
            Controls.Add(btnCalculate);
            Controls.Add(label1);
            Controls.Add(txtLastMonthWater);
            Controls.Add(txtThisMonthWater);
            Controls.Add(txtNumberOfPeople);
            Controls.Add(txtCustomerName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCustomerName;
        private TextBox txtNumberOfPeople;
        private TextBox txtThisMonthWater;
        private TextBox txtLastMonthWater;
        private Label label1;
        private Button btnCalculate;
        private ComboBox cbTypeOfCustomer;
        private ListView lvWaterBill;
        private TextBox txtSearch;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox cboSort;
        private Label Search;
        private Label label2;
        private Label label3;
        private Button btnReset;
    }
}
