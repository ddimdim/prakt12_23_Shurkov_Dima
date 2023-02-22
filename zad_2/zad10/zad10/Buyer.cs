using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zad10
{
    public class Buyer
    {
        public string surname;
        public string name;
        public string otchestvo;
        public string adress;
        public long numk;
        public int numb;

        public Buyer(string _surname, string _name, string _otchestvo, string _adress, long _numk, int _numb)
        {
            surname = _surname;
            name = _name;
            otchestvo = _otchestvo;
            adress = _adress;
            numk = _numk;
            numb = _numb;
        }
        //Установка и получение атрибутов(по условию задания)
        public void Set(string _surname, string _name, string _otchestvo, string _adress, long _numk, int _numb)
        {
            surname = _surname;
            name = _name;
            otchestvo = _otchestvo;
            adress = _adress;
            numk = _numk;
            numb = _numb;
        }
        public void Get(string _surname, string _name, string _otchestvo, string _adress, long _numk, int _numb)
        {
            _surname = surname;
            _name = name;
            _otchestvo = otchestvo;
            _adress = adress;
            _numk = numk;
            _numb = numb;
        }
        //Вывод информации
        public void Print()
        {
            MessageBox.Show(surname + " " + name + " " + otchestvo + " \nАдрес: " + adress + " \nНомер кредитной карты: " + numk + " \nНомер банковского счета: " + numb, "Вывод");
        }

    }
}
