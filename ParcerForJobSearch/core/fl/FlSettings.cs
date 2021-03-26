using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcerForJobSearch.core.fl
{
    class FlSettings : IParserSettings
    {
        public FlSettings(int start, int end)
        {
            StartPoint = start;
            EndPoint = end;
        }

        public string BaseUrl { get; set; } = "https://www.fl.ru/projects/?kind=1";
        public string Postfix { get; set; } = "&page={CurrentId}";
        public int StartPoint { get; set; }
        public int EndPoint { get; set; }
    }
}
