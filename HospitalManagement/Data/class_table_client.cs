using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

public class Class_table_client: BaseClass{
public Class_table_client(MySqlConnection connection) : base(connection){}
public String setInsertValues(table_client_element data){

  SQLExecute("SELECT set_new_table_client('"+data.getfio().ToString()+"','"+data.getblood_type().ToString()+"','"+data.getdate_of_birth().ToString()+"','"+data.getplace_of_work().ToString()+"')");
  return "0";

  }
public String setUpdateValues(table_client_element data){

  SQLExecute("SELECT set_update_table_client('"+data.getfio().ToString()+"','"+data.getblood_type().ToString()+"','"+data.getdate_of_birth().ToString()+"','"+data.getplace_of_work().ToString()+"','"+data.getidtable_client().ToString()+"')");
  return "0";

  }
public String setDeleteValues(string id){

  SQLExecute("SELECT set_delete_table_client("+id+")");
  return "0";

  }
public void getDataValues(string filter){

  SQLExecute("CALL get_view_table_client('"+filter+"')");
 

  }
public table_client_element getElementValues(){

 table_client_element element = new  table_client_element();
return  new  table_client_element((getintValues(getValuesField(element.get_fields_idtable_client()))),(getStringValues(getValuesField(element.get_fields_fio()))),(getStringValues(getValuesField(element.get_fields_blood_type()))),(getStringValues(getValuesField(element.get_fields_date_of_birth()))),(getStringValues(getValuesField(element.get_fields_place_of_work())))); 

  }
public table_client_element getElementId(string id){

  SQLExecute("CALL get_id_table_client("+id+")");
return getElementValues();}
}