using System;

namespace MyTitlePageApp
{
    partial class TitlePageForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.comboBoxCities = new System.Windows.Forms.ComboBox();
            this.textBoxNewCity = new System.Windows.Forms.TextBox();
            this.btnUpdateCity = new System.Windows.Forms.Button();
            this.labelCity = new System.Windows.Forms.Label();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.numericUpDownLeftMargin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRightMargin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownTopMargin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownBottomMargin = new System.Windows.Forms.NumericUpDown();
            this.btnSetMargins = new System.Windows.Forms.Button();
            this.comboBoxFontFormat = new System.Windows.Forms.ComboBox();
            this.labelFontFormat = new System.Windows.Forms.Label();
            this.btnSetFontColor = new System.Windows.Forms.Button();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.textBoxStudentName = new System.Windows.Forms.TextBox();
            this.btnIncreaseYear = new System.Windows.Forms.Button();
            this.btnDecreaseYear = new System.Windows.Forms.Button();
            this.labelDepartment = new System.Windows.Forms.Label();
            this.textBoxDepartment = new System.Windows.Forms.TextBox();
            this.checkBoxCapsLock = new System.Windows.Forms.CheckBox();
            this.labelDiscipline = new System.Windows.Forms.Label();
            this.textBoxDiscipline = new System.Windows.Forms.TextBox();
            this.labelWorkTitle = new System.Windows.Forms.Label();
            this.textBoxWorkTitle = new System.Windows.Forms.TextBox();
            this.froupName = new System.Windows.Forms.Label();
            this.textBoxTopic = new System.Windows.Forms.TextBox();
            this.labelAssignment = new System.Windows.Forms.Label();
            this.textBoxAssignment = new System.Windows.Forms.TextBox();
            this.labelInstructor = new System.Windows.Forms.Label();
            this.textBoxInstructor = new System.Windows.Forms.TextBox();
            this.btnCreateTitlePage = new System.Windows.Forms.Button();
            // 
            // comboBoxCities
            // 
            this.comboBoxCities.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCities.FormattingEnabled = true;
            this.comboBoxCities.Location = new System.Drawing.Point(20, 30);
            this.comboBoxCities.Name = "comboBoxCities";
            this.comboBoxCities.Size = new System.Drawing.Size(200, 21);
            this.comboBoxCities.TabIndex = 0;
            // 
            // textBoxNewCity
            // 
            this.textBoxNewCity.Location = new System.Drawing.Point(20, 70);
            this.textBoxNewCity.Name = "textBoxNewCity";
            this.textBoxNewCity.Size = new System.Drawing.Size(200, 20);
            this.textBoxNewCity.TabIndex = 1;
            // 
            // btnUpdateCity
            // 
            this.btnUpdateCity.Location = new System.Drawing.Point(240, 68);
            this.btnUpdateCity.Name = "btnUpdateCity";
            this.btnUpdateCity.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateCity.TabIndex = 2;
            this.btnUpdateCity.Text = "Обновить";
            this.btnUpdateCity.UseVisualStyleBackColor = true;
            this.btnUpdateCity.Click += new System.EventHandler(this.btnUpdateCity_Click);
            // 
            // labelCity
            // 
            this.labelCity.AutoSize = true;
            this.labelCity.Location = new System.Drawing.Point(20, 10);
            this.labelCity.Name = "labelCity";
            this.labelCity.Size = new System.Drawing.Size(48, 13);
            this.labelCity.TabIndex = 3;
            this.labelCity.Text = "Город:";
            
             
            this.numericUpDownLeftMargin.Location = new System.Drawing.Point(20, 120);
            this.numericUpDownLeftMargin.Name = "numericUpDownLeftMargin";
            this.numericUpDownLeftMargin.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownLeftMargin.TabIndex = 4;
            // 
            // numericUpDownRightMargin
            // 
            this.numericUpDownRightMargin.Location = new System.Drawing.Point(100, 120);
            this.numericUpDownRightMargin.Name = "numericUpDownRightMargin";
            this.numericUpDownRightMargin.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownRightMargin.TabIndex = 5;
            // 
            // numericUpDownTopMargin
            // 
            this.numericUpDownTopMargin.Location = new System.Drawing.Point(20, 160);
            this.numericUpDownTopMargin.Name = "numericUpDownTopMargin";
            this.numericUpDownTopMargin.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownTopMargin.TabIndex = 6;
            // 
            // numericUpDownBottomMargin
            // 
            this.numericUpDownBottomMargin.Location = new System.Drawing.Point(100, 160);
            this.numericUpDownBottomMargin.Name = "numericUpDownBottomMargin";
            this.numericUpDownBottomMargin.Size = new System.Drawing.Size(60, 20);
            this.numericUpDownBottomMargin.TabIndex = 7;
            // 
            // btnSetMargins
            // 
            this.btnSetMargins.Location = new System.Drawing.Point(180, 140);
            this.btnSetMargins.Name = "btnSetMargins";
            this.btnSetMargins.Size = new System.Drawing.Size(160, 23);
            this.btnSetMargins.TabIndex = 8;
            this.btnSetMargins.Text = "Установить отступы л п в н";
            this.btnSetMargins.UseVisualStyleBackColor = true;
            this.btnSetMargins.Click += new System.EventHandler(this.btnSetMargins_Click);
            // 
            // comboBoxFontFormat
            // 
            this.comboBoxFontFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFontFormat.FormattingEnabled = true;
            this.comboBoxFontFormat.Items.AddRange(new object[] {
            "Calibri",
            "Times New Roman",
            "Courier New"});
            this.comboBoxFontFormat.Location = new System.Drawing.Point(20, 200);
            this.comboBoxFontFormat.Name = "comboBoxFontFormat";
            this.comboBoxFontFormat.Size = new System.Drawing.Size(200, 21);
            this.comboBoxFontFormat.TabIndex = 9;
            this.comboBoxFontFormat.SelectedIndexChanged += new System.EventHandler(this.comboBoxFontFormat_SelectedIndexChanged);
            // 
            // labelFontFormat
            // 
            this.labelFontFormat.AutoSize = true;
            this.labelFontFormat.Location = new System.Drawing.Point(20, 180);
            this.labelFontFormat.Name = "labelFontFormat";
            this.labelFontFormat.Size = new System.Drawing.Size(105, 13);
            this.labelFontFormat.TabIndex = 10;
            this.labelFontFormat.Text = "Семейство шрифтов:";
            // 
            // btnSetFontColor
            // 
            this.btnSetFontColor.Location = new System.Drawing.Point(20, 240);
            this.btnSetFontColor.Name = "btnSetFontColor";
            this.btnSetFontColor.Size = new System.Drawing.Size(75, 23);
            this.btnSetFontColor.TabIndex = 11;
            this.btnSetFontColor.Text = "Цвет шрифта";
            this.btnSetFontColor.UseVisualStyleBackColor = true;
            this.btnSetFontColor.Click += new System.EventHandler(this.btnSetFontColor_Click);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(20, 270);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(41, 13);
            this.labelYear.TabIndex = 12;
            this.labelYear.Text = "Год:";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(70, 270);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(40, 20);
            this.textBoxYear.TabIndex = 13;
            this.textBoxYear.Text = DateTime.Now.Year.ToString();
            // 
            // btnIncreaseYear
            // 
            this.btnIncreaseYear.Location = new System.Drawing.Point(120, 270);
            this.btnIncreaseYear.Name = "btnIncreaseYear";
            this.btnIncreaseYear.Size = new System.Drawing.Size(30, 23);
            this.btnIncreaseYear.TabIndex = 14;
            this.btnIncreaseYear.Text = "+";
            this.btnIncreaseYear.UseVisualStyleBackColor = true;
            this.btnIncreaseYear.Click += new System.EventHandler(this.btnIncreaseYear_Click);
            // 
            // btnDecreaseYear
            // 
            this.btnDecreaseYear.Location = new System.Drawing.Point(160, 270);
            this.btnDecreaseYear.Name = "btnDecreaseYear";
            this.btnDecreaseYear.Size = new System.Drawing.Size(30, 23);
            this.btnDecreaseYear.TabIndex = 15;
            this.btnDecreaseYear.Text = "-";
            this.btnDecreaseYear.UseVisualStyleBackColor = true;
            this.btnDecreaseYear.Click += new System.EventHandler(this.btnDecreaseYear_Click);
            // 
            // labelDepartment
            // 
            this.labelDepartment.AutoSize = true;
            this.labelDepartment.Location = new System.Drawing.Point(20, 310);
            this.labelDepartment.Name = "labelDepartment";
            this.labelDepartment.Size = new System.Drawing.Size(51, 13);
            this.labelDepartment.TabIndex = 16;
            this.labelDepartment.Text = "Кафедра:";
            // 
            // textBoxDepartment
            // 
            this.textBoxDepartment.Location = new System.Drawing.Point(20, 330);
            this.textBoxDepartment.Name = "textBoxDepartment";
            this.textBoxDepartment.Size = new System.Drawing.Size(200, 20);
            this.textBoxDepartment.TabIndex = 17;
            // 
            // checkBoxCapsLock
            // 
            this.checkBoxCapsLock.AutoSize = true;
            this.checkBoxCapsLock.Location = new System.Drawing.Point(20, 360);
            this.checkBoxCapsLock.Name = "checkBoxCapsLock";
            this.checkBoxCapsLock.Size = new System.Drawing.Size(103, 17);
            this.checkBoxCapsLock.TabIndex = 18;
            this.checkBoxCapsLock.Text = "Использовать CapsLock";
            this.checkBoxCapsLock.UseVisualStyleBackColor = true;
            // 
            // labelDiscipline
            // 
            this.labelDiscipline.AutoSize = true;
            this.labelDiscipline.Location = new System.Drawing.Point(20, 390);
            this.labelDiscipline.Name = "labelDiscipline";
            this.labelDiscipline.Size = new System.Drawing.Size(72, 13);
            this.labelDiscipline.TabIndex = 19;
            this.labelDiscipline.Text = "Дисциплина:";
            // 
            // textBoxDiscipline
            // 
            this.textBoxDiscipline.Location = new System.Drawing.Point(20, 410);
            this.textBoxDiscipline.Name = "textBoxDiscipline";
            this.textBoxDiscipline.Size = new System.Drawing.Size(200, 20);
            this.textBoxDiscipline.TabIndex = 20;
            // 
            // labelWorkTitle
            // 
            this.labelWorkTitle.AutoSize = true;
            this.labelWorkTitle.Location = new System.Drawing.Point(20, 440);
            this.labelWorkTitle.Name = "labelWorkTitle";
            this.labelWorkTitle.Size = new System.Drawing.Size(101, 13);
            this.labelWorkTitle.TabIndex = 21;
            this.labelWorkTitle.Text = "Название работы:";
            // 
            // textBoxWorkTitle
            // 
            this.textBoxWorkTitle.Location = new System.Drawing.Point(20, 460);
            this.textBoxWorkTitle.Name = "textBoxWorkTitle";
            this.textBoxWorkTitle.Size = new System.Drawing.Size(200, 20);
            this.textBoxWorkTitle.TabIndex = 22;
            // 
            // froupName
            // 
            this.froupName.AutoSize = true;
            this.froupName.Location = new System.Drawing.Point(20, 490);
            this.froupName.Name = "froupName";
            this.froupName.Size = new System.Drawing.Size(38, 13);
            this.froupName.TabIndex = 23;
            this.froupName.Text = "Группа:";
            // 
            // textBoxTopic
            // 
            this.textBoxTopic.Location = new System.Drawing.Point(20, 510);
            this.textBoxTopic.Name = "textBoxTopic";
            this.textBoxTopic.Size = new System.Drawing.Size(200, 20);
            this.textBoxTopic.TabIndex = 24;
            // 
            // labelAssignment
            // 
            this.labelAssignment.AutoSize = true;
            this.labelAssignment.Location = new System.Drawing.Point(20, 540);
            this.labelAssignment.Name = "labelAssignment";
            this.labelAssignment.Size = new System.Drawing.Size(66, 13);
            this.labelAssignment.TabIndex = 25;
            this.labelAssignment.Text = "Вариант №:";
            // 
            // textBoxAssignment
            // 
            this.textBoxAssignment.Location = new System.Drawing.Point(20, 560);
            this.textBoxAssignment.Name = "textBoxAssignment";
            this.textBoxAssignment.Size = new System.Drawing.Size(200, 20);
            this.textBoxAssignment.TabIndex = 26;
            
            // labelInstructor
            
            this.labelInstructor.AutoSize = true;
            this.labelInstructor.Location = new System.Drawing.Point(20, 590);
            this.labelInstructor.Name = "labelInstructor";
            this.labelInstructor.Size = new System.Drawing.Size(76, 13);
            this.labelInstructor.TabIndex = 27;
            this.labelInstructor.Text = "Преподаватель:";
            // 
            // textBoxInstructor
            // 
            this.textBoxInstructor.Location = new System.Drawing.Point(20, 610);
            this.textBoxInstructor.Name = "textBoxInstructor";
            this.textBoxInstructor.Size = new System.Drawing.Size(200, 20);
            this.textBoxInstructor.TabIndex = 28;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(20, 640);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(48, 13);
            this.labelStudentName.TabIndex = 29;
            this.labelStudentName.Text = "Студент:";
            //
            // textBoxStudentName
            // 
            this.textBoxStudentName.Location = new System.Drawing.Point(20, 660);
            this.textBoxStudentName.Name = "textBoxStudentName";
            this.textBoxStudentName.Size = new System.Drawing.Size(200, 20);
            this.textBoxStudentName.TabIndex = 30;
            this.textBoxStudentName.Text = "Вихорьков И. Е.";
            // 
            // btnCreateTitlePage
            // 
            this.btnCreateTitlePage.Location = new System.Drawing.Point(20, 690);
            this.btnCreateTitlePage.Name = "btnCreateTitlePage";
            this.btnCreateTitlePage.Size = new System.Drawing.Size(100, 23);
            this.btnCreateTitlePage.TabIndex = 31;
            this.btnCreateTitlePage.Text = "Создать титульный лист";
            this.btnCreateTitlePage.UseVisualStyleBackColor = true;
            this.btnCreateTitlePage.Click += new System.EventHandler(this.btnCreateTitlePage_Click);
            // 
            // TitlePageForm
            // 
            this.ClientSize = new System.Drawing.Size(400, 700);
            this.Controls.Add(this.btnCreateTitlePage);
            this.Controls.Add(this.textBoxInstructor);
            this.Controls.Add(this.labelInstructor);
            this.Controls.Add(this.textBoxAssignment);
            this.Controls.Add(this.labelAssignment);
            this.Controls.Add(this.textBoxTopic);
            this.Controls.Add(this.froupName);
            this.Controls.Add(this.textBoxWorkTitle);
            this.Controls.Add(this.labelWorkTitle);
            this.Controls.Add(this.textBoxDiscipline);
            this.Controls.Add(this.labelDiscipline);
            this.Controls.Add(this.checkBoxCapsLock);
            this.Controls.Add(this.textBoxDepartment);
            this.Controls.Add(this.labelDepartment);
            this.Controls.Add(this.btnDecreaseYear);
            this.Controls.Add(this.btnIncreaseYear);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxStudentName);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.btnSetFontColor);
            this.Controls.Add(this.labelFontFormat);
            this.Controls.Add(this.comboBoxFontFormat);
            this.Controls.Add(this.btnSetMargins);
            this.Controls.Add(this.numericUpDownBottomMargin);
            this.Controls.Add(this.numericUpDownTopMargin);
            this.Controls.Add(this.numericUpDownRightMargin);
            this.Controls.Add(this.numericUpDownLeftMargin);
            this.Controls.Add(this.labelCity);
            this.Controls.Add(this.labelStudentName);
            this.Controls.Add(this.btnUpdateCity);
            this.Controls.Add(this.textBoxNewCity);
            this.Controls.Add(this.comboBoxCities);
            this.Text = "Титульный лист";
        }

        private System.Windows.Forms.ComboBox comboBoxCities;
        private System.Windows.Forms.TextBox textBoxNewCity;
        private System.Windows.Forms.Button btnUpdateCity;
        private System.Windows.Forms.Label labelCity;
          private System.Windows.Forms.Label labelStudentName;
        private System.Windows.Forms.NumericUpDown numericUpDownLeftMargin;
        private System.Windows.Forms.NumericUpDown numericUpDownRightMargin;
        private System.Windows.Forms.NumericUpDown numericUpDownTopMargin;
        private System.Windows.Forms.NumericUpDown numericUpDownBottomMargin;
        private System.Windows.Forms.Button btnSetMargins;
        private System.Windows.Forms.ComboBox comboBoxFontFormat;
        private System.Windows.Forms.Label labelFontFormat;
        private System.Windows.Forms.Button btnSetFontColor;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxYear;

        private System.Windows.Forms.TextBox textBoxStudentName;
        private System.Windows.Forms.Button btnIncreaseYear;
        private System.Windows.Forms.Button btnDecreaseYear;
        private System.Windows.Forms.Label labelDepartment;
        private System.Windows.Forms.TextBox textBoxDepartment;
        private System.Windows.Forms.CheckBox checkBoxCapsLock;
        private System.Windows.Forms.Label labelDiscipline;
        private System.Windows.Forms.TextBox textBoxDiscipline;
        private System.Windows.Forms.Label labelWorkTitle;
        private System.Windows.Forms.TextBox textBoxWorkTitle;
        private System.Windows.Forms.Label froupName;
        private System.Windows.Forms.TextBox textBoxTopic;
        private System.Windows.Forms.Label labelAssignment;
        private System.Windows.Forms.TextBox textBoxAssignment;
        private System.Windows.Forms.Label labelInstructor;
        private System.Windows.Forms.TextBox textBoxInstructor;
        private System.Windows.Forms.Button btnCreateTitlePage;
    }
}
