namespace test
{
    partial class QuenMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuenMK));
            this.btcheck = new System.Windows.Forms.Button();
            this.tbpass2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpass = new System.Windows.Forms.TextBox();
            this.tbrepass = new System.Windows.Forms.TextBox();
            this.tbusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btcheck
            // 
            this.btcheck.Location = new System.Drawing.Point(205, 199);
            this.btcheck.Name = "btcheck";
            this.btcheck.Size = new System.Drawing.Size(104, 41);
            this.btcheck.TabIndex = 5;
            this.btcheck.Text = "Kiểm Tra";
            this.btcheck.UseVisualStyleBackColor = true;
            this.btcheck.Click += new System.EventHandler(this.btcheck_Click);
            // 
            // tbpass2
            // 
            this.tbpass2.Location = new System.Drawing.Point(165, 68);
            this.tbpass2.Name = "tbpass2";
            this.tbpass2.Size = new System.Drawing.Size(185, 20);
            this.tbpass2.TabIndex = 2;
            this.tbpass2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nhập Mật Khẩu Cấp 2 :";
            // 
            // tbpass
            // 
            this.tbpass.Location = new System.Drawing.Point(165, 105);
            this.tbpass.Name = "tbpass";
            this.tbpass.Size = new System.Drawing.Size(185, 20);
            this.tbpass.TabIndex = 3;
            this.tbpass.UseSystemPasswordChar = true;
            this.tbpass.Visible = false;
            // 
            // tbrepass
            // 
            this.tbrepass.Location = new System.Drawing.Point(165, 145);
            this.tbrepass.Name = "tbrepass";
            this.tbrepass.Size = new System.Drawing.Size(185, 20);
            this.tbrepass.TabIndex = 4;
            this.tbrepass.UseSystemPasswordChar = true;
            this.tbrepass.Visible = false;
            this.tbrepass.TextChanged += new System.EventHandler(this.tbrepass_TextChanged);
            // 
            // tbusername
            // 
            this.tbusername.Location = new System.Drawing.Point(165, 24);
            this.tbusername.Name = "tbusername";
            this.tbusername.Size = new System.Drawing.Size(185, 20);
            this.tbusername.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tên Đăng Nhập :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(202, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nhập Mật Khẩu Mới :";
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(205, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nhập Lại Mật Khẩu :";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(356, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "X";
            this.label5.Visible = false;
            // 
            // QuenMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 295);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbusername);
            this.Controls.Add(this.tbrepass);
            this.Controls.Add(this.tbpass);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbpass2);
            this.Controls.Add(this.btcheck);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "QuenMK";
            this.Text = "Phục Hồi Mật Khẩu Bằng Mật Khẩu Cấp 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btcheck;
        private System.Windows.Forms.TextBox tbpass2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbpass;
        private System.Windows.Forms.TextBox tbrepass;
        private System.Windows.Forms.TextBox tbusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}