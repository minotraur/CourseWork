using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngleSharp.Html.Dom;
using AngleSharp.Html.Parser;

namespace ParcerForJobSearch.core
{
    // Обобщённый класс. Этот класс будет получать код страницы через HtmlLoader, после чего разбирать страницу и возвращать содержимое нужных элементов
    class ParserWorker<T> where T : class
    {
        IParser<T> parser;
        IParserSettings parserSettings; // Настройки для загрузчика кода страниц, здесь хранятся настройки для парсера.
        HtmlLoader loader; // Загрузчик кода страницы
        bool isActive; // Активность парсера

        public IParser<T> Parser
        {
            get { return parser; }
            set { parser = value; }
        }

        public IParserSettings Settings
        {
            get { return parserSettings; }
            set
            {
                parserSettings = value; // Новые настройки парсера
                loader = new HtmlLoader(value); // Сюда помещаются настройки для загрузчика кода страницы
            }
        }

        public bool IsActive // Проверяем активность парсера.
        {
            get { return isActive; }
        }

        //Это событие возвращает спаршенные за итерацию данные( первый аргумент ссылка на парсер, и сами данные вторым аргументом)
        public event Action<object, T> OnNewData;

        //1-й конструктор, в качестве аргумента будет передеваться класс реализующий интерфейс IParser
        public ParserWorker(IParser<T> parser)
        {
            this.parser = parser;
        }

        public void Start() //Запускаем парсер
        {
            isActive = true;
            Worker();
        }

        public void Stop() //Останавливаем парсер
        {
            isActive = false;
        }

        // Создаём асинхронный метод чтобы ускорить работу парсинга
        public async void Worker()
        {
            for (int i = parserSettings.StartPoint; i <= parserSettings.EndPoint; i++)
            {
                if (IsActive)
                {

                    // Здесь с помощью HtmlLoader, получаем и исходный код страницы из цикла
                    string source = await loader.GetSourceByPage(i);

                    // Создаём HtmlParser, который доступен из библиотеки AngleSharp
                    HtmlParser domParser = new HtmlParser();

                    // Парсим исходный код страницы, и получим document с которым можно работать
                    IHtmlDocument document = await domParser.ParseDocumentAsync(source);

                    // Передаём парсеру document, и запишем спаршенные данные в result
                    T result = parser.Parse(document);

                    // Передаём ссылку и результат
                    OnNewData?.Invoke(this, result);
                }
                return;
            }
            isActive = false;
        }
    }
}
