namespace LoginForm
{
    partial class productstored
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productstored));
            this.btnlogout = new System.Windows.Forms.Button();
            this.grdinformation = new System.Windows.Forms.DataGridView();
            this.cmbproductbrand = new System.Windows.Forms.ComboBox();
            this.cmbproductname = new System.Windows.Forms.ComboBox();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtproductquantityavailable = new System.Windows.Forms.TextBox();
            this.labelproductquantity = new System.Windows.Forms.Label();
            this.labelproductbrand = new System.Windows.Forms.Label();
            this.labelproductname = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdinformation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.OrangeRed;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.Color.White;
            this.btnlogout.Location = new System.Drawing.Point(325, 280);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(119, 50);
            this.btnlogout.TabIndex = 41;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // grdinformation
            // 
            this.grdinformation.BackgroundColor = System.Drawing.Color.White;
            this.grdinformation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdinformation.Location = new System.Drawing.Point(563, 81);
            this.grdinformation.Name = "grdinformation";
            this.grdinformation.Size = new System.Drawing.Size(337, 150);
            this.grdinformation.TabIndex = 39;
            // 
            // cmbproductbrand
            // 
            this.cmbproductbrand.FormattingEnabled = true;
            this.cmbproductbrand.Items.AddRange(new object[] {
            "LG",
            "Samsung",
            "Godrej",
            "Onida",
            "Videocon",
            "Whirpool",
            "Other"});
            this.cmbproductbrand.Location = new System.Drawing.Point(323, 124);
            this.cmbproductbrand.Name = "cmbproductbrand";
            this.cmbproductbrand.Size = new System.Drawing.Size(121, 21);
            this.cmbproductbrand.TabIndex = 1;
            // 
            // cmbproductname
            // 
            this.cmbproductname.FormattingEnabled = true;
            this.cmbproductname.Items.AddRange(new object[] {
            "TV",
            "Refrigerator",
            "Mixer",
            "Oven",
            "Washing Machine ",
            "Cooker",
            "Electric Stove",
            "Other"});
            this.cmbproductname.Location = new System.Drawing.Point(323, 81);
            this.cmbproductname.Name = "cmbproductname";
            this.cmbproductname.Size = new System.Drawing.Size(121, 21);
            this.cmbproductname.TabIndex = 0;
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.Color.Green;
            this.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.Color.White;
            this.btnedit.Location = new System.Drawing.Point(187, 280);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(98, 50);
            this.btnedit.TabIndex = 36;
            this.btnedit.Text = "Update";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.MediumBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.Color.White;
            this.btnsave.Location = new System.Drawing.Point(44, 280);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(98, 50);
            this.btnsave.TabIndex = 35;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtproductquantityavailable
            // 
            this.txtproductquantityavailable.Location = new System.Drawing.Point(323, 174);
            this.txtproductquantityavailable.Name = "txtproductquantityavailable";
            this.txtproductquantityavailable.Size = new System.Drawing.Size(121, 20);
            this.txtproductquantityavailable.TabIndex = 2;
            txtproductquantityavailable.KeyPress += Control_KeyPress;
            this.txtproductquantityavailable.Tag = "int";
            // 
            // labelproductquantity
            // 
            this.labelproductquantity.AutoSize = true;
            this.labelproductquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductquantity.Location = new System.Drawing.Point(55, 174);
            this.labelproductquantity.Name = "labelproductquantity";
            this.labelproductquantity.Size = new System.Drawing.Size(255, 24);
            this.labelproductquantity.TabIndex = 33;
            this.labelproductquantity.Text = "Product Quantity Available";
            // 
            // labelproductbrand
            // 
            this.labelproductbrand.AutoSize = true;
            this.labelproductbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductbrand.Location = new System.Drawing.Point(55, 125);
            this.labelproductbrand.Name = "labelproductbrand";
            this.labelproductbrand.Size = new System.Drawing.Size(143, 24);
            this.labelproductbrand.TabIndex = 32;
            this.labelproductbrand.Text = "Product Brand";
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(55, 81);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(143, 24);
            this.labelproductname.TabIndex = 31;
            this.labelproductname.Text = "Product Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(240, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 31);
            this.label1.TabIndex = 30;
            this.label1.Text = "Product Available at Store";
            // 
            // productstored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 542);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.grdinformation);
            this.Controls.Add(this.cmbproductbrand);
            this.Controls.Add(this.cmbproductname);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txtproductquantityavailable);
            this.Controls.Add(this.labelproductquantity);
            this.Controls.Add(this.labelproductbrand);
            this.Controls.Add(this.labelproductname);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "productstored";
            this.Text = "Store";
            ((System.ComponentModel.ISupportInitialize)(this.grdinformation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.DataGridView grdinformation;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label labelproductquantity;
        private System.Windows.Forms.Label labelproductbrand;
        private System.Windows.Forms.Label labelproductname;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox cmbproductbrand;
        public System.Windows.Forms.ComboBox cmbproductname;
        public System.Windows.Forms.TextBox txtproductquantityavailable;
    }
}