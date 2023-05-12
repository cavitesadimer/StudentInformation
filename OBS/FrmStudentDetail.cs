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

namespace OBS
{

    public partial class FrmStudentDetail : Form
    {
        public FrmStudentDetail()
        {
            InitializeComponent();
        }

        public string number;
        SqlConnection conneciton = new SqlConnection
            (@"Data Source=DESKTOP-3F6NEMV\SQLEXPRESS;Initial Catalog=db_NoteList;Integrated Security=True");
        private void FrmStudentDetail_Load(object sender, EventArgs e)
        {
            lblStudentNumber.Text = number;
            conneciton.Open();
            SqlCommand command = new SqlCommand("Select * from tbl_StudentNotes where StudentNumber=@stdntNum", conneciton);
            command.Parameters.AddWithValue("@stdntNum", number);

            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                lblNameSurname.Text = reader[2].ToString() + " " + reader[3].ToString();
                lblMidTerm1.Text = reader[4].ToString();
                lblMidTerm2.Text = reader[5].ToString();
                lblFinal.Text = reader[6].ToString();
                lblAverege.Text = reader[7].ToString();
                lblState.Text = reader[8].ToString();
            }
            conneciton.Close();
        }
    }
}
