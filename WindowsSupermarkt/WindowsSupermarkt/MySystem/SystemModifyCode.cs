﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsSupermarkt.MySystem
{
    public partial class SystemModifyCode : Form
    {
        DBHelper.DBHelper db = new DBHelper.DBHelper();
        string ID, Code;
        public SystemModifyCode(string id,string code)
        {
            ID = id;
            Code = code;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("旧密码不能为空");
            }
            else
                if (textBox1.Text != Code.ToString())//该Code为此界面定义的code,不是上个界面的code
                {
                    MessageBox.Show("旧密码输入错误，请重新输入");
                }
                else
                    if (textBox2.Text.Trim() == "")
                    {
                        MessageBox.Show("请输入六位或六位以上的新密码");
                    }

                    else
                        if (textBox2.Text.Length < 6)
                        {
                            MessageBox.Show("请输入六位或六位以上的新密码");

                        }
                        else
                            if (textBox3.Text.Trim() == "")
                            {
                                MessageBox.Show("确认密码不能为空！");
                            }
                            else

                                if (textBox2.Text != textBox3.Text)
                                {
                                    MessageBox.Show("两次输入的新密码不符！请核对后重新输入");
                                }
                                else
                                {
                                    string s = "update OperInfor set OperCode='" + textBox2.Text + "' where OperID='" + this.ID.ToString() + "'";
                                    db.execute(s);
                                    MessageBox.Show("密码修改成功");
                                    this.Hide();
                                    MySystem.Main my = new Main(this.ID.ToString());
                                    my.Show();
                                }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MySystem.Main my = new Main(this.ID.ToString());
            my.Show();
        }
    }
}