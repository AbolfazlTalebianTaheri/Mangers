using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mnager
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (new FrmStudents().ShowDialog() == DialogResult.OK)
                this.Show();
        }
        
        private void btnPerson_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(new FrmPersons().ShowDialog() ==DialogResult.OK)
                this.Show();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = AlertHelper.Question("از خزوج مطمئن هستید ؟");
            if (result == DialogResult.Yes)
                Application.Exit();
            
        }
    }
}
