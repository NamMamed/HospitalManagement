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
    public partial class FormNewClient : Form
    {
        private int TypeValues;
        private table_client_element main_element;
        public FormNewClient()
        {
            InitializeComponent();
            TypeValues = 0;
        }

        public FormNewClient(table_client_element client) {
            InitializeComponent();
            TypeValues = 1;
            main_element = client;
            fio.Text = client.getfio();
            blood_type.Text = client.getblood_type();
            place_of_work.Text = client.getplace_of_work();
            date_of_birth.Value = Convert.ToDateTime(client.getdate_of_birth());
     
        }

        private void FormNewClient_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (TypeValues)
            {
                case 0: {
                        try{
                            table_client_element element = new table_client_element(0, fio.Text, blood_type.Text, date_of_birth.Value.ToString("yyyy-MM-dd"), place_of_work.Text);
                            new Class_table_client(StaticData.SeverConnect.Conncet).setInsertValues(element);
                            Close();
                        }
                        catch {}
                        break;
                    }
                case 1: {
                        try {
                            main_element.setfio(fio.Text);
                            main_element.setblood_type(blood_type.Text);
                            main_element.setplace_of_work(place_of_work.Text);
                            main_element.setdate_of_birth(date_of_birth.Value.ToString("yyyy-MM-dd"));
                            new Class_table_client(StaticData.SeverConnect.Conncet).setUpdateValues(main_element);
                            Close();
                        } catch { }
                        break;
                    }
            }
           
            }
        
    }
}
