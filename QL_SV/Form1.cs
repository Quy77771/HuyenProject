using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        string flag; 
        public Form1()
        {
            InitializeComponent();
        }

        DataTable dtSV;
        int index;
        public DataTable createTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("MASV");
            dt.Columns.Add("TENSV");
            dt.Columns.Add("LOP");
            dt.Columns.Add("DIEM");
            return dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LOCKCONTROL();
            dtSV = createTable();
        }
        public void LOCKCONTROL()
        {
            btnTHEM.Enabled = true;
            btnSUA.Enabled = true;
            btnXOA.Enabled = true;
            btnLUU.Enabled = false;
            btnHUY.Enabled = false;

            textMASV.ReadOnly = true;
            textTENSV.ReadOnly = true;
            textDIEM.ReadOnly = true;
            textLOP.ReadOnly = true;

            btnTHEM.Focus();
        }
        public void UNLOCKCONTROL()
        {
            btnTHEM.Enabled = false;
            btnSUA.Enabled = false;
            btnXOA.Enabled = false;
            btnLUU.Enabled = true;
            btnHUY.Enabled = true;

            textMASV.ReadOnly = false;
            textTENSV.ReadOnly = false;
            textDIEM.ReadOnly = false;
            textLOP.ReadOnly = false;

            textMASV.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnTHEM_Click(object sender, EventArgs e)
        {
            UNLOCKCONTROL();
            flag = "ADD";

            textMASV.Text = "";
            textTENSV.Text = "";
            textLOP.Text = "";
            textDIEM.Text = "";
        }

        private void btnSUA_Click(object sender, EventArgs e)
        {
            UNLOCKCONTROL();
            flag = "EDIT";
        }

        private void btnLUU_Click(object sender, EventArgs e)
        {
            if(flag == "ADD")
            {
                if (CHECKDATA())
                {
                    dtSV.Rows.Add(textMASV.Text, textTENSV.Text, textLOP.Text, textDIEM.Text);
                    dataGridSV.DataSource = dtSV;
                    dataGridSV.RefreshEdit();
                }
                
            }
            else if ( flag == "EDIT")
            {
                if (CHECKDATA())
                {
                    dtSV.Rows[index][0] = textMASV.Text;
                    dtSV.Rows[index][1] = textTENSV.Text;
                    dtSV.Rows[index][2] = textLOP.Text;
                    dtSV.Rows[index][3] = textDIEM.Text;
                    dataGridSV.DataSource = dtSV;
                    dataGridSV.RefreshEdit();
                }
            }
            LOCKCONTROL();
        }

        public bool CHECKDATA()
        {
            if (string.IsNullOrWhiteSpace(textMASV.Text))
            {
                MessageBox.Show("NHẬP MÃ SINH VIÊN", "THONG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textMASV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textTENSV.Text))
            {
                MessageBox.Show("NHẬP TÊN", "THONG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textTENSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textLOP.Text))
            {
                MessageBox.Show("NHẬP LỚP", "THONG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textLOP.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textDIEM.Text))
            {
                MessageBox.Show("NHẬP ĐIỂM", "THONG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textDIEM.Focus();
                return false;
            }
            return true;
        }

        private void dataGridSV_SelectionChanged(object sender, EventArgs e)
        {
            index = dataGridSV.CurrentCell.RowIndex;
            DataTable dt = (DataTable)dataGridSV.DataSource;
            if( dt.Rows != null || dt.Rows.Count > 0)
            {
                textMASV.Text = dataGridSV.Rows[index].Cells[0].Value.ToString();
                textTENSV.Text = dataGridSV.Rows[index].Cells[1].Value.ToString();
                textLOP.Text = dataGridSV.Rows[index].Cells[2].Value.ToString();
                textDIEM.Text = dataGridSV.Rows[index].Cells[3].Value.ToString();

            }

        }

        private void btnXOA_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("a diu sua","cảnh báo",MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                dtSV.Rows.RemoveAt(index);
                dataGridSV.DataSource = dtSV;
                dataGridSV.RefreshEdit();
            }
        }
    }
}
