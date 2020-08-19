using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

public class Class_table_diagnos_symptom: BaseClass{
public Class_table_diagnos_symptom(MySqlConnection connection) : base(connection){}
public String setInsertValues(table_diagnos_symptom_element data){

  SQLExecute("SELECT set_new_table_diagnos_symptom('"+data.getid_diagn().ToString()+"','"+data.getid_symp().ToString()+"')");
  return "0";

  }
public String setUpdateValues(table_diagnos_symptom_element data){

  SQLExecute("SELECT set_update_table_diagnos_symptom('"+data.getid_diagn().ToString()+"','"+data.getid_symp().ToString()+"','"+data.getidtable_diagnos_symptom().ToString()+"')");
  return "0";

  }
public String setDeleteValues(string id){

  SQLExecute("SELECT set_delete_table_diagnos_symptom("+id+")");
  return "0";

  }
public void getDataValues(string filter){

  SQLExecute("CALL get_view_table_diagnos_symptom('"+filter+"')");
  }

public table_diagnos_symptom_element getElementValues(){

 table_diagnos_symptom_element element = new  table_diagnos_symptom_element();
return  new  table_diagnos_symptom_element((getintValues(getValuesField(element.get_fields_idtable_diagnos_symptom()))),(getintValues(getValuesField(element.get_fields_id_diagn()))),(getintValues(getValuesField(element.get_fields_id_symp())))); 

  }
public table_diagnos_symptom_element getElementId(string id){

  SQLExecute("CALL get_id_table_diagnos_symptom("+id+")");
return getElementValues();}
}