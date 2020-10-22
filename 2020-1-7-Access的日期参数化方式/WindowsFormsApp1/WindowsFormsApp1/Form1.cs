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

using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Access的日期比较，采用参数化的方式如下
            //注意1.采用依然采用@而不是？
            //    2.把datatime型的数据转成string赋给参数，不需要转换成datatime型数据access似乎自动识别了，
            //并没有采用##号来表示日期型数据，怪异，如果转换反而错了。
            //    3.如果不采用参数方式这样写 string strSQL = "select * from table1 where time between #2019-2-12 12:00:00 # and #2019-2-15 12:00:00 #";
            //    4.采用拼接方式strSQL = "select * from table1 where time between #" + strStart + "# and #" + strEnd + "#";
            //    5.从satckoverflow上找到原因，在参数化时要忽略#和‘。屏蔽的语句也是ok的。
            string strSQL = "select * from table1 where time between @value1 and @value2";

            string strConnection = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Program.strPath + "\\test.mdb;";

            OleDbConnection Oconn = new OleDbConnection(strConnection);

            OleDbCommand Ocmd = new OleDbCommand(strSQL, Oconn);
            Ocmd.Parameters.AddWithValue("@value1", SqlDbType.VarChar);
            Ocmd.Parameters.AddWithValue("@value2", SqlDbType.VarChar);
            Ocmd.Parameters["@value1"].Value = dtStart.Value.ToShortDateString();
            Ocmd.Parameters["@value2"].Value = dtEnd.Value.ToShortDateString();
            //Ocmd.Parameters.AddWithValue("@value1", SqlDbType.Date);
            //Ocmd.Parameters.AddWithValue("@value2", SqlDbType.Date);
            //Ocmd.Parameters["@value1"].Value = dtStart.Value.ToShortDateString();
            //Ocmd.Parameters["@value2"].Value = dtEnd.Value.ToShortDateString();
            
            OleDbDataAdapter Adapter = new OleDbDataAdapter(Ocmd);
            DataSet dst = new DataSet();
            Adapter.Fill(dst, "table1");
         

            dataGridView1.DataSource = dst;
            dataGridView1.DataMember = "table1";
            dataGridView1.Refresh();

        }
    }
}
