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
    public partial class FormNewDoctor : Form
    {
        private table_doctor_element doctor;
        private int TypeValues;
        public FormNewDoctor()
        {
            InitializeComponent();
            TypeValues = 0;
        }
        public FormNewDoctor(table_doctor_element doctor)
        {
            InitializeComponent();
            TypeValues = 1;
            this.doctor = doctor;
            fio_doctor.Text = doctor.getfio_doctor();
            specific_.Text = doctor.getspecific_();
        }

        private void FormNewDoctor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (TypeValues)
            {
                case 0:
                    {
                        try
                        {
                            table_doctor_element element = new table_doctor_element(0, fio_doctor.Text, specific_.Text);
                            new Class_table_doctor(StaticData.SeverConnect.Conncet).setInsertValues(element);
                            Close();
                        }
                        catch { }
                        break;
                    }
                case 1:
                    {
                        try
                        {
                            doctor.setfio_doctor(fio_doctor.Text);
                            doctor.setspecific_(specific_.Text);
    
                            new Class_table_doctor(StaticData.SeverConnect.Conncet).setUpdateValues(doctor);
                            Close();
                        }
                        catch { }
                        break;
                    }
            }
        }
    }
}
