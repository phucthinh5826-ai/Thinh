namespace ASM
{
    partial class Form2
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
            lblTitle = new Label();
            lblCustomerName = new Label();
            lblPeople = new Label();
            lblConsumption = new Label();
            lblTotalAmount = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            lblCustomerType = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 20F);
            lblTitle.ForeColor = Color.Bisque;
            lblTitle.Location = new Point(154, 36);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(229, 54);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "WATER BILL";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.BackColor = Color.Transparent;
            lblCustomerName.Font = new Font("Segoe UI", 13F);
            lblCustomerName.ForeColor = Color.Bisque;
            lblCustomerName.Location = new Point(364, 159);
            lblCustomerName.Margin = new Padding(4, 0, 4, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(47, 36);
            lblCustomerName.TabIndex = 1;
            lblCustomerName.Text = "...1";
            // 
            // lblPeople
            // 
            lblPeople.AutoSize = true;
            lblPeople.BackColor = Color.Transparent;
            lblPeople.Font = new Font("Segoe UI", 13F);
            lblPeople.ForeColor = Color.Bisque;
            lblPeople.Location = new Point(364, 229);
            lblPeople.Margin = new Padding(4, 0, 4, 0);
            lblPeople.Name = "lblPeople";
            lblPeople.Size = new Size(47, 36);
            lblPeople.TabIndex = 2;
            lblPeople.Text = "...3";
            lblPeople.Click += lblPeople_Click;
            // 
            // lblConsumption
            // 
            lblConsumption.AutoSize = true;
            lblConsumption.BackColor = Color.Transparent;
            lblConsumption.Font = new Font("Segoe UI", 13F);
            lblConsumption.ForeColor = Color.Bisque;
            lblConsumption.Location = new Point(364, 264);
            lblConsumption.Margin = new Padding(4, 0, 4, 0);
            lblConsumption.Name = "lblConsumption";
            lblConsumption.Size = new Size(47, 36);
            lblConsumption.TabIndex = 5;
            lblConsumption.Text = "...4";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.BackColor = Color.Transparent;
            lblTotalAmount.Font = new Font("Segoe UI", 13F);
            lblTotalAmount.ForeColor = Color.Bisque;
            lblTotalAmount.Location = new Point(364, 299);
            lblTotalAmount.Margin = new Padding(4, 0, 4, 0);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(47, 36);
            lblTotalAmount.TabIndex = 7;
            lblTotalAmount.Text = "...5";
            // 
            // lblCustomerType
            // 
            lblCustomerType.AutoSize = true;
            lblCustomerType.BackColor = Color.Transparent;
            lblCustomerType.Font = new Font("Segoe UI", 13F);
            lblCustomerType.ForeColor = Color.Bisque;
            lblCustomerType.Location = new Point(364, 194);
            lblCustomerType.Margin = new Padding(4, 0, 4, 0);
            lblCustomerType.Name = "lblCustomerType";
            lblCustomerType.Size = new Size(47, 36);
            lblCustomerType.TabIndex = 18;
            lblCustomerType.Text = "...2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.Bisque;
            label1.Location = new Point(125, 159);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(132, 36);
            label1.TabIndex = 19;
            label1.Text = "Customer:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Bisque;
            label2.Location = new Point(125, 196);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(180, 32);
            label2.TabIndex = 20;
            label2.Text = "Customer Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Bisque;
            label3.Location = new Point(125, 231);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(217, 32);
            label3.TabIndex = 21;
            label3.Text = "Number of people:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Bisque;
            label4.Location = new Point(125, 266);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 32);
            label4.TabIndex = 22;
            label4.Text = "Consumption:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Bisque;
            label5.Location = new Point(125, 301);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(194, 32);
            label5.TabIndex = 23;
            label5.Text = "TOTAL AMOUNT:";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._1050201;
            ClientSize = new Size(676, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblCustomerType);
            Controls.Add(lblTotalAmount);
            Controls.Add(lblConsumption);
            Controls.Add(lblPeople);
            Controls.Add(lblCustomerName);
            Controls.Add(lblTitle);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblCustomerName;
        private Label lblPeople;
        private Label lblConsumption;
        private Label lblTotalAmount;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lblCustomerType;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}