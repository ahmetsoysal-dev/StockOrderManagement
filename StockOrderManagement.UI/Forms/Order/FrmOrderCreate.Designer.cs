namespace StockOrderManagement.UI.Forms.Order
{
    partial class FrmOrderCreate
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
            this.nud_Quantity = new System.Windows.Forms.NumericUpDown();
            this.cmb_ProductID = new System.Windows.Forms.ComboBox();
            this.cmb_EmployeeID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_formName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).BeginInit();
            this.SuspendLayout();
            // 
            // nud_Quantity
            // 
            this.nud_Quantity.Location = new System.Drawing.Point(209, 228);
            this.nud_Quantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Quantity.Name = "nud_Quantity";
            this.nud_Quantity.Size = new System.Drawing.Size(162, 22);
            this.nud_Quantity.TabIndex = 11;
            this.nud_Quantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nud_Quantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmb_ProductID
            // 
            this.cmb_ProductID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_ProductID.FormattingEnabled = true;
            this.cmb_ProductID.Location = new System.Drawing.Point(208, 169);
            this.cmb_ProductID.Name = "cmb_ProductID";
            this.cmb_ProductID.Size = new System.Drawing.Size(163, 24);
            this.cmb_ProductID.TabIndex = 9;
            // 
            // cmb_EmployeeID
            // 
            this.cmb_EmployeeID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_EmployeeID.FormattingEnabled = true;
            this.cmb_EmployeeID.Location = new System.Drawing.Point(208, 115);
            this.cmb_EmployeeID.Name = "cmb_EmployeeID";
            this.cmb_EmployeeID.Size = new System.Drawing.Size(163, 24);
            this.cmb_EmployeeID.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ürün ID";
            // 
            // lbl_formName
            // 
            this.lbl_formName.AutoSize = true;
            this.lbl_formName.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formName.ForeColor = System.Drawing.Color.Red;
            this.lbl_formName.Location = new System.Drawing.Point(90, 35);
            this.lbl_formName.Name = "lbl_formName";
            this.lbl_formName.Size = new System.Drawing.Size(266, 29);
            this.lbl_formName.TabIndex = 7;
            this.lbl_formName.Text = "SİPARİŞ GİRİŞ FORMU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 26);
            this.label1.TabIndex = 8;
            this.label1.Text = "Kullanıcı ID";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Save.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(208, 296);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(165, 39);
            this.btn_Save.TabIndex = 4;
            this.btn_Save.Text = "KAYDET";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // FrmOrderCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(453, 385);
            this.Controls.Add(this.nud_Quantity);
            this.Controls.Add(this.cmb_ProductID);
            this.Controls.Add(this.cmb_EmployeeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_formName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Save);
            this.Name = "FrmOrderCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOrderCreate";
            this.Load += new System.EventHandler(this.FrmOrderCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nud_Quantity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud_Quantity;
        private System.Windows.Forms.ComboBox cmb_ProductID;
        private System.Windows.Forms.ComboBox cmb_EmployeeID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_formName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
    }
}