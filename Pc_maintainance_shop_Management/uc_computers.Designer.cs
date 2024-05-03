namespace Pc_maintainance_shop_Management
{
    partial class uc_computers
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
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.txt_computerbrand = new System.Windows.Forms.TextBox();
            this.txt_computercolor = new System.Windows.Forms.TextBox();
            this.txt_ownersname = new System.Windows.Forms.TextBox();
            this.txt_computermodel = new System.Windows.Forms.TextBox();
            this.txt_computerno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_computersDataGridView = new System.Windows.Forms.DataGridView();
            this.db_computersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_computers = new Pc_maintainance_shop_Management.ds_computers();
            this.db_computersTableAdapter = new Pc_maintainance_shop_Management.ds_computersTableAdapters.db_computersTableAdapter();
            this.tableAdapterManager = new Pc_maintainance_shop_Management.ds_computersTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_computersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_computersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_computers)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_date.Location = new System.Drawing.Point(624, 157);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(223, 30);
            this.dtp_date.TabIndex = 36;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_update.Location = new System.Drawing.Point(361, 284);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 50);
            this.btn_update.TabIndex = 33;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_delete.Location = new System.Drawing.Point(500, 284);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 50);
            this.btn_delete.TabIndex = 34;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_insert.Location = new System.Drawing.Point(221, 284);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(115, 50);
            this.btn_insert.TabIndex = 35;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_computerbrand
            // 
            this.txt_computerbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_computerbrand.Location = new System.Drawing.Point(201, 150);
            this.txt_computerbrand.Name = "txt_computerbrand";
            this.txt_computerbrand.Size = new System.Drawing.Size(223, 27);
            this.txt_computerbrand.TabIndex = 28;
            // 
            // txt_computercolor
            // 
            this.txt_computercolor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_computercolor.Location = new System.Drawing.Point(624, 90);
            this.txt_computercolor.Name = "txt_computercolor";
            this.txt_computercolor.Size = new System.Drawing.Size(223, 27);
            this.txt_computercolor.TabIndex = 29;
            // 
            // txt_ownersname
            // 
            this.txt_ownersname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ownersname.Location = new System.Drawing.Point(624, 225);
            this.txt_ownersname.Name = "txt_ownersname";
            this.txt_ownersname.Size = new System.Drawing.Size(223, 27);
            this.txt_ownersname.TabIndex = 30;
            // 
            // txt_computermodel
            // 
            this.txt_computermodel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_computermodel.Location = new System.Drawing.Point(201, 218);
            this.txt_computermodel.Name = "txt_computermodel";
            this.txt_computermodel.Size = new System.Drawing.Size(223, 27);
            this.txt_computermodel.TabIndex = 31;
            // 
            // txt_computerno
            // 
            this.txt_computerno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_computerno.Location = new System.Drawing.Point(201, 87);
            this.txt_computerno.Name = "txt_computerno";
            this.txt_computerno.Size = new System.Drawing.Size(223, 27);
            this.txt_computerno.TabIndex = 32;
            this.txt_computerno.TextChanged += new System.EventHandler(this.txt_computerno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(451, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Computer Color :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label6.Location = new System.Drawing.Point(451, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Owner\'s Name :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(451, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = "Date :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(19, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Computer Model :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(19, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Computer Brand :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(281, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(254, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Computers Information";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_name.Location = new System.Drawing.Point(19, 87);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(143, 20);
            this.lbl_name.TabIndex = 27;
            this.lbl_name.Text = "Computer No :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.db_computersDataGridView);
            this.panel1.Location = new System.Drawing.Point(53, 361);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 306);
            this.panel1.TabIndex = 37;
            // 
            // db_computersDataGridView
            // 
            this.db_computersDataGridView.AutoGenerateColumns = false;
            this.db_computersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_computersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.db_computersDataGridView.DataSource = this.db_computersBindingSource;
            this.db_computersDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_computersDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_computersDataGridView.Name = "db_computersDataGridView";
            this.db_computersDataGridView.RowHeadersWidth = 51;
            this.db_computersDataGridView.RowTemplate.Height = 24;
            this.db_computersDataGridView.Size = new System.Drawing.Size(794, 306);
            this.db_computersDataGridView.TabIndex = 0;
            // 
            // db_computersBindingSource
            // 
            this.db_computersBindingSource.DataMember = "db_computers";
            this.db_computersBindingSource.DataSource = this.ds_computers;
            // 
            // ds_computers
            // 
            this.ds_computers.DataSetName = "ds_computers";
            this.ds_computers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_computersTableAdapter
            // 
            this.db_computersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_computersTableAdapter = this.db_computersTableAdapter;
            this.tableAdapterManager.UpdateOrder = Pc_maintainance_shop_Management.ds_computersTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ownersname";
            this.dataGridViewTextBoxColumn6.HeaderText = "Owner\'s Name";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "computercolor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Computer Color";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "computermodel";
            this.dataGridViewTextBoxColumn3.HeaderText = "Computer Model";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "computerbrand";
            this.dataGridViewTextBoxColumn2.HeaderText = "Computer Brand";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "computerno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Computer No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // uc_computers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_computerbrand);
            this.Controls.Add(this.txt_computercolor);
            this.Controls.Add(this.txt_ownersname);
            this.Controls.Add(this.txt_computermodel);
            this.Controls.Add(this.txt_computerno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_name);
            this.Name = "uc_computers";
            this.Size = new System.Drawing.Size(906, 687);
            this.Load += new System.EventHandler(this.uc_computers_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_computersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_computersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_computers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_computerbrand;
        private System.Windows.Forms.TextBox txt_computercolor;
        private System.Windows.Forms.TextBox txt_ownersname;
        private System.Windows.Forms.TextBox txt_computermodel;
        private System.Windows.Forms.TextBox txt_computerno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel1;
        private ds_computers ds_computers;
        private System.Windows.Forms.BindingSource db_computersBindingSource;
        private ds_computersTableAdapters.db_computersTableAdapter db_computersTableAdapter;
        private ds_computersTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView db_computersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
