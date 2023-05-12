namespace OBS
{
    partial class Student_Entry
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
            this.lblStudent_Num = new System.Windows.Forms.Label();
            this.maskedTxtStudentNumber = new System.Windows.Forms.MaskedTextBox();
            this.btn_Enter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStudent_Num
            // 
            this.lblStudent_Num.AutoSize = true;
            this.lblStudent_Num.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblStudent_Num.Location = new System.Drawing.Point(71, 97);
            this.lblStudent_Num.Name = "lblStudent_Num";
            this.lblStudent_Num.Size = new System.Drawing.Size(158, 24);
            this.lblStudent_Num.TabIndex = 0;
            this.lblStudent_Num.Text = "Öğrenci Numara";
            // 
            // maskedTxtStudentNumber
            // 
            this.maskedTxtStudentNumber.Location = new System.Drawing.Point(236, 97);
            this.maskedTxtStudentNumber.Mask = "0000";
            this.maskedTxtStudentNumber.Name = "maskedTxtStudentNumber";
            this.maskedTxtStudentNumber.Size = new System.Drawing.Size(130, 30);
            this.maskedTxtStudentNumber.TabIndex = 1;
            this.maskedTxtStudentNumber.ValidatingType = typeof(int);
            this.maskedTxtStudentNumber.TextChanged += new System.EventHandler(this.maskedTxtStudentNumber_TextChanged);
            // 
            // btn_Enter
            // 
            this.btn_Enter.Location = new System.Drawing.Point(236, 133);
            this.btn_Enter.Name = "btn_Enter";
            this.btn_Enter.Size = new System.Drawing.Size(130, 30);
            this.btn_Enter.TabIndex = 2;
            this.btn_Enter.Text = "Giriş Yap";
            this.btn_Enter.UseVisualStyleBackColor = true;
            this.btn_Enter.Click += new System.EventHandler(this.btn_Enter_Click);
            // 
            // Student_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.btn_Enter);
            this.Controls.Add(this.maskedTxtStudentNumber);
            this.Controls.Add(this.lblStudent_Num);
            this.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Student_Entry";
            this.Text = "Öğrenci Giriş";
            this.Load += new System.EventHandler(this.Student_Entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent_Num;
        private System.Windows.Forms.MaskedTextBox maskedTxtStudentNumber;
        private System.Windows.Forms.Button btn_Enter;
    }
}

