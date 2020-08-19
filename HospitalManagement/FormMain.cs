using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace HospitalManagement
{
    public partial class FormMain : Form
    {

        private Class_table_customer_appeal ListCustomerAppeal = new Class_table_customer_appeal(StaticData.SeverConnect.Conncet);

        public FormMain()
        {
            InitializeComponent();
            GridView.DataSource = ListCustomerAppeal.getBinbSource();
            GridView.AutoGenerateColumns = false;
            ListCustomerAppeal.getDataValues("");
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            new FormClient().ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            new FormDoctor().ShowDialog();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            new FormSymptoms().ShowDialog();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            new FormDiagnos().ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            new FormNewCustomerAppeal().ShowDialog();
            ListCustomerAppeal.getDataValues("");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            new FormNewCustomerAppeal(ListCustomerAppeal.getElementValues()).ShowDialog();
            ListCustomerAppeal.getDataValues("");
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить  прием?", "Ввод данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ListCustomerAppeal.setDeleteValues(ListCustomerAppeal.getElementValues().getidtable_customer_appeal().ToString());
                ListCustomerAppeal.getDataValues("");
            }
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }

        private void toolStripButton9_Click(object sender, EventArgs e)
        {

        }
    }
}
