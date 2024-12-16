
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using ExcelSupport;


namespace Rabota_18
{
    public partial class Rabota_18 : Form
    {
        public Rabota_18()
        {
            InitializeComponent();
        }

        private void ButtonPreview_Click(object sender, EventArgs e)
        {
            string[] headers = " №;Наименование дисциплина;всего часов в год;Переаттестация часов по нормативн. учебному плану;ауд. часов в год;5 семестр (18 недель) ауд. часов в семестре;5 семестр (18 недель) ауд. часы в неделю всего ;5 семестр (18 недель) ауд. часы в неделю лекции;5 семестр (18 недель) ауд. часы в неделю семинары и практ. занятия;5 семестр (18 недель) Форма аттестации;5 семестр (18 недель) курсовая работа(* - по выбору)".Split(new char[] { ';' });
            string dataCsvPath = @"C:\Users\ЕГОР\source\repos\Rabota_18\Rabota_18\bin\Debug\DataCsv.csv";
            foreach (string header in headers)
            {
                dataGridView.Columns.Add(header, header);
            }

            StreamReader reader = new StreamReader(dataCsvPath);
            for (int i = 0; i < 4; i++)
            {
                string line = reader.ReadLine();
                string[] row = line.Split(new char[] { ';' });
                dataGridView.Rows.Add(row);
            }
            reader.Close();
        }

        private void ExcelFile_Click(object sender, EventArgs e)
        {
            string[] headers = " № п/п;Наименование дисциплина;всего часов в год;Переаттестация часов по нормативн. учебному плану;ауд. часов в год;".Split(new char[] { ';' });
            string dataCsvPath = @"C:\Users\ЕГОР\source\repos\Rabota_18\Rabota_18\bin\Debug\DataCsv.csv";
            Excel.Application app = new Excel.Application();
            app.Visible = false;
            Excel.Workbook wb = app.Workbooks.Add(Missing.Value);
            Excel.Worksheet ws = (Excel.Worksheet)wb.Sheets.Add();
            ws.Activate();
            ws.Range[ExcelSupportMethods.ExcelCellTranslator(1, 1), ExcelSupportMethods.ExcelCellTranslator(3, 1)].Merge();
            ws.Range[ExcelSupportMethods.ExcelCellTranslator(1, 2), ExcelSupportMethods.ExcelCellTranslator(3, 2)].Merge();
            ws.Range[ExcelSupportMethods.ExcelCellTranslator(1, 3), ExcelSupportMethods.ExcelCellTranslator(3, 3)].Merge();
            ws.Range[ExcelSupportMethods.ExcelCellTranslator(1, 4), ExcelSupportMethods.ExcelCellTranslator(3, 4)].Merge();
            ws.Range[ExcelSupportMethods.ExcelCellTranslator(1, 5), ExcelSupportMethods.ExcelCellTranslator(3, 5)].Merge();
            for (int i = 0; i < 5; i++)
            {
                ws.Cells[1, i + 1] = headers[i];
                ws.Cells[1, i + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            }
            ws.Cells[1, 1] = "№" + "\n" + "п/п";
            ws.Cells[1, 4] = "переаттестация часов по" + "\n" + "нормативн. учебному плану";
            ws.Cells[1, 1].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[1, 2].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[1, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[1, 3].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[1, 3].Orientation = Excel.XlOrientation.xlUpward;
            ws.Cells[1, 4].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[1, 4].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[1, 4].Orientation = Excel.XlOrientation.xlUpward;
            ws.Cells[1, 5].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[1, 5].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[1, 5].Orientation = Excel.XlOrientation.xlUpward;
            ws.Range[ExcelSupportMethods.ExcelCellTranslator(1, 6), ExcelSupportMethods.ExcelCellTranslator(1, 11)].Merge();
            ws.Range[ExcelSupportMethods.ExcelCellTranslator(2, 6), ExcelSupportMethods.ExcelCellTranslator(3, 6)].Merge();
            ws.Range[ExcelSupportMethods.ExcelCellTranslator(2, 7), ExcelSupportMethods.ExcelCellTranslator(2, 9)].Merge();
            ws.Range[ExcelSupportMethods.ExcelCellTranslator(2, 10), ExcelSupportMethods.ExcelCellTranslator(3, 10)].Merge();
            ws.Range[ExcelSupportMethods.ExcelCellTranslator(2,11), ExcelSupportMethods.ExcelCellTranslator(3, 11)].Merge();
            ws.Cells[1, 6] = "5 семестр (18 недель)";
            ws.Cells[1, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[1, 6].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[2,6]="ауд. часов в семестре";
            ws.Cells[2, 6].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[2, 6].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[2, 6].Orientation = Excel.XlOrientation.xlUpward;
            ws.Cells[2, 7] = "ауд. часы в неделю";
            ws.Cells[2, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[2, 7].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[2, 10] = "Форма аттестации";
            ws.Cells[2, 10].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[2, 10].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[2, 10].Orientation = Excel.XlOrientation.xlUpward;
            ws.Cells[2, 11] = "курсовая работа (*" + "\n"+ "-по выбору)";
            ws.Cells[2, 11].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[2, 11].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[2, 11].Orientation = Excel.XlOrientation.xlUpward;
            ws.Cells[3, 7] = "всего";
            ws.Cells[3, 7].Orientation = Excel.XlOrientation.xlUpward;
            ws.Cells[3, 7].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[3, 7].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[3, 8] = "лекции";
            ws.Cells[3, 8].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[3, 8].VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[3, 8].Orientation = Excel.XlOrientation.xlUpward;
            ws.Cells[3, 9] = "семинары и" + "\n" + "практ." + "\n" + "занятия";
            ws.Cells[3, 9].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            ws.Cells[3, 9].Orientation = Excel.XlOrientation.xlUpward;
            ws.Rows[1].RowHeight = 100;
            ws.Rows[2].RowHeight = 50;
            ws.Columns[2].ColumnWidth = 30;
            ws.Columns[10].ColumnWidth = 20;
            StreamReader reader = new StreamReader(dataCsvPath);
            for (int i = 0; i < 4; i++)
            {
                string line = reader.ReadLine();
                string[] row = line.Split(new char[] { ';' });
                for (int j = 0; j < row.Length; j++)
                {
                    ws.Cells[i + 4, j + 1] = row[j];
                    ws.Cells[i + 4, j + 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                }
            }
            reader.Close();
            ws.Cells[7, 10] = "Экзаменов 0," + "\n" + "зачетов 1";
            ws.Range[ExcelSupportMethods.ExcelCellTranslator(1, 1), ExcelSupportMethods.ExcelCellTranslator(7, 11)].Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            app.UserControl = true;
            wb.SaveCopyAs(Application.StartupPath + Name + ".xlsx");
            wb.Close(false);
        }
    }
}



