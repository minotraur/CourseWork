using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcerForJobSearch.core.hh
{
    class HhSettings : IParserSettings
    {
        public HhSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "https://freelance.ru/projects/filter/?specs=4"; //здесь прописываем url сайта.
        public string Postfix { get; set; } = "&page={CurrentId}"; //вместо CurrentID будет подставляться номер страницы
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
