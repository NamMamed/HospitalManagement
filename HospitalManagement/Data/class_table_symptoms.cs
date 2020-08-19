using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

public class Class_table_symptoms: BaseClass{
public Class_table_symptoms(MySqlConnection connection) : base(connection){}
public String setInsertValues(table_symptoms_element data){

  SQLExecute("SELECT set_new_table_symptoms('"+data.getname_symptoms().ToString()+"')");
  return "0";

  }
public String setUpdateValues(table_symptoms_element data){

  SQLExecute("SELECT set_update_table_symptoms('"+data.getname_symptoms().ToString()+"','"+data.getidtable_symptoms().ToString()+"')");
  return "0";

  }
public String setDeleteValues(string id){

  SQLExecute("SELECT set_delete_table_symptoms("+id+")");
  return "0";

  }
public void getDataValues(string filter){

  SQLExecute("CALL get_view_table_symptoms('"+filter+"')");
 

  }
public table_symptoms_element getElementValues(){

 table_symptoms_element element = new  table_symptoms_element();
return  new  table_symptoms_element((getintValues(getValuesField(element.get_fields_idtable_symptoms()))),(getStringValues(getValuesField(element.get_fields_name_symptoms())))); 

  }
public table_symptoms_element getElementId(string id){

  SQLExecute("CALL get_id_table_symptoms("+id+")");
return getElementValues();}
}