using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Подключаем данные библиотеки чтобы работать с Http страницами
using System.Net;
using System.Net.Http;

namespace ParcerForJobSearch.core
{
    // Предназначение этого класса загружать исходный код HTML страницы из указанных настроек парсера, будет получать настройки(url и постфикс).
    class HtmlLoader
    {
        readonly HttpClient client; // Для отправки HTTP запросов и получения HTTP ответов.
        readonly string url; // Сюда будем передовать адрес.

        public HtmlLoader(IParserSettings settings)
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("User-Agent", "C# App"); // Это для индентификации на сайте.
            url = $"{settings.BaseUrl}/{settings.Postfix}/"; // Здесь собирается адресная строка
        }


        // Открытый асинхронный метод, который будет возвращать строку, названный GetSourceByPage в аргументе будет принимать id страницы
        public async Task<string> GetSourceByPage(int id) // id - это id страницы
        {
            string currentUrl = url.Replace("{CurrentId}", id.ToString());// Подменяем {CurrentId} на номер страницы
            HttpResponseMessage responce = await client.GetAsync(currentUrl); // Получаем ответ с сайта
            string source = null; // В эту переменную будем получать исходный код страницы

            if (responce != null && responce.StatusCode == HttpStatusCode.OK)
            {
                source = await responce.Content.ReadAsStringAsync(); // Помещаем код страницы в переменную.
            }
            return source;
        }
    }
}
