using System;
using System.Drawing;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace MyTitlePageApp
{
    public partial class TitlePageForm : Form
    {
        private Word.Application wordApp;
        private Word.Document doc;

        public TitlePageForm()
        {
            InitializeComponent();
            InitializeCities();
            InitializeWord();
        }

        private void InitializeCities()
        {
            string[] cities = { "Москва", "Саратов", "Санкт-Петербург", "Челябинск", "Жуковский", "Троицк" };
            comboBoxCities.Items.AddRange(cities);
            comboBoxCities.SelectedIndex = 0; // Установить первый город по умолчанию
        }

        private void InitializeWord()
        {
            wordApp = new Word.Application();
            wordApp.Visible = false; // Скрыть приложение Word
            doc = wordApp.Documents.Add();
        }

        private void btnUpdateCity_Click(object sender, EventArgs e)
        {
            string newCity = textBoxNewCity.Text.Trim();
            if (!string.IsNullOrEmpty(newCity))
            {
                comboBoxCities.Items.Add(newCity);
                comboBoxCities.SelectedItem = newCity; // Установить новый город как выбранный
                textBoxNewCity.Clear();
            }
        }

        private void btnSetMargins_Click(object sender, EventArgs e)
        {
            // Установка полей документа
            doc.PageSetup.LeftMargin = (float)numericUpDownLeftMargin.Value * 28.35f; // 1 пункт = 1/72 дюйма = 28.35 пунктов
            doc.PageSetup.RightMargin = (float)numericUpDownRightMargin.Value * 28.35f;
            doc.PageSetup.TopMargin = (float)numericUpDownTopMargin.Value * 28.35f;
            doc.PageSetup.BottomMargin = (float)numericUpDownBottomMargin.Value * 28.35f;
        }

        private void comboBoxFontFormat_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Установка шрифта
            doc.Content.Font.Name = comboBoxFontFormat.SelectedItem.ToString();
        }

        private void btnSetFontColor_Click(object sender, EventArgs e)
        {
            // Установка цвета шрифта
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                doc.Content.Font.Color = (Word.WdColor)System.Drawing.ColorTranslator.ToOle(colorDialog.Color);
            }
        }

        private void btnIncreaseYear_Click(object sender, EventArgs e)
        {
            int currentYear;
            if (int.TryParse(textBoxYear.Text, out currentYear))
            {
                textBoxYear.Text = (currentYear + 1).ToString();
            }
        }

        private void btnDecreaseYear_Click(object sender, EventArgs e)
        {
            int currentYear;
            if (int.TryParse(textBoxYear.Text, out currentYear) && currentYear > 0)
            {
                textBoxYear.Text = (currentYear - 1).ToString();
            }
        }

      private void btnCreateTitlePage_Click(object sender, EventArgs e)
{
    // Создание титульного листа
    try
    {
        Word.Paragraph objParagraph = doc.Content.Paragraphs.Add();
        doc.Activate();

        // Формирование заголовков
        InsertText("Министерство транспорта Российской Федерации", 16, true, Word.WdParagraphAlignment.wdAlignParagraphCenter);
        InsertText("Федеральное государственное автономное образовательное", 12, false, Word.WdParagraphAlignment.wdAlignParagraphCenter);
        InsertText("учреждение высшего образования", 12, false, Word.WdParagraphAlignment.wdAlignParagraphCenter);
        InsertText("«Российский университет транспорта (МИИТ)» (РУТ (МИИТ)", 12, false, Word.WdParagraphAlignment.wdAlignParagraphCenter);

        // Создание таблицы для кафедры
        object EndOfDoc = "\\endofdoc";
        Word.Table objTable;
        Word.Range objWordRange;
        objWordRange = doc.Bookmarks.get_Item(ref EndOfDoc).Range;

        // Передаем Missing.Value как ref
        object missing = System.Reflection.Missing.Value;
        objTable = doc.Tables.Add(objWordRange, 1, 1, ref missing, ref missing);
        objTable.Range.ParagraphFormat.SpaceAfter = 0;
        objTable.Borders[Word.WdBorderType.wdBorderTop].Visible = true;
        InsertText("Институт транспортной техники и систем управления", 12, false, Word.WdParagraphAlignment.wdAlignParagraphCenter);
        InsertText("Кафедра «"+textBoxDepartment.Text+"»", 12, false, Word.WdParagraphAlignment.wdAlignParagraphCenter);

        spacesAfter(4);

        InsertText("Предмет: «" + textBoxDiscipline.Text + "»", 16, false);

        InsertText("Тема работы: «" + textBoxWorkTitle.Text + "»", 16, false);
        InsertParagraphBreak();

       

        InsertParagraphBreak();

        spacesAfter(4);

        InsertStudentData();

        spacesAfter(4);
        // Используем значения из comboBoxCities и textBoxYear
        InsertText(comboBoxCities.SelectedItem.ToString() + " – " + textBoxYear.Text + "г.", 16, false, Word.WdParagraphAlignment.wdAlignParagraphCenter);

        


        // Сохранение документа
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            doc.SaveAs2(saveFileDialog.FileName);
            MessageBox.Show("Титульный лист успешно создан!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // Закрытие документа и приложения
        doc.Close();
        wordApp.Quit();
    }
    catch (Exception ex)
    {
        MessageBox.Show("Произошла ошибка. Попробуйте снова: " + ex.Message);
    }
}


        private void InsertText(string text, int fontSize, bool isBold, Word.WdParagraphAlignment alignment = Word.WdParagraphAlignment.wdAlignParagraphLeft)
        {
            var para = doc.Content.Paragraphs.Add();
            para.Range.Text = text;
            para.Range.Font.Size = fontSize;
            para.Range.Font.Name = comboBoxFontFormat.SelectedItem.ToString();
            para.Range.Font.Bold = isBold ? 1 : 0; // 1 для жирного, 0 для обычного
            para.Range.ParagraphFormat.Alignment = alignment;
            para.Range.InsertParagraphAfter();
        }

        private void InsertParagraphBreak()
        {
            doc.Content.Paragraphs.Add();
        }

        private void InsertStudentData()
        {
            object EndOfDoc = "\\endofdoc";
            Word.Table objTable;
            Word.Range objWordRange;
            objWordRange = doc.Bookmarks.get_Item(ref EndOfDoc).Range;

            // Передаем Missing.Value как ref
            object missing = System.Reflection.Missing.Value;
            objTable = doc.Tables.Add(objWordRange, 1, 1, ref missing, ref missing);
            objTable.Range.ParagraphFormat.SpaceAfter = 0;

            // Вставка информации о студенте
            string studentInfo = $"Выполнил: ст. гр. "+textBoxTopic.Text+"\n"+textBoxStudentName.Text+"\nВариант №"+textBoxAssignment.Text+"\nПроверил: " + textBoxInstructor.Text;
            objTable.Cell(1, 1).Range.Text = studentInfo;
            objTable.Cell(1, 1).Range.ParagraphFormat.Alignment = Word.WdParagraphAlignment.wdAlignParagraphRight;
        }

        private void spacesAfter(int count)
        {
            for (int i = 0; i < count; i++)
            {
                doc.Content.Paragraphs.Add();
            }
        }
    }
}
