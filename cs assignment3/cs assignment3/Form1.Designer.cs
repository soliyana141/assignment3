namespace cs_assignment3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbnum = new System.Windows.Forms.TextBox();
            this.tbinvnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbobjname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbcount = new System.Windows.Forms.TextBox();
            this.tbprice = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.db = new System.Windows.Forms.DataGridView();
            this.ERP = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.db)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(267, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(599, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Inventory number";
            // 
            // tbnum
            // 
            this.tbnum.Location = new System.Drawing.Point(12, 60);
            this.tbnum.Name = "tbnum";
            this.tbnum.Size = new System.Drawing.Size(197, 26);
            this.tbnum.TabIndex = 3;
            // 
            // tbinvnum
            // 
            this.tbinvnum.Location = new System.Drawing.Point(534, 62);
            this.tbinvnum.Name = "tbinvnum";
            this.tbinvnum.Size = new System.Drawing.Size(308, 26);
            this.tbinvnum.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "object name";
            // 
            // tbobjname
            // 
            this.tbobjname.Location = new System.Drawing.Point(12, 159);
            this.tbobjname.Name = "tbobjname";
            this.tbobjname.Size = new System.Drawing.Size(757, 26);
            this.tbobjname.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Count";
            // 
            // tbcount
            // 
            this.tbcount.Location = new System.Drawing.Point(12, 252);
            this.tbcount.Name = "tbcount";
            this.tbcount.Size = new System.Drawing.Size(164, 26);
            this.tbcount.TabIndex = 9;
            // 
            // tbprice
            // 
            this.tbprice.Location = new System.Drawing.Point(380, 252);
            this.tbprice.Name = "tbprice";
            this.tbprice.Size = new System.Drawing.Size(167, 26);
            this.tbprice.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "price";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(71, 330);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(75, 31);
            this.btnadd.TabIndex = 12;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(403, 330);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 31);
            this.btncancel.TabIndex = 13;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(239, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(271, 26);
            this.dateTimePicker1.TabIndex = 14;
            // 
            // db
            // 
            this.db.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.db.Location = new System.Drawing.Point(3, 389);
            this.db.Name = "db";
            this.db.RowHeadersWidth = 62;
            this.db.RowTemplate.Height = 28;
            this.db.Size = new System.Drawing.Size(880, 216);
            this.db.TabIndex = 15;
            // 
            // ERP
            // 
            this.ERP.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 609);
            this.Controls.Add(this.db);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbprice);
            this.Controls.Add(this.tbcount);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbobjname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbinvnum);
            this.Controls.Add(this.tbnum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.db)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ERP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbnum;
        private System.Windows.Forms.TextBox tbinvnum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbobjname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbcount;
        private System.Windows.Forms.TextBox tbprice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView db;
        private System.Windows.Forms.ErrorProvider ERP;
    }
}

