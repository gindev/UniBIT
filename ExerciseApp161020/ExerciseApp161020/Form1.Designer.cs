namespace ExerciseApp161020
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TCount = new System.Windows.Forms.TextBox();
            this.REven = new System.Windows.Forms.RadioButton();
            this.RRand = new System.Windows.Forms.RadioButton();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.BFill = new System.Windows.Forms.Button();
            this.BRight = new System.Windows.Forms.Button();
            this.BLeft = new System.Windows.Forms.Button();
            this.BEnd = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "534",
            "54534",
            "53",
            "45",
            "345",
            "34",
            "5",
            "345",
            "34",
            "5"});
            this.listBox1.Location = new System.Drawing.Point(23, 126);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox1.Size = new System.Drawing.Size(120, 173);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(266, 126);
            this.listBox2.Name = "listBox2";
            this.listBox2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox2.Size = new System.Drawing.Size(120, 173);
            this.listBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Брой";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TCount
            // 
            this.TCount.Location = new System.Drawing.Point(64, 40);
            this.TCount.MaxLength = 3;
            this.TCount.Name = "TCount";
            this.TCount.Size = new System.Drawing.Size(79, 20);
            this.TCount.TabIndex = 0;
            this.TCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TCount_KeyPress);
            // 
            // REven
            // 
            this.REven.AutoSize = true;
            this.REven.Checked = true;
            this.REven.Location = new System.Drawing.Point(168, 41);
            this.REven.Name = "REven";
            this.REven.Size = new System.Drawing.Size(88, 17);
            this.REven.TabIndex = 1;
            this.REven.TabStop = true;
            this.REven.Text = "Четни числа";
            this.REven.UseVisualStyleBackColor = true;
            this.REven.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            this.REven.Click += new System.EventHandler(this.REven_Click);
            // 
            // RRand
            // 
            this.RRand.AutoSize = true;
            this.RRand.Location = new System.Drawing.Point(266, 41);
            this.RRand.Name = "RRand";
            this.RRand.Size = new System.Drawing.Size(104, 17);
            this.RRand.TabIndex = 2;
            this.RRand.Text = "Случайни числа";
            this.RRand.UseVisualStyleBackColor = true;
            this.RRand.Click += new System.EventHandler(this.RRand_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(266, 65);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Увеличение с 666";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // BFill
            // 
            this.BFill.Location = new System.Drawing.Point(168, 136);
            this.BFill.Name = "BFill";
            this.BFill.Size = new System.Drawing.Size(75, 23);
            this.BFill.TabIndex = 4;
            this.BFill.Text = "Попълни";
            this.BFill.UseVisualStyleBackColor = true;
            this.BFill.Click += new System.EventHandler(this.button1_Click);
            // 
            // BRight
            // 
            this.BRight.Location = new System.Drawing.Point(168, 179);
            this.BRight.Name = "BRight";
            this.BRight.Size = new System.Drawing.Size(75, 23);
            this.BRight.TabIndex = 8;
            this.BRight.Text = ">>";
            this.BRight.UseVisualStyleBackColor = true;
            this.BRight.Click += new System.EventHandler(this.button2_Click);
            // 
            // BLeft
            // 
            this.BLeft.Location = new System.Drawing.Point(168, 222);
            this.BLeft.Name = "BLeft";
            this.BLeft.Size = new System.Drawing.Size(75, 23);
            this.BLeft.TabIndex = 9;
            this.BLeft.Text = "<<";
            this.BLeft.UseVisualStyleBackColor = true;
            this.BLeft.Click += new System.EventHandler(this.BLeft_Click);
            // 
            // BEnd
            // 
            this.BEnd.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BEnd.Location = new System.Drawing.Point(168, 265);
            this.BEnd.Name = "BEnd";
            this.BEnd.Size = new System.Drawing.Size(75, 23);
            this.BEnd.TabIndex = 5;
            this.BEnd.Text = "Край";
            this.BEnd.UseVisualStyleBackColor = true;
            this.BEnd.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Първи списък";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Втри списък";
            // 
            // Form1
            // 
            this.AcceptButton = this.BFill;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BEnd;
            this.ClientSize = new System.Drawing.Size(412, 329);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BEnd);
            this.Controls.Add(this.BLeft);
            this.Controls.Add(this.BRight);
            this.Controls.Add(this.BFill);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.RRand);
            this.Controls.Add(this.REven);
            this.Controls.Add(this.TCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Работа със списъчни полета";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCount;
        private System.Windows.Forms.RadioButton REven;
        private System.Windows.Forms.RadioButton RRand;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BFill;
        private System.Windows.Forms.Button BRight;
        private System.Windows.Forms.Button BLeft;
        private System.Windows.Forms.Button BEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

