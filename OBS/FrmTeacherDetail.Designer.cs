namespace OBS
{
    partial class FrmTeacherDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtBoxSurname = new System.Windows.Forms.TextBox();
            this.txtBoxName = new System.Windows.Forms.TextBox();
            this.maskedTxtBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnUpdateNotes = new System.Windows.Forms.Button();
            this.txtBoxFinal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxMidterm2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxMidTerm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblState = new System.Windows.Forms.Label();
            this.lblStudentGPA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ıdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midterm1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midterm2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gPADataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tblStudentNotesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.db_NoteListDataSet = new OBS.db_NoteListDataSet();
            this.tbl_StudentNotesTableAdapter = new OBS.db_NoteListDataSetTableAdapters.tbl_StudentNotesTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentNotesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_NoteListDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtBoxSurname);
            this.groupBox1.Controls.Add(this.txtBoxName);
            this.groupBox1.Controls.Add(this.maskedTxtBoxNumber);
            this.groupBox1.Controls.Add(this.lblSurname);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblNumber);
            this.groupBox1.Location = new System.Drawing.Point(39, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 240);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student İnformation";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(124, 177);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 63);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxSurname
            // 
            this.txtBoxSurname.Location = new System.Drawing.Point(124, 126);
            this.txtBoxSurname.Name = "txtBoxSurname";
            this.txtBoxSurname.Size = new System.Drawing.Size(120, 30);
            this.txtBoxSurname.TabIndex = 6;
            // 
            // txtBoxName
            // 
            this.txtBoxName.Location = new System.Drawing.Point(124, 87);
            this.txtBoxName.Name = "txtBoxName";
            this.txtBoxName.Size = new System.Drawing.Size(120, 30);
            this.txtBoxName.TabIndex = 5;
            // 
            // maskedTxtBoxNumber
            // 
            this.maskedTxtBoxNumber.Location = new System.Drawing.Point(124, 47);
            this.maskedTxtBoxNumber.Name = "maskedTxtBoxNumber";
            this.maskedTxtBoxNumber.Size = new System.Drawing.Size(120, 30);
            this.maskedTxtBoxNumber.TabIndex = 4;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Location = new System.Drawing.Point(17, 128);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(98, 25);
            this.lblSurname.TabIndex = 2;
            this.lblSurname.Text = "Surname:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 87);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(70, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(17, 47);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(87, 25);
            this.lblNumber.TabIndex = 0;
            this.lblNumber.Text = "Number:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnUpdateNotes);
            this.groupBox2.Controls.Add(this.txtBoxFinal);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtBoxMidterm2);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBoxMidTerm);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(372, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 240);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exams";
            // 
            // btnUpdateNotes
            // 
            this.btnUpdateNotes.Location = new System.Drawing.Point(119, 177);
            this.btnUpdateNotes.Name = "btnUpdateNotes";
            this.btnUpdateNotes.Size = new System.Drawing.Size(115, 63);
            this.btnUpdateNotes.TabIndex = 13;
            this.btnUpdateNotes.Text = "Update Notes";
            this.btnUpdateNotes.UseVisualStyleBackColor = true;
            this.btnUpdateNotes.Click += new System.EventHandler(this.btnUpdateNotes_Click);
            // 
            // txtBoxFinal
            // 
            this.txtBoxFinal.Location = new System.Drawing.Point(119, 128);
            this.txtBoxFinal.Name = "txtBoxFinal";
            this.txtBoxFinal.Size = new System.Drawing.Size(115, 30);
            this.txtBoxFinal.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "Final:";
            // 
            // txtBoxMidterm2
            // 
            this.txtBoxMidterm2.Location = new System.Drawing.Point(119, 87);
            this.txtBoxMidterm2.Name = "txtBoxMidterm2";
            this.txtBoxMidterm2.Size = new System.Drawing.Size(115, 30);
            this.txtBoxMidterm2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Midterm2:";
            // 
            // txtBoxMidTerm
            // 
            this.txtBoxMidTerm.Location = new System.Drawing.Point(119, 47);
            this.txtBoxMidTerm.Name = "txtBoxMidTerm";
            this.txtBoxMidTerm.Size = new System.Drawing.Size(115, 30);
            this.txtBoxMidTerm.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Midterm1:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblState);
            this.groupBox3.Controls.Add(this.lblStudentGPA);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(750, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(270, 252);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Info";
            //this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(176, 92);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(34, 25);
            this.lblState.TabIndex = 15;
            this.lblState.Text = "00";
            // 
            // lblStudentGPA
            // 
            this.lblStudentGPA.AutoSize = true;
            this.lblStudentGPA.Location = new System.Drawing.Point(176, 52);
            this.lblStudentGPA.Name = "lblStudentGPA";
            this.lblStudentGPA.Size = new System.Drawing.Size(34, 25);
            this.lblStudentGPA.TabIndex = 14;
            this.lblStudentGPA.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Student State:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Student GPA:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(39, 277);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1094, 280);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Class Info";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıdDataGridViewTextBoxColumn,
            this.studentNumberDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.surnameDataGridViewTextBoxColumn,
            this.midterm1DataGridViewTextBoxColumn,
            this.midterm2DataGridViewTextBoxColumn,
            this.finalDataGridViewTextBoxColumn,
            this.gPADataGridViewTextBoxColumn,
            this.stateDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tblStudentNotesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 251);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ıdDataGridViewTextBoxColumn
            // 
            this.ıdDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.ıdDataGridViewTextBoxColumn.HeaderText = "Id";
            this.ıdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ıdDataGridViewTextBoxColumn.Name = "ıdDataGridViewTextBoxColumn";
            this.ıdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentNumberDataGridViewTextBoxColumn
            // 
            this.studentNumberDataGridViewTextBoxColumn.DataPropertyName = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.HeaderText = "StudentNumber";
            this.studentNumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.studentNumberDataGridViewTextBoxColumn.Name = "studentNumberDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // surnameDataGridViewTextBoxColumn
            // 
            this.surnameDataGridViewTextBoxColumn.DataPropertyName = "Surname";
            this.surnameDataGridViewTextBoxColumn.HeaderText = "Surname";
            this.surnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.surnameDataGridViewTextBoxColumn.Name = "surnameDataGridViewTextBoxColumn";
            // 
            // midterm1DataGridViewTextBoxColumn
            // 
            this.midterm1DataGridViewTextBoxColumn.DataPropertyName = "Midterm1";
            this.midterm1DataGridViewTextBoxColumn.HeaderText = "Midterm1";
            this.midterm1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midterm1DataGridViewTextBoxColumn.Name = "midterm1DataGridViewTextBoxColumn";
            // 
            // midterm2DataGridViewTextBoxColumn
            // 
            this.midterm2DataGridViewTextBoxColumn.DataPropertyName = "Midterm2";
            this.midterm2DataGridViewTextBoxColumn.HeaderText = "Midterm2";
            this.midterm2DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.midterm2DataGridViewTextBoxColumn.Name = "midterm2DataGridViewTextBoxColumn";
            // 
            // finalDataGridViewTextBoxColumn
            // 
            this.finalDataGridViewTextBoxColumn.DataPropertyName = "Final";
            this.finalDataGridViewTextBoxColumn.HeaderText = "Final";
            this.finalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finalDataGridViewTextBoxColumn.Name = "finalDataGridViewTextBoxColumn";
            // 
            // gPADataGridViewTextBoxColumn
            // 
            this.gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            this.gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            this.gPADataGridViewTextBoxColumn.MinimumWidth = 6;
            this.gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            // 
            // stateDataGridViewCheckBoxColumn
            // 
            this.stateDataGridViewCheckBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewCheckBoxColumn.HeaderText = "State";
            this.stateDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.stateDataGridViewCheckBoxColumn.Name = "stateDataGridViewCheckBoxColumn";
            // 
            // tblStudentNotesBindingSource
            // 
            this.tblStudentNotesBindingSource.DataMember = "tbl_StudentNotes";
            this.tblStudentNotesBindingSource.DataSource = this.db_NoteListDataSet;
            // 
            // db_NoteListDataSet
            // 
            this.db_NoteListDataSet.DataSetName = "db_NoteListDataSet";
            this.db_NoteListDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_StudentNotesTableAdapter
            // 
            this.tbl_StudentNotesTableAdapter.ClearBeforeFill = true;
            // 
            // FrmTeacherDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmTeacherDetail";
            this.Text = "FrmTeacherDetail";
            this.Load += new System.EventHandler(this.FrmTeacherDetail_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStudentNotesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.db_NoteListDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtBoxSurname;
        private System.Windows.Forms.TextBox txtBoxName;
        private System.Windows.Forms.MaskedTextBox maskedTxtBoxNumber;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUpdateNotes;
        private System.Windows.Forms.TextBox txtBoxFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxMidterm2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxMidTerm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label lblStudentGPA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private db_NoteListDataSet db_NoteListDataSet;
        private System.Windows.Forms.BindingSource tblStudentNotesBindingSource;
        private db_NoteListDataSetTableAdapters.tbl_StudentNotesTableAdapter tbl_StudentNotesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midterm1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn midterm2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn stateDataGridViewCheckBoxColumn;
    }
}