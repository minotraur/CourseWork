using System;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ParcerForJobSearch
{
    public partial class feedbacking : UserControl
    {
        public feedbacking()
        {
            InitializeComponent();
        }

        // К кнопке привязываем вызов метода MySendMail()
        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            mail sendMail = new mail(textBoxName.Text, textBoxSubject.Text, textBoxBody.Text);
            sendMail.MySendMail();
        }
    }
}
