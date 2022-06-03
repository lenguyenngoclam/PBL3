using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DAL;
namespace PBL3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_Post_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Posts.ToList();

        }

        private void button_Role_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Roles.ToList();
        }

        private void button_Ward_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Wards.ToList();
        }

        private void button_Acc_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Accounts.ToList();
        }

        private void button_User_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Users.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Districts.ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Addresses.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Universities.ToList();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Images.ToList();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Comments.ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MyData db = new MyData();
            dataGridView1.DataSource = db.Ratings.ToList();
        }
    }
}
