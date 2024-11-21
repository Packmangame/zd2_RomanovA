using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace УП_2
{
    class Contact //Класс контакта со свойствами
    {
        private string name;
        private string phone;
        public string Name
        {
            get { return name; }
            set
            {
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch) && !char.IsWhiteSpace(ch)) //Проверка на ввод только букв и пробелов
                    {
                        MessageBox.Show("Разрешенно вводить только буквы");
                        name = "";
                        return;
                    }
                }
                name = value;
            }
        }
        public string Phone
        {
            get { return phone; }
            set
            {
                //Проверка на форнмат телефона (xxx)xxx-xx-xx
                if (Regex.IsMatch(value, @"^\(\d{3}\)\d{3}-\d{2}-\d{2}$"))
                {
                    phone = value;
                }
            }
        }
    }
}
