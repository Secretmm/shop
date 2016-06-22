namespace WindowsSupermarkt.MyUser
{
    partial class UserLogin
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.btncancel2 = new System.Windows.Forms.Button();
            this.btnsure2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labcode1 = new System.Windows.Forms.Label();
            this.labname1 = new System.Windows.Forms.Label();
            this.btnback = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.linkLabel3);
            this.groupBox1.Controls.Add(this.btncancel2);
            this.groupBox1.Controls.Add(this.btnsure2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labcode1);
            this.groupBox1.Controls.Add(this.labname1);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(66, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(589, 300);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登录窗口";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(421, 148);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(76, 16);
            this.linkLabel3.TabIndex = 12;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "忘记密码";
            // 
            // btncancel2
            // 
            this.btncancel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btncancel2.Location = new System.Drawing.Point(392, 235);
            this.btncancel2.Name = "btncancel2";
            this.btncancel2.Size = new System.Drawing.Size(86, 50);
            this.btncancel2.TabIndex = 4;
            this.btncancel2.Text = "取消";
            this.btncancel2.UseVisualStyleBackColor = false;
            // 
            // btnsure2
            // 
            this.btnsure2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnsure2.Location = new System.Drawing.Point(138, 235);
            this.btnsure2.Name = "btnsure2";
            this.btnsure2.Size = new System.Drawing.Size(94, 50);
            this.btnsure2.TabIndex = 3;
            this.btnsure2.Text = "登录";
            this.btnsure2.UseVisualStyleBackColor = false;
            this.btnsure2.Click += new System.EventHandler(this.btnsure2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(232, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(136, 26);
            this.textBox2.TabIndex = 8;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(232, 62);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 26);
            this.textBox1.TabIndex = 7;
            // 
            // labcode1
            // 
            this.labcode1.AutoSize = true;
            this.labcode1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labcode1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labcode1.Location = new System.Drawing.Point(115, 134);
            this.labcode1.Name = "labcode1";
            this.labcode1.Size = new System.Drawing.Size(42, 16);
            this.labcode1.TabIndex = 6;
            this.labcode1.Text = "密码";
            // 
            // labname1
            // 
            this.labname1.AutoSize = true;
            this.labname1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labname1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labname1.Location = new System.Drawing.Point(115, 72);
            this.labname1.Name = "labname1";
            this.labname1.Size = new System.Drawing.Size(93, 16);
            this.labname1.TabIndex = 5;
            this.labname1.Text = "会员卡编号";
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnback.Location = new System.Drawing.Point(620, 389);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(134, 48);
            this.btnback.TabIndex = 12;
            this.btnback.Text = "返回";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // UserLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsSupermarkt.Properties.Resources._124;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserLogin";
            this.Text = "UserLogin";
            this.Load += new System.EventHandler(this.UserLogin_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel3;
        public System.Windows.Forms.Button btncancel2;
        public System.Windows.Forms.Button btnsure2;
        public System.Windows.Forms.TextBox textBox2;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.Label labcode1;
        public System.Windows.Forms.Label labname1;
        private System.Windows.Forms.Button btnback;
    }
}