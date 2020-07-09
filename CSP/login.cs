using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSP
{
    public partial class login : Form
    {
        dataBase getDB = new dataBase();
        string dbC;
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            getIp.Text = getDB.ip;
            getId.Text = getDB.db_id;
            getPw.Text = getDB.db_pw;
            getDBname.Text = getDB.db_name;
        }

        private void loginDB_Click_1(object sender, EventArgs e)
        {
            getDB.ip = getIp.Text;
            getDB.db_id = getId.Text;
            getDB.db_pw = getPw.Text;
            getDB.db_name = getDBname.Text;

            dbC = getDB.loginDB();
            if (dbC == "done")
            {
                this.Visible = false;
                MainForm mainform = new MainForm();
                mainform.ShowDialog();
                this.Close();
            }
            else if (dbC == "error")
            {
                MessageBox.Show("DB와 연결에 실패했습니다");
            }
            else
            {
                MessageBox.Show("아무런 일도 일어나지 않았습니다");
            }
        }
    }
}
