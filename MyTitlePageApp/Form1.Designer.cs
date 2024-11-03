namespace MyTitlePageApp
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
            this.createTitleButton = new System.Windows.Forms.Button();
            this.createSurveyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // createTitleButton
            // 
            this.createTitleButton.Location = new System.Drawing.Point(50, 50);
            this.createTitleButton.Name = "createTitleButton";
            this.createTitleButton.Size = new System.Drawing.Size(300, 50);
            this.createTitleButton.TabIndex = 0;
            this.createTitleButton.Text = "Создать титульный лист";
            this.createTitleButton.UseVisualStyleBackColor = true;
            this.createTitleButton.Click += new System.EventHandler(this.createTitleButton_Click);
            // 
            // createSurveyButton
            // 
            this.createSurveyButton.Location = new System.Drawing.Point(50, 120);
            this.createSurveyButton.Name = "createSurveyButton";
            this.createSurveyButton.Size = new System.Drawing.Size(300, 50);
            this.createSurveyButton.TabIndex = 1;
            this.createSurveyButton.Text = "Создать анкету";
            this.createSurveyButton.UseVisualStyleBackColor = true;
            this.createSurveyButton.Click += new System.EventHandler(this.createSurveyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 230);
            this.Controls.Add(this.createSurveyButton);
            this.Controls.Add(this.createTitleButton);
            this.Name = "Form1";
            this.Text = "Окно входа";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button createTitleButton;
        private System.Windows.Forms.Button createSurveyButton;
    }
}
