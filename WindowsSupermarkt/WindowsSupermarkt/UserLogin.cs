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

namespace WindowsSupermarkt.MyUser
{
    public partial class UserLogin : Form
    {
        DBHelper.DBHelper db = new DBHelper.DBHelper();
        public UserLogin()
        {
            InitializeComponent();
        }

        private void btnsure2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "")
            {
                MessageBox.Show("编号不能为空");
            }
            else
                if (textBox2.Text.Trim() == "")
                {
                    MessageBox.Show("密码不能为空");
                }
                else
                    if (textBox1.Text.Length == 5)
                    {
                        string s = "Select * from UserInfor" +
                            " Where UserID='" + textBox1.Text + "'";


                        // string s = "Select UserCode,UserID,UserPhone,UserNumber where UserInfor.UserName='" + textBox1.Text + "'";
                        SqlDataReader dr = db.DataReader(s);
                        if (dr.Read())
                        {
                            dr.Close();
                            string s1 = "Select * from UserInfor" +
                          " Where UserCode='" + textBox2.Text + "'" +
                          "and UserID='" + textBox1.Text + "'";
                            SqlDataReader dr1 = db.DataReader(s1);

                            if (dr1.Read())
                            {
                                UserMain usermain = new UserMain(dr1[0].ToString());

                                this.Hide();
                                usermain.Show();
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
                            MessageBox.Show("会员卡编号不存在，请重新输入");
                            textBox1.Text = "";
                            textBox2.Text = "";
                            dr.Close();
                        }

                    }
                    else
                        if (textBox1.Text.Length == 2)
                        {
                            string s2 = "Select * from OperInfor" +
                   " Where OperID='" + textBox1.Text + "'";


                            // string s = " Select UserCode,UserID,UserPhone,UsersInfo where UsersInfo.UserName='" + textBox1.Text + "'";
                            SqlDataReader dr2 = db.DataReader(s2);
                            if (dr2.Read())
                            {
                                dr2.Close();
                                string s1 = "Select * from OperInfor" +
                              " Where OperCode='" + textBox2.Text + "'" +
                              "and OperID='" + textBox1.Text + "'";
                                SqlDataReader dr1 = db.DataReader(s1);

                                if (dr1.Read())
                                {

                                    MySystem.Main main = new MySystem.Main(dr1[0].ToString());

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
                                dr2.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("编号不存在，请重新输入");
                            textBox1.Text = "";
                            textBox2.Text = "";

                        }
           
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
