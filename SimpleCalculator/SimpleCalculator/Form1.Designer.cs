namespace SimpleCalculator
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
            this.TRes = new System.Windows.Forms.TextBox();
            this.B0 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.B4 = new System.Windows.Forms.Button();
            this.B5 = new System.Windows.Forms.Button();
            this.B6 = new System.Windows.Forms.Button();
            this.B7 = new System.Windows.Forms.Button();
            this.B9 = new System.Windows.Forms.Button();
            this.B8 = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.BSub = new System.Windows.Forms.Button();
            this.BMult = new System.Windows.Forms.Button();
            this.BDiv = new System.Windows.Forms.Button();
            this.BPow = new System.Windows.Forms.Button();
            this.BPt = new System.Windows.Forms.Button();
            this.BClear = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.BEq = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TRes
            // 
            this.TRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TRes.Location = new System.Drawing.Point(13, 21);
            this.TRes.Name = "TRes";
            this.TRes.ReadOnly = true;
            this.TRes.Size = new System.Drawing.Size(199, 23);
            this.TRes.TabIndex = 0;
            this.TRes.Text = "0";
            this.TRes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // B0
            // 
            this.B0.Location = new System.Drawing.Point(12, 66);
            this.B0.Name = "B0";
            this.B0.Size = new System.Drawing.Size(35, 30);
            this.B0.TabIndex = 1;
            this.B0.Text = "0";
            this.B0.UseVisualStyleBackColor = true;
            this.B0.Click += new System.EventHandler(this.Digits_Click);
            // 
            // B1
            // 
            this.B1.Location = new System.Drawing.Point(53, 66);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(35, 30);
            this.B1.TabIndex = 2;
            this.B1.Text = "1";
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.Digits_Click);
            // 
            // B2
            // 
            this.B2.Location = new System.Drawing.Point(94, 66);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(35, 30);
            this.B2.TabIndex = 3;
            this.B2.Text = "2";
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.Digits_Click);
            // 
            // B3
            // 
            this.B3.Location = new System.Drawing.Point(135, 66);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(35, 30);
            this.B3.TabIndex = 4;
            this.B3.Text = "3";
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.Digits_Click);
            // 
            // B4
            // 
            this.B4.Location = new System.Drawing.Point(176, 66);
            this.B4.Name = "B4";
            this.B4.Size = new System.Drawing.Size(35, 30);
            this.B4.TabIndex = 5;
            this.B4.Text = "4";
            this.B4.UseVisualStyleBackColor = true;
            this.B4.Click += new System.EventHandler(this.Digits_Click);
            // 
            // B5
            // 
            this.B5.Location = new System.Drawing.Point(12, 102);
            this.B5.Name = "B5";
            this.B5.Size = new System.Drawing.Size(35, 30);
            this.B5.TabIndex = 6;
            this.B5.Text = "5";
            this.B5.UseVisualStyleBackColor = true;
            this.B5.Click += new System.EventHandler(this.Digits_Click);
            // 
            // B6
            // 
            this.B6.Location = new System.Drawing.Point(53, 102);
            this.B6.Name = "B6";
            this.B6.Size = new System.Drawing.Size(35, 30);
            this.B6.TabIndex = 7;
            this.B6.Text = "6";
            this.B6.UseVisualStyleBackColor = true;
            this.B6.Click += new System.EventHandler(this.Digits_Click);
            // 
            // B7
            // 
            this.B7.Location = new System.Drawing.Point(94, 102);
            this.B7.Name = "B7";
            this.B7.Size = new System.Drawing.Size(35, 30);
            this.B7.TabIndex = 8;
            this.B7.Text = "7";
            this.B7.UseVisualStyleBackColor = true;
            this.B7.Click += new System.EventHandler(this.Digits_Click);
            // 
            // B9
            // 
            this.B9.Location = new System.Drawing.Point(176, 102);
            this.B9.Name = "B9";
            this.B9.Size = new System.Drawing.Size(35, 30);
            this.B9.TabIndex = 9;
            this.B9.Text = "9";
            this.B9.UseVisualStyleBackColor = true;
            this.B9.Click += new System.EventHandler(this.Digits_Click);
            // 
            // B8
            // 
            this.B8.Location = new System.Drawing.Point(135, 102);
            this.B8.Name = "B8";
            this.B8.Size = new System.Drawing.Size(35, 30);
            this.B8.TabIndex = 10;
            this.B8.Text = "8";
            this.B8.UseVisualStyleBackColor = true;
            this.B8.Click += new System.EventHandler(this.Digits_Click);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(12, 138);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(35, 30);
            this.BAdd.TabIndex = 11;
            this.BAdd.Text = "+";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.MathOps_Click);
            // 
            // BSub
            // 
            this.BSub.Location = new System.Drawing.Point(53, 138);
            this.BSub.Name = "BSub";
            this.BSub.Size = new System.Drawing.Size(35, 30);
            this.BSub.TabIndex = 12;
            this.BSub.Text = "-";
            this.BSub.UseVisualStyleBackColor = true;
            this.BSub.Click += new System.EventHandler(this.MathOps_Click);
            // 
            // BMult
            // 
            this.BMult.Location = new System.Drawing.Point(94, 138);
            this.BMult.Name = "BMult";
            this.BMult.Size = new System.Drawing.Size(35, 30);
            this.BMult.TabIndex = 13;
            this.BMult.Text = "*";
            this.BMult.UseVisualStyleBackColor = true;
            this.BMult.Click += new System.EventHandler(this.MathOps_Click);
            // 
            // BDiv
            // 
            this.BDiv.Location = new System.Drawing.Point(135, 138);
            this.BDiv.Name = "BDiv";
            this.BDiv.Size = new System.Drawing.Size(35, 30);
            this.BDiv.TabIndex = 14;
            this.BDiv.Text = "/";
            this.BDiv.UseVisualStyleBackColor = true;
            this.BDiv.Click += new System.EventHandler(this.MathOps_Click);
            // 
            // BPow
            // 
            this.BPow.Location = new System.Drawing.Point(176, 138);
            this.BPow.Name = "BPow";
            this.BPow.Size = new System.Drawing.Size(35, 30);
            this.BPow.TabIndex = 15;
            this.BPow.Text = "^";
            this.BPow.UseVisualStyleBackColor = true;
            this.BPow.Click += new System.EventHandler(this.MathOps_Click);
            // 
            // BPt
            // 
            this.BPt.Location = new System.Drawing.Point(12, 174);
            this.BPt.Name = "BPt";
            this.BPt.Size = new System.Drawing.Size(35, 30);
            this.BPt.TabIndex = 16;
            this.BPt.Text = ".";
            this.BPt.UseVisualStyleBackColor = true;
            this.BPt.Click += new System.EventHandler(this.BPt_Click);
            // 
            // BClear
            // 
            this.BClear.Location = new System.Drawing.Point(53, 174);
            this.BClear.Name = "BClear";
            this.BClear.Size = new System.Drawing.Size(35, 30);
            this.BClear.TabIndex = 17;
            this.BClear.Text = "C";
            this.BClear.UseVisualStyleBackColor = true;
            this.BClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // BBack
            // 
            this.BBack.Location = new System.Drawing.Point(94, 174);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(76, 30);
            this.BBack.TabIndex = 18;
            this.BBack.Text = "BackSpace";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // BEq
            // 
            this.BEq.Location = new System.Drawing.Point(176, 174);
            this.BEq.Name = "BEq";
            this.BEq.Size = new System.Drawing.Size(35, 30);
            this.BEq.TabIndex = 19;
            this.BEq.Text = "=";
            this.BEq.UseVisualStyleBackColor = true;
            this.BEq.Click += new System.EventHandler(this.BEq_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 223);
            this.Controls.Add(this.BEq);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BClear);
            this.Controls.Add(this.BPt);
            this.Controls.Add(this.BPow);
            this.Controls.Add(this.BDiv);
            this.Controls.Add(this.BMult);
            this.Controls.Add(this.BSub);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.B8);
            this.Controls.Add(this.B9);
            this.Controls.Add(this.B7);
            this.Controls.Add(this.B6);
            this.Controls.Add(this.B5);
            this.Controls.Add(this.B4);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B0);
            this.Controls.Add(this.TRes);
            this.Name = "Form1";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TRes;
        private System.Windows.Forms.Button B0;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button B4;
        private System.Windows.Forms.Button B5;
        private System.Windows.Forms.Button B6;
        private System.Windows.Forms.Button B7;
        private System.Windows.Forms.Button B9;
        private System.Windows.Forms.Button B8;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button BSub;
        private System.Windows.Forms.Button BMult;
        private System.Windows.Forms.Button BDiv;
        private System.Windows.Forms.Button BPow;
        private System.Windows.Forms.Button BPt;
        private System.Windows.Forms.Button BClear;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Button BEq;
    }
}

