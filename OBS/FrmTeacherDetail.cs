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
    public partial class FrmTeacherDetail : Form
    {
        public FrmTeacherDetail()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection
            (@"Data Source=DESKTOP-3F6NEMV\SQLEXPRESS;Initial Catalog=db_NoteList;Integrated Security=True");

        private void FrmTeacherDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_NoteListDataSet.tbl_StudentNotes' table. You can move, or remove it, as needed.
            this.tbl_StudentNotesTableAdapter.Fill(this.db_NoteListDataSet.tbl_StudentNotes);

        }



        private void button1_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into tbl_StudentNotes(StudentNumber,Name,Surname) values (@p1,@p2,@p3)", connection);
            command.Parameters.AddWithValue("@p1", maskedTxtBoxNumber.Text);
            command.Parameters.AddWithValue("@p2", txtBoxName.Text);
            command.Parameters.AddWithValue("@p3", txtBoxSurname.Text);
            command.ExecuteNonQuery();

            connection.Close();
            MessageBox.Show("Student Added");
            this.tbl_StudentNotesTableAdapter.Fill(this.db_NoteListDataSet.tbl_StudentNotes);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose = dataGridView1.SelectedCells[0].RowIndex;
            maskedTxtBoxNumber.Text = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            txtBoxName.Text = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            txtBoxSurname.Text = dataGridView1.Rows[choose].Cells[3].Value.ToString();

            txtBoxMidTerm.Text = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            txtBoxMidterm2.Text = dataGridView1.Rows[choose].Cells[5].Value.ToString();
            txtBoxFinal.Text = dataGridView1.Rows[choose].Cells[6].Value.ToString();
        }

        private void btnUpdateNotes_Click(object sender, EventArgs e)
        {
            double average, exam1, exam2, final;
            string state;
            exam1 = Convert.ToDouble(txtBoxMidTerm.Text);
            exam2 = Convert.ToDouble(txtBoxMidterm2.Text);
            final = Convert.ToDouble(txtBoxFinal.Text);

            average = (exam1 * 0.3 + exam2 * 0.3 + final * 0.4);
            lblStudentGPA.Text = average.ToString();

            if (average >= 50)
            {
                state = "True";
            }else { state = "False"; }

            connection.Open();
            SqlCommand command = new SqlCommand
                ("update tbl_StudentNotes set Midterm1=@P1,Midterm2=@P2,Final=@P3,GPA=@P4,State=@P5 where StudentNumber=@P6",connection);
            command.Parameters.AddWithValue("@P1", txtBoxMidTerm.Text);
            command.Parameters.AddWithValue("@P2", txtBoxMidterm2.Text);
            command.Parameters.AddWithValue("@P3", txtBoxFinal.Text);
            command.Parameters.AddWithValue("@P4", decimal.Parse(lblStudentGPA.Text));
            command.Parameters.AddWithValue("@P5", state);
            command.Parameters.AddWithValue("@P6",maskedTxtBoxNumber.Text);
            lblState.Text = state;

            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Notes Updated");
            this.tbl_StudentNotesTableAdapter.Fill(this.db_NoteListDataSet.tbl_StudentNotes);


        }

        
    }
}
