using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParcerForJobSearch
{
    public partial class abouting : UserControl
    {
        public abouting()
        {
            InitializeComponent();
        }

        // привязываем на клик по картинке переход по ссылке
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/vladfedotov.official/");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://vk.com/minotraur");
        }
    }
}
