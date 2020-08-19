using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalManagement
{
    public partial class FormDoctor : Form
    {
        private Class_table_doctor ListDoctor = new Class_table_doctor(StaticData.SeverConnect.Conncet);

        public FormDoctor()
        {
            InitializeComponent();
            GridView.AutoGenerateColumns = false;
            GridView.DataSource = ListDoctor.getBinbSource();
            ListDoctor.getDataValues("");
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNewDoctor().ShowDialog();
            ListDoctor.getDataValues("");
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNewDoctor(ListDoctor.getElementValues()).ShowDialog();
            ListDoctor.getDataValues("");
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить  " + ListDoctor.getElementValues().getfio_doctor(), "Ввод данных",
                MessageBoxButtons.OKCancel, 
                MessageBoxIcon.Information) == DialogResult.OK)
            {
                ListDoctor.setDeleteValues(ListDoctor.getElementValues().getidtable_doctor().ToString());
                ListDoctor.getDataValues("");
            }
        }
    
    }
}
