using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Для того чтобы парсить данные с сайта необходимо подключить библиотеку, которая будет парсить 
using AngleSharp.Html.Dom;

namespace ParcerForJobSearch.core
{
    // Данный интерфейс обобщённый, и в качестве обобщенного параметра указываем T, где T — это объект ссылочного типа
    // Классы которые будут реализовывать этот интерфейс смогут возвращать данные любого ссылочного типа
    interface IParser<T> where T : class 
    {
        // Метод Parse в него будет передаваться код страницы, после чего будет производиться анализ кода и поиск содержимого HTML элементов
        T Parse(IHtmlDocument document); // тип T при реализации будет заменяться на любой другой тип
    }
}
