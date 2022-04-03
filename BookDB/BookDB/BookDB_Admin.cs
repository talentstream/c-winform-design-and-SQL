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
    public partial class BookDB_Admin : Form
    {
        public BookDB_Admin()
        {
            InitializeComponent();
        }

        private void BookDB_Admin_Load(object sender, EventArgs e)
        {

        }

        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admin2 admin2 = new admin2();
            admin2.ShowDialog();
        }
    }
}
