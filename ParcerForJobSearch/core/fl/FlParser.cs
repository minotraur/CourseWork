using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngleSharp.Dom;
using AngleSharp.Html.Dom;

namespace ParcerForJobSearch.core.fl
{
    class FlParser : IParser<string[]>
    {
        public string[] Parse(IHtmlDocument document)
        {
            // Для хранения заголовков, контейнеров и д.т всё что связано с тегами Html
            List<string> list = new List<string>();

            // Здесь мы получаем теги и класс тега
            // При помощи объекта document и метода QuerySelectorAll мы сможем получить из Html документа все теги определённого типа
            IEnumerable<IElement> items = document.QuerySelectorAll("a")
                .Where(item => item.ClassName != null && item.ClassName.Contains("b-post__link"));

            foreach (var item in items)
            {
                // Добавляем заголовки в коллекцию.
                // У каждого объекта реализующего IElement есть свойство TextContent, именно в нём содержится наш заголовок.
                list.Add(item.TextContent);
            }
            
            // list преобразуем в массив
            return list.ToArray();
        }
    }
}
