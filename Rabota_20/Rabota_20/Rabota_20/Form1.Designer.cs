namespace Rabota_20
{
    partial class Nomograms
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.FirstChar = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.SecondChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.FirstNomogramRowSelectedBox = new System.Windows.Forms.ComboBox();
            this.SecondNomogramRowSelectedBox = new System.Windows.Forms.ComboBox();
            this.RowSelectedButton1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FirstChar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondChart)).BeginInit();
            this.SuspendLayout();
            // 
            // FirstChar
            // 
            this.FirstChar.Location = new System.Drawing.Point(242, 60);
            this.FirstChar.Name = "FirstChar";
            this.FirstChar.Size = new System.Drawing.Size(374, 351);
            this.FirstChar.TabIndex = 5;
            this.FirstChar.Text = "FirstChar";
            // 
            // SecondChart
            // 
            this.SecondChart.Location = new System.Drawing.Point(756, 60);
            this.SecondChart.Name = "SecondChart";
            this.SecondChart.Size = new System.Drawing.Size(374, 351);
            this.SecondChart.TabIndex = 6;
            this.SecondChart.Text = "SecondChart";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(242, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Отобразить номограмму №1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.CreateFirstGraph_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(756, 441);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(374, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Отобразить номограмму №2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.CreateSecondGraph_Click);
            // 
            // FirstNomogramRowSelectedBox
            // 
            this.FirstNomogramRowSelectedBox.FormattingEnabled = true;
            this.FirstNomogramRowSelectedBox.Location = new System.Drawing.Point(550, 511);
            this.FirstNomogramRowSelectedBox.Name = "FirstNomogramRowSelectedBox";
            this.FirstNomogramRowSelectedBox.Size = new System.Drawing.Size(66, 24);
            this.FirstNomogramRowSelectedBox.TabIndex = 9;
            // 
            // SecondNomogramRowSelectedBox
            // 
            this.SecondNomogramRowSelectedBox.FormattingEnabled = true;
            this.SecondNomogramRowSelectedBox.Location = new System.Drawing.Point(1064, 507);
            this.SecondNomogramRowSelectedBox.Name = "SecondNomogramRowSelectedBox";
            this.SecondNomogramRowSelectedBox.Size = new System.Drawing.Size(66, 24);
            this.SecondNomogramRowSelectedBox.TabIndex = 10;
            // 
            // RowSelectedButton1
            // 
            this.RowSelectedButton1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RowSelectedButton1.Location = new System.Drawing.Point(242, 497);
            this.RowSelectedButton1.Name = "RowSelectedButton1";
            this.RowSelectedButton1.Size = new System.Drawing.Size(302, 50);
            this.RowSelectedButton1.TabIndex = 11;
            this.RowSelectedButton1.Text = "Отобразить отдельный ряд номограммы №1";
            this.RowSelectedButton1.UseVisualStyleBackColor = false;
            this.RowSelectedButton1.Click += new System.EventHandler(this.FirstGraphRowSelectedButton_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(756, 493);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(302, 50);
            this.button4.TabIndex = 12;
            this.button4.Text = "Отобразить отдельный ряд номограммы №2";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.SecondGraphRowSelectedButton_Click);
            // 
            // Nomograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1313, 667);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.RowSelectedButton1);
            this.Controls.Add(this.SecondNomogramRowSelectedBox);
            this.Controls.Add(this.FirstNomogramRowSelectedBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SecondChart);
            this.Controls.Add(this.FirstChar);
            this.Name = "Nomograms";
            this.Text = "Задание №20 выполнил: Волобуев Е.Д., номер варианта: 2, дата выполнения: 11.12.20" +
    "24";
            ((System.ComponentModel.ISupportInitialize)(this.FirstChar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SecondChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart FirstChar;
        private System.Windows.Forms.DataVisualization.Charting.Chart SecondChart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox FirstNomogramRowSelectedBox;
        private System.Windows.Forms.ComboBox SecondNomogramRowSelectedBox;
        private System.Windows.Forms.Button RowSelectedButton1;
        private System.Windows.Forms.Button button4;
    }
}