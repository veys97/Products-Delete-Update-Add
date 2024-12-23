namespace Ado.Net
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.firstlbl = new System.Windows.Forms.Label();
            this.firsttbox = new System.Windows.Forms.TextBox();
            this.secondtbox = new System.Windows.Forms.TextBox();
            this.thirdtbox = new System.Windows.Forms.TextBox();
            this.secondlbl = new System.Windows.Forms.Label();
            this.thirdlbl = new System.Windows.Forms.Label();
            this.gbAdd = new System.Windows.Forms.GroupBox();
            this.btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxStockAmountUpdate = new System.Windows.Forms.TextBox();
            this.lblsA = new System.Windows.Forms.Label();
            this.tbxNameUpdate = new System.Windows.Forms.TextBox();
            this.lbluP = new System.Windows.Forms.Label();
            this.tbxUnitPriceUpdate = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbAdd.SuspendLayout();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(12, 26);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(592, 206);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // firstlbl
            // 
            this.firstlbl.AutoSize = true;
            this.firstlbl.Location = new System.Drawing.Point(8, 45);
            this.firstlbl.Name = "firstlbl";
            this.firstlbl.Size = new System.Drawing.Size(82, 29);
            this.firstlbl.TabIndex = 1;
            this.firstlbl.Text = "Name";
            // 
            // firsttbox
            // 
            this.firsttbox.Location = new System.Drawing.Point(186, 45);
            this.firsttbox.Name = "firsttbox";
            this.firsttbox.Size = new System.Drawing.Size(144, 34);
            this.firsttbox.TabIndex = 2;
            // 
            // secondtbox
            // 
            this.secondtbox.Location = new System.Drawing.Point(186, 99);
            this.secondtbox.Name = "secondtbox";
            this.secondtbox.Size = new System.Drawing.Size(144, 34);
            this.secondtbox.TabIndex = 3;
            // 
            // thirdtbox
            // 
            this.thirdtbox.Location = new System.Drawing.Point(186, 159);
            this.thirdtbox.Name = "thirdtbox";
            this.thirdtbox.Size = new System.Drawing.Size(144, 34);
            this.thirdtbox.TabIndex = 4;
            // 
            // secondlbl
            // 
            this.secondlbl.AutoSize = true;
            this.secondlbl.Location = new System.Drawing.Point(6, 102);
            this.secondlbl.Name = "secondlbl";
            this.secondlbl.Size = new System.Drawing.Size(127, 29);
            this.secondlbl.TabIndex = 5;
            this.secondlbl.Text = "Unit Price";
            // 
            // thirdlbl
            // 
            this.thirdlbl.AutoSize = true;
            this.thirdlbl.Location = new System.Drawing.Point(8, 159);
            this.thirdlbl.Name = "thirdlbl";
            this.thirdlbl.Size = new System.Drawing.Size(172, 29);
            this.thirdlbl.TabIndex = 6;
            this.thirdlbl.Text = "Stock Amount";
            // 
            // gbAdd
            // 
            this.gbAdd.Controls.Add(this.btn);
            this.gbAdd.Controls.Add(this.label1);
            this.gbAdd.Controls.Add(this.firstlbl);
            this.gbAdd.Controls.Add(this.thirdtbox);
            this.gbAdd.Controls.Add(this.thirdlbl);
            this.gbAdd.Controls.Add(this.firsttbox);
            this.gbAdd.Controls.Add(this.secondlbl);
            this.gbAdd.Controls.Add(this.secondtbox);
            this.gbAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbAdd.Location = new System.Drawing.Point(688, 26);
            this.gbAdd.Name = "gbAdd";
            this.gbAdd.Size = new System.Drawing.Size(387, 312);
            this.gbAdd.TabIndex = 7;
            this.gbAdd.TabStop = false;
            this.gbAdd.Text = "Add a product";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(110, 229);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(121, 50);
            this.btn.TabIndex = 8;
            this.btn.Text = "Add";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.btnUpdate);
            this.gbUpdate.Controls.Add(this.lblName);
            this.gbUpdate.Controls.Add(this.label3);
            this.gbUpdate.Controls.Add(this.tbxStockAmountUpdate);
            this.gbUpdate.Controls.Add(this.lblsA);
            this.gbUpdate.Controls.Add(this.tbxNameUpdate);
            this.gbUpdate.Controls.Add(this.lbluP);
            this.gbUpdate.Controls.Add(this.tbxUnitPriceUpdate);
            this.gbUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbUpdate.Location = new System.Drawing.Point(1177, 26);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(355, 312);
            this.gbUpdate.TabIndex = 8;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Update a product";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(110, 229);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(121, 50);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(8, 45);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 29);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "Name";
            // 
            // tbxStockAmountUpdate
            // 
            this.tbxStockAmountUpdate.Location = new System.Drawing.Point(186, 159);
            this.tbxStockAmountUpdate.Name = "tbxStockAmountUpdate";
            this.tbxStockAmountUpdate.Size = new System.Drawing.Size(144, 34);
            this.tbxStockAmountUpdate.TabIndex = 4;
            // 
            // lblsA
            // 
            this.lblsA.AutoSize = true;
            this.lblsA.Location = new System.Drawing.Point(8, 159);
            this.lblsA.Name = "lblsA";
            this.lblsA.Size = new System.Drawing.Size(172, 29);
            this.lblsA.TabIndex = 6;
            this.lblsA.Text = "Stock Amount";
            // 
            // tbxNameUpdate
            // 
            this.tbxNameUpdate.Location = new System.Drawing.Point(186, 45);
            this.tbxNameUpdate.Name = "tbxNameUpdate";
            this.tbxNameUpdate.Size = new System.Drawing.Size(144, 34);
            this.tbxNameUpdate.TabIndex = 2;
            // 
            // lbluP
            // 
            this.lbluP.AutoSize = true;
            this.lbluP.Location = new System.Drawing.Point(6, 102);
            this.lbluP.Name = "lbluP";
            this.lbluP.Size = new System.Drawing.Size(127, 29);
            this.lbluP.TabIndex = 5;
            this.lbluP.Text = "Unit Price";
            // 
            // tbxUnitPriceUpdate
            // 
            this.tbxUnitPriceUpdate.Location = new System.Drawing.Point(186, 99);
            this.tbxUnitPriceUpdate.Name = "tbxUnitPriceUpdate";
            this.tbxUnitPriceUpdate.Size = new System.Drawing.Size(144, 34);
            this.tbxUnitPriceUpdate.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(34, 281);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(174, 68);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1544, 390);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.gbAdd);
            this.Controls.Add(this.dgwProducts);
            this.Name = "Form1";
            this.Text = "Delete";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbAdd.ResumeLayout(false);
            this.gbAdd.PerformLayout();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.Label firstlbl;
        private System.Windows.Forms.TextBox firsttbox;
        private System.Windows.Forms.TextBox secondtbox;
        private System.Windows.Forms.TextBox thirdtbox;
        private System.Windows.Forms.Label secondlbl;
        private System.Windows.Forms.Label thirdlbl;
        private System.Windows.Forms.GroupBox gbAdd;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbxStockAmountUpdate;
        private System.Windows.Forms.Label lblsA;
        private System.Windows.Forms.TextBox tbxNameUpdate;
        private System.Windows.Forms.Label lbluP;
        private System.Windows.Forms.TextBox tbxUnitPriceUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}

