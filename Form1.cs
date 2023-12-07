using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalcArea;
using StringWorker;
using UserData;
using ClassFileSystem;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DLL_HomeLesson
{
    public partial class Form1 : Form
    {
        string pathFileOld = string.Empty;
        string pathFileNew = string.Empty;
        string resArea = string.Empty;
        int chek = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //ЗАДАНИЕ 1 ПЛОЩАДЬ ФИГУР
        private void b_Area_Click(object sender, EventArgs e)
        {
            Area();//считаем площадь выбранной фигуры
            label_resArea.Text = resArea;//выводим результат
        }
        private void Area()
        {
            if (rb_square.Checked)
            {
                //площадь квадрата
                resArea = "Площадь квадрата = " + AreaCalc.AreaSquare(Convert.ToDouble(mtb_side1.Text));
            }
            else
            if (rb_rectangle.Checked)
            {
                //площадь прямоугольника
                resArea = "Площадь прямоугольника = " + AreaCalc.AreaRectange(Convert.ToDouble(mtb_side1.Text), Convert.ToDouble(mtb_side2.Text));
            }
            else
            if (rb_triangle.Checked)
            {
                //площадь треугольника
                resArea = "Площадь треугольника = " + AreaCalc.AreaTriangle(Convert.ToDouble(mtb_side1.Text), Convert.ToDouble(mtb_side2.Text));
            }
        }
        //изменения интерфейса от выбраного параметра
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {

            if (rb_square.Checked)
            {
                mtb_side2.Enabled = false;
                label2.Text = "Сторона 2";
            }
            else
            if (rb_rectangle.Checked)
            {
                mtb_side2.Enabled = true;
                label2.Text = "Сторона 2";
            }
            else
            if (rb_triangle.Checked)
            {
                mtb_side2.Enabled = true;
                label2.Text = "Высота";
            }

        }
        //ЗАДАНИЕ 2 РАБОТА С ТЕКСТОМ
        //проверка на полиндром
        private void b_polyndrom_Click(object sender, EventArgs e)
        {

            if (ExamString.Palindrom(tb_stringWorker.Text))
                tb_stringWorker.Text += " - является полиндром";
            else
                tb_stringWorker.Text += " - не является полиндром";
        }
        //подсчет предложений(заканчивыаються на ('.','!','?'))
        private void b_countString_Click(object sender, EventArgs e)
        {
            tb_stringWorker.Text += "Количество предложений в тескте = " + ExamString.CountSentencesInText(tb_stringWorker.Text);
        }
        //переворачивает строку
        private void b_reverse_Click(object sender, EventArgs e)
        {
            tb_stringWorker.Text = ExamString.ReverseText(tb_stringWorker.Text);
        }
        //ЗАДАНИЕ 3 ВАЛИДАЦИЯ ДАННЫХ ПОЛЬЗОВАТЕЛЯ

        private void b_chek_Click(object sender, EventArgs e)
        {
            string resault = string.Empty;
            if (RentData.UserFIO(tb_userName.Text))//ПРОВЕРЯЕТ ЧТОБЫ В ТЕКСТЕ БЫЛИ ТОЛЬКО БУКВЫ
                resault += "ФИО пользователя корректное\n";
            else resault += "ФИО пользователя не корректное\n";
            if (RentData.UserAge(tb_age.Text))//ПРОВЕРЯЕТ ЧТО ВОЗРАСТ ЭТО ЧИСЛО ОТ 1 ДО 150
                resault += "Возраст пользователя корректен\n";
            else resault += "Возраст пользователя не корректное\n";
            if (RentData.UserMail(tb_mail.Text))//проверяет mail
                resault += "Mail пользователя корректен\n";
            else resault += "Mail пользователя не корректнен\n";
            if (RentData.UserPhone(mtb_number.Text))//проверяет номер соответствует нормам Российской федерации
                resault += "номер пользователя корректен\n";
            else resault += "номер пользователя не корректнен\n";
            label_resCheck.Text = resault;
        }
        //ЗАДАНИЕ 4-5 ФАЙЛОВАЯ СИСТЕМА
        //включение и выключение кнопок , в зависимоти от выбранного парваметра
        private void radioButtonFile_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_file.Checked) {
                chek = 1;
                b_copy.Enabled = true;
                b_move.Enabled = true;
                b_searchWordsInFile.Enabled = true;
            }
            else if (rb_directory.Checked) {
                chek = 2;
                b_copy.Enabled = true;
                b_move.Enabled = false;
                b_searchWordsInFile.Enabled = true;
            }
        }
        //копирование фалов
        private void b_copy_Click(object sender, EventArgs e)
        {
            if (chek == 1) {
                FileOparations.CopyFile(tb_oldPath.Text, tb_newPath.Text);
            }
            else if (chek == 2) {
                FileOparations.CopyDirectory(tb_oldPath.Text, tb_newPath.Text);
            }
        }
        //перенос файла
        private void b_move_Click(object sender, EventArgs e)
        {
            FileOparations.MoveFile(tb_oldPath.Text, tb_newPath.Text);
        }
        //выбор файла
        private void b_selectFile_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.Cancel)
                 return;
            string filename = openFileDialog1.FileName;
            tb_oldPath.Text = filename;
        }
        //удаление файла
        private void b_delete_Click(object sender, EventArgs e)
        {
            FileOparations.DeleteFile(tb_oldPath.Text);
        }
        //поиск слова в файле
        private void b_searchWordsInFile_Click(object sender, EventArgs e)
        {
            if (chek == 1)
            {
                FileOparations.SearchWordInFile(tb_oldPath.Text, tb_word.Text);
            }
            else if (chek == 2)
            {
                FileOparations.SearchWordInFolder(tb_oldPath.Text, tb_word.Text);
            }
        }
    }
}
