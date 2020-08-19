using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
public class table_customer_appeal_element{
  private int idtable_customer_appeal;
  private String date_appeal;
  private int id_client;
  private int id_diagnos;
  private int id_doctor;
public  table_customer_appeal_element(){}

public  table_customer_appeal_element(int idtable_customer_appeal,String date_appeal,int id_client,int id_diagnos,int id_doctor){
  this.idtable_customer_appeal=idtable_customer_appeal;
  this.date_appeal=date_appeal;
  this.id_client=id_client;
  this.id_diagnos=id_diagnos;
  this.id_doctor=id_doctor;
}
//--- start create idtable_customer_appeal
public void setidtable_customer_appeal(int idtable_customer_appeal){
  this.idtable_customer_appeal=idtable_customer_appeal;
}

public int getidtable_customer_appeal(){
return this.idtable_customer_appeal;
}

public String get_fields_idtable_customer_appeal(){
return "idtable_customer_appeal";
}

//--- end create idtable_customer_appeal
//--- start create date_appeal
public void setdate_appeal(String date_appeal){
  this.date_appeal=date_appeal;
}

public String getdate_appeal(){
return this.date_appeal;
}

public String get_fields_date_appeal(){
return "date_appeal";
}

//--- end create date_appeal
//--- start create id_client
public void setid_client(int id_client){
  this.id_client=id_client;
}

public int getid_client(){
return this.id_client;
}

public String get_fields_id_client(){
return "id_client";
}

//--- end create id_client
//--- start create id_diagnos
public void setid_diagnos(int id_diagnos){
  this.id_diagnos=id_diagnos;
}

public int getid_diagnos(){
return this.id_diagnos;
}

public String get_fields_id_diagnos(){
return "id_diagnos";
}

//--- end create id_diagnos
//--- start create id_doctor
public void setid_doctor(int id_doctor){
  this.id_doctor=id_doctor;
}

public int getid_doctor(){
return this.id_doctor;
}

public String get_fields_id_doctor(){
return "id_doctor";
}

//--- end create id_doctor
}