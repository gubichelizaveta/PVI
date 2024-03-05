using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace laba3.Models
{
    // класс гипермедийной ссылки
    [DataContractAttribute]
    public class HateoasLink
    {
        [DataMemberAttribute]
        public string Href { get; set; } // на что ссылаемся
        [DataMemberAttribute]
        public string Rel { get; set; } // тип отношений между текущим ресурсом и связанным ресурсом.
        [DataMemberAttribute]
        public string Method { get; set; } // HTTP-метод, который можно использовать для взаимодействия с данным ресурсом

        public HateoasLink(string href, string rel, string method)
        {
            Href = href;
            Rel = rel;
            Method = method;
        }
    }
}