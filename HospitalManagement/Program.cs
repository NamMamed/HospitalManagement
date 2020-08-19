using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace HospitalManagement
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            
          //  StaticData.ServerOption = new ReturnServerOption("local","base","root","password");
            XmlSerializer formatter = new XmlSerializer(typeof(ReturnServerOption));
           // using (FileStream fs = new FileStream("setting.xml", FileMode.OpenOrCreate))
           // {
           //     formatter.Serialize(fs, StaticData.ServerOption);
           // }

            using (FileStream fs = new FileStream("setting.xml", FileMode.OpenOrCreate))
            {
                StaticData.ServerOption = (ReturnServerOption)formatter.Deserialize(fs);
            }

            //StaticData.SeverConnect.LoadOption();


            if (StaticData.SeverConnect.connect_base(StaticData.ServerOption))
            {

                new BaseClass(StaticData.SeverConnect.Conncet).SQLExecute("SELECT COUNT(*)");
                Application.Run(new FormMain());
            }
        }
    }
}
