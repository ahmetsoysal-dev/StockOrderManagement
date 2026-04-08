namespace StockOrderManagement.UI.Forms.Supplier
{
    partial class FrmSupplierCreate
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
            this.lbl_info = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.txt_SupplierName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_formName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_info.Location = new System.Drawing.Point(37, 254);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(23, 25);
            this.lbl_info.TabIndex = 15;
            this.lbl_info.Text = "0";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Save.Font = new System.Drawing.Font("MV Boli", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Location = new System.Drawing.Point(213, 190);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(190, 72);
            this.btn_Save.TabIndex = 11;
            this.btn_Save.Text = "KAYDET";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // txt_SupplierName
            // 
            this.txt_SupplierName.Location = new System.Drawing.Point(213, 124);
            this.txt_SupplierName.MaxLength = 30;
            this.txt_SupplierName.Name = "txt_SupplierName";
            this.txt_SupplierName.Size = new System.Drawing.Size(190, 22);
            this.txt_SupplierName.TabIndex = 12;
            this.txt_SupplierName.TextChanged += new System.EventHandler(this.txt_SupplierName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 29);
            this.label2.TabIndex = 14;
            this.label2.Text = "AD";
            // 
            // lbl_formName
            // 
            this.lbl_formName.AutoSize = true;
            this.lbl_formName.Font = new System.Drawing.Font("MV Boli", 16.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formName.ForeColor = System.Drawing.Color.Red;
            this.lbl_formName.Location = new System.Drawing.Point(75, 41);
            this.lbl_formName.Name = "lbl_formName";
            this.lbl_formName.Size = new System.Drawing.Size(325, 37);
            this.lbl_formName.TabIndex = 13;
            this.lbl_formName.Text = "MARKA GİRİŞ FORMU";
            // 
            // FrmSupplierCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(534, 331);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.txt_SupplierName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_formName);
            this.Name = "FrmSupplierCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSupplierCreate";
            this.Load += new System.EventHandler(this.FrmSupplierCreate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox txt_SupplierName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_formName;
    }
}