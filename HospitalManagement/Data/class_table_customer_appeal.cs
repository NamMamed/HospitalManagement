using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Windows.Forms;

public class Class_table_customer_appeal: BaseClass{
public Class_table_customer_appeal(MySqlConnection connection) : base(connection){}
public String setInsertValues(table_customer_appeal_element data){

  SQLExecute("SELECT set_new_table_customer_appeal('"+data.getdate_appeal().ToString()+"','"+data.getid_client().ToString()+"','"+data.getid_diagnos().ToString()+"','"+data.getid_doctor().ToString()+"')");
  return "0";

  }
public String setUpdateValues(table_customer_appeal_element data){

  SQLExecute("SELECT set_update_table_customer_appeal('"+data.getdate_appeal().ToString()+"','"+data.getid_client().ToString()+"','"+data.getid_diagnos().ToString()+"','"+data.getid_doctor().ToString()+"','"+data.getidtable_customer_appeal().ToString()+"')");
  return "0";

  }
public String setDeleteValues(string id){

  SQLExecute("SELECT set_delete_table_customer_appeal("+id+")");
  return "0";

  }
public void getDataValues(string filter){

  SQLExecute("CALL get_view_table_customer_appeal('"+filter+"')");
 

  }
public table_customer_appeal_element getElementValues(){

 table_customer_appeal_element element = new  table_customer_appeal_element();
return  new  table_customer_appeal_element((getintValues(getValuesField(element.get_fields_idtable_customer_appeal()))),(getStringValues(getValuesField(element.get_fields_date_appeal()))),(getintValues(getValuesField(element.get_fields_id_client()))),(getintValues(getValuesField(element.get_fields_id_diagnos()))),(getintValues(getValuesField(element.get_fields_id_doctor())))); 

  }
public table_customer_appeal_element getElementId(string id){

  SQLExecute("CALL get_id_table_customer_appeal("+id+")");
return getElementValues();}
}