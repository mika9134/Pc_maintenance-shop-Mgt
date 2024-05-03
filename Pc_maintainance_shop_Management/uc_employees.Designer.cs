namespace Pc_maintainance_shop_Management
{
    partial class uc_employees
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.cmb_egender = new System.Windows.Forms.ComboBox();
            this.txt_eadress = new System.Windows.Forms.TextBox();
            this.txt_erole = new System.Windows.Forms.TextBox();
            this.txt_ename = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_employeeDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_employee = new Pc_maintainance_shop_Management.ds_employee();
            this.db_employeeTableAdapter = new Pc_maintainance_shop_Management.ds_employeeTableAdapters.db_employeeTableAdapter();
            this.tableAdapterManager = new Pc_maintainance_shop_Management.ds_employeeTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_employeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_employee)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_update.Location = new System.Drawing.Point(364, 233);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 50);
            this.btn_update.TabIndex = 16;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_delete.Location = new System.Drawing.Point(514, 233);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 50);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_insert.Location = new System.Drawing.Point(217, 233);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(115, 50);
            this.btn_insert.TabIndex = 18;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // cmb_egender
            // 
            this.cmb_egender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_egender.FormattingEnabled = true;
            this.cmb_egender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmb_egender.Location = new System.Drawing.Point(161, 173);
            this.cmb_egender.Name = "cmb_egender";
            this.cmb_egender.Size = new System.Drawing.Size(223, 28);
            this.cmb_egender.TabIndex = 15;
            // 
            // txt_eadress
            // 
            this.txt_eadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_eadress.Location = new System.Drawing.Point(630, 169);
            this.txt_eadress.Name = "txt_eadress";
            this.txt_eadress.Size = new System.Drawing.Size(223, 27);
            this.txt_eadress.TabIndex = 12;
            // 
            // txt_erole
            // 
            this.txt_erole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_erole.Location = new System.Drawing.Point(630, 98);
            this.txt_erole.Name = "txt_erole";
            this.txt_erole.Size = new System.Drawing.Size(223, 27);
            this.txt_erole.TabIndex = 13;
            // 
            // txt_ename
            // 
            this.txt_ename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ename.Location = new System.Drawing.Point(161, 103);
            this.txt_ename.Name = "txt_ename";
            this.txt_ename.Size = new System.Drawing.Size(223, 27);
            this.txt_ename.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(510, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Adress :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(510, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Role :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(50, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(322, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Manage Employee";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_name.Location = new System.Drawing.Point(50, 103);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(73, 20);
            this.lbl_name.TabIndex = 11;
            this.lbl_name.Text = "Name :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.db_employeeDataGridView);
            this.panel1.Location = new System.Drawing.Point(111, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 289);
            this.panel1.TabIndex = 19;
            // 
            // db_employeeDataGridView
            // 
            this.db_employeeDataGridView.AutoGenerateColumns = false;
            this.db_employeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_employeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.db_employeeDataGridView.DataSource = this.db_employeeBindingSource;
            this.db_employeeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_employeeDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_employeeDataGridView.Name = "db_employeeDataGridView";
            this.db_employeeDataGridView.RowHeadersWidth = 51;
            this.db_employeeDataGridView.RowTemplate.Height = 24;
            this.db_employeeDataGridView.Size = new System.Drawing.Size(680, 289);
            this.db_employeeDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ename";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "egender";
            this.dataGridViewTextBoxColumn2.HeaderText = "Gender";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "eroll";
            this.dataGridViewTextBoxColumn3.HeaderText = "Role";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "eadress";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // db_employeeBindingSource
            // 
            this.db_employeeBindingSource.DataMember = "db_employee";
            this.db_employeeBindingSource.DataSource = this.ds_employee;
            // 
            // ds_employee
            // 
            this.ds_employee.DataSetName = "ds_employee";
            this.ds_employee.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_employeeTableAdapter
            // 
            this.db_employeeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_employeeTableAdapter = this.db_employeeTableAdapter;
            this.tableAdapterManager.UpdateOrder = Pc_maintainance_shop_Management.ds_employeeTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uc_employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.cmb_egender);
            this.Controls.Add(this.txt_eadress);
            this.Controls.Add(this.txt_erole);
            this.Controls.Add(this.txt_ename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_name);
            this.Name = "uc_employees";
            this.Size = new System.Drawing.Size(906, 638);
            this.Load += new System.EventHandler(this.uc_employees_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_employeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_employee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.ComboBox cmb_egender;
        private System.Windows.Forms.TextBox txt_eadress;
        private System.Windows.Forms.TextBox txt_erole;
        private System.Windows.Forms.TextBox txt_ename;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel1;
        private ds_employee ds_employee;
        private System.Windows.Forms.BindingSource db_employeeBindingSource;
        private ds_employeeTableAdapters.db_employeeTableAdapter db_employeeTableAdapter;
        private ds_employeeTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView db_employeeDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
