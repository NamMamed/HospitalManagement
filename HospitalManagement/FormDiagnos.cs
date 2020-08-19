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
    public partial class FormDiagnos : Form
    {
        private Class_table_diagnos ListDiagnos = new Class_table_diagnos(StaticData.SeverConnect.Conncet);
        private Class_table_diagnos_symptom ListDiagnosSyptom = new Class_table_diagnos_symptom(StaticData.SeverConnect.Conncet);
        private Class_table_symptoms ListSymptoms = new Class_table_symptoms(StaticData.SeverConnect.Conncet);
        public FormDiagnos()
        {
            InitializeComponent();
            GridView.AutoGenerateColumns = false;
            dataGridView1.AutoGenerateColumns = false;

            GridView.DataSource = ListDiagnos.getBinbSource();
            dataGridView1.DataSource = ListDiagnosSyptom.getBinbSource();

            ListDiagnos.BSource.CurrentChanged += new EventHandler(bindingSource1_DataSourceChanged);
            ListDiagnos.getDataValues("");

            ListSymptoms.getDataValues("");
            comboBox1.DataSource = ListSymptoms.getBinbSource();
            comboBox1.DisplayMember = "name_symptoms";
            comboBox1.ValueMember = "idtable_symptoms";

            /*
             *         bs.CurrentChanged += new EventHandler(bs_CurrentChanged);
        bs.CurrentItemChanged += new EventHandler(bs_CurrentItemChanged);
             */
        }

        void DataSourceChange(EventArgs e) 
            { 
            }

    private void FormDiagnos_Load(object sender, EventArgs e)
        {

        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDiagnos.BSource.CurrentChanged -= new EventHandler(bindingSource1_DataSourceChanged);
            new FormNewDiagnos().ShowDialog();
            ListDiagnos.BSource.CurrentChanged += new EventHandler(bindingSource1_DataSourceChanged);
            ListDiagnos.getDataValues("");
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListDiagnos.BSource.CurrentChanged -= new EventHandler(bindingSource1_DataSourceChanged);
            new FormNewDiagnos(ListDiagnos.getElementValues()).ShowDialog();
            ListDiagnos.BSource.CurrentChanged += new EventHandler(bindingSource1_DataSourceChanged);
            ListDiagnos.getDataValues("");
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить  " + ListDiagnos.getElementValues().getname_diagnos(), "Ввод данных",
    MessageBoxButtons.OKCancel,
    MessageBoxIcon.Information) == DialogResult.OK)
            {
                ListDiagnos.setDeleteValues(ListDiagnos.getElementValues().getidtable_diagnos().ToString());
                ListDiagnos.getDataValues("");
            }
        }

        private void удалитьСимптомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить  ", "Ввод данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ListDiagnosSyptom.setDeleteValues(ListDiagnosSyptom.getElementValues().getidtable_diagnos_symptom().ToString());
                ListDiagnosSyptom.getDataValues(ListDiagnos.getElementValues().getidtable_diagnos().ToString());
            }
        }

        private void bindingSource1_DataSourceChanged(object sender, EventArgs e)
        { 
            ListDiagnosSyptom.getDataValues(ListDiagnos.getElementValues().getidtable_diagnos().ToString());
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ListDiagnosSyptom.setInsertValues(new table_diagnos_symptom_element(0, ListDiagnos.getElementValues().getidtable_diagnos(),(int)comboBox1.SelectedValue));
            ListDiagnosSyptom.getDataValues(ListDiagnos.getElementValues().getidtable_diagnos().ToString());
        }
    }
}
