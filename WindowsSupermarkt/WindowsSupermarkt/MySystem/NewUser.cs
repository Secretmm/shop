using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsSupermarkt.MySystem
{
    public partial class NewUser : Form
    {
        DBHelper.DBHelper db = new DBHelper.DBHelper();
        string ID;
        public NewUser(string id)
        {
            ID = id;
            InitializeComponent();
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Main main = new Main(this.ID.ToString());
            this.Hide();
            main.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("请输入五位会员卡编号");
            }
            else if (textBox1.Text.Length != 5)
            {
                MessageBox.Show("请输入五位会员卡编号");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("请输入五位或五位以上的密码");
            }
            else if (textBox2.Text.Length < 5)
            {
                MessageBox.Show("请输入五位或五位以上的密码");
            }
            else if (textBox6.Text.Trim() == "")
            {
                MessageBox.Show("手机号不能为空");
            }
            else if (textBox6.Text.Length != 11)
            {
                MessageBox.Show("请输入11位有效手机号");
            }
            else if (textBox7.Text.Trim() == "")
            {
                MessageBox.Show("身份证号不能为空");
            }
            else if (textBox7.Text.Length != 18)
            {
                MessageBox.Show("请输入18位有效身份证号");
            }

            else
            {
                string s1 = "Select UserID from UserInfor Where UserID='" + textBox1.Text + "'";
                SqlDataReader dr = db.DataReader(s1);
                if (dr.Read())
                {
                    MessageBox.Show("会员卡编号不能重复，请重新选择");
                    textBox1.Text = "";
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    string s = "insert into UserInfor values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
                    db.execute(s);
                    MessageBox.Show("新会员注册成功！");
                    Main main = new Main(this.ID.ToString());
                    this.Hide();
                    main.Show();
                }
            }
        }
    }
}
