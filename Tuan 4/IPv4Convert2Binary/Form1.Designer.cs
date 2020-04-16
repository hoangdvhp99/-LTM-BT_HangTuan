namespace IPv4Convert2Binary
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbNhap = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.lbKQ = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.rbtnNormal2Bin = new System.Windows.Forms.RadioButton();
            this.rbtnBin2Normal = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐỔI ĐỊA CHỈ IPv4";
            // 
            // lbNhap
            // 
            this.lbNhap.AutoSize = true;
            this.lbNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNhap.Location = new System.Drawing.Point(31, 140);
            this.lbNhap.Name = "lbNhap";
            this.lbNhap.Size = new System.Drawing.Size(113, 22);
            this.lbNhap.TabIndex = 0;
            this.lbNhap.Text = "Nhập địa chỉ";
            // 
            // txtNhap
            // 
            this.txtNhap.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhap.Location = new System.Drawing.Point(159, 135);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(358, 29);
            this.txtNhap.TabIndex = 3;
            this.txtNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNhap_KeyPress);
            // 
            // lbKQ
            // 
            this.lbKQ.AutoSize = true;
            this.lbKQ.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKQ.Location = new System.Drawing.Point(31, 186);
            this.lbKQ.Name = "lbKQ";
            this.lbKQ.Size = new System.Drawing.Size(74, 22);
            this.lbKQ.TabIndex = 0;
            this.lbKQ.Text = "Kết quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(159, 181);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.ReadOnly = true;
            this.txtKQ.Size = new System.Drawing.Size(358, 29);
            this.txtKQ.TabIndex = 8;
            this.txtKQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(303, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "ĐỔI";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(424, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 33);
            this.button2.TabIndex = 5;
            this.button2.Text = "THOÁT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // rbtnNormal2Bin
            // 
            this.rbtnNormal2Bin.AutoSize = true;
            this.rbtnNormal2Bin.Checked = true;
            this.rbtnNormal2Bin.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNormal2Bin.Location = new System.Drawing.Point(35, 65);
            this.rbtnNormal2Bin.Name = "rbtnNormal2Bin";
            this.rbtnNormal2Bin.Size = new System.Drawing.Size(263, 19);
            this.rbtnNormal2Bin.TabIndex = 1;
            this.rbtnNormal2Bin.TabStop = true;
            this.rbtnNormal2Bin.Text = "DẠNG \'THƯỜNG DÙNG\' SANG \'NHỊ PHÂN\'";
            this.rbtnNormal2Bin.UseVisualStyleBackColor = true;
            // 
            // rbtnBin2Normal
            // 
            this.rbtnBin2Normal.AutoSize = true;
            this.rbtnBin2Normal.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBin2Normal.Location = new System.Drawing.Point(35, 90);
            this.rbtnBin2Normal.Name = "rbtnBin2Normal";
            this.rbtnBin2Normal.Size = new System.Drawing.Size(263, 19);
            this.rbtnBin2Normal.TabIndex = 2;
            this.rbtnBin2Normal.Text = "DẠNG \'NHỊ PHÂN\' SANG \'THƯỜNG DÙNG\'";
            this.rbtnBin2Normal.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "_______________";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 321);
            this.Controls.Add(this.rbtnBin2Normal);
            this.Controls.Add(this.rbtnNormal2Bin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.lbKQ);
            this.Controls.Add(this.lbNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ĐỔI ĐỊA CHỈ IPv4";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNhap;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label lbKQ;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton rbtnNormal2Bin;
        private System.Windows.Forms.RadioButton rbtnBin2Normal;
        private System.Windows.Forms.Label label2;
    }
}

