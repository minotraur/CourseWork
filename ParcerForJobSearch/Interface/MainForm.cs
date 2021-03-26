using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcerForJobSearch
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen; // центрируем окно по середине экрана
            // Для того чтобы нам показалось 1 окно
            RedPanel.Height = DescriptionBtn.Height;
            RedPanel.Top = DescriptionBtn.Top;
            desc1.BringToFront();
        }

        // по клику на кнопку "Описание" и др. окно всплывает на передний план
        private void DescriptionBtn_Click(object sender, EventArgs e)
        {
            RedPanel.Height = DescriptionBtn.Height;
            RedPanel.Top = DescriptionBtn.Top;
            desc1.BringToFront();
        }

        private void ParcerBtn_Click(object sender, EventArgs e)
        {
            RedPanel.Height = ParcerBtn.Height;
            RedPanel.Top = ParcerBtn.Top;
            pars1.BringToFront();
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            RedPanel.Height = HelpBtn.Height;
            RedPanel.Top = HelpBtn.Top;
            helping1.BringToFront();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            RedPanel.Height = AboutBtn.Height;
            RedPanel.Top = AboutBtn.Top;
            abouting1.BringToFront();
        }

        private void FeedBackBtn_Click(object sender, EventArgs e)
        {
            RedPanel.Height = FeedBackBtn.Height;
            RedPanel.Top = FeedBackBtn.Top;
            feedbacking1.BringToFront();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 50)
            {
                panel1.Visible = false;
                panel1.Width = 253;
                SlideAnimator.ShowSync(panel1);
                LogoAnimator.ShowSync(pictureBox1);
            }
            else
            {
                LogoAnimator.Hide(pictureBox1);
                panel1.Visible = false;
                panel1.Width = 50;
                SlideAnimator.ShowSync(panel1);
            }
        }
        //-------------------------------------------------------------------//
    }
}
