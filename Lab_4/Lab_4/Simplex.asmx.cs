using System.Web.Services;
using System.Web.Script.Services;
using System.Web;
using System.IO;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace Lab_4
{

    [WebService(Namespace = "http://GEA/", Description = "Simplex Service")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    [ScriptService]
    public class Simplex : System.Web.Services.WebService
    {
        [WebMethod(MessageName = "Sum_1", Description = "int+int")]
        public int Add(int x, int y)
        {
            return x + y;
        }

        [WebMethod(MessageName = "Sum_2", Description = "concat string&double")]
        public string Concat(string s, double d)
        {
            return s + d.ToString();
        }

        [WebMethod(MessageName = "Sum_3", Description = "sum obj A and obj A = new obj A")]
        public A Sum(A a1, A a2)
        {
           string notification = "";
            using (var stream = new MemoryStream())
            using (var textWriter = new StreamWriter("D:\\4kurs\\pvi\\Lab_4\\request.txt"))
            {
                var request = HttpContext.Current.Request;
                request.InputStream.Seek(0, SeekOrigin.Begin);
                request.InputStream.CopyTo(stream);
                notification = Encoding.UTF8.GetString(stream.ToArray());
                textWriter.Write(notification);
            }
            //// Получаем необходимые данные из объекта HttpContext.Current.Request
            //string userHostAddress = HttpContext.Current.Request.UserHostAddress;
            //string userAgent = HttpContext.Current.Request.UserAgent;

            //// Записываем данные в файл "request.txt"
            //string requestData = $"User Host Address: {userHostAddress}, User Agent: {userAgent}";
            //File.WriteAllText(@"D:\4kurs\pvi\Lab_4\request.txt", requestData);

            A model = new A();
            model.s = string.Concat(a1.s, a2.s);
            model.k = a1.k + a2.k;
            model.f = a1.f + a2.f;
            return model;
        }

        [ScriptMethod(UseHttpGet = true, ResponseFormat = ResponseFormat.Json)]
        [WebMethod(MessageName = "Sum_4", Description = "int+int/response JSON")]
        public int Adds(int x, int y)
        {
            return x + y;
        }
    }
}