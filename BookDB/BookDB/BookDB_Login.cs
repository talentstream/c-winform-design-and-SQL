using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookDB
{
    public partial class BookDB_Login : Form
    {
        public BookDB_Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rBUser_CheckedChanged(object sender, EventArgs e)
        {

        }
        //登录
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tBuser.Text != "" && tBpsw.Text != "")
            {
                Login();
            }
            else
            {
                MessageBox.Show("输入有空项，请重新输入");
            }
        }

        //登录方法
        public void Login()
        {
            //用户
            if (rBuser.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select *from t_user where id='{tBuser.Text}' and psw='{tBpsw.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    Data.UID = dc["id"].ToString();
                    Data.UName = dc["name"].ToString();

                    MessageBox.Show("登陆成功");
                    BookDB_User user = new BookDB_User();

                    this.Hide();
                    user.ShowDialog();
                    this.Show();

                }
                else
                {
                    MessageBox.Show("登陆失败");
                }
                dao.DaoClose();
            }
            //管理员
            if(rBadmin.Checked == true)
            {
                Dao dao = new Dao();
                string sql = $"select *from t_admin where id='{tBuser.Text}' and psw='{tBpsw.Text}'";
                IDataReader dc = dao.read(sql);
                if (dc.Read())
                {
                    MessageBox.Show("登陆成功");

                    BookDB_Admin admin = new BookDB_Admin();

                    this.Hide();
                    admin.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败");
                }
                dao.DaoClose();
            }
        }
    }
}
