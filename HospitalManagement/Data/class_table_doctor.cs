using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

public class Class_table_doctor: BaseClass{
public Class_table_doctor(MySqlConnection connection) : base(connection){}
public String setInsertValues(table_doctor_element data){

  SQLExecute("SELECT set_new_table_doctor('"+data.getfio_doctor().ToString()+"','"+data.getspecific_().ToString()+"')");
  return "0";

  }
public String setUpdateValues(table_doctor_element data){

  SQLExecute("SELECT set_update_table_doctor('"+data.getfio_doctor().ToString()+"','"+data.getspecific_().ToString()+"','"+data.getidtable_doctor().ToString()+"')");
  return "0";

  }
public String setDeleteValues(string id){

  SQLExecute("SELECT set_delete_table_doctor("+id+")");
  return "0";

  }
public void getDataValues(string filter){

  SQLExecute("CALL get_view_table_doctor('"+filter+"')");
 

  }
public table_doctor_element getElementValues(){

 table_doctor_element element = new  table_doctor_element();
return  new  table_doctor_element((getintValues(getValuesField(element.get_fields_idtable_doctor()))),(getStringValues(getValuesField(element.get_fields_fio_doctor()))),(getStringValues(getValuesField(element.get_fields_specific_())))); 

  }
public table_doctor_element getElementId(string id){

  SQLExecute("CALL get_id_table_doctor("+id+")");
return getElementValues();}
}