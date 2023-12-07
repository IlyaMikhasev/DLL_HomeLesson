namespace DLL_HomeLesson
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_resArea = new System.Windows.Forms.Label();
            this.rb_triangle = new System.Windows.Forms.RadioButton();
            this.rb_rectangle = new System.Windows.Forms.RadioButton();
            this.rb_square = new System.Windows.Forms.RadioButton();
            this.b_Area = new System.Windows.Forms.Button();
            this.mtb_side2 = new System.Windows.Forms.MaskedTextBox();
            this.mtb_side1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_directory = new System.Windows.Forms.RadioButton();
            this.rb_file = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_reverse = new System.Windows.Forms.Button();
            this.b_countString = new System.Windows.Forms.Button();
            this.b_polyndrom = new System.Windows.Forms.Button();
            this.tb_stringWorker = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label_resCheck = new System.Windows.Forms.Label();
            this.b_chek = new System.Windows.Forms.Button();
            this.tb_userName = new System.Windows.Forms.TextBox();
            this.tb_age = new System.Windows.Forms.TextBox();
            this.tb_mail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtb_number = new System.Windows.Forms.MaskedTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.tb_oldPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_newPath = new System.Windows.Forms.TextBox();
            this.b_copy = new System.Windows.Forms.Button();
            this.b_move = new System.Windows.Forms.Button();
            this.b_selectFile = new System.Windows.Forms.Button();
            this.b_delete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_word = new System.Windows.Forms.TextBox();
            this.b_searchWordsInFile = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_resArea);
            this.groupBox1.Controls.Add(this.rb_triangle);
            this.groupBox1.Controls.Add(this.rb_rectangle);
            this.groupBox1.Controls.Add(this.rb_square);
            this.groupBox1.Controls.Add(this.b_Area);
            this.groupBox1.Controls.Add(this.mtb_side2);
            this.groupBox1.Controls.Add(this.mtb_side1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(417, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Задание 1";
            // 
            // label_resArea
            // 
            this.label_resArea.AutoSize = true;
            this.label_resArea.Location = new System.Drawing.Point(20, 115);
            this.label_resArea.Name = "label_resArea";
            this.label_resArea.Size = new System.Drawing.Size(71, 13);
            this.label_resArea.TabIndex = 7;
            this.label_resArea.Text = "Результат = ";
            // 
            // rb_triangle
            // 
            this.rb_triangle.AutoSize = true;
            this.rb_triangle.Location = new System.Drawing.Point(210, 81);
            this.rb_triangle.Name = "rb_triangle";
            this.rb_triangle.Size = new System.Drawing.Size(88, 17);
            this.rb_triangle.TabIndex = 6;
            this.rb_triangle.TabStop = true;
            this.rb_triangle.Text = "треугольник";
            this.rb_triangle.UseVisualStyleBackColor = true;
            this.rb_triangle.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_rectangle
            // 
            this.rb_rectangle.AutoSize = true;
            this.rb_rectangle.Location = new System.Drawing.Point(210, 61);
            this.rb_rectangle.Name = "rb_rectangle";
            this.rb_rectangle.Size = new System.Drawing.Size(103, 17);
            this.rb_rectangle.TabIndex = 5;
            this.rb_rectangle.TabStop = true;
            this.rb_rectangle.Text = "прямоугольник";
            this.rb_rectangle.UseVisualStyleBackColor = true;
            this.rb_rectangle.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // rb_square
            // 
            this.rb_square.AutoSize = true;
            this.rb_square.Location = new System.Drawing.Point(210, 37);
            this.rb_square.Name = "rb_square";
            this.rb_square.Size = new System.Drawing.Size(67, 17);
            this.rb_square.TabIndex = 4;
            this.rb_square.TabStop = true;
            this.rb_square.Text = "Квадрат";
            this.rb_square.UseVisualStyleBackColor = true;
            this.rb_square.CheckedChanged += new System.EventHandler(this.radioButton_CheckedChanged);
            // 
            // b_Area
            // 
            this.b_Area.Location = new System.Drawing.Point(20, 76);
            this.b_Area.Name = "b_Area";
            this.b_Area.Size = new System.Drawing.Size(75, 23);
            this.b_Area.TabIndex = 3;
            this.b_Area.Text = "Посчитать";
            this.b_Area.UseVisualStyleBackColor = true;
            this.b_Area.Click += new System.EventHandler(this.b_Area_Click);
            // 
            // mtb_side2
            // 
            this.mtb_side2.Location = new System.Drawing.Point(108, 37);
            this.mtb_side2.Mask = "00000";
            this.mtb_side2.Name = "mtb_side2";
            this.mtb_side2.Size = new System.Drawing.Size(54, 20);
            this.mtb_side2.TabIndex = 2;
            this.mtb_side2.Text = "0";
            this.mtb_side2.ValidatingType = typeof(int);
            // 
            // mtb_side1
            // 
            this.mtb_side1.Location = new System.Drawing.Point(20, 37);
            this.mtb_side1.Mask = "00000";
            this.mtb_side1.Name = "mtb_side1";
            this.mtb_side1.Size = new System.Drawing.Size(54, 20);
            this.mtb_side1.TabIndex = 2;
            this.mtb_side1.Text = "0";
            this.mtb_side1.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сторона 2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "сторона 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.b_searchWordsInFile);
            this.groupBox2.Controls.Add(this.tb_word);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.b_delete);
            this.groupBox2.Controls.Add(this.b_selectFile);
            this.groupBox2.Controls.Add(this.b_move);
            this.groupBox2.Controls.Add(this.b_copy);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tb_newPath);
            this.groupBox2.Controls.Add(this.tb_oldPath);
            this.groupBox2.Controls.Add(this.rb_directory);
            this.groupBox2.Controls.Add(this.rb_file);
            this.groupBox2.Location = new System.Drawing.Point(435, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 458);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задание 4,5";
            // 
            // rb_directory
            // 
            this.rb_directory.AutoSize = true;
            this.rb_directory.Location = new System.Drawing.Point(13, 115);
            this.rb_directory.Name = "rb_directory";
            this.rb_directory.Size = new System.Drawing.Size(57, 17);
            this.rb_directory.TabIndex = 2;
            this.rb_directory.Text = "Папка";
            this.rb_directory.UseVisualStyleBackColor = true;
            this.rb_directory.CheckedChanged += new System.EventHandler(this.radioButtonFile_CheckedChanged);
            // 
            // rb_file
            // 
            this.rb_file.AutoSize = true;
            this.rb_file.Location = new System.Drawing.Point(74, 115);
            this.rb_file.Name = "rb_file";
            this.rb_file.Size = new System.Drawing.Size(54, 17);
            this.rb_file.TabIndex = 2;
            this.rb_file.Text = "Файл";
            this.rb_file.UseVisualStyleBackColor = true;
            this.rb_file.CheckedChanged += new System.EventHandler(this.radioButtonFile_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_reverse);
            this.groupBox3.Controls.Add(this.b_countString);
            this.groupBox3.Controls.Add(this.b_polyndrom);
            this.groupBox3.Controls.Add(this.tb_stringWorker);
            this.groupBox3.Location = new System.Drawing.Point(12, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(417, 147);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Задание2 ";
            // 
            // b_reverse
            // 
            this.b_reverse.Location = new System.Drawing.Point(238, 80);
            this.b_reverse.Name = "b_reverse";
            this.b_reverse.Size = new System.Drawing.Size(142, 23);
            this.b_reverse.TabIndex = 3;
            this.b_reverse.Text = "Переворот строки";
            this.b_reverse.UseVisualStyleBackColor = true;
            this.b_reverse.Click += new System.EventHandler(this.b_reverse_Click);
            // 
            // b_countString
            // 
            this.b_countString.Location = new System.Drawing.Point(238, 50);
            this.b_countString.Name = "b_countString";
            this.b_countString.Size = new System.Drawing.Size(142, 23);
            this.b_countString.TabIndex = 2;
            this.b_countString.Text = "Подсчет строк";
            this.b_countString.UseVisualStyleBackColor = true;
            this.b_countString.Click += new System.EventHandler(this.b_countString_Click);
            // 
            // b_polyndrom
            // 
            this.b_polyndrom.Location = new System.Drawing.Point(237, 20);
            this.b_polyndrom.Name = "b_polyndrom";
            this.b_polyndrom.Size = new System.Drawing.Size(143, 23);
            this.b_polyndrom.TabIndex = 1;
            this.b_polyndrom.Text = "Проверка на полиндром";
            this.b_polyndrom.UseVisualStyleBackColor = true;
            this.b_polyndrom.Click += new System.EventHandler(this.b_polyndrom_Click);
            // 
            // tb_stringWorker
            // 
            this.tb_stringWorker.Location = new System.Drawing.Point(7, 20);
            this.tb_stringWorker.Multiline = true;
            this.tb_stringWorker.Name = "tb_stringWorker";
            this.tb_stringWorker.Size = new System.Drawing.Size(224, 121);
            this.tb_stringWorker.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label_resCheck);
            this.groupBox4.Controls.Add(this.b_chek);
            this.groupBox4.Controls.Add(this.tb_userName);
            this.groupBox4.Controls.Add(this.tb_age);
            this.groupBox4.Controls.Add(this.tb_mail);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.mtb_number);
            this.groupBox4.Location = new System.Drawing.Point(12, 332);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(417, 204);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "задание 3 валидаеция данных";
            // 
            // label_resCheck
            // 
            this.label_resCheck.AutoSize = true;
            this.label_resCheck.Location = new System.Drawing.Point(207, 51);
            this.label_resCheck.Name = "label_resCheck";
            this.label_resCheck.Size = new System.Drawing.Size(0, 13);
            this.label_resCheck.TabIndex = 4;
            // 
            // b_chek
            // 
            this.b_chek.Location = new System.Drawing.Point(23, 167);
            this.b_chek.Name = "b_chek";
            this.b_chek.Size = new System.Drawing.Size(75, 23);
            this.b_chek.TabIndex = 3;
            this.b_chek.Text = "Проверка";
            this.b_chek.UseVisualStyleBackColor = true;
            this.b_chek.Click += new System.EventHandler(this.b_chek_Click);
            // 
            // tb_userName
            // 
            this.tb_userName.Location = new System.Drawing.Point(62, 20);
            this.tb_userName.Name = "tb_userName";
            this.tb_userName.Size = new System.Drawing.Size(285, 20);
            this.tb_userName.TabIndex = 2;
            // 
            // tb_age
            // 
            this.tb_age.Location = new System.Drawing.Point(63, 51);
            this.tb_age.Name = "tb_age";
            this.tb_age.Size = new System.Drawing.Size(100, 20);
            this.tb_age.TabIndex = 2;
            // 
            // tb_mail
            // 
            this.tb_mail.Location = new System.Drawing.Point(65, 89);
            this.tb_mail.Name = "tb_mail";
            this.tb_mail.Size = new System.Drawing.Size(100, 20);
            this.tb_mail.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Телефон";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Возраст";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "ФИО";
            // 
            // mtb_number
            // 
            this.mtb_number.Location = new System.Drawing.Point(65, 125);
            this.mtb_number.Mask = "8(999) 000-0000";
            this.mtb_number.Name = "mtb_number";
            this.mtb_number.Size = new System.Drawing.Size(100, 20);
            this.mtb_number.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // tb_oldPath
            // 
            this.tb_oldPath.Location = new System.Drawing.Point(6, 42);
            this.tb_oldPath.Name = "tb_oldPath";
            this.tb_oldPath.Size = new System.Drawing.Size(384, 20);
            this.tb_oldPath.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Путь к Файлу\\Папке";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Путь для копирования";
            // 
            // tb_newPath
            // 
            this.tb_newPath.Location = new System.Drawing.Point(6, 81);
            this.tb_newPath.Name = "tb_newPath";
            this.tb_newPath.Size = new System.Drawing.Size(384, 20);
            this.tb_newPath.TabIndex = 3;
            // 
            // b_copy
            // 
            this.b_copy.Enabled = false;
            this.b_copy.Location = new System.Drawing.Point(134, 115);
            this.b_copy.Name = "b_copy";
            this.b_copy.Size = new System.Drawing.Size(91, 23);
            this.b_copy.TabIndex = 6;
            this.b_copy.Text = "Копировать";
            this.b_copy.UseVisualStyleBackColor = true;
            this.b_copy.Click += new System.EventHandler(this.b_copy_Click);
            // 
            // b_move
            // 
            this.b_move.Enabled = false;
            this.b_move.Location = new System.Drawing.Point(231, 115);
            this.b_move.Name = "b_move";
            this.b_move.Size = new System.Drawing.Size(91, 23);
            this.b_move.TabIndex = 6;
            this.b_move.Text = "Перенести";
            this.b_move.UseVisualStyleBackColor = true;
            this.b_move.Click += new System.EventHandler(this.b_move_Click);
            // 
            // b_selectFile
            // 
            this.b_selectFile.Location = new System.Drawing.Point(127, 15);
            this.b_selectFile.Name = "b_selectFile";
            this.b_selectFile.Size = new System.Drawing.Size(111, 23);
            this.b_selectFile.TabIndex = 7;
            this.b_selectFile.Text = "Выбрать файл";
            this.b_selectFile.UseVisualStyleBackColor = true;
            this.b_selectFile.Click += new System.EventHandler(this.b_selectFile_Click);
            // 
            // b_delete
            // 
            this.b_delete.Location = new System.Drawing.Point(328, 115);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(75, 23);
            this.b_delete.TabIndex = 8;
            this.b_delete.Text = "Удалить";
            this.b_delete.UseVisualStyleBackColor = true;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "слово для поиска";
            // 
            // tb_word
            // 
            this.tb_word.Location = new System.Drawing.Point(10, 203);
            this.tb_word.Name = "tb_word";
            this.tb_word.Size = new System.Drawing.Size(125, 20);
            this.tb_word.TabIndex = 10;
            // 
            // b_searchWordsInFile
            // 
            this.b_searchWordsInFile.Enabled = false;
            this.b_searchWordsInFile.Location = new System.Drawing.Point(164, 203);
            this.b_searchWordsInFile.Name = "b_searchWordsInFile";
            this.b_searchWordsInFile.Size = new System.Drawing.Size(124, 23);
            this.b_searchWordsInFile.TabIndex = 11;
            this.b_searchWordsInFile.Text = "поиск";
            this.b_searchWordsInFile.UseVisualStyleBackColor = true;
            this.b_searchWordsInFile.Click += new System.EventHandler(this.b_searchWordsInFile_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "результат поиска...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 534);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_triangle;
        private System.Windows.Forms.RadioButton rb_rectangle;
        private System.Windows.Forms.RadioButton rb_square;
        private System.Windows.Forms.Button b_Area;
        private System.Windows.Forms.MaskedTextBox mtb_side2;
        private System.Windows.Forms.MaskedTextBox mtb_side1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_resArea;
        private System.Windows.Forms.Button b_polyndrom;
        private System.Windows.Forms.TextBox tb_stringWorker;
        private System.Windows.Forms.Button b_reverse;
        private System.Windows.Forms.Button b_countString;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtb_number;
        private System.Windows.Forms.TextBox tb_mail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_resCheck;
        private System.Windows.Forms.Button b_chek;
        private System.Windows.Forms.TextBox tb_userName;
        private System.Windows.Forms.TextBox tb_age;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton rb_directory;
        private System.Windows.Forms.RadioButton rb_file;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_oldPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_newPath;
        private System.Windows.Forms.Button b_copy;
        private System.Windows.Forms.Button b_move;
        private System.Windows.Forms.Button b_selectFile;
        private System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Button b_searchWordsInFile;
        private System.Windows.Forms.TextBox tb_word;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}

