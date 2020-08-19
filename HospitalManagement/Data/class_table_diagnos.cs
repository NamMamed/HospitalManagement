using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

public class Class_table_diagnos: BaseClass{
public Class_table_diagnos(MySqlConnection connection) : base(connection){}
public String setInsertValues(table_diagnos_element data){

  SQLExecute("SELECT set_new_table_diagnos('"+data.getname_diagnos().ToString()+"','"+data.getnotes().ToString()+"')");
  return "0";

  }
public String setUpdateValues(table_diagnos_element data){

  SQLExecute("SELECT set_update_table_diagnos('"+data.getname_diagnos().ToString()+"','"+data.getnotes().ToString()+"','"+data.getidtable_diagnos().ToString()+"')");
  return "0";

  }
public String setDeleteValues(string id){

  SQLExecute("SELECT set_delete_table_diagnos("+id+")");
  return "0";

  }
public void getDataValues(string filter){

  SQLExecute("CALL get_view_table_diagnos('"+filter+"')");
 

  }
public table_diagnos_element getElementValues(){

 table_diagnos_element element = new  table_diagnos_element();
return  new  table_diagnos_element((getintValues(getValuesField(element.get_fields_idtable_diagnos()))),(getStringValues(getValuesField(element.get_fields_name_diagnos()))),(getStringValues(getValuesField(element.get_fields_notes())))); 

  }
public table_diagnos_element getElementId(string id){

  SQLExecute("CALL get_id_table_diagnos("+id+")");
return getElementValues();}
}