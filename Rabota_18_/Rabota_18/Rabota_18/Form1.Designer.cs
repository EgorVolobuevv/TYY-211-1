namespace Rabota_18
{
    partial class Rabota_18
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.ButtonPreview = new System.Windows.Forms.Button();
            this.ExcelFile = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 12);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(1366, 272);
            this.dataGridView.TabIndex = 0;
            // 
            // ButtonPreview
            // 
            this.ButtonPreview.Location = new System.Drawing.Point(403, 332);
            this.ButtonPreview.Name = "ButtonPreview";
            this.ButtonPreview.Size = new System.Drawing.Size(163, 23);
            this.ButtonPreview.TabIndex = 1;
            this.ButtonPreview.Text = "Предпросмотр";
            this.ButtonPreview.UseVisualStyleBackColor = true;
            this.ButtonPreview.Click += new System.EventHandler(this.ButtonPreview_Click);
            // 
            // ExcelFile
            // 
            this.ExcelFile.Location = new System.Drawing.Point(818, 332);
            this.ExcelFile.Name = "ExcelFile";
            this.ExcelFile.Size = new System.Drawing.Size(163, 23);
            this.ExcelFile.TabIndex = 2;
            this.ExcelFile.Text = "Выгрузка в Excel";
            this.ExcelFile.UseVisualStyleBackColor = true;
            this.ExcelFile.Click += new System.EventHandler(this.ExcelFile_Click);
            // 
            // Rabota_18
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1390, 388);
            this.Controls.Add(this.ExcelFile);
            this.Controls.Add(this.ButtonPreview);
            this.Controls.Add(this.dataGridView);
            this.Name = "Rabota_18";
            this.Text = "Задание №18 выполнил: Волобуев Е.Д., номер варианта: 2, дата выполнения: 02.12.20" +
    "24";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button ButtonPreview;
        private System.Windows.Forms.Button ExcelFile;
    }
}

