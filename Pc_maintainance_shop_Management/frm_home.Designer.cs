namespace Pc_maintainance_shop_Management
{
    partial class frm_home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_billing = new System.Windows.Forms.Button();
            this.btn_analytics = new System.Windows.Forms.Button();
            this.btn_employees = new System.Windows.Forms.Button();
            this.btn_stocks = new System.Windows.Forms.Button();
            this.btn_computers = new System.Windows.Forms.Button();
            this.Main_Panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.uc_analytics1 = new Pc_maintainance_shop_Management.uc_analytics();
            this.uc_billing1 = new Pc_maintainance_shop_Management.uc_billing();
            this.uc_employees1 = new Pc_maintainance_shop_Management.uc_employees();
            this.uc_stocks1 = new Pc_maintainance_shop_Management.uc_stocks();
            this.uc_computers1 = new Pc_maintainance_shop_Management.uc_computers();
            this.panel1.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btn_billing);
            this.panel1.Controls.Add(this.btn_analytics);
            this.panel1.Controls.Add(this.btn_employees);
            this.panel1.Controls.Add(this.btn_stocks);
            this.panel1.Controls.Add(this.btn_computers);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 648);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shop Management";
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SidePanel.Location = new System.Drawing.Point(3, 78);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(25, 76);
            this.SidePanel.TabIndex = 3;
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_exit.Location = new System.Drawing.Point(26, 450);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(274, 78);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_billing
            // 
            this.btn_billing.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_billing.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_billing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_billing.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_billing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_billing.Location = new System.Drawing.Point(26, 301);
            this.btn_billing.Name = "btn_billing";
            this.btn_billing.Size = new System.Drawing.Size(274, 78);
            this.btn_billing.TabIndex = 5;
            this.btn_billing.Text = "Billing";
            this.btn_billing.UseVisualStyleBackColor = false;
            this.btn_billing.Click += new System.EventHandler(this.btn_billing_Click);
            // 
            // btn_analytics
            // 
            this.btn_analytics.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_analytics.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_analytics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_analytics.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_analytics.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_analytics.Location = new System.Drawing.Point(25, 375);
            this.btn_analytics.Name = "btn_analytics";
            this.btn_analytics.Size = new System.Drawing.Size(274, 78);
            this.btn_analytics.TabIndex = 6;
            this.btn_analytics.Text = "Analytics";
            this.btn_analytics.UseVisualStyleBackColor = false;
            this.btn_analytics.Click += new System.EventHandler(this.btn_analytics_Click);
            // 
            // btn_employees
            // 
            this.btn_employees.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_employees.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_employees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employees.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employees.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_employees.Location = new System.Drawing.Point(26, 226);
            this.btn_employees.Name = "btn_employees";
            this.btn_employees.Size = new System.Drawing.Size(274, 78);
            this.btn_employees.TabIndex = 7;
            this.btn_employees.Text = "Employees";
            this.btn_employees.UseVisualStyleBackColor = false;
            this.btn_employees.Click += new System.EventHandler(this.btn_employees_Click);
            // 
            // btn_stocks
            // 
            this.btn_stocks.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_stocks.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_stocks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stocks.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stocks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_stocks.Location = new System.Drawing.Point(26, 151);
            this.btn_stocks.Name = "btn_stocks";
            this.btn_stocks.Size = new System.Drawing.Size(274, 78);
            this.btn_stocks.TabIndex = 8;
            this.btn_stocks.Text = "Stocks";
            this.btn_stocks.UseVisualStyleBackColor = false;
            this.btn_stocks.Click += new System.EventHandler(this.btn_stocks_Click);
            // 
            // btn_computers
            // 
            this.btn_computers.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_computers.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_computers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_computers.Font = new System.Drawing.Font("Myanmar Text", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_computers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_computers.Location = new System.Drawing.Point(26, 76);
            this.btn_computers.Name = "btn_computers";
            this.btn_computers.Size = new System.Drawing.Size(274, 78);
            this.btn_computers.TabIndex = 9;
            this.btn_computers.Text = "Computers";
            this.btn_computers.UseVisualStyleBackColor = false;
            this.btn_computers.Click += new System.EventHandler(this.btn_computers_Click);
            // 
            // Main_Panel
            // 
            this.Main_Panel.Controls.Add(this.uc_analytics1);
            this.Main_Panel.Controls.Add(this.uc_billing1);
            this.Main_Panel.Controls.Add(this.uc_employees1);
            this.Main_Panel.Controls.Add(this.uc_stocks1);
            this.Main_Panel.Controls.Add(this.uc_computers1);
            this.Main_Panel.Location = new System.Drawing.Point(306, 12);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Size = new System.Drawing.Size(904, 638);
            this.Main_Panel.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel3.Location = new System.Drawing.Point(295, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(886, 10);
            this.panel3.TabIndex = 2;
            // 
            // uc_analytics1
            // 
            this.uc_analytics1.Location = new System.Drawing.Point(-5, -12);
            this.uc_analytics1.Name = "uc_analytics1";
            this.uc_analytics1.Size = new System.Drawing.Size(906, 638);
            this.uc_analytics1.TabIndex = 7;
            // 
            // uc_billing1
            // 
            this.uc_billing1.Location = new System.Drawing.Point(-11, -12);
            this.uc_billing1.Name = "uc_billing1";
            this.uc_billing1.Size = new System.Drawing.Size(906, 638);
            this.uc_billing1.TabIndex = 6;
            // 
            // uc_employees1
            // 
            this.uc_employees1.Location = new System.Drawing.Point(-8, -14);
            this.uc_employees1.Name = "uc_employees1";
            this.uc_employees1.Size = new System.Drawing.Size(906, 638);
            this.uc_employees1.TabIndex = 5;
            // 
            // uc_stocks1
            // 
            this.uc_stocks1.Location = new System.Drawing.Point(-5, -12);
            this.uc_stocks1.Name = "uc_stocks1";
            this.uc_stocks1.Size = new System.Drawing.Size(906, 638);
            this.uc_stocks1.TabIndex = 4;
            // 
            // uc_computers1
            // 
            this.uc_computers1.Location = new System.Drawing.Point(-8, -14);
            this.uc_computers1.Name = "uc_computers1";
            this.uc_computers1.Size = new System.Drawing.Size(906, 638);
            this.uc_computers1.TabIndex = 3;
            // 
            // frm_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1204, 648);
            this.Controls.Add(this.Main_Panel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_home";
            this.Text = "frm_home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Main_Panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_billing;
        private System.Windows.Forms.Button btn_analytics;
        private System.Windows.Forms.Button btn_employees;
        private System.Windows.Forms.Button btn_stocks;
        private System.Windows.Forms.Button btn_computers;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Main_Panel;
        private System.Windows.Forms.Panel panel3;
        private uc_computers uc_computers1;
        private uc_stocks uc_stocks1;
        private uc_employees uc_employees1;
        private uc_billing uc_billing1;
        private uc_analytics uc_analytics1;
    }
}