namespace cs_assignment3
{
    partial class product_card
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
            this.lblNum = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblInv = new System.Windows.Forms.Label();
            this.LblObj = new System.Windows.Forms.Label();
            this.LblCount = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNum
            // 
            this.lblNum.AutoSize = true;
            this.lblNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum.Location = new System.Drawing.Point(23, 22);
            this.lblNum.Name = "lblNum";
            this.lblNum.Size = new System.Drawing.Size(100, 29);
            this.lblNum.TabIndex = 0;
            this.lblNum.Text = "Number";
            this.lblNum.Click += new System.EventHandler(this.lblNum_Click);
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.Location = new System.Drawing.Point(23, 66);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(63, 29);
            this.LblDate.TabIndex = 1;
            this.LblDate.Text = "Date";
            // 
            // LblInv
            // 
            this.LblInv.AutoSize = true;
            this.LblInv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblInv.Location = new System.Drawing.Point(27, 111);
            this.LblInv.Name = "LblInv";
            this.LblInv.Size = new System.Drawing.Size(94, 29);
            this.LblInv.TabIndex = 2;
            this.LblInv.Text = "InvNum";
            // 
            // LblObj
            // 
            this.LblObj.AutoSize = true;
            this.LblObj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblObj.Location = new System.Drawing.Point(311, 19);
            this.LblObj.Name = "LblObj";
            this.LblObj.Size = new System.Drawing.Size(117, 29);
            this.LblObj.TabIndex = 3;
            this.LblObj.Text = "ObjName";
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount.Location = new System.Drawing.Point(315, 66);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(76, 29);
            this.LblCount.TabIndex = 4;
            this.LblCount.Text = "Count";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(315, 110);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(69, 29);
            this.LblPrice.TabIndex = 5;
            this.LblPrice.Text = "Price";
            // 
            // product_card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.LblObj);
            this.Controls.Add(this.LblInv);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.lblNum);
            this.Name = "product_card";
            this.Size = new System.Drawing.Size(465, 165);
            this.Load += new System.EventHandler(this.product_card_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblInv;
        private System.Windows.Forms.Label LblObj;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label LblPrice;
    }
}
