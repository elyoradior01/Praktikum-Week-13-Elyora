using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum_Week_13_Elyora
{
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        String sqlQuery;
        DataTable dtTypePemain = new DataTable();
        int PosisiNow = 0;
        DataTable dtNegara = new DataTable();
        DataTable dtTim = new DataTable();
        DataTable dtNo = new DataTable();



        private void FormPlayer_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT * FROM player";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTypePemain);
            IsiDataPemain(0);
        
            
            sqlQuery = "select n.nation as `Nationality`, p.nationality_id as `Negarah` from player p, nationality n where p.nationality_id = n.nationality_id group by p.nationality_id; ";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNegara);
            IsiDataPemain(0);
            cbnegara.DataSource = dtNegara;
            cbnegara.DisplayMember = "Nationality";
            cbnegara.ValueMember = "Negarah";

            sqlQuery = "SELECT t.team_name as `Team`, p.team_id as `Tim id` from player p, team t where p.team_id = t.team_id group by t.team_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTim);
            cbtim.DataSource = dtTim;
            cbtim.DisplayMember = "Team";
            cbtim.ValueMember = "Tim id";

        }

        public void IsiDataPemain(int Posisi)
        {
            txtboxplayer.Text = dtTypePemain.Rows[Posisi][0].ToString();
            txtboxnama.Text = dtTypePemain.Rows[Posisi][2].ToString();
            dtpultah.Text = dtTypePemain.Rows[Posisi][7].ToString();
            cbnegara.SelectedValue = dtTypePemain.Rows[Posisi][3].ToString();
            cbtim.SelectedValue = dtTypePemain.Rows[Posisi][8].ToString();
            numnotim.Text = dtTypePemain.Rows[Posisi][1].ToString();
            PosisiNow = Posisi;
        }

        private void btnbackbnyk_Click(object sender, EventArgs e)
        {
            IsiDataPemain(0);
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            if (PosisiNow > 0)
            {
                PosisiNow--;
                IsiDataPemain(PosisiNow);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Pertama");
            }

        }

        private void btnmaju_Click(object sender, EventArgs e)
        {
            if (PosisiNow < dtTypePemain.Rows.Count - 1)
            {
                PosisiNow++;
                IsiDataPemain(PosisiNow);
            }
            else
            {
                MessageBox.Show("Data Sudah Data Terakhir");
            }

        }

        private void btnmajubnyk_Click(object sender, EventArgs e)
        {
            IsiDataPemain(dtTypePemain.Rows.Count - 1);

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            
            if (lblavl.Text == "Available")
            {
                sqlQuery = $"UPDATE player SET player_name = '" + txtboxnama.Text + "', team_number = '" + numnotim.Value.ToString() + "', nationality_id = '" + cbnegara.SelectedValue.ToString() + "', team_id = '" + cbtim.SelectedValue.ToString() + "' where player_id = '" + txtboxplayer.Text + "' ";
                sqlConnect.Open();
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlCommand.ExecuteNonQuery();
                sqlConnect.Close();
            }
            else
            {
                MessageBox.Show("No Tim Tidak Tersedia");
            }
            

        }

        private void numnotim_ValueChanged(object sender, EventArgs e)
        {
            dtNo= new DataTable();
            sqlQuery = $"SELECT * FROM player WHERE team_id ='{cbtim.SelectedValue}' and team_number ={numnotim.Value}";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtNo);

            if (dtNo.Rows.Count > 0)
            {
                lblavl.Text = "Not Available";
            }
            else
            {
                lblavl.Text = "Available";
            }
        }
    }
}


