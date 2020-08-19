using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
public class table_doctor_element{
  private int idtable_doctor;
  private String fio_doctor;
  private String specific_;
public  table_doctor_element(){}

public  table_doctor_element(int idtable_doctor,String fio_doctor,String specific_){
  this.idtable_doctor=idtable_doctor;
  this.fio_doctor=fio_doctor;
  this.specific_=specific_;
}
//--- start create idtable_doctor
public void setidtable_doctor(int idtable_doctor){
  this.idtable_doctor=idtable_doctor;
}

public int getidtable_doctor(){
return this.idtable_doctor;
}

public String get_fields_idtable_doctor(){
return "idtable_doctor";
}

//--- end create idtable_doctor
//--- start create fio_doctor
public void setfio_doctor(String fio_doctor){
  this.fio_doctor=fio_doctor;
}

public String getfio_doctor(){
return this.fio_doctor;
}

public String get_fields_fio_doctor(){
return "fio_doctor";
}

//--- end create fio_doctor
//--- start create specific_
public void setspecific_(String specific_){
  this.specific_=specific_;
}

public String getspecific_(){
return this.specific_;
}

public String get_fields_specific_(){
return "specific_";
}

//--- end create specific_
}