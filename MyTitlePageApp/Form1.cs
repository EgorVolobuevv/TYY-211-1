using System;
using System.Windows.Forms;

namespace MyTitlePageApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       private void createTitleButton_Click(object sender, EventArgs e)
{
    TitlePageForm titlePageForm = new TitlePageForm();
    titlePageForm.Show();
}

        private void createSurveyButton_Click(object sender, EventArgs e)
        {
             MigrationCard mc = new MigrationCard();
            mc.Show();
        }
    }
}
