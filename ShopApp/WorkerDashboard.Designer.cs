namespace ShopApp
{
    partial class WorkerDashboard
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbProducts = new System.Windows.Forms.ComboBox();
            this.lblPRoduct = new System.Windows.Forms.Label();
            this.nmCount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rcDesctiption = new System.Windows.Forms.RichTextBox();
            this.btnSale = new System.Windows.Forms.Button();
            this.dtgSaleProduct = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbFilterCat = new System.Windows.Forms.ComboBox();
            this.nmMaxPrice = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.nmMinPrice = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSaleProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category";
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(14, 42);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(184, 28);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // cmbProducts
            // 
            this.cmbProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbProducts.FormattingEnabled = true;
            this.cmbProducts.Location = new System.Drawing.Point(14, 140);
            this.cmbProducts.Name = "cmbProducts";
            this.cmbProducts.Size = new System.Drawing.Size(184, 28);
            this.cmbProducts.TabIndex = 3;
            this.cmbProducts.SelectedIndexChanged += new System.EventHandler(this.cmbProducts_SelectedIndexChanged);
            // 
            // lblPRoduct
            // 
            this.lblPRoduct.AutoSize = true;
            this.lblPRoduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPRoduct.Location = new System.Drawing.Point(14, 107);
            this.lblPRoduct.Name = "lblPRoduct";
            this.lblPRoduct.Size = new System.Drawing.Size(72, 20);
            this.lblPRoduct.TabIndex = 2;
            this.lblPRoduct.Text = "Products";
            // 
            // nmCount
            // 
            this.nmCount.Location = new System.Drawing.Point(14, 245);
            this.nmCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCount.Name = "nmCount";
            this.nmCount.Size = new System.Drawing.Size(120, 20);
            this.nmCount.TabIndex = 4;
            this.nmCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmCount.ValueChanged += new System.EventHandler(this.nmCount_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Counts";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 292);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 382);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description";
            // 
            // rcDesctiption
            // 
            this.rcDesctiption.Location = new System.Drawing.Point(18, 431);
            this.rcDesctiption.Name = "rcDesctiption";
            this.rcDesctiption.Size = new System.Drawing.Size(180, 96);
            this.rcDesctiption.TabIndex = 8;
            this.rcDesctiption.Text = "";
            // 
            // btnSale
            // 
            this.btnSale.Enabled = false;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Location = new System.Drawing.Point(18, 556);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(178, 46);
            this.btnSale.TabIndex = 9;
            this.btnSale.Text = "Sale";
            this.btnSale.UseVisualStyleBackColor = true;
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // dtgSaleProduct
            // 
            this.dtgSaleProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgSaleProduct.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgSaleProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgSaleProduct.Location = new System.Drawing.Point(460, 107);
            this.dtgSaleProduct.Name = "dtgSaleProduct";
            this.dtgSaleProduct.Size = new System.Drawing.Size(671, 361);
            this.dtgSaleProduct.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(456, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Category";
            // 
            // cmbFilterCat
            // 
            this.cmbFilterCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilterCat.FormattingEnabled = true;
            this.cmbFilterCat.Location = new System.Drawing.Point(456, 57);
            this.cmbFilterCat.Name = "cmbFilterCat";
            this.cmbFilterCat.Size = new System.Drawing.Size(184, 28);
            this.cmbFilterCat.TabIndex = 12;
            this.cmbFilterCat.SelectedIndexChanged += new System.EventHandler(this.cmbFilterCat_SelectedIndexChanged);
            this.cmbFilterCat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFilterCat_KeyPress);
            // 
            // nmMaxPrice
            // 
            this.nmMaxPrice.Location = new System.Drawing.Point(838, 57);
            this.nmMaxPrice.Name = "nmMaxPrice";
            this.nmMaxPrice.Size = new System.Drawing.Size(120, 20);
            this.nmMaxPrice.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(834, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Max Price";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Orange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(985, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Filter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nmMinPrice
            // 
            this.nmMinPrice.Location = new System.Drawing.Point(687, 57);
            this.nmMinPrice.Name = "nmMinPrice";
            this.nmMinPrice.Size = new System.Drawing.Size(120, 20);
            this.nmMinPrice.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(683, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Min Price";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(214, 148);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(44, 20);
            this.lblStock.TabIndex = 16;
            this.lblStock.Text = "Price";
            this.lblStock.Visible = false;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.ForeColor = System.Drawing.Color.Orange;
            this.lblPrice.Location = new System.Drawing.Point(14, 330);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(44, 20);
            this.lblPrice.TabIndex = 17;
            this.lblPrice.Text = "Price";
            this.lblPrice.Visible = false;
            // 
            // WorkerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 614);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nmMaxPrice);
            this.Controls.Add(this.cmbFilterCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtgSaleProduct);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.rcDesctiption);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nmMinPrice);
            this.Controls.Add(this.nmCount);
            this.Controls.Add(this.cmbProducts);
            this.Controls.Add(this.lblPRoduct);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.label1);
            this.Name = "WorkerDashboard";
            this.Text = "WorkerDashboard";
            this.Load += new System.EventHandler(this.WorkerDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgSaleProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMaxPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbProducts;
        private System.Windows.Forms.Label lblPRoduct;
        private System.Windows.Forms.NumericUpDown nmCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rcDesctiption;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.DataGridView dtgSaleProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbFilterCat;
        private System.Windows.Forms.NumericUpDown nmMaxPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nmMinPrice;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblPrice;
    }
}