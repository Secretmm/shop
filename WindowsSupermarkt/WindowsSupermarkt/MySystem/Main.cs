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
    public partial class Main : Form
    {
        DBHelper.DBHelper db = new DBHelper.DBHelper();
        string  ID,Na,Code,Phone;
          public Main(string id)
        {
            ID = id;
            string s = "select OperCode,OperPhone,OperName from OperInfor where OperID='" + this.ID.ToString() + "'";
            SqlDataReader dr = db.DataReader(s);
            if (dr.Read())
            {
                Code = dr[0].ToString();//这里的0，1，2的数字顺序以上方的 string s为主
                Phone = dr[1].ToString();
                Na = dr[2].ToString();

            }
            else
            {

            }
            dr.Close();
            InitializeComponent();

        }

        private void button4_Click(object sender, EventArgs e)
        {
          SystemModifyCode systemmodifycode = new SystemModifyCode(this.ID.ToString(), this.Code.ToString());
            this.Hide();
            systemmodifycode.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            txtID.Text = ID;
            txtName.Text = Na;
            txtCode.Text = Code;
            txtPhone.Text = Phone;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SystemModifyPhone sysmodifyphone = new SystemModifyPhone(this.ID.ToString(), this.Phone.ToString());
            this.Hide();
            sysmodifyphone.Show();
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

        private void button9_Click(object sender, EventArgs e)
        {
            this .Hide ();
            NewUser newuser = new NewUser(this.ID.ToString());
            newuser.Show();
        }
    }
}
