using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data;

[Serializable]
public class ReturnServerOption
{
    public string host { get; set; }
    public string baze { get; set; }
    public string root { get; set; }
    public string pasword { get; set; }

    public ReturnServerOption(string _host = "localhost", string _baze = "test", string _root = "root", string _pasword = "")
    {
        this.baze = _baze;
        this.host = _host;
        this.root = _root;
        this.pasword = _pasword;
    }
    public ReturnServerOption() { }
}

public class ConnectionServer{// подключение к серверу
    
    public MySqlConnection Conncet = new MySqlConnection();
    public Boolean connect_base(ReturnServerOption OptConncet)
      {
        try
         {
             string constr = "Server=" + OptConncet.host + ";" + "Database=" + OptConncet.baze + ";" +
                                                   "Uid=" + OptConncet.root + ";" +
                                                   "Pwd=" + OptConncet.pasword + ";" +
                                                   "CharSet = utf8; ";
          Conncet = new MySqlConnection(constr);
          Conncet.Open();
          return true;
         }
         catch (Exception e)  
         {
             MessageBox.Show(e.Message,"Ошибка подключения к серверу.",MessageBoxButtons.OK, MessageBoxIcon.Error);
             return false;
         }
        }
    
    public void SaveOption(ReturnServerOption _save)
      {
          String[] _tmp = new String[5];
          _tmp[0] = _save.host;
          _tmp[1] = _save.baze;
          _tmp[2] = _save.root;
          _tmp[3] = _save.pasword;
          System.IO.File.WriteAllLines("server.ini", _tmp);
      }
    
    public ReturnServerOption LoadOption()
      {
          ReturnServerOption _rso = new ReturnServerOption();
          int counter = 0; 
          String line;
          if (System.IO.File.Exists("server.ini"))
          {
              System.IO.StreamReader file = new System.IO.StreamReader("server.ini");
              while ((line = file.ReadLine()) != null)
              {
                  switch (counter)
                  {
                      case 0: { _rso.host = line; } break;
                      case 1: { _rso.baze = line; } break;
                      case 2: { _rso.root = line; } break;
                      case 3: { _rso.pasword = line; } break;
                  }
                  counter++;
              }

              file.Close();
          }
          return _rso;
      }
    
    public Boolean CreateDataBase(string base_name, ReturnServerOption OptConncet)
    {
        try
        {
            ConnectionServer mSqlTemp = new ConnectionServer();
            OptConncet.baze = "mysql";
            if (mSqlTemp.connect_base(OptConncet))
            {
                BaseClass _bsTmp = new BaseClass(mSqlTemp.Conncet);
                _bsTmp.SQLExecute("CREATE DATABASE IF NOT EXISTS `" + base_name + "` CHARACTER SET utf8 COLLATE utf8_general_ci;");
            }
            MessageBox.Show("База успешно созданна", "Всё прошло удачно.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
        catch (Exception e)
        {
            MessageBox.Show(e.Message, "Ошибка создания базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
    
    public MySqlConnection getMySqlConnection()
    {
        return Conncet;
    }
}
