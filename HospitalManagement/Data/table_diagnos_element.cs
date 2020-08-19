using System;
using System.Collections.Generic; 
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Windows.Forms;
public class table_diagnos_element{
  private int idtable_diagnos;
  private String name_diagnos;
  private String notes;
public  table_diagnos_element(){}

public  table_diagnos_element(int idtable_diagnos,String name_diagnos,String notes){
  this.idtable_diagnos=idtable_diagnos;
  this.name_diagnos=name_diagnos;
  this.notes=notes;
}
//--- start create idtable_diagnos
public void setidtable_diagnos(int idtable_diagnos){
  this.idtable_diagnos=idtable_diagnos;
}

public int getidtable_diagnos(){
return this.idtable_diagnos;
}

public String get_fields_idtable_diagnos(){
return "idtable_diagnos";
}

//--- end create idtable_diagnos
//--- start create name_diagnos
public void setname_diagnos(String name_diagnos){
  this.name_diagnos=name_diagnos;
}

public String getname_diagnos(){
return this.name_diagnos;
}

public String get_fields_name_diagnos(){
return "name_diagnos";
}

//--- end create name_diagnos
//--- start create notes
public void setnotes(String notes){
  this.notes=notes;
}

public String getnotes(){
return this.notes;
}

public String get_fields_notes(){
return "notes";
}

//--- end create notes
}