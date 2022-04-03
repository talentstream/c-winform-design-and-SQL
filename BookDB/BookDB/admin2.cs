﻿using System;
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
    public partial class admin2 : Form
    {
        public admin2()
        {
            InitializeComponent();
        }

        private void admin2_Load(object sender, EventArgs e)
        {
            ReadTable();
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        //从数据库中读取数据显示在表格控件中
        public void ReadTable()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = "select * from t_book";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(
                    dc[0].ToString(),
                    dc[1].ToString(),
                    dc[2].ToString(),
                    dc[3].ToString(),
                    dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        public void ReadTableID()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select * from t_book where id='{tBSearchById.Text}'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(
                    dc[0].ToString(),
                    dc[1].ToString(),
                    dc[2].ToString(),
                    dc[3].ToString(),
                    dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        public void ReadTableName()
        {
            dataGridView1.Rows.Clear();//清空旧数据
            Dao dao = new Dao();
            string sql = $"select * from t_book where name like '%{tBSearchByName.Text}%'";
            IDataReader dc = dao.read(sql);
            while (dc.Read())
            {
                dataGridView1.Rows.Add(
                    dc[0].ToString(),
                    dc[1].ToString(),
                    dc[2].ToString(),
                    dc[3].ToString(),
                    dc[4].ToString());
            }
            dc.Close();
            dao.DaoClose();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除吗？","信息提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                if(dr == DialogResult.OK)
                {
                    string sql = $"delete from t_book where id='{id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功");
                        ReadTable();
                    }
                    else
                    {
                        MessageBox.Show("删除失败"+sql);
                    }
                    dao.DaoClose();
                }                
            }
            catch
            {
                MessageBox.Show("请先选择在表格中的图书！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            admin21 admin21 = new admin21();
            admin21.ShowDialog();
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString()+ dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string author = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string press = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string number = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                admin23 admin23 = new admin23(id, name, author, press, number);
                admin23.ShowDialog();
                ReadTable();
            }
            catch
            {
                MessageBox.Show("ERROR");
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ReadTable();
            tBSearchById.Text = "";
            tBSearchByName.Text = "";
        }

        private void btnSerachById_Click(object sender, EventArgs e)
        {
            ReadTableID();
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            ReadTableName();
        }
    }
}
