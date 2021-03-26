using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcerForJobSearch.core
{
    // Интерфейсы созданы для того чтобы в один и тот же список сложили "родственные" объекты и 
    // использовали несколько команд, чтобы они были доступны для всех классов, которые реализуют эти интерфейсы
    interface IParserSettings
    {
        string BaseUrl { get; set; } //url сайта
        string Postfix { get; set; } //в постфикс будет передаваться id страницы
        int StartPoint { get; set; } //c какой страницы парсим данные
        int EndPoint { get; set; } //по какую страницу парсим данные
    }
}
