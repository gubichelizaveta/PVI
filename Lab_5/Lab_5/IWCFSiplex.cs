using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Lab_5
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени интерфейса "IService1" в коде и файле конфигурации.
    [ServiceContract]
    public interface IWCFSiplex
    {
        [OperationContract]
        [WebGet(UriTemplate = "Add?x={x}&y={y}", ResponseFormat = WebMessageFormat.Json)]
        int Add(int x, int y);

        [OperationContract]
        [WebGet(UriTemplate = "Concat?s={s}&d={d}", ResponseFormat = WebMessageFormat.Json)]
        string Concat(string s, double d);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "Sum", RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped)]
        A Sum(A a1, A a2);
    }

    // Используйте контракт данных, как показано в примере ниже, чтобы добавить составные типы к операциям служб.
    // В проект можно добавлять XSD-файлы. После построения проекта вы можете напрямую использовать в нем определенные типы данных с пространством имен "Lab_5.ContractType".
    [DataContract]
    public class A
    {
        [DataMember]
        public string s { get; set; }

        [DataMember]
        public int k { get; set; }

        [DataMember]
        public float f { get; set; }
    }
}
