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
    public partial class FormClient : Form
    {
        private Class_table_client ClientList = new Class_table_client(StaticData.SeverConnect.Conncet);
        public FormClient()
        {
            InitializeComponent();
            GridView.AutoGenerateColumns = false;
            ClientList.getDataValues("");
            GridView.DataSource = ClientList.getBinbSource();
           
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNewClient().ShowDialog();
            ClientList.getDataValues("");
        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNewClient(ClientList.getElementValues()).ShowDialog();
            ClientList.getDataValues("");
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить  " + ClientList.getElementValues().getfio(), "Ввод данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ClientList.setDeleteValues(ClientList.getElementValues().getidtable_client().ToString());
                ClientList.getDataValues("");
            }
        }
    }
}
