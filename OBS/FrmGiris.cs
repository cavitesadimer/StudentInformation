using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OBS
{
    public partial class Student_Entry : Form
    {
        public Student_Entry()
        {
            InitializeComponent();
        }
        private void btn_Enter_Click(object sender, EventArgs e)
        {
            FrmStudentDetail frm = new FrmStudentDetail();
            frm.number = maskedTxtStudentNumber.Text;
            frm.Show();
        }

        private void Student_Entry_Load(object sender, EventArgs e)
        {

        }

        private void maskedTxtStudentNumber_TextChanged(object sender, EventArgs e)
        {
            if (maskedTxtStudentNumber.Text == "9999")
            {
                FrmTeacherDetail frm = new FrmTeacherDetail();
                frm.Show();
            }
        }
    }
}
