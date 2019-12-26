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

namespace QLSV
{
    public partial class QLSVTK : Form
    {
        public QLSVTK()
        {
            InitializeComponent();
        }
        string strKetNoi = @"Data Source=DESKTOP-AD054TF\SQLEXPRESS; Initial Catalog=Bai1tr113; Integrated Security=True";
        SqlConnection sqlCon;
        SqlCommand sqlCom;
        SqlDataReader sqlRe;

        SqlDataAdapter sqlAdap;
        DataTable dt;
        void KetNoi()
        {
            sqlCon = new SqlConnection(strKetNoi);
            if (sqlCon.State == ConnectionState.Closed)
            {
                sqlCon.Open();
            }
        }
        void NgatKetNoi()
        {
            sqlCon.Close();
        }
        public DataTable taobang(string sql)
        {
            dt = new DataTable();
            sqlAdap = new SqlDataAdapter(sql, sqlCon);
            sqlAdap.Fill(dt);
            return (dt);
        }
        private void QLSVTK_Load(object sender, EventArgs e)
        {
            KetNoi();
            string sql = "select * from MONHOC";
            cbmmh.DataSource = taobang(sql);
            cbmmh.DisplayMember = "MaMH";
        }

        private void btthoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void cbmmh_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = "select * from MONHOC where MaMH='" + cbmmh.Text + "'";
            DataTable d = taobang(s);
            foreach (DataRow hang in d.Rows)
                txttmh.Text = hang["TenMH"].ToString();
            foreach (DataRow hang in d.Rows)
                txtst.Text = hang["SoTiet"].ToString();
            string s2 = "select * from KETQUA where MaMH='" + cbmmh.Text + "'";
            dataGridView1.DataSource = taobang(s2);
        }
    }
}
