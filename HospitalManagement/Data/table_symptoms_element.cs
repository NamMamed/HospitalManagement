using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
public class table_symptoms_element{
  private int idtable_symptoms;
  private String name_symptoms;
public  table_symptoms_element(){}

public  table_symptoms_element(int idtable_symptoms,String name_symptoms){
  this.idtable_symptoms=idtable_symptoms;
  this.name_symptoms=name_symptoms;
}
//--- start create idtable_symptoms
public void setidtable_symptoms(int idtable_symptoms){
  this.idtable_symptoms=idtable_symptoms;
}

public int getidtable_symptoms(){
return this.idtable_symptoms;
}

public String get_fields_idtable_symptoms(){
return "idtable_symptoms";
}

//--- end create idtable_symptoms
//--- start create name_symptoms
public void setname_symptoms(String name_symptoms){
  this.name_symptoms=name_symptoms;
}

public String getname_symptoms(){
return this.name_symptoms;
}

public String get_fields_name_symptoms(){
return "name_symptoms";
}

//--- end create name_symptoms
}