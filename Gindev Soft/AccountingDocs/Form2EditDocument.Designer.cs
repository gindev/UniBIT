namespace AccountingDocs
{
    partial class Form2EditDocument
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
            this.textBoxDocNumber = new System.Windows.Forms.TextBox();
            this.labelDocNumber = new System.Windows.Forms.Label();
            this.labelDocDate = new System.Windows.Forms.Label();
            this.textBoxDocDate = new System.Windows.Forms.TextBox();
            this.labelDocType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelClient = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.labelReceivedBy = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.groupBoxCustomer = new System.Windows.Forms.GroupBox();
            this.linkLabelCDEdit = new System.Windows.Forms.LinkLabel();
            this.labelCDDanNo = new System.Windows.Forms.Label();
            this.labelCDBulstat = new System.Windows.Forms.Label();
            this.labelCDMol = new System.Windows.Forms.Label();
            this.labelCDCity = new System.Windows.Forms.Label();
            this.labelCDAddress = new System.Windows.Forms.Label();
            this.labelCDName = new System.Windows.Forms.Label();
            this.groupBoxCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxDocNumber
            // 
            this.textBoxDocNumber.Location = new System.Drawing.Point(116, 10);
            this.textBoxDocNumber.Name = "textBoxDocNumber";
            this.textBoxDocNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxDocNumber.TabIndex = 0;
            // 
            // labelDocNumber
            // 
            this.labelDocNumber.AutoSize = true;
            this.labelDocNumber.Location = new System.Drawing.Point(14, 13);
            this.labelDocNumber.Name = "labelDocNumber";
            this.labelDocNumber.Size = new System.Drawing.Size(97, 13);
            this.labelDocNumber.TabIndex = 1;
            this.labelDocNumber.Text = "Document number:";
            // 
            // labelDocDate
            // 
            this.labelDocDate.AutoSize = true;
            this.labelDocDate.Location = new System.Drawing.Point(14, 39);
            this.labelDocDate.Name = "labelDocDate";
            this.labelDocDate.Size = new System.Drawing.Size(83, 13);
            this.labelDocDate.TabIndex = 2;
            this.labelDocDate.Text = "Document date:";
            // 
            // textBoxDocDate
            // 
            this.textBoxDocDate.Location = new System.Drawing.Point(116, 36);
            this.textBoxDocDate.Name = "textBoxDocDate";
            this.textBoxDocDate.Size = new System.Drawing.Size(100, 20);
            this.textBoxDocDate.TabIndex = 3;
            // 
            // labelDocType
            // 
            this.labelDocType.AutoSize = true;
            this.labelDocType.Location = new System.Drawing.Point(14, 65);
            this.labelDocType.Name = "labelDocType";
            this.labelDocType.Size = new System.Drawing.Size(82, 13);
            this.labelDocType.TabIndex = 4;
            this.labelDocType.Text = "Document type:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Invoice",
            "Receipt"});
            this.comboBox1.Location = new System.Drawing.Point(116, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(14, 93);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(54, 13);
            this.labelClient.TabIndex = 6;
            this.labelClient.Text = "Customer:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(116, 90);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 7;
            // 
            // labelReceivedBy
            // 
            this.labelReceivedBy.AutoSize = true;
            this.labelReceivedBy.Location = new System.Drawing.Point(14, 122);
            this.labelReceivedBy.Name = "labelReceivedBy";
            this.labelReceivedBy.Size = new System.Drawing.Size(70, 13);
            this.labelReceivedBy.TabIndex = 8;
            this.labelReceivedBy.Text = "Received by:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(116, 119);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(100, 21);
            this.comboBox3.TabIndex = 9;
            // 
            // groupBoxCustomer
            // 
            this.groupBoxCustomer.Controls.Add(this.linkLabelCDEdit);
            this.groupBoxCustomer.Controls.Add(this.labelCDDanNo);
            this.groupBoxCustomer.Controls.Add(this.labelCDBulstat);
            this.groupBoxCustomer.Controls.Add(this.labelCDMol);
            this.groupBoxCustomer.Controls.Add(this.labelCDCity);
            this.groupBoxCustomer.Controls.Add(this.labelCDAddress);
            this.groupBoxCustomer.Controls.Add(this.labelCDName);
            this.groupBoxCustomer.Location = new System.Drawing.Point(325, 13);
            this.groupBoxCustomer.Name = "groupBoxCustomer";
            this.groupBoxCustomer.Size = new System.Drawing.Size(284, 207);
            this.groupBoxCustomer.TabIndex = 10;
            this.groupBoxCustomer.TabStop = false;
            this.groupBoxCustomer.Text = "Customer details";
            // 
            // linkLabelCDEdit
            // 
            this.linkLabelCDEdit.AutoSize = true;
            this.linkLabelCDEdit.Location = new System.Drawing.Point(86, 183);
            this.linkLabelCDEdit.Name = "linkLabelCDEdit";
            this.linkLabelCDEdit.Size = new System.Drawing.Size(125, 13);
            this.linkLabelCDEdit.TabIndex = 6;
            this.linkLabelCDEdit.TabStop = true;
            this.linkLabelCDEdit.Text = "Edit customer information";
            // 
            // labelCDDanNo
            // 
            this.labelCDDanNo.AutoSize = true;
            this.labelCDDanNo.Location = new System.Drawing.Point(7, 151);
            this.labelCDDanNo.Name = "labelCDDanNo";
            this.labelCDDanNo.Size = new System.Drawing.Size(44, 13);
            this.labelCDDanNo.TabIndex = 5;
            this.labelCDDanNo.Text = "DanNo:";
            // 
            // labelCDBulstat
            // 
            this.labelCDBulstat.AutoSize = true;
            this.labelCDBulstat.Location = new System.Drawing.Point(7, 126);
            this.labelCDBulstat.Name = "labelCDBulstat";
            this.labelCDBulstat.Size = new System.Drawing.Size(42, 13);
            this.labelCDBulstat.TabIndex = 4;
            this.labelCDBulstat.Text = "Bulstat:";
            // 
            // labelCDMol
            // 
            this.labelCDMol.AutoSize = true;
            this.labelCDMol.Location = new System.Drawing.Point(7, 101);
            this.labelCDMol.Name = "labelCDMol";
            this.labelCDMol.Size = new System.Drawing.Size(33, 13);
            this.labelCDMol.TabIndex = 3;
            this.labelCDMol.Text = "MOL:";
            // 
            // labelCDCity
            // 
            this.labelCDCity.AutoSize = true;
            this.labelCDCity.Location = new System.Drawing.Point(7, 51);
            this.labelCDCity.Name = "labelCDCity";
            this.labelCDCity.Size = new System.Drawing.Size(27, 13);
            this.labelCDCity.TabIndex = 2;
            this.labelCDCity.Text = "City:";
            // 
            // labelCDAddress
            // 
            this.labelCDAddress.AutoSize = true;
            this.labelCDAddress.Location = new System.Drawing.Point(7, 76);
            this.labelCDAddress.Name = "labelCDAddress";
            this.labelCDAddress.Size = new System.Drawing.Size(48, 13);
            this.labelCDAddress.TabIndex = 1;
            this.labelCDAddress.Text = "Address:";
            // 
            // labelCDName
            // 
            this.labelCDName.AutoSize = true;
            this.labelCDName.Location = new System.Drawing.Point(7, 26);
            this.labelCDName.Name = "labelCDName";
            this.labelCDName.Size = new System.Drawing.Size(38, 13);
            this.labelCDName.TabIndex = 0;
            this.labelCDName.Text = "Name:";
            // 
            // Form2EditDocument
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 341);
            this.Controls.Add(this.groupBoxCustomer);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.labelReceivedBy);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.labelClient);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelDocType);
            this.Controls.Add(this.textBoxDocDate);
            this.Controls.Add(this.labelDocDate);
            this.Controls.Add(this.labelDocNumber);
            this.Controls.Add(this.textBoxDocNumber);
            this.Name = "Form2EditDocument";
            this.Text = "Form2EditDocument";
            this.groupBoxCustomer.ResumeLayout(false);
            this.groupBoxCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDocNumber;
        private System.Windows.Forms.Label labelDocNumber;
        private System.Windows.Forms.Label labelDocDate;
        private System.Windows.Forms.TextBox textBoxDocDate;
        private System.Windows.Forms.Label labelDocType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label labelReceivedBy;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Label labelCDCity;
        private System.Windows.Forms.Label labelCDAddress;
        private System.Windows.Forms.Label labelCDName;
        private System.Windows.Forms.Label labelCDMol;
        private System.Windows.Forms.LinkLabel linkLabelCDEdit;
        private System.Windows.Forms.Label labelCDDanNo;
        private System.Windows.Forms.Label labelCDBulstat;
    }
}