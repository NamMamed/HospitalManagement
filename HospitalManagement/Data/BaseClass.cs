using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

public class BaseClass// общий базовый класс
{    
    private   DataTable DTable= new DataTable();
    public BindingSource BSource = new BindingSource();
    protected String SQLtext;
    protected MySqlConnection MConnected;
    
    public  BaseClass(MySqlConnection _Con){ MConnected = _Con;}
    
    public Boolean NotNull(){
        if (BSource.Count != 0) { return true; } else { return false; } 
    }
    
    public void SQLExecute(string sql_txt){
       try
       {
          SQLtext = sql_txt;
          DTable.Clear();
          BSource.DataSource = null;
         MySqlCommand MyCommand = new MySqlCommand(sql_txt, MConnected);
          MySqlDataAdapter adapter = new MySqlDataAdapter(MyCommand);
          adapter.Fill(DTable);
          adapter = null;
          MyCommand = null;
          BSource.DataSource = DTable;  
       }
      catch (Exception Error)
       {
           if (MessageBox.Show("Введены не корректные данные. Просмотреть запрос?", "Ошибка данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK) {
               MessageBox.Show(SQLtext+" ОШИБКА: "+ Error.Message,"Просмотр ошибки", MessageBoxButtons.OK, MessageBoxIcon.Information);
           }
      }
    }

    public BindingSource getBinbSource(){
        return BSource;
    }

    public string getValuesField(string Name) {
        if (Count() > 0)
        {
            if (new function().CountString(Convert.ToString((BSource.Current as DataRowView)[Name])))
            {
                return Convert.ToString((BSource.Current as DataRowView)[Name]);
            }
            else
            {
                return "";
            }
        }
        else { return "1"; }
    }

    public int getintValues(string values) {
        
        return Convert.ToInt32(values);    
    }

    public string getStringValues(string values) {
        
        return values;
    }

    public Double getdoubleValues(string values) {
        
        return Convert.ToInt32(values);
    }

    public Boolean getBooleanValues(string values) {
        
        return Convert.ToBoolean(values);
   
    }

    public void MoveFirst() {
        BSource.MoveFirst();
    }

    public void MoveNext() {
        BSource.MoveNext();
    }

    public void MoveLast() {
        BSource.MoveLast();
    }

    public int Count() {

       return BSource.Count;
    }

    public string ConvertToFloat(string data) {
        return data.Replace(',', '.');
    }
}

