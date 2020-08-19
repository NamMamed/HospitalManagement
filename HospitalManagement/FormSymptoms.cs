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
    public partial class FormSymptoms : Form
    {
        private Class_table_symptoms ListSymptoms = new Class_table_symptoms(StaticData.SeverConnect.Conncet);
        private bool edit;
        public FormSymptoms()
        {
            InitializeComponent();
            GridView.AutoGenerateColumns = false;
            GridView.DataSource = ListSymptoms.getBinbSource();
            ListSymptoms.getDataValues("");
            edit = false;

        }

        private void FormSymptoms_Load(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить  " + ListSymptoms.getElementValues().getname_symptoms(), "Ввод данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ListSymptoms.setDeleteValues(ListSymptoms.getElementValues().getidtable_symptoms().ToString());
                ListSymptoms.getDataValues("");
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            edit = true;
            textBox1.Text = ListSymptoms.getElementValues().getname_symptoms();
            button1.Text = "Изменить";
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!edit)
            {
                ListSymptoms.setInsertValues(new table_symptoms_element(0, textBox1.Text));
                ListSymptoms.getDataValues("");
                textBox1.Clear();
            }
            else {
                ListSymptoms.setUpdateValues(new table_symptoms_element(ListSymptoms.getElementValues().getidtable_symptoms(), textBox1.Text));
                ListSymptoms.getDataValues("");
                textBox1.Clear();
                button1.Text = "Добавить";
                edit = false;
            }
        }
    }
}
