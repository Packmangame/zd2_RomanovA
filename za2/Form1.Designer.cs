namespace УП_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            deleteBut = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            addBut = new Button();
            changeBut = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            searchBut = new Button();
            textBox5 = new TextBox();
            exitBut = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(396, 384);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += IndexChanged;
            // 
            // deleteBut
            // 
            deleteBut.Location = new Point(61, 409);
            deleteBut.Name = "deleteBut";
            deleteBut.Size = new Size(296, 29);
            deleteBut.TabIndex = 1;
            deleteBut.Text = "Удалить контакт";
            deleteBut.UseVisualStyleBackColor = true;
            deleteBut.Click += DeleteContact;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(61, 28);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Введите имя";
            textBox1.Size = new Size(215, 27);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(61, 61);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Номер (000)000-00-00";
            textBox2.Size = new Size(215, 27);
            textBox2.TabIndex = 3;
            // 
            // addBut
            // 
            addBut.Location = new Point(61, 94);
            addBut.Name = "addBut";
            addBut.Size = new Size(215, 29);
            addBut.TabIndex = 4;
            addBut.Text = "Добавить контакт";
            addBut.UseVisualStyleBackColor = true;
            addBut.Click += AddContact;
            // 
            // changeBut
            // 
            changeBut.Location = new Point(60, 91);
            changeBut.Name = "changeBut";
            changeBut.Size = new Size(215, 29);
            changeBut.TabIndex = 4;
            changeBut.Text = "Изменить";
            changeBut.UseVisualStyleBackColor = true;
            changeBut.Click += ChangeContact;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(60, 25);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Введите имя";
            textBox3.Size = new Size(215, 27);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(60, 58);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Номер (000)000-00-00";
            textBox4.Size = new Size(215, 27);
            textBox4.TabIndex = 3;
            // 
            // searchBut
            // 
            searchBut.Location = new Point(61, 75);
            searchBut.Name = "searchBut";
            searchBut.Size = new Size(215, 29);
            searchBut.TabIndex = 4;
            searchBut.Text = "Поиск";
            searchBut.UseVisualStyleBackColor = true;
            searchBut.Click += SearchForContact;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(61, 42);
            textBox5.Name = "textBox5";
            textBox5.PlaceholderText = "Введите имя";
            textBox5.Size = new Size(215, 27);
            textBox5.TabIndex = 2;
            // 
            // exitBut
            // 
            exitBut.Location = new Point(496, 194);
            exitBut.Name = "exitBut";
            exitBut.Size = new Size(215, 29);
            exitBut.TabIndex = 8;
            exitBut.Text = "Выход";
            exitBut.UseVisualStyleBackColor = true;
            exitBut.Click += Exit;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(431, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(357, 180);
            tabControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(addBut);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(textBox2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(349, 147);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Добавление";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(changeBut);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(349, 147);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Редактирование";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(searchBut);
            tabPage3.Controls.Add(textBox5);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(349, 147);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Поиск по имени";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(exitBut);
            Controls.Add(deleteBut);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Записная книга";
            Load += FormLoading;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private Button deleteBut;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button addBut;
        private Button changeBut;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button searchBut;
        private TextBox textBox5;
        private Button exitBut;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
    }
}
