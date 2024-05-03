namespace Pc_maintainance_shop_Management
{
    partial class uc_billing
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
            this.btn_remove = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.txt_partprice = new System.Windows.Forms.TextBox();
            this.txt_partquantity = new System.Windows.Forms.TextBox();
            this.txt_partname = new System.Windows.Forms.TextBox();
            this.txt_totalprice = new System.Windows.Forms.TextBox();
            this.txt_billno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.db_billcardDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.db_billcardBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ds_billcard = new Pc_maintainance_shop_Management.ds_billcard();
            this.btn_calculatebill = new System.Windows.Forms.Button();
            this.db_billcardTableAdapter = new Pc_maintainance_shop_Management.ds_billcardTableAdapters.db_billcardTableAdapter();
            this.tableAdapterManager = new Pc_maintainance_shop_Management.ds_billcardTableAdapters.TableAdapterManager();
            this.db_billcard1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txt_grandtotal = new System.Windows.Forms.TextBox();
            this.lbl_grandtotal = new System.Windows.Forms.Label();
            this.btn_removeall = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.db_billcardDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billcardBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_billcard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billcard1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_remove
            // 
            this.btn_remove.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_remove.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_remove.Location = new System.Drawing.Point(267, 224);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(115, 50);
            this.btn_remove.TabIndex = 30;
            this.btn_remove.Text = "Remove";
            this.btn_remove.UseVisualStyleBackColor = false;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_add.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_add.Location = new System.Drawing.Point(111, 224);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(115, 50);
            this.btn_add.TabIndex = 31;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txt_partprice
            // 
            this.txt_partprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partprice.Location = new System.Drawing.Point(611, 163);
            this.txt_partprice.Name = "txt_partprice";
            this.txt_partprice.Size = new System.Drawing.Size(223, 27);
            this.txt_partprice.TabIndex = 25;
            // 
            // txt_partquantity
            // 
            this.txt_partquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partquantity.Location = new System.Drawing.Point(616, 235);
            this.txt_partquantity.Name = "txt_partquantity";
            this.txt_partquantity.Size = new System.Drawing.Size(223, 27);
            this.txt_partquantity.TabIndex = 26;
            this.txt_partquantity.TextChanged += new System.EventHandler(this.txt_partquantity_TextChanged);
            // 
            // txt_partname
            // 
            this.txt_partname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_partname.Location = new System.Drawing.Point(611, 92);
            this.txt_partname.Name = "txt_partname";
            this.txt_partname.Size = new System.Drawing.Size(223, 27);
            this.txt_partname.TabIndex = 27;
            // 
            // txt_totalprice
            // 
            this.txt_totalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalprice.Location = new System.Drawing.Point(171, 161);
            this.txt_totalprice.Name = "txt_totalprice";
            this.txt_totalprice.Size = new System.Drawing.Size(223, 27);
            this.txt_totalprice.TabIndex = 28;
            this.txt_totalprice.TextChanged += new System.EventHandler(this.txt_totalprice_TextChanged);
            // 
            // txt_billno
            // 
            this.txt_billno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_billno.Location = new System.Drawing.Point(166, 92);
            this.txt_billno.Name = "txt_billno";
            this.txt_billno.Size = new System.Drawing.Size(223, 27);
            this.txt_billno.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(449, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Part Price :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label5.Location = new System.Drawing.Point(449, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Part Quantity :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(449, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Part Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS PGothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label3.Location = new System.Drawing.Point(352, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Billing Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(35, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Total Price. :";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.Color.RoyalBlue;
            this.lbl_name.Location = new System.Drawing.Point(35, 92);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(87, 20);
            this.lbl_name.TabIndex = 24;
            this.lbl_name.Text = "Bill No. :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.db_billcardDataGridView);
            this.panel1.Location = new System.Drawing.Point(111, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(677, 219);
            this.panel1.TabIndex = 32;
            // 
            // db_billcardDataGridView
            // 
            this.db_billcardDataGridView.AutoGenerateColumns = false;
            this.db_billcardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db_billcardDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.db_billcardDataGridView.DataSource = this.db_billcardBindingSource;
            this.db_billcardDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.db_billcardDataGridView.Location = new System.Drawing.Point(0, 0);
            this.db_billcardDataGridView.Name = "db_billcardDataGridView";
            this.db_billcardDataGridView.RowHeadersWidth = 51;
            this.db_billcardDataGridView.RowTemplate.Height = 24;
            this.db_billcardDataGridView.Size = new System.Drawing.Size(677, 219);
            this.db_billcardDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "billno";
            this.dataGridViewTextBoxColumn1.HeaderText = "Bill No";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "partname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Part Name";
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
            this.dataGridViewTextBoxColumn4.DataPropertyName = "partquantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Part Quantity";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "totalprice";
            this.dataGridViewTextBoxColumn5.HeaderText = "Total Price";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // db_billcardBindingSource
            // 
            this.db_billcardBindingSource.DataMember = "db_billcard";
            this.db_billcardBindingSource.DataSource = this.ds_billcard;
            // 
            // ds_billcard
            // 
            this.ds_billcard.DataSetName = "ds_billcard";
            this.ds_billcard.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_calculatebill
            // 
            this.btn_calculatebill.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_calculatebill.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_calculatebill.Location = new System.Drawing.Point(189, 280);
            this.btn_calculatebill.Name = "btn_calculatebill";
            this.btn_calculatebill.Size = new System.Drawing.Size(136, 50);
            this.btn_calculatebill.TabIndex = 34;
            this.btn_calculatebill.Text = "Calculate Bill";
            this.btn_calculatebill.UseVisualStyleBackColor = false;
            this.btn_calculatebill.Click += new System.EventHandler(this.btn_calculatebill_Click);
            // 
            // db_billcardTableAdapter
            // 
            this.db_billcardTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.db_billcardTableAdapter = this.db_billcardTableAdapter;
            this.tableAdapterManager.UpdateOrder = Pc_maintainance_shop_Management.ds_billcardTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // db_billcard1BindingSource
            // 
            this.db_billcard1BindingSource.DataMember = "db_billcard1";
            this.db_billcard1BindingSource.DataSource = this.ds_billcard;
            // 
            // txt_grandtotal
            // 
            this.txt_grandtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_grandtotal.Location = new System.Drawing.Point(254, 583);
            this.txt_grandtotal.Name = "txt_grandtotal";
            this.txt_grandtotal.Size = new System.Drawing.Size(208, 27);
            this.txt_grandtotal.TabIndex = 35;
            this.txt_grandtotal.TextChanged += new System.EventHandler(this.txt_grandtotal_TextChanged);
            // 
            // lbl_grandtotal
            // 
            this.lbl_grandtotal.AutoSize = true;
            this.lbl_grandtotal.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_grandtotal.Location = new System.Drawing.Point(106, 583);
            this.lbl_grandtotal.Name = "lbl_grandtotal";
            this.lbl_grandtotal.Size = new System.Drawing.Size(124, 26);
            this.lbl_grandtotal.TabIndex = 36;
            this.lbl_grandtotal.Text = "Grand Total";
            // 
            // btn_removeall
            // 
            this.btn_removeall.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_removeall.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_removeall.ForeColor = System.Drawing.Color.White;
            this.btn_removeall.Location = new System.Drawing.Point(616, 571);
            this.btn_removeall.Name = "btn_removeall";
            this.btn_removeall.Size = new System.Drawing.Size(155, 50);
            this.btn_removeall.TabIndex = 37;
            this.btn_removeall.Text = "Remove All";
            this.btn_removeall.UseVisualStyleBackColor = false;
            this.btn_removeall.Click += new System.EventHandler(this.btn_removeall_Click);
            // 
            // uc_billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_removeall);
            this.Controls.Add(this.lbl_grandtotal);
            this.Controls.Add(this.txt_grandtotal);
            this.Controls.Add(this.btn_calculatebill);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.txt_partprice);
            this.Controls.Add(this.txt_partquantity);
            this.Controls.Add(this.txt_partname);
            this.Controls.Add(this.txt_totalprice);
            this.Controls.Add(this.txt_billno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_name);
            this.Name = "uc_billing";
            this.Size = new System.Drawing.Size(906, 658);
            this.Load += new System.EventHandler(this.uc_billing_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.db_billcardDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billcardBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ds_billcard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_billcard1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txt_partprice;
        private System.Windows.Forms.TextBox txt_partquantity;
        private System.Windows.Forms.TextBox txt_partname;
        private System.Windows.Forms.TextBox txt_totalprice;
        private System.Windows.Forms.TextBox txt_billno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_calculatebill;
        private ds_billcard ds_billcard;
        private System.Windows.Forms.BindingSource db_billcardBindingSource;
        private ds_billcardTableAdapters.db_billcardTableAdapter db_billcardTableAdapter;
        private ds_billcardTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView db_billcardDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource db_billcard1BindingSource;
        private System.Windows.Forms.TextBox txt_grandtotal;
        private System.Windows.Forms.Label lbl_grandtotal;
        private System.Windows.Forms.Button btn_removeall;
    }
}
