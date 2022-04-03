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
    public partial class BookDB_User : Form
    {
        public BookDB_User()
        {
            InitializeComponent();
            label1.Text = $"欢迎{Data.UName}进入图书管理系统";
        }

        private void 图书查看和借阅ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user2 user2 = new user2();

            user2.ShowDialog();
        }

        private void 当前图书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user3 user3 = new user3();

            user3.ShowDialog();
        }

        private void 帮助ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("并没有欸嘿😋");
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
