namespace WindowsSupermarkt.MySystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.商品交易区AToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品销售情况区EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品信息查询区BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.商品信息操作区CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.超市活动发布区DToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查看超市活动aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除超市活动bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(365, 401);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "基本信息";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(117, 100);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "姓名";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(211, 268);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(101, 23);
            this.button5.TabIndex = 18;
            this.button5.Text = "修改手机号";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(251, 198);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "修改密码";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Location = new System.Drawing.Point(82, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 59);
            this.button2.TabIndex = 15;
            this.button2.Text = "退出登录";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Location = new System.Drawing.Point(117, 236);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(185, 26);
            this.txtPhone.TabIndex = 11;
            // 
            // txtCode
            // 
            this.txtCode.BackColor = System.Drawing.Color.White;
            this.txtCode.Location = new System.Drawing.Point(117, 169);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(185, 26);
            this.txtCode.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(16, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "手机号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(16, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Location = new System.Drawing.Point(115, 43);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(185, 26);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(16, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "编号";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品交易区AToolStripMenuItem,
            this.商品销售情况区EToolStripMenuItem,
            this.商品信息查询区BToolStripMenuItem,
            this.商品信息操作区CToolStripMenuItem,
            this.超市活动发布区DToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 商品交易区AToolStripMenuItem
            // 
            this.商品交易区AToolStripMenuItem.Name = "商品交易区AToolStripMenuItem";
            this.商品交易区AToolStripMenuItem.Size = new System.Drawing.Size(96, 21);
            this.商品交易区AToolStripMenuItem.Text = "商品交易区(&A)";
            // 
            // 商品销售情况区EToolStripMenuItem
            // 
            this.商品销售情况区EToolStripMenuItem.Name = "商品销售情况区EToolStripMenuItem";
            this.商品销售情况区EToolStripMenuItem.Size = new System.Drawing.Size(119, 21);
            this.商品销售情况区EToolStripMenuItem.Text = "商品销售情况区(&E)";
            // 
            // 商品信息查询区BToolStripMenuItem
            // 
            this.商品信息查询区BToolStripMenuItem.Name = "商品信息查询区BToolStripMenuItem";
            this.商品信息查询区BToolStripMenuItem.Size = new System.Drawing.Size(120, 21);
            this.商品信息查询区BToolStripMenuItem.Text = "商品信息查询区(&B)";
            // 
            // 商品信息操作区CToolStripMenuItem
            // 
            this.商品信息操作区CToolStripMenuItem.Name = "商品信息操作区CToolStripMenuItem";
            this.商品信息操作区CToolStripMenuItem.Size = new System.Drawing.Size(120, 21);
            this.商品信息操作区CToolStripMenuItem.Text = "商品信息操作区(&C)";
            // 
            // 超市活动发布区DToolStripMenuItem
            // 
            this.超市活动发布区DToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看超市活动aToolStripMenuItem,
            this.删除超市活动bToolStripMenuItem});
            this.超市活动发布区DToolStripMenuItem.Name = "超市活动发布区DToolStripMenuItem";
            this.超市活动发布区DToolStripMenuItem.Size = new System.Drawing.Size(121, 21);
            this.超市活动发布区DToolStripMenuItem.Text = "超市活动发布区(&D)";
            // 
            // 查看超市活动aToolStripMenuItem
            // 
            this.查看超市活动aToolStripMenuItem.Name = "查看超市活动aToolStripMenuItem";
            this.查看超市活动aToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.查看超市活动aToolStripMenuItem.Text = "查看超市活动(&a)";
            // 
            // 删除超市活动bToolStripMenuItem
            // 
            this.删除超市活动bToolStripMenuItem.Name = "删除超市活动bToolStripMenuItem";
            this.删除超市活动bToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.删除超市活动bToolStripMenuItem.Text = "删除超市活动(&b)";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.button9);
            this.groupBox2.Controls.Add(this.button8);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(401, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 401);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Location = new System.Drawing.Point(34, 309);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(130, 73);
            this.button9.TabIndex = 5;
            this.button9.Text = "注册新会员";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button8.Location = new System.Drawing.Point(34, 42);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(130, 237);
            this.button8.TabIndex = 4;
            this.button8.Text = "商品交易区";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button7.Location = new System.Drawing.Point(216, 312);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(130, 73);
            this.button7.TabIndex = 3;
            this.button7.Text = "超市活动发布区";
            this.button7.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button6.Location = new System.Drawing.Point(216, 221);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(130, 73);
            this.button6.TabIndex = 2;
            this.button6.Text = "商品信息操作区";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(216, 124);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(130, 73);
            this.button3.TabIndex = 1;
            this.button3.Text = "商品信息查询区";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(216, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 73);
            this.button1.TabIndex = 0;
            this.button1.Text = "商品销售情况区";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.TextBox txtPhone;
        public System.Windows.Forms.TextBox txtCode;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtID;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.ToolStripMenuItem 商品交易区AToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品信息查询区BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品信息操作区CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 超市活动发布区DToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查看超市活动aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除超市活动bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 商品销售情况区EToolStripMenuItem;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button button9;
    }
}