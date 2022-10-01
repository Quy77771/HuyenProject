using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// cai nay tu may anh
namespace QL_SV
{
    public partial class Form1 : Form
    {
        private bool connectedDatabase = false;
        private SqlConnection sqlConnection;
        public Form1()
        {
            InitializeComponent();
            this.FormClosing += (x, y) => DisconnectDatabase();
        }

        private void LoadForm(object sender, EventArgs e)
        {
            RefreshGridSV();
        }

        private void ConnectDatabase()
        {
            if (connectedDatabase)
                return;

            String str = $"Server={Const.SEVER_NAME};Database={Const.DATABASE_NAME};Integrated Security=true";
            sqlConnection = new SqlConnection(str);
            sqlConnection.Open();
            connectedDatabase = true;
        }

        private void DisconnectDatabase()
        {
            if (!connectedDatabase)
                return;

            sqlConnection.Close();
            connectedDatabase = false;
        }
        private DataTable GetDataFromDatabase()
        {
            ConnectDatabase();

            string query = "SELECT * FROM StudentInfo";
            DataTable dataTable = new DataTable();

            using (SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                using (SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd))
                    dataAdapter.Fill(dataTable);
            }

            return dataTable;
        }

        private void ClearAllInfoStudentTextBox()
        {
            textMASV.Text = string.Empty;
            textTENSV.Text = string.Empty;
            textLOP.Text = string.Empty;
            textDIEM.Text = string.Empty;
        }

        private void RefreshGridSV()
        {
            dataGridSV.DataSource = GetDataFromDatabase();
        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textMASV.Text))
            {
                MessageBox.Show("Student ID mustn't be left blank", "Save fail", MessageBoxButtons.OK);
                return;
            }
            ConnectDatabase();

            string query = $"INSERT INTO {Const.TABLE_ACCESS} ({Const.COL_MASV}, {Const.COL_TENSV}, {Const.COL_LOP}, {Const.COL_DIEM})" +
                                                    $"VALUES ('{textMASV.Text}', '{textTENSV.Text}', '{textLOP.Text}', {textDIEM.Text})";

            using(SqlCommand cmd = new SqlCommand(query, sqlConnection))
            {
                cmd.ExecuteNonQuery();
            }

            ClearAllInfoStudentTextBox();
            RefreshGridSV();
        }
    }
}
