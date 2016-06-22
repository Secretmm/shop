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
    public partial class SystemLogin : Form
    {
        DBHelper.DBHelper db = new DBHelper.DBHelper();
        public SystemLogin()
        {
            InitializeComponent();
        }

        private void btnsure2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空");
            }
            else if (textBox2.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空");
            }
            else
            {
                string s = "Select * from OperInfor" +
                " Where OperID='" + textBox1.Text + "'";


                // string s = " Select UserCode,UserID,UserPhone,UsersInfo where UsersInfo.UserName='" + textBox1.Text + "'";
                SqlDataReader dr = db.DataReader(s);
                if (dr.Read())
                {
                    dr.Close();
                    string s1 = "Select * from OperInfor" +
                  " Where OperCode='" + textBox2.Text + "'" +
                  "and OperID='" + textBox1.Text + "'";
                    SqlDataReader dr1 = db.DataReader(s1);

                    if (dr1.Read())
                    {

                        Main main = new Main(dr1[0].ToString());

                        this.Hide();
                        main.Show();
                        dr1.Close();
                    }
                    else
                    {
                        MessageBox.Show("密码错误，请核对后重新输入");
                        textBox2.Text = "";
                        dr1.Close();
                    }

                }
                else
                {
                    MessageBox.Show("系统操作员编号不存在，请重新输入");
                    textBox1.Text = "";
                    textBox2.Text = "";
                    dr.Close();
                }


            }
        }

        private void SystemLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
