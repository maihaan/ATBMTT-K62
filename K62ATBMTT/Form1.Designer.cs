namespace K62ATBMTT
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
            this.tbDLCMH = new System.Windows.Forms.TextBox();
            this.btMaHoa = new System.Windows.Forms.Button();
            this.tbDLMH = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btGiaiMa = new System.Windows.Forms.Button();
            this.tbGiaiMa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dữ liệu cần mã hóa";
            // 
            // tbDLCMH
            // 
            this.tbDLCMH.Location = new System.Drawing.Point(16, 29);
            this.tbDLCMH.Multiline = true;
            this.tbDLCMH.Name = "tbDLCMH";
            this.tbDLCMH.Size = new System.Drawing.Size(330, 103);
            this.tbDLCMH.TabIndex = 1;
            // 
            // btMaHoa
            // 
            this.btMaHoa.Location = new System.Drawing.Point(16, 140);
            this.btMaHoa.Name = "btMaHoa";
            this.btMaHoa.Size = new System.Drawing.Size(330, 23);
            this.btMaHoa.TabIndex = 2;
            this.btMaHoa.Text = "Thực hiện mã hóa";
            this.btMaHoa.UseVisualStyleBackColor = true;
            this.btMaHoa.Click += new System.EventHandler(this.btMaHoa_Click);
            // 
            // tbDLMH
            // 
            this.tbDLMH.Location = new System.Drawing.Point(16, 192);
            this.tbDLMH.Multiline = true;
            this.tbDLMH.Name = "tbDLMH";
            this.tbDLMH.Size = new System.Drawing.Size(330, 116);
            this.tbDLMH.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dữ liệu mã hóa";
            // 
            // btGiaiMa
            // 
            this.btGiaiMa.Location = new System.Drawing.Point(13, 315);
            this.btGiaiMa.Name = "btGiaiMa";
            this.btGiaiMa.Size = new System.Drawing.Size(333, 23);
            this.btGiaiMa.TabIndex = 5;
            this.btGiaiMa.Text = "Giải mã";
            this.btGiaiMa.UseVisualStyleBackColor = true;
            this.btGiaiMa.Click += new System.EventHandler(this.btGiaiMa_Click);
            // 
            // tbGiaiMa
            // 
            this.tbGiaiMa.Location = new System.Drawing.Point(16, 345);
            this.tbGiaiMa.Multiline = true;
            this.tbGiaiMa.Name = "tbGiaiMa";
            this.tbGiaiMa.Size = new System.Drawing.Size(330, 110);
            this.tbGiaiMa.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 468);
            this.Controls.Add(this.tbGiaiMa);
            this.Controls.Add(this.btGiaiMa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDLMH);
            this.Controls.Add(this.btMaHoa);
            this.Controls.Add(this.tbDLCMH);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDLCMH;
        private System.Windows.Forms.Button btMaHoa;
        private System.Windows.Forms.TextBox tbDLMH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btGiaiMa;
        private System.Windows.Forms.TextBox tbGiaiMa;
    }
}

