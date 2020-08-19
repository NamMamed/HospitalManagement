using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


public class function{
    
    private string RemoveSpaces(string inputString)// удалить все пробелы
    {
        inputString = inputString.Replace("  ", string.Empty);
        inputString = inputString.Trim().Replace(" ", string.Empty);

        return inputString;
    }

    public bool CountString(string inputString) {// проверка или значение не пустое 
        inputString = RemoveSpaces(inputString);
        if (inputString.Length == 0) { return false; } else { return true; }
    }

    public string stringMonth(int numberMonth) {// месяц в стороков виде.
        switch (numberMonth)
        {
                case 1:  return "Январь";  //break;
                case 2:  return "Февраль";  //break;
                case 3:  return "Март";  //break;
                case 4:  return "Апрель"; // break;
                case 5:  return "Май";  //break;
                case 6:  return "Июнь"; // break;
                case 7:  return "Июль";  //break;
                case 8:  return "Август"; // break;
                case 9:  return "Сентябрь";  //break;
                case 10:  return "Октябрь"; // break;
                case 11:  return "Ноябрь";  //break;
                case 12:  return "Декабрь";  //break;
                default: return "Январь"; //break;
             
        }
    }

    public List<int> Week(int month, int year)// возвращает лист с выходными датами(заданного месяца в году)
    {

        List<int> list = new List<int> { };
        DateTime date = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), 1);
        int Count = 0;
        while (true)
        {
            if (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                Count++;
                list.Add(date.Day);
            }
            date = date.AddDays(1.0);
            if (date.Month != Convert.ToInt32(month))
            {
                break;
            }
        }
        return list;
    }

    public void viewErrorData(){
        MessageBox.Show("Введены не корректные данные","Ошибка данных",MessageBoxButtons.OK,MessageBoxIcon.Error);
    }
    public Boolean viewDeleteData()
    {
        //return
        if (MessageBox.Show("Вы действительно хотите удалить выбранные данные?", "Удаление данных", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK) { return true; } else return false;
    }
   
}

