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
    public partial class UserMain : Form
    {
        DBHelper.DBHelper db = new DBHelper.DBHelper();
        string ID, Code, Phone, Number;//只是定义这几个变量
        public UserMain()
        {
            InitializeComponent();
        }
        public UserMain(string id)//（）中的值为userLogin的dr[0]实例化
        {
            ID = id;//id为UserLogin中dr1[0]的值
            string s = "select UserCode,UserPhone,UserNumber from UserInfor where UserID='" + this.ID.ToString() + "'";
            SqlDataReader dr = db.DataReader(s);
            if (dr.Read())
            {
               Code = dr[0].ToString();//这里的0，1，2的数字顺序以上方的 string s为主
               Phone = dr[1].ToString();
               Number = dr[2].ToString();
               
            }
            else
            {

            }
            dr.Close();
            
          
            InitializeComponent();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定退出？", "退出",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
            {
                this.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModifyCode modifycode = new ModifyCode(this.ID .ToString (),this.Code.ToString ());
            this.Hide();
            modifycode.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void UserMain_Load(object sender, EventArgs e)
        {
            textBox1.Text = ID;
            textBox2.Text = Code;
            textBox6.Text = Phone;
            textBox7.Text = Number;
        }

        private void 我的购物ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 超市最新活动BToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {


        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ModifyPhone modifyphone = new ModifyPhone(this.ID.ToString(), this.Phone.ToString());
            this.Hide();
            modifyphone.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShoppingList shopinglist = new ShoppingList();
            this.Hide();
            shopinglist.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivityShow activityshow = new ActivityShow();
            this.Hide();
            activityshow.Show();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {

        }
    }
}
