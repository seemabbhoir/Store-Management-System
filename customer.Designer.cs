using System.Windows.Forms;

namespace LoginForm
{
    partial class customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customer));
            this.labelpricefor1product = new System.Windows.Forms.Label();
            this.txtpriceforoneproduct = new System.Windows.Forms.TextBox();
            this.btnlogout = new System.Windows.Forms.Button();
            this.grddata = new System.Windows.Forms.DataGridView();
            this.cmbprctname = new System.Windows.Forms.ComboBox();
            this.cmbproductbrand = new System.Windows.Forms.ComboBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txttotalprice = new System.Windows.Forms.TextBox();
            this.txtproductquantity = new System.Windows.Forms.TextBox();
            this.txtproductid = new System.Windows.Forms.TextBox();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtmobileno = new System.Windows.Forms.TextBox();
            this.txtcname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.labelinformation = new System.Windows.Forms.Label();
            this.labeltotalprice = new System.Windows.Forms.Label();
            this.labelproductquantity = new System.Windows.Forms.Label();
            this.labelproductbrand = new System.Windows.Forms.Label();
            this.labelproductname = new System.Windows.Forms.Label();
            this.labelproductid = new System.Windows.Forms.Label();
            this.labeladdress = new System.Windows.Forms.Label();
            this.labelmobileno = new System.Windows.Forms.Label();
            this.labelname = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).BeginInit();
            this.SuspendLayout();
            // 
            // labelpricefor1product
            // 
            this.labelpricefor1product.AutoSize = true;
            this.labelpricefor1product.BackColor = System.Drawing.Color.Transparent;
            this.labelpricefor1product.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelpricefor1product.Location = new System.Drawing.Point(46, 427);
            this.labelpricefor1product.Name = "labelpricefor1product";
            this.labelpricefor1product.Size = new System.Drawing.Size(171, 29);
            this.labelpricefor1product.TabIndex = 54;
            this.labelpricefor1product.Text = "Product Price";
            // 
            // txtpriceforoneproduct
            // 
            this.txtpriceforoneproduct.Location = new System.Drawing.Point(281, 427);
            this.txtpriceforoneproduct.Name = "txtpriceforoneproduct";
            this.txtpriceforoneproduct.Size = new System.Drawing.Size(152, 20);
            this.txtpriceforoneproduct.TabIndex = 8;
            this.txtpriceforoneproduct.Tag = "double";
            // 
            // btnlogout
            // 
            this.btnlogout.BackColor = System.Drawing.Color.OrangeRed;
            this.btnlogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnlogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnlogout.Location = new System.Drawing.Point(314, 522);
            this.btnlogout.Name = "btnlogout";
            this.btnlogout.Size = new System.Drawing.Size(119, 45);
            this.btnlogout.TabIndex = 52;
            this.btnlogout.Text = "Log Out";
            this.btnlogout.UseVisualStyleBackColor = false;
            this.btnlogout.Click += new System.EventHandler(this.btnlogout_Click);
            // 
            // grddata
            // 
            this.grddata.BackgroundColor = System.Drawing.Color.White;
            this.grddata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grddata.Location = new System.Drawing.Point(564, 88);
            this.grddata.Name = "grddata";
            this.grddata.Size = new System.Drawing.Size(491, 192);
            this.grddata.TabIndex = 50;
            // 
            // cmbprctname
            // 
            this.cmbprctname.FormattingEnabled = true;
            this.cmbprctname.Items.AddRange(new object[] {
            "TV",
            "Washing Machine",
            "Refrigerator",
            "Oven",
            "Mixer",
            "Cooker",
            "Electric Stove",
            "Other"});
            this.cmbprctname.Location = new System.Drawing.Point(281, 304);
            this.cmbprctname.Name = "cmbprctname";
            this.cmbprctname.Size = new System.Drawing.Size(152, 21);
            this.cmbprctname.TabIndex = 5;
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
            this.cmbproductbrand.Location = new System.Drawing.Point(281, 347);
            this.cmbproductbrand.Name = "cmbproductbrand";
            this.cmbproductbrand.Size = new System.Drawing.Size(152, 21);
            this.cmbproductbrand.TabIndex = 6;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(182, 523);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(96, 45);
            this.btndelete.TabIndex = 47;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnsave
            // 
            this.btnsave.BackColor = System.Drawing.Color.MediumBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnsave.Location = new System.Drawing.Point(51, 523);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(96, 45);
            this.btnsave.TabIndex = 46;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = false;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txttotalprice
            // 
            this.txttotalprice.Location = new System.Drawing.Point(281, 472);
            this.txttotalprice.Name = "txttotalprice";
            this.txttotalprice.Size = new System.Drawing.Size(152, 20);
            this.txttotalprice.TabIndex = 9;
            this.txttotalprice.Tag = "double";
            this.txttotalprice.TextChanged += new System.EventHandler(this.txttotalprice_TextChanged);
            // 
            // txtproductquantity
            // 
            this.txtproductquantity.Location = new System.Drawing.Point(281, 387);
            this.txtproductquantity.Name = "txtproductquantity";
            this.txtproductquantity.Size = new System.Drawing.Size(152, 20);
            this.txtproductquantity.TabIndex = 7;
            this.txtproductquantity.Tag = "int";
            // 
            // txtproductid
            // 
            this.txtproductid.Location = new System.Drawing.Point(281, 260);
            this.txtproductid.Name = "txtproductid";
            this.txtproductid.Size = new System.Drawing.Size(152, 20);
            this.txtproductid.TabIndex = 4;
            this.txtproductid.Tag = "int";
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(281, 221);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(152, 20);
            this.txtaddress.TabIndex = 3;
            this.txtaddress.Tag = "";
            // 
            // txtmobileno
            // 
            this.txtmobileno.Location = new System.Drawing.Point(281, 176);
            this.txtmobileno.Name = "txtmobileno";
            this.txtmobileno.Size = new System.Drawing.Size(152, 20);
            this.txtmobileno.TabIndex = 2;
            this.txtmobileno.Tag = "int";
            // 
            // txtcname
            // 
            this.txtcname.Location = new System.Drawing.Point(281, 131);
            this.txtcname.Name = "txtcname";
            this.txtcname.Size = new System.Drawing.Size(152, 20);
            this.txtcname.TabIndex = 1;
            this.txtcname.Tag = "string";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(281, 88);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(152, 20);
            this.txtid.TabIndex = 0;
            this.txtid.Tag = "int";
            this.txtid.Validating += new System.ComponentModel.CancelEventHandler(this.txtid_Validating);
            // 
            // labelinformation
            // 
            this.labelinformation.AutoSize = true;
            this.labelinformation.BackColor = System.Drawing.Color.Transparent;
            this.labelinformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinformation.Location = new System.Drawing.Point(387, 24);
            this.labelinformation.Name = "labelinformation";
            this.labelinformation.Size = new System.Drawing.Size(262, 29);
            this.labelinformation.TabIndex = 38;
            this.labelinformation.Text = "Customer Information";
            // 
            // labeltotalprice
            // 
            this.labeltotalprice.AutoSize = true;
            this.labeltotalprice.BackColor = System.Drawing.Color.Transparent;
            this.labeltotalprice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltotalprice.Location = new System.Drawing.Point(46, 472);
            this.labeltotalprice.Name = "labeltotalprice";
            this.labeltotalprice.Size = new System.Drawing.Size(141, 29);
            this.labeltotalprice.TabIndex = 37;
            this.labeltotalprice.Text = "Total Price";
            // 
            // labelproductquantity
            // 
            this.labelproductquantity.AutoSize = true;
            this.labelproductquantity.BackColor = System.Drawing.Color.Transparent;
            this.labelproductquantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductquantity.Location = new System.Drawing.Point(46, 387);
            this.labelproductquantity.Name = "labelproductquantity";
            this.labelproductquantity.Size = new System.Drawing.Size(205, 29);
            this.labelproductquantity.TabIndex = 36;
            this.labelproductquantity.Text = "Product Quantity";
            // 
            // labelproductbrand
            // 
            this.labelproductbrand.AutoSize = true;
            this.labelproductbrand.BackColor = System.Drawing.Color.Transparent;
            this.labelproductbrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductbrand.Location = new System.Drawing.Point(46, 347);
            this.labelproductbrand.Name = "labelproductbrand";
            this.labelproductbrand.Size = new System.Drawing.Size(179, 29);
            this.labelproductbrand.TabIndex = 35;
            this.labelproductbrand.Text = "Product Brand";
            // 
            // labelproductname
            // 
            this.labelproductname.AutoSize = true;
            this.labelproductname.BackColor = System.Drawing.Color.Transparent;
            this.labelproductname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductname.Location = new System.Drawing.Point(46, 304);
            this.labelproductname.Name = "labelproductname";
            this.labelproductname.Size = new System.Drawing.Size(179, 29);
            this.labelproductname.TabIndex = 34;
            this.labelproductname.Text = "Product Name";
            // 
            // labelproductid
            // 
            this.labelproductid.AutoSize = true;
            this.labelproductid.BackColor = System.Drawing.Color.Transparent;
            this.labelproductid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelproductid.Location = new System.Drawing.Point(46, 260);
            this.labelproductid.Name = "labelproductid";
            this.labelproductid.Size = new System.Drawing.Size(135, 29);
            this.labelproductid.TabIndex = 33;
            this.labelproductid.Text = "Product ID";
            // 
            // labeladdress
            // 
            this.labeladdress.AutoSize = true;
            this.labeladdress.BackColor = System.Drawing.Color.Transparent;
            this.labeladdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeladdress.Location = new System.Drawing.Point(46, 221);
            this.labeladdress.Name = "labeladdress";
            this.labeladdress.Size = new System.Drawing.Size(109, 29);
            this.labeladdress.TabIndex = 32;
            this.labeladdress.Text = "Address";
            // 
            // labelmobileno
            // 
            this.labelmobileno.AutoSize = true;
            this.labelmobileno.BackColor = System.Drawing.Color.Transparent;
            this.labelmobileno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmobileno.Location = new System.Drawing.Point(46, 176);
            this.labelmobileno.Name = "labelmobileno";
            this.labelmobileno.Size = new System.Drawing.Size(146, 29);
            this.labelmobileno.TabIndex = 31;
            this.labelmobileno.Text = "Mobile NO.";
            // 
            // labelname
            // 
            this.labelname.AutoSize = true;
            this.labelname.BackColor = System.Drawing.Color.Transparent;
            this.labelname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelname.Location = new System.Drawing.Point(46, 131);
            this.labelname.Name = "labelname";
            this.labelname.Size = new System.Drawing.Size(82, 29);
            this.labelname.TabIndex = 30;
            this.labelname.Text = "Name";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.Transparent;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.Location = new System.Drawing.Point(46, 88);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(157, 29);
            this.labelid.TabIndex = 0;
            this.labelid.Text = "Customer ID";
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.toy_shopping_cart;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1135, 598);
            this.Controls.Add(this.labelpricefor1product);
            this.Controls.Add(this.txtpriceforoneproduct);
            this.Controls.Add(this.btnlogout);
            this.Controls.Add(this.grddata);
            this.Controls.Add(this.cmbprctname);
            this.Controls.Add(this.cmbproductbrand);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.txttotalprice);
            this.Controls.Add(this.txtproductquantity);
            this.Controls.Add(this.txtproductid);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtmobileno);
            this.Controls.Add(this.txtcname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.labelinformation);
            this.Controls.Add(this.labeltotalprice);
            this.Controls.Add(this.labelproductquantity);
            this.Controls.Add(this.labelproductbrand);
            this.Controls.Add(this.labelproductname);
            this.Controls.Add(this.labelproductid);
            this.Controls.Add(this.labeladdress);
            this.Controls.Add(this.labelmobileno);
            this.Controls.Add(this.labelname);
            this.Controls.Add(this.labelid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customer";
            this.Text = "Customer";
            ((System.ComponentModel.ISupportInitialize)(this.grddata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpricefor1product;
        private System.Windows.Forms.Button btnlogout;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label labelinformation;
        private System.Windows.Forms.Label labeltotalprice;
        private System.Windows.Forms.Label labelproductquantity;
        private System.Windows.Forms.Label labelproductbrand;
        private System.Windows.Forms.Label labelproductname;
        private System.Windows.Forms.Label labelproductid;
        private System.Windows.Forms.Label labeladdress;
        private System.Windows.Forms.Label labelmobileno;
        private System.Windows.Forms.Label labelname;
        private System.Windows.Forms.Label labelid;
        public System.Windows.Forms.TextBox txtaddress;
        public System.Windows.Forms.TextBox txtmobileno;
        public System.Windows.Forms.TextBox txtcname;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.TextBox txtpriceforoneproduct;
        public System.Windows.Forms.DataGridView grddata;
        public System.Windows.Forms.ComboBox cmbprctname;
        public System.Windows.Forms.ComboBox cmbproductbrand;
        public System.Windows.Forms.TextBox txttotalprice;
        public System.Windows.Forms.TextBox txtproductquantity;
        public System.Windows.Forms.TextBox txtproductid;
        //private ComboBox cmbproductbrand;
        //private ComboBox cmbproductname;
        //private DataGridView grddata;
        //private Button btnshowgrid;
        //private Button btnlogout;
        //private TextBox txtpriceforoneproduct;
        //private Label labelpricefor1product;
    }
}