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
    public partial class FormNewDiagnos : Form
    {
        private table_diagnos_element diagnos;
        private int TypeValues;
        public FormNewDiagnos()
        {
            InitializeComponent();
            TypeValues = 0;
        }
        public FormNewDiagnos(table_diagnos_element diagnos)
        {
            InitializeComponent();
            TypeValues = 1;
            this.diagnos = diagnos;
            name_diagnos.Text = diagnos.getname_diagnos();
            notes.Text = diagnos.getnotes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                switch (TypeValues)
                {
                    case 0:
                        {
                            try
                            {
                                table_diagnos_element element = new table_diagnos_element(0, name_diagnos.Text, notes.Text);
                                new Class_table_diagnos(StaticData.SeverConnect.Conncet).setInsertValues(element);
                                Close();
                            }
                            catch { }
                            break;
                        }
                    case 1:
                        {
                            try
                            {
                                diagnos.setname_diagnos(name_diagnos.Text);
                                diagnos.setnotes(notes.Text);

                                new Class_table_diagnos(StaticData.SeverConnect.Conncet).setUpdateValues(diagnos);
                                Close();
                            }
                            catch { }
                            break;
                        }
                }
            }
        }
    }
}
