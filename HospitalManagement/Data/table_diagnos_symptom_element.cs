using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
public class table_diagnos_symptom_element{
  private int idtable_diagnos_symptom;
  private int id_diagn;
  private int id_symp;
public  table_diagnos_symptom_element(){}

public  table_diagnos_symptom_element(int idtable_diagnos_symptom,int id_diagn,int id_symp){
  this.idtable_diagnos_symptom=idtable_diagnos_symptom;
  this.id_diagn=id_diagn;
  this.id_symp=id_symp;
}
//--- start create idtable_diagnos_symptom
public void setidtable_diagnos_symptom(int idtable_diagnos_symptom){
  this.idtable_diagnos_symptom=idtable_diagnos_symptom;
}

public int getidtable_diagnos_symptom(){
return this.idtable_diagnos_symptom;
}

public String get_fields_idtable_diagnos_symptom(){
return "idtable_diagnos_symptom";
}

//--- end create idtable_diagnos_symptom
//--- start create id_diagn
public void setid_diagn(int id_diagn){
  this.id_diagn=id_diagn;
}

public int getid_diagn(){
return this.id_diagn;
}

public String get_fields_id_diagn(){
return "id_diagn";
}

//--- end create id_diagn
//--- start create id_symp
public void setid_symp(int id_symp){
  this.id_symp=id_symp;
}

public int getid_symp(){
return this.id_symp;
}

public String get_fields_id_symp(){
return "id_symp";
}

//--- end create id_symp
}