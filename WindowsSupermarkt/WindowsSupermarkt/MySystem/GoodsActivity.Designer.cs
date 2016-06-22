namespace WindowsSupermarkt.MySystem
{
    partial class GoodsActivity
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GoodsActivity));
            this.btnback = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.活动铁甲ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.活动删除BToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.活动查询CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnback.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnback.Location = new System.Drawing.Point(638, 374);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(134, 48);
            this.btnback.TabIndex = 9;
            this.btnback.Text = "返回";
            this.btnback.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(65, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 225);
            this.button1.TabIndex = 10;
            this.button1.Text = "活动添加";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(303, 115);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 225);
            this.button2.TabIndex = 11;
            this.button2.Text = "活动删除";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.ForeColor = System.Drawing.Color.Red;
            this.button3.Location = new System.Drawing.Point(529, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(149, 225);
            this.button3.TabIndex = 12;
            this.button3.Text = "活动展示";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.活动铁甲ToolStripMenuItem,
            this.活动删除BToolStripMenuItem,
            this.活动查询CToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 活动铁甲ToolStripMenuItem
            // 
            this.活动铁甲ToolStripMenuItem.Name = "活动铁甲ToolStripMenuItem";
            this.活动铁甲ToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.活动铁甲ToolStripMenuItem.Text = "活动添加(&A)";
            // 
            // 活动删除BToolStripMenuItem
            // 
            this.活动删除BToolStripMenuItem.Name = "活动删除BToolStripMenuItem";
            this.活动删除BToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.活动删除BToolStripMenuItem.Text = "活动删除(&B)";
            // 
            // 活动查询CToolStripMenuItem
            // 
            this.活动查询CToolStripMenuItem.Name = "活动查询CToolStripMenuItem";
            this.活动查询CToolStripMenuItem.Size = new System.Drawing.Size(84, 21);
            this.活动查询CToolStripMenuItem.Text = "活动查询(&C)";
            // 
            // GoodsActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "GoodsActivity";
            this.Text = "超市活动发布区";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 活动铁甲ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 活动删除BToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 活动查询CToolStripMenuItem;
    }
}