﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsSupermarkt
{
    public partial class ModifyPhone : Form
    {
        DBHelper.DBHelper db = new DBHelper.DBHelper();
        string ID, Phone;
        public ModifyPhone(string id,string phone)
        {
            ID = id;
            Phone = phone;
            InitializeComponent();
        }

        private void ModifyPhone_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("原手机号不能为空");
            }
            else
                if (textBox1.Text != Phone.ToString())
                {
                    MessageBox.Show("原手机号输入错误，请重新输入");
                }
                else 
                if (textBox2.Text.Trim() == "")
            { 
                MessageBox.Show("请输入新手机号"); 
            }
                else
                
                    if (textBox2.Text.Length != 11)
                {
                    MessageBox.Show("请输入有效的11位手机号码");
                }
                else
                        if (textBox3.Text.Trim ()== "")
                        {
                            MessageBox.Show("确认手机号不能为空！");
                        }
                        else

                        if (textBox2.Text != textBox3.Text)
                        {
                            MessageBox.Show("两次输入的新手机号不符！请核对后重新输入");
                        }
                        else
                        {
                            string s = "update UserInfor set UserPhone='" + textBox2.Text + "' where UserID='" + this.ID.ToString() + "'";
                            db.execute(s);
                            MessageBox.Show("手机号修改成功");
                            this.Hide();
                            MyUser.UserMain main = new MyUser.UserMain(this.ID.ToString());
                            main.Show();
                        }


            
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
