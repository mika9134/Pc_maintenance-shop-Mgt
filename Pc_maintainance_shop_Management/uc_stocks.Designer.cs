namespace Pc_maintainance_shop_Management
{
    partial class uc_stocks
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
            this.txt_partname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_partprice = new System.Windows.Forms.TextBox();
            this.txt_serialnumber = new System.Windows.Forms.TextBox();
            this.txt_partquantity = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_stockDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_stockBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_stock = new Pc_maintainance_shop_Management.ds_stock();
            this.db_stockTableAdapter = new Pc_maintainance_shop_Management.ds_stockTableAdapters.db_stockTableAdapter();
            this.tableAdapterManager = new Pc_maintainance_shop_Management.ds_stockTableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_stock)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_update.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_update.Location = new System.Drawing.Point(404, 209);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(115, 50);
            this.btn_update.TabIndex = 26;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_delete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_delete.Location = new System.Drawing.Point(554, 209);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(115, 50);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_insert
            // 
            this.btn_insert.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_insert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_insert.Location = new System.Drawing.Point(257, 209);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(115, 50);
            this.btn_insert.TabIndex = 28;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = false;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // txt_partname
            // 
            this.txt_partname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partname.Location = new System.Drawing.Point(200, 100);
            this.txt_partname.Name = "txt_partname";
            this.txt_partname.Size = new System.Drawing.Size(223, 27);
            this.txt_partname.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(400, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 23);
            this.label3.TabIndex = 23;
            this.label3.Text = "Stocks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(39, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Part Name:";
            // 
            // txt_partprice
            // 
            this.txt_partprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partprice.Location = new System.Drawing.Point(638, 102);
            this.txt_partprice.Name = "txt_partprice";
            this.txt_partprice.Size = new System.Drawing.Size(223, 27);
            this.txt_partprice.TabIndex = 20;
            // 
            // txt_serialnumber
            // 
            this.txt_serialnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_serialnumber.Location = new System.Drawing.Point(638, 154);
            this.txt_serialnumber.Name = "txt_serialnumber";
            this.txt_serialnumber.Size = new System.Drawing.Size(223, 27);
            this.txt_serialnumber.TabIndex = 21;
            // 
            // txt_partquantity
            // 
            this.txt_partquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partquantity.Location = new System.Drawing.Point(200, 159);
            this.txt_partquantity.Name = "txt_partquantity";
            this.txt_partquantity.Size = new System.Drawing.Size(223, 27);
            this.txt_partquantity.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(477, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Part Price :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(477, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Serial Number :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_name.Location = new System.Drawing.Point(39, 161);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(148, 20);
            this.lbl_name.TabIndex = 19;
            this.lbl_name.Text = "Part Quantity :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.db_stockDataGridView);
            this.panel1.Location = new System.Drawing.Point(164, 265);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 359);
            this.panel1.TabIndex = 29;
            // 
            // db_stockDataGridView
            // 
            this.db_stockDataGridView.AutoGenerateColumns = false;
            this.db_stockDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_stockDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.db_stockDataGridView.DataSource = this.db_stockBindingSource;
            this.db_stockDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_stockDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_stockDataGridView.Name = "db_stockDataGridView";
            this.db_stockDataGridView.RowHeadersWidth = 51;
            this.db_stockDataGridView.RowTemplate.Height = 24;
            this.db_stockDataGridView.Size = new System.Drawing.Size(622, 359);
            this.db_stockDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "partname";
            this.dataGridViewTextBoxColumn1.HeaderText = "Part Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "partquantity";
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Quantity";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "partprice";
            this.dataGridViewTextBoxColumn3.HeaderText = "Part Price";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "serialno";
            this.dataGridViewTextBoxColumn4.HeaderText = "Serial Number";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // db_stockBindingSource
            // 
            this.db_stockBindingSource.DataMember = "db_stock";
            this.db_stockBindingSource.DataSource = this.ds_stock;
            // 
            // ds_stock
            // 
            this.ds_stock.DataSetName = "ds_stock";
            this.ds_stock.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // db_stockTableAdapter
            // 
            this.db_stockTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_stockTableAdapter = this.db_stockTableAdapter;
            this.tableAdapterManager.UpdateOrder = Pc_maintainance_shop_Management.ds_stockTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // uc_stocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_partname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_partprice);
            this.Controls.Add(this.txt_serialnumber);
            this.Controls.Add(this.txt_partquantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_name);
            this.Name = "uc_stocks";
            this.Size = new System.Drawing.Size(906, 658);
            this.Load += new System.EventHandler(this.uc_stocks_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_stockDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_stockBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.TextBox txt_partname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_partprice;
        private System.Windows.Forms.TextBox txt_serialnumber;
        private System.Windows.Forms.TextBox txt_partquantity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel1;
        private ds_stock ds_stock;
        private System.Windows.Forms.BindingSource db_stockBindingSource;
        private ds_stockTableAdapters.db_stockTableAdapter db_stockTableAdapter;
        private ds_stockTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView db_stockDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
