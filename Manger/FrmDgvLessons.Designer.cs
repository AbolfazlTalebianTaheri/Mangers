namespace Manger
{
    partial class FrmDgvLessons
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
            this.dgvLessonName = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessonName)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLessonName
            // 
            this.dgvLessonName.AllowUserToAddRows = false;
            this.dgvLessonName.AllowUserToDeleteRows = false;
            this.dgvLessonName.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLessonName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLessonName.Location = new System.Drawing.Point(0, 0);
            this.dgvLessonName.Name = "dgvLessonName";
            this.dgvLessonName.ReadOnly = true;
            this.dgvLessonName.RowHeadersWidth = 51;
            this.dgvLessonName.RowTemplate.Height = 24;
            this.dgvLessonName.Size = new System.Drawing.Size(727, 411);
            this.dgvLessonName.TabIndex = 0;
            // 
            // FrmDgvLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 411);
            this.Controls.Add(this.dgvLessonName);
            this.Name = "FrmDgvLessons";
            this.Text = "FrmDgvLessons";
            this.Load += new System.EventHandler(this.FrmDgvLessons_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLessonName)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLessonName;
    }
}