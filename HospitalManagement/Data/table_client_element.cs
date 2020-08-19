using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
public class table_client_element{
  private int idtable_client;
  private String fio;
  private String blood_type;
  private String date_of_birth;
  private String place_of_work;
public  table_client_element(){}

public  table_client_element(int idtable_client,String fio,String blood_type,String date_of_birth,String place_of_work){
  this.idtable_client=idtable_client;
  this.fio=fio;
  this.blood_type=blood_type;
  this.date_of_birth=date_of_birth;
  this.place_of_work=place_of_work;
}
//--- start create idtable_client
public void setidtable_client(int idtable_client){
  this.idtable_client=idtable_client;
}

public int getidtable_client(){
return this.idtable_client;
}

public String get_fields_idtable_client(){
return "idtable_client";
}

//--- end create idtable_client
//--- start create fio
public void setfio(String fio){
  this.fio=fio;
}

public String getfio(){
return this.fio;
}

public String get_fields_fio(){
return "fio";
}

//--- end create fio
//--- start create blood_type
public void setblood_type(String blood_type){
  this.blood_type=blood_type;
}

public String getblood_type(){
return this.blood_type;
}

public String get_fields_blood_type(){
return "blood_type";
}

//--- end create blood_type
//--- start create date_of_birth
public void setdate_of_birth(String date_of_birth){
  this.date_of_birth=date_of_birth;
}

public String getdate_of_birth(){
return this.date_of_birth;
}

public String get_fields_date_of_birth(){
return "date_of_birth";
}

//--- end create date_of_birth
//--- start create place_of_work
public void setplace_of_work(String place_of_work){
  this.place_of_work=place_of_work;
}

public String getplace_of_work(){
return this.place_of_work;
}

public String get_fields_place_of_work(){
return "place_of_work";
}

//--- end create place_of_work
}