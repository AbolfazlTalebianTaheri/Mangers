using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manger
{
    public partial class FrmDgvLessons : Form
    {
        public FrmDgvLessons()
        {
            InitializeComponent();
        }

        private void FrmDgvLessons_Load(object sender, EventArgs e)
        {
            dgvLessonName.DataSource = LessonsManger.GetLessons().ToList();
            dgvLessonName.BuildColumns<Lessons>();
        }
    }
}
