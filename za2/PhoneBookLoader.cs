using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace УП_2
{
    static class PhoneBookLoader
    {
        public static void Load(PhoneBook phoneBook, string fileName) //Выгрузка контактов из файла в список контактов
        {
            if (File.Exists(fileName))
            {
                StreamReader sr = File.OpenText(fileName); 

                while (!sr.EndOfStream) 
                {
                    string[] item = sr.ReadLine().Split(';'); 
                    phoneBook.AddContact(item[0], item[1]); 
                }

                sr.Close(); 
            }
            else
                MessageBox.Show("Данного файла не существует");
        }
        public static void Save(PhoneBook phoneBook, string fileName) //Запись контактов в файл .csv
        {
            if (File.Exists(fileName))
            {
                StreamWriter sw = File.CreateText(fileName);

                foreach (var item in phoneBook.GetAllContacts())
                {
                    string[] contact = item.Split("~");
                    sw.WriteLine(contact[0] + ";" + contact[1]);
                }

                sw.Close();
            }
            else
                MessageBox.Show("Данного файла не существует");
        }
    }
}
