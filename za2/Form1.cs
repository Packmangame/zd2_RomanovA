namespace УП_2
{
    public partial class Form1 :Form
    {
        PhoneBook phoneBook;
        string[] item;
        public Form1()
        {
            InitializeComponent();
        }
        private void ShowContacts() //Метод отображения контактов в листбоксе
        {
            listBox1.Items.Clear();
            List<string> list = phoneBook.GetAllContacts();
            foreach (var item in list)
            {
                listBox1.Items.Add(item);
            }
        }

        private void DeleteContact(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string[] item = listBox1.Items[listBox1.SelectedIndex].ToString().Split('~');
                phoneBook.RemoveContact(item[0], item[1]); //Удаление контакта
                ShowContacts(); //Отображение новых контактов
                PhoneBookLoader.Save(phoneBook, "contacts (2024).csv"); //Сохраняем данные

                textBox3.Text = "";
                textBox4.Text = "";
               
            }
            else
                MessageBox.Show("Выберите контакт для удаления");
        }

        private void AddContact(object sender, EventArgs e)
        {
            phoneBook.AddContact(textBox1.Text, textBox2.Text); //Добавляем контакт
            ShowContacts(); //Отображение новых контактов
            PhoneBookLoader.Save(phoneBook, "contacts (2024).csv"); //Сохраняем данные

            Contact contact = new Contact();
            contact.Name = textBox1.Text; //Выделяем добавленный контакт
            contact.Phone = textBox2.Text;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().Contains(contact.Name))
                {
                    listBox1.SelectedIndex = i;
                }
            }

            textBox1.Text = "";
            textBox2.Text = "";
            
        }

        private void ChangeContact(object sender, EventArgs e)
        {
            Contact contact = new Contact(); //Изменяем данные контакта
            contact.Name = item[0];
            contact.Phone = item[1];
            phoneBook.EditContact(contact, textBox3.Text, textBox4.Text);
            ShowContacts(); //Отображение новых контактов
            PhoneBookLoader.Save(phoneBook, "contacts (2024).csv"); //Сохраняем данные

            contact.Name = textBox3.Text; //Выделяем изменённый контакт
            contact.Phone = textBox4.Text;
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                if (listBox1.Items[i].ToString().Contains(contact.Name))
                {
                    listBox1.SelectedIndex = i;
                }
            }
            
        }

        private void SearchForContact(object sender, EventArgs e) //Ищем контакт в списке и выделяем его
        {
            if (textBox5.Text != "")
            {
                Contact contact = phoneBook.FindContactByName(textBox5.Text);

                if (contact != null)
                {
                    for (int i = 0; i < listBox1.Items.Count; i++)
                    {
                        if (listBox1.Items[i].ToString().Contains(contact.Name))
                        {
                            listBox1.SelectedIndex = i;
                            return;
                        }
                    }
                }
                else
                    MessageBox.Show("Контакт не найден");
            }
            else
                MessageBox.Show("Заполните поле поиска по имени");
        }

        private void Exit(object sender, EventArgs e)
        {
            this.Close(); //Выход из программы
        }

        private void FormLoading(object sender, EventArgs e)
        {
            phoneBook = new PhoneBook();
            PhoneBookLoader.Load(phoneBook, "contacts (2024).csv"); //Загрузили контакты из файла в список

            ShowContacts();
        }

        private void IndexChanged(object sender, EventArgs e)
        {
            item = listBox1.Items[listBox1.SelectedIndex].ToString().Split('~'); //Переносим данные из листбокса в поля для изменения контакта
            textBox3.Text = item[0];
            textBox4.Text = item[1];
        }
    }
}
