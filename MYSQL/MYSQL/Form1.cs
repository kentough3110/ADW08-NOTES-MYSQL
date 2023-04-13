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

namespace MYSQL
{
    public partial class Form1 : Form
    {
        MySqlConnection sqlConnection;
        MySqlCommand sqlCommand;
        //menerima query
        MySqlDataAdapter sqlDataAdapter;
        //menerima hasil
        string connectionString;
        string sqlQuery;
        DataTable dtPemain = new DataTable();
        DataTable dtNationality = new DataTable();
        DataTable dtTeam = new DataTable();
        public Form1()
        {
            InitializeComponent();
            connectionString = "server=localhost;uid=root;pwd=;database=premier_league";
            sqlConnection = new MySqlConnection(connectionString);
            sqlConnection.Open(); //for DML 

            sqlQuery = "select player_id as 'ID Player', player_name as 'Player Name', height as 'Height', weight as 'Weight', team_name as 'Team Name'\r\nfrom player\r\ninner join team\r\non player.team_id = team.team_id\r\norder by 1 asc;";
            sqlCommand = new MySqlCommand(sqlQuery,sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtPemain);
            dgv_premier.DataSource = dtPemain;

            sqlQuery = "select abv as 'Abrevation', nation as 'Nation' from nationality;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtNationality);
            cmbBox_nationality.DataSource = dtNationality;
            cmbBox_nationality.ValueMember = "nation";
            cmbBox_nationality.DisplayMember = "abrevation";

            sqlQuery = "select team_name as 'Team Name' from team;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtTeam);
            cmbBox_teamName.DataSource = dtTeam;
            cmbBox_teamName.ValueMember = "team name";
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label_value.Text = cmbBox_nationality.SelectedValue.ToString();
        }

        private void cmbBox_teamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            dtPemain = new DataTable();
            sqlQuery = "select player_id as 'ID Player', player_name as 'Player Name', height as 'Height', weight as 'Weight', team_name as 'Team Name' from player inner join team on player.team_id = team.team_id and team_name = '"+ cmbBox_teamName.SelectedValue.ToString() +"' order by 1 asc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnection);
            sqlDataAdapter = new MySqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dtPemain);
            dgv_premier.DataSource = dtPemain;
        }
    }
}
