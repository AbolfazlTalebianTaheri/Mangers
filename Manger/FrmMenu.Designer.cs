namespace Mnager
{
    partial class FrmMenu
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
            this.btnPerson = new System.Windows.Forms.Button();
            this.btnStudent = new System.Windows.Forms.Button();
            this.btnViewTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPerson
            // 
            this.btnPerson.Location = new System.Drawing.Point(146, 12);
            this.btnPerson.Name = "btnPerson";
            this.btnPerson.Size = new System.Drawing.Size(78, 42);
            this.btnPerson.TabIndex = 0;
            this.btnPerson.Text = "Person";
            this.btnPerson.UseVisualStyleBackColor = true;
            this.btnPerson.Click += new System.EventHandler(this.btnPerson_Click);
            // 
            // btnStudent
            // 
            this.btnStudent.Location = new System.Drawing.Point(149, 82);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(75, 38);
            this.btnStudent.TabIndex = 1;
            this.btnStudent.Text = "Student";
            this.btnStudent.UseVisualStyleBackColor = true;
            this.btnStudent.Click += new System.EventHandler(this.btnStudent_Click);
            // 
            // btnViewTeacher
            // 
            this.btnViewTeacher.Location = new System.Drawing.Point(149, 142);
            this.btnViewTeacher.Name = "btnViewTeacher";
            this.btnViewTeacher.Size = new System.Drawing.Size(75, 38);
            this.btnViewTeacher.TabIndex = 1;
            this.btnViewTeacher.Text = "Teacher";
            this.btnViewTeacher.UseVisualStyleBackColor = true;
            this.btnViewTeacher.Click += new System.EventHandler(this.btnViewTeacher_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 206);
            this.Controls.Add(this.btnViewTeacher);
            this.Controls.Add(this.btnStudent);
            this.Controls.Add(this.btnPerson);
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMenu_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPerson;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Button btnViewTeacher;
    }
}