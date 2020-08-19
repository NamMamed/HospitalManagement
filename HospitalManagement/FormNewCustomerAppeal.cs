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
    public partial class FormNewCustomerAppeal : Form
    {
        private table_customer_appeal_element appeal;
        private int TypeValues;
        private Class_table_client client = new Class_table_client(StaticData.SeverConnect.Conncet);
        private Class_table_diagnos diagnos = new Class_table_diagnos(StaticData.SeverConnect.Conncet);
        private Class_table_doctor doctor = new Class_table_doctor(StaticData.SeverConnect.Conncet);


        
        public FormNewCustomerAppeal()
        {
            InitializeComponent();
            TypeValues = 0;
            setLoadValues();
        }


        public FormNewCustomerAppeal(table_customer_appeal_element appeal)
        {
            InitializeComponent();
            this.appeal = appeal;
            TypeValues = 1;
            setLoadValues();
            //
            dateTimePicker1.Value = Convert.ToDateTime(appeal.getdate_appeal());
            comboBox1.SelectedValue = appeal.getid_client();
            comboBox2.SelectedValue = appeal.getid_diagnos();
            comboBox3.SelectedValue = appeal.getid_doctor();
        }

        private void setLoadValues()
        {
            client.getDataValues("");
            comboBox1.DataSource = client.getBinbSource();
            comboBox1.DisplayMember = "fio";
            comboBox1.ValueMember = "idtable_client";

            //------------------
            diagnos.getDataValues("");
            comboBox2.DataSource = diagnos.getBinbSource();
            comboBox2.DisplayMember = "name_diagnos";
            comboBox2.ValueMember = "idtable_diagnos";

            //----------------------
            doctor.getDataValues("");
            comboBox3.DataSource = doctor.getBinbSource();
            comboBox3.DisplayMember = "fio_doctor";
            comboBox3.ValueMember = "idtable_doctor";
            
        }

        private void FormNewCustomerAppeal_Load(object sender, EventArgs e)
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
                           table_customer_appeal_element element = new table_customer_appeal_element
                                (0, dateTimePicker1.Value.ToString("yyyy-MM-dd"),(int) comboBox1.SelectedValue,
                                (int)comboBox2.SelectedValue, (int)comboBox3.SelectedValue);
                            new Class_table_customer_appeal(StaticData.SeverConnect.Conncet).setInsertValues(element);
                            Close();
                        }
                        catch { }
                        break;
                    }
                case 1:
                    {
                        try
                        {
                               appeal.setdate_appeal(dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                               appeal.setid_client((int)comboBox1.SelectedValue);
                               appeal.setid_diagnos((int)comboBox2.SelectedValue);
                               appeal.setid_doctor((int)comboBox3.SelectedValue);
                            new Class_table_customer_appeal(StaticData.SeverConnect.Conncet).setUpdateValues(appeal);
                            Close();
                        }
                        catch { }
                        break;
                    }
            }
        }
    }
}
