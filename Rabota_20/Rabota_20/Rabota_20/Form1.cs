using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Rabota_20
{
    public partial class Nomograms : Form
    {
        public Nomograms()
        {
            InitializeComponent();
            string[] RowsFirstNomogram = { "1", "2", "3", "4", "5", "6", "7", "8", "9","10","11" };
            string[] RowsSecondNomogram = { "1", "2", "3", "4", "5", "6"};
            FirstNomogramRowSelectedBox.Items.AddRange(RowsFirstNomogram);
            SecondNomogramRowSelectedBox.Items.AddRange(RowsSecondNomogram);
        }
        private void CreateFirstGraph_Click(object sender, EventArgs e)
        {
            CreateFirstGraph();
        }
        private void CreateSecondGraph_Click(object sender, EventArgs e)
        {
            CreateSecondGraph();
        }
        private void CreateFirstGraph()
        {
            FirstChar.Series.Clear();
            FirstChar.ChartAreas.Clear();
            ChartArea FirstChartArea = new ChartArea
            {
                AxisX =
                {
                    Minimum = 0,
                    Maximum = 100,
                    Interval = 20,
                    Title = "Толщина стали, мм"
                },
                AxisY =
                {
                    Minimum =0,
                    Maximum = 100,
                    Interval = 10,
                    Title = "Экспозиция, мА*мин"
                }
            };
            FirstChartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            FirstChartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            FirstChartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            FirstChartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            FirstChar.ChartAreas.Add(FirstChartArea);
            
            if (!File.Exists("points1.csv"))
            {
                MessageBox.Show($"Файл не найден.");
                return;
            }
            string[] lines = File.ReadAllLines("points1.csv");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                Series series = new Series
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 1,
                    Color = Color.Black
                };
                string[] points = line.Split(';');

                foreach (string point in points)
                {
                    string[] coordinates = point.Split(',');
                    if (coordinates.Length == 2 &&
                        double.TryParse(coordinates[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double x) &&
                        double.TryParse(coordinates[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double y))
                    {
                        series.Points.AddXY(x, y);
                    }
                }
                FirstChar.Series.Add(series);
            }
        }
        private void CreateSecondGraph()
        {
            SecondChart.Series.Clear();
            SecondChart.ChartAreas.Clear();
            ChartArea SecondChartArea = new ChartArea
            {
                AxisX =
            {
                Minimum = 0,
                Maximum = 140,
                Interval = 20,
                Title = "Толщина стали, мм"
            },
                AxisY =
            {
                IsLogarithmic=true,
                Minimum =0.01,
                Maximum = 40,
                Title = "Экспозиция, г-экВ*ч"
            }
            };
            SecondChartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            SecondChartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            SecondChartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            SecondChartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            SecondChart.ChartAreas.Add(SecondChartArea);
            if (!File.Exists("points2.csv"))
            {
                MessageBox.Show($"Файл не найден.");
                return;
            }
            string[] lines = File.ReadAllLines("points2.csv");
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];

                Series series = new Series
                {
                    ChartType = SeriesChartType.Line,
                    BorderWidth = 1,
                    Color = Color.Black
                };

                string[] points = line.Split(';');

                foreach (string point in points)
                {
                    string[] coordinates = point.Split(',');

                    if (coordinates.Length == 2 &&
                        double.TryParse(coordinates[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double x) &&
                        double.TryParse(coordinates[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double y))
                    {
                        series.Points.AddXY(x, y);
                    }
                }
                SecondChart.Series.Add(series);
            }
        }
        private void FirstGraphRowSelectedButton_Click(object sender, EventArgs e)
        {
            FirstChar.Series.Clear();
            FirstChar.ChartAreas.Clear();
            ChartArea FirstChartArea = new ChartArea
            {
                AxisX =
                {
                    Minimum = 0,
                    Maximum = 100,
                    Interval = 20,
                    Title = "Толщина стали, мм"
                },
                AxisY =
                {
                    Minimum =0,
                    Maximum = 100,
                    Interval = 10,
                    Title = "Экспозиция, мА*мин"
                }
            };
            FirstChartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            FirstChartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            FirstChartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            FirstChartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            FirstChar.ChartAreas.Add(FirstChartArea);
            if (!File.Exists("points1.csv"))
            {
                MessageBox.Show($"Файл  не найден.");
                return;
            }
            string[] lines = File.ReadAllLines("points1.csv");
            int index = FirstNomogramRowSelectedBox.SelectedIndex;
            string line = lines[index];
            Series series = new Series
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 1,
                Color = Color.Black
            };

            string[] points = line.Split(';');

            foreach (string point in points)
            {
                string[] coordinates = point.Split(',');

                if (coordinates.Length == 2 &&
                    double.TryParse(coordinates[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double x) &&
                    double.TryParse(coordinates[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double y))
                {
                    series.Points.AddXY(x, y);
                }
            }
            FirstChar.Series.Add(series);
            
            
        }
        private void SecondGraphRowSelectedButton_Click(object sender, EventArgs e)
        {
            SecondChart.Series.Clear();
            SecondChart.ChartAreas.Clear();
            ChartArea SecondChartArea = new ChartArea
            {
                AxisX =
                {
                    Minimum = 0,
                    Maximum = 140,
                    Interval = 20,
                    Title = "Толщина стали, мм"
                },
                AxisY =
                {
                    IsLogarithmic=true,
                    Minimum =0.01,
                    Maximum = 40,
                    Title = "Экспозиция, г-экВ*ч"
                }
            };
            SecondChartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
            SecondChartArea.AxisX.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            SecondChartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
            SecondChartArea.AxisY.MajorGrid.LineDashStyle = ChartDashStyle.Dash;
            this.SecondChart.ChartAreas.Add(SecondChartArea);
            if (!File.Exists("points2.csv"))
            {
                MessageBox.Show($"Файл не найден.");
                return;
            }
            string[] lines = File.ReadAllLines("points2.csv");
            int index = SecondNomogramRowSelectedBox.SelectedIndex;
            string line = lines[index];
            Series series = new Series
            {
                ChartType = SeriesChartType.Line,
                BorderWidth = 1,
                Color = Color.Black
            };
            string[] points = line.Split(';');
            foreach (string point in points)
            {
                string[] coordinates = point.Split(',');

                if (coordinates.Length == 2 &&
                    double.TryParse(coordinates[0], NumberStyles.Float, CultureInfo.InvariantCulture, out double x) &&
                    double.TryParse(coordinates[1], NumberStyles.Float, CultureInfo.InvariantCulture, out double y))
                {
                    series.Points.AddXY(x, y);
                }
            }
            this.SecondChart.Series.Add(series);
        }
    }
}