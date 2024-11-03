using System;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace MyTitlePageApp
{
    public partial class MigrationCard : Form
    {
        private Word.Application wordApp;
        private Word.Document docTwo;

        public MigrationCard()
        {
            InitializeComponent();
            InitializeWord();
        }

        private void InitializeWord()
        {
            wordApp = new Word.Application();
            wordApp.Visible = false; // Скрыть приложение Word
            docTwo = wordApp.Documents.Add();
        }

private void btnGenerateMigrationCard_Click(object sender, EventArgs e)
{
    try
    {
        docTwo.Content.Font.Name = "Times New Roman";
        // Вставка утверждения
        InsertText("Утверждена", 12, false, Word.WdParagraphAlignment.wdAlignParagraphRight);
        InsertText("распоряжением Правительства", 12, false, Word.WdParagraphAlignment.wdAlignParagraphRight);
        InsertText("Российской Федерации", 12, false, Word.WdParagraphAlignment.wdAlignParagraphRight);
        InsertText("от 26 мая 2005 г. № 667-р", 12, false, Word.WdParagraphAlignment.wdAlignParagraphRight);
        InsertText("(в ред. от 5 марта 2018 г.)", 12, false, Word.WdParagraphAlignment.wdAlignParagraphRight, true);
        InsertParagraphBreak();

        // Вставка заголовка анкеты
        InsertText("АНКЕТА", 16, true, Word.WdParagraphAlignment.wdAlignParagraphCenter);
        InsertParagraphBreak();

        // Вставка ФИО и места для фото
        InsertText("1. Фамилия: _______________" + textBoxSurname.Text, 12, false, Word.WdParagraphAlignment.wdAlignParagraphLeft);
        InsertText("Имя: _______________" + textBoxName.Text, 12, false, Word.WdParagraphAlignment.wdAlignParagraphLeft);
        InsertText("Отчество: _______________" + textBoxPatronymic.Text, 12, false, Word.WdParagraphAlignment.wdAlignParagraphLeft);
        InsertParagraphBreak();


        Word.Range rangeBeforeTable = docTwo.Content.Paragraphs.Add().Range;
        rangeBeforeTable.InsertParagraphAfter(); // Вставляем пустую строку
        Word.Table objTable = docTwo.Tables.Add(rangeBeforeTable, 6, 2); 

        // Заполнение левой колонки вопросами
        objTable.Cell(1, 1).Range.Text = "2. Если изменяли фамилию, имя или отчество, то укажите их, а также когда, где и по какой причине изменяли:";
        objTable.Cell(2, 1).Range.Text = "3. Число, месяц, год и место рождения (село, деревня, город, район, область, край, республика, страна):";
        objTable.Cell(3, 1).Range.Text = "4. Гражданство (если изменяли, то укажите, когда и по какой причине, если имеете гражданство другого государства – укажите):";
        objTable.Cell(4, 1).Range.Text = "5. Образование (когда и какие учебные заведения окончили, номера дипломов):";
        objTable.Cell(5, 1).Range.Text = "6. Послевузовское профессиональное образование: адьюнктура, докторантура (наименование образовательного или научного учреждения, год окончания):";
        objTable.Cell(6, 1).Range.Text = "7. Какими иностранными языками и языками народов Российской Федерации владеете и в какой степени (читаете и переводите со словарем, читаете и можете объясняться, владеете свободно):";

        // Заполнение правой колонки ответами из текстовых полей
        objTable.Cell(1, 2).Range.Text = textBoxQuestion1.Text;
        objTable.Cell(2, 2).Range.Text = textBoxQuestion2.Text;
        objTable.Cell(3, 2).Range.Text = textBoxQuestion3.Text;
        objTable.Cell(4, 2).Range.Text = textBoxQuestion4.Text;
        objTable.Cell(5, 2).Range.Text = textBoxQuestion5.Text;
        objTable.Cell(6, 2).Range.Text = textBoxQuestion6.Text;

        // Настройка таблицы
        objTable.Borders.Enable = 1;

        // Сохранение документа
        SaveFileDialog saveFileDialog = new SaveFileDialog();
        saveFileDialog.Filter = "Word Documents (*.docx)|*.docx";
        if (saveFileDialog.ShowDialog() == DialogResult.OK)
        {
            docTwo.SaveAs2(saveFileDialog.FileName);
            MessageBox.Show("Анкета успешно создана!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}



        
        private void InsertText(string text, int fontSize, bool bold, Word.WdParagraphAlignment alignment, bool italic = false)
{
    Word.Paragraph objParagraph = docTwo.Content.Paragraphs.Add();
    objParagraph.Range.Text = text;
    objParagraph.Range.Font.Size = fontSize;
    objParagraph.Range.Font.Bold = bold ? 1 : 0;
    objParagraph.Range.Font.Italic = italic ? 1 : 0;
    objParagraph.Alignment = alignment;
    objParagraph.Range.InsertParagraphAfter();
}


        private void InsertParagraphBreak()
        {
            Word.Paragraph objParagraph = docTwo.Content.Paragraphs.Add();
            objParagraph.Range.InsertParagraphAfter();
        }

        private void MigrationCard_Load(object sender, EventArgs e)
        {

        }
       
       
