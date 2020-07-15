using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSP
{
    public partial class MainForm : Form
    {
        public int type = 1;
        public int selectedOredrId;//1 - order 2 - student 3 - notebook
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            string result = textBox1.Text;
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(new dataBase().path))
            {
                conn.Open();
                string sql = "SELECT * FROM ordernotebook WHERE stuid=" + textBox1.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "order");
            }
            dataGridView1.DataSource = ds.Tables[0];
            type = 1;

        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(new dataBase().path))
            {
                conn.Open();
                string sql = "SELECT * FROM ordernotebook";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "order");
            }
            dataGridView1.DataSource = ds.Tables[0];
            
        }

        private void btnTime_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("조회할 월을 입력하세요", "학생 노트북 대여 관리 시스템", "1~12");
            int month = 1;
            try // 숫자를 입력한게 맞는지 확인
            {
                month = int.Parse(result);
            } catch
            {
                MessageBox.Show("제대로 입력한게 맞으신가요?\n확인이 필요합니다.");
                return;
            }
            
            if(month < 1 || month > 12)
            {
                MessageBox.Show("제대로 입력한게 맞으신가요?\n확인이 필요합니다.");
                return;
            }

            result = Interaction.InputBox("조회할 주를 입력하세요", "학생 노트북 대여 관리 시스템", "1~4");
            int refus = 1;
            try // 숫자를 입력한게 맞는지 확인
            {
                refus = int.Parse(result);
            }
            catch
            {
                MessageBox.Show("제대로 입력한게 맞으신가요?\n확인이 필요합니다.");
                return;
            }

            if (refus < 1 || refus > 4)
            {
                MessageBox.Show("제대로 입력한게 맞으신가요?\n확인이 필요합니다.");
                return;
            }
            string search_dt = "";
            if (month < 10)
            {
                search_dt = "0" + month + "/" + refus;
            }
            else
            {
                search_dt = month + "/" + refus;
            }
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(new dataBase().path))
            {
                conn.Open();
                string sql = "SELECT * FROM ordernotebook WHERE date='" + search_dt + "';";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "order");
            }
            dataGridView1.DataSource = ds.Tables[0];
            type = 1;
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string result = Interaction.InputBox("조회할 학생의 이름을 입력해주세요", "학생 노트북 대여 관리 시스템", "홍길동");

            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(new dataBase().path))
            {
                conn.Open();
                string sql = "SELECT * FROM student, ordernotebook WHERE ordernotebook.stuid = student.stuid AND stuname = '" + result + "';";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "ordernotebook");
            }
            dataGridView1.DataSource = ds.Tables[0];
            type = 1;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
       
            string result = inputName.Text;
            double dt = 1.0;
            string date = DateTime.Now.ToString("MM") + "/" + GetWeekOfMonth(DateTime.Now);
            try // 숫자를 입력한게 맞는지 확인
            {
                dt = double.Parse(result.Split('-')[0]);
                dt = double.Parse(result.Split('-')[1]);
            }
            catch
            {
                MessageBox.Show("제대로 입력한게 맞으신가요?\n확인이 필요합니다.");
                return;
            }
            string[] res = result.Split('-');
            string stid = res[0], nbid = res[1];

            using (SqlConnection conn = new SqlConnection(new dataBase().path))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();

                command.Connection = conn;
                command.CommandText = "INSERT INTO ordernotebook(date, stuid, notebookid) VALUES('" + date + "','" + stid + "','" + nbid + "');";
                command.ExecuteNonQuery();

                btnAll_Click(null, null);
            }

        }

        private void btn_del_Click(object sender, EventArgs e)
        {
        
            using (SqlConnection conn = new SqlConnection(new dataBase().path))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "DELETE FROM ordernotebook WHERE orderid = " + selectedOredrId;
                command.ExecuteNonQuery();

                btnAll_Click(null, null);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(type == 1)
            {
                selectedOredrId = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["orderid"].Value.ToString());
                inputString.Text = dataGridView1.Rows[e.RowIndex].Cells["stuid"].Value.ToString() +"-"+ dataGridView1.Rows[e.RowIndex].Cells["notebookid"].Value.ToString();
            }
            else if (type == 2)
            {
         
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["stuid"].Value.ToString();
            }
            else
            {
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["notebookid"].Value.ToString();
            }
           
        }

        private void stuList_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(new dataBase().path))
            {
                conn.Open();
                string sql = "SELECT * FROM student";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "student");
            }
            dataGridView1.DataSource = ds.Tables[0];
            type = 2;
        }

        private void stuAdd_Click(object sender, EventArgs e)
        {
            int stuid = 0;
            string name = null;
            string result1 = Interaction.InputBox("추가할 학생의 id를 입력하세요", "학생 노트북 대여 관리 시스템", "학생id");
            string result2 = Interaction.InputBox("추가할 학생의 이름을 입력해주세요", "학생 노트북 대여 관리 시스템", "전우치");
            try
            {
                stuid = int.Parse(result1);
                name = result2;
            }
            catch
            {
                MessageBox.Show("제대로 입력한게 맞으신가요?\n확인이 필요합니다.");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(new dataBase().path))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();

                    command.Connection = conn;
                    command.CommandText = "INSERT INTO student(stuid, stuname) VALUES('" + stuid + "','" + name + "');";
                    command.ExecuteNonQuery();

                    stuList_Click(null, null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("문제가 발생했습니다.\n" + ex);
            }
        }

        private void stuDel_Click(object sender, EventArgs e)
        {
            string stuid = textBox2.Text;
            if (stuid == null)
            {
                MessageBox.Show("데이터 테이블에서 아이템을 선택하세요.");
                return;
            }
            using (SqlConnection conn = new SqlConnection(new dataBase().path))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "DELETE FROM student WHERE stuid = " + stuid;
                command.ExecuteNonQuery();

                stuList_Click(null, null);
            }
        }

        private void notList_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            using (SqlConnection conn = new SqlConnection(new dataBase().path))
            {
                conn.Open();
                string sql = "SELECT * FROM notebook";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                adapter.Fill(ds, "notebook");
            }
            dataGridView1.DataSource = ds.Tables[0];
            type = 3;
        }

        private void notAdd_Click(object sender, EventArgs e)
        {
            int noteid = 0;
            string model = null;
            string result1 = Interaction.InputBox("추가할 노트북의 id를 입력하세요", "학생 노트북 대여 관리 시스템", "노트북id");
            string result2 = Interaction.InputBox("추가할 노트북의 모델을 입력해주세요", "학생 노트북 대여 관리 시스템", "한성컴레기");
            try
            {
                noteid = int.Parse(result1);
                model = result2;
            } catch
            {
                MessageBox.Show("제대로 입력한게 맞으신가요?\n확인이 필요합니다.");
                return;
            }
            try
            {
                using (SqlConnection conn = new SqlConnection(new dataBase().path))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand();

                    command.Connection = conn;
                    command.CommandText = "INSERT INTO notebook(notebookid, model) VALUES('" + noteid + "','" + model + "');";
                    command.ExecuteNonQuery();

                    notList_Click(null, null);
                }
            } catch (Exception ex)
            {
                MessageBox.Show("문제가 발생했습니다.\n" + ex);
            }
        }

        private void notDel_Click(object sender, EventArgs e)
        {
            string noteid = textBox2.Text;
            if (noteid == null)
            {
                MessageBox.Show("데이터 테이블에서 아이템을 선택하세요.");
                return;
            }
            
            using (SqlConnection conn = new SqlConnection(new dataBase().path))
            {
                conn.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = conn;
                command.CommandText = "DELETE FROM notebook WHERE notebookid = " + noteid;
                command.ExecuteNonQuery();

                notList_Click(null, null);
            }
        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {

        }

        public int GetWeekNumber(int year, int month, int day, DayOfWeek dayOfWeek)
        {
            DateTime calculationDate = new DateTime(year, month, day); //주차를 구할 일자 
            DateTime standardDate = new DateTime(year, 1, 1);   //기준일 
            Calendar calendarCalc = CultureInfo.CurrentCulture.Calendar;
            int weekNumber = calendarCalc.GetWeekOfYear(calculationDate, CalendarWeekRule.FirstDay, dayOfWeek)
                 - calendarCalc.GetWeekOfYear(standardDate, CalendarWeekRule.FirstDay, dayOfWeek) + 1;
            return weekNumber;
        }

        public static int GetWeekOfMonth(DateTime dt)
        {
            DateTime now = dt;

            int basisWeekOfDay = (now.Day - 1) % 7;
            int thisWeek = (int)now.DayOfWeek;

            double val = Math.Ceiling((double)now.Day / 7);

            if (basisWeekOfDay > thisWeek) val++;

            return Convert.ToInt32(val);

        }


    }
    
}


