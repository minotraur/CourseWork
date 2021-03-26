using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;

namespace ParcerForJobSearch.core.freelansim
{
    class FreelansimParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            // Для хранения заголовков, контейнеров и д.т всё что связано с тегами Html
            List<string> list = new List<string>();
            // Здесь мы получаем теги и класс тега
            IEnumerable<IElement> items = document.QuerySelectorAll("div")
                .Where(item => item.ClassName != null && item.ClassName.Contains("task__title"));

            foreach (var item in items)
            {
                //Добавляем заголовки в коллекцию.
                list.Add(item.TextContent);
            }

            return list.ToArray();
        }
    }
}
