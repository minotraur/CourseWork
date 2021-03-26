using ParcerForJobSearch.core;
using ParcerForJobSearch.core.fl;
using ParcerForJobSearch.core.freelansim;
using ParcerForJobSearch.core.hh;
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
    public partial class pars : UserControl
    {
        // Объявим переменные для парсинга на разных сайтах
        ParserWorker<string[]> parcer_fl;
        ParserWorker<string[]> parser_freelansim;
        ParserWorker<string[]> parser_hh;

        public pars()
        {
            InitializeComponent();
            //----------------------------------------------------------------------------//
            // Инициализируем parcer_fl
            parcer_fl = new ParserWorker<string[]>(new FlParser());
            //Заполняем listBox
            parcer_fl.OnNewData += Parser_OnNewData;
        //----------------------------------------------------------------------------//
            parser_freelansim = new ParserWorker<string[]>(new FreelansimParser());
            parser_freelansim.OnNewData += Parser_OnNewData;
        //----------------------------------------------------------------------------//
            parser_hh = new ParserWorker<string[]>(new HhParcer());
            parser_hh.OnNewData += Parser_OnNewData;
        //----------------------------------------------------------------------------//
        }

        // Реализовываем метод Parser_OnNewData который при появлении новых данных будет расширять элемент ListBox в данном случае переименованный в ListTitles для удобства
        public void Parser_OnNewData(object o, string[] str) 
        { 
            ListTitles.Items.AddRange(str); 
        }



        // Далее по нажатию кнопок соответствующих сайтов в FlSettings будет передоваться с какой по какую страницу необходимо спарсить данные
        private void buttonFl_Click(object sender, EventArgs e)
        {
            // Настройки для парсера
            parcer_fl.Settings = new FlSettings((int)numericUpDownStart.Value, (int)numericUpDownEnd.Value);
            // Парсим
            parcer_fl.Start();
        }
        // Аналогично с buttonFl_Click
        private void buttonHh_Click(object sender, EventArgs e)
        {
            parser_hh.Settings = new HhSettings((int)numericUpDownStart.Value, (int)numericUpDownEnd.Value);
            parser_hh.Start();
        }
        // Аналогично с buttonFl_Click
        private void buttonFreelansim_Click(object sender, EventArgs e)
        {
            parser_freelansim.Settings = new FreelansimSettings((int)numericUpDownStart.Value, (int)numericUpDownEnd.Value);
            parser_freelansim.Start();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------

        //  По нажатию кнопки "Очистить" будут удаляться данные из ListTitles
        private void buttonClear_Click(object sender, EventArgs e)
        {
            ListTitles.Items.Clear();
        }

        //  По нажатию кнопки "Завершить" будет остановлен парсер
        private void buttonEnd_Click(object sender, EventArgs e)
        {
            parcer_fl.Stop();
            parser_hh.Stop();
            parser_freelansim.Stop();
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.fl.ru/projects/?kind=1");
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://freelance.ru/projects/filter/?specs=4"); 
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://freelance.habr.com/tasks?_=1589374483765&categories=development_all_inclusive%2Cdevelopment_backend%2Cdevelopment_frontend%2Cdevelopment_prototyping%2Cdevelopment_ios%2Cdevelopment_android%2Cdevelopment_desktop%2Cdevelopment_bots%2Cdevelopment_games%2Cdevelopment_1c_dev%2Cdevelopment_scripts%2Cdevelopment_voice_interfaces%2Cdevelopment_other&page=1"); 
        }
    }
}
