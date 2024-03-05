using lr7.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Syndication;
using System.ServiceModel.Web;
using System.Text;

namespace lr7
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Feed1" в коде и файле конфигурации.
    public class Feed1 : IFeed1
    {
        public SyndicationFeedFormatter CreateFeed()
        {
            var serviceUrl = new Uri("http://localhost:58061/StudentNotes.svc");
            // создание канала синдикации с основными свойствами (title, ...)
            var feed = new SyndicationFeed(
                title: "Student Notes Feed",
                description: "A WCF Syndication Student Notes Feed",
                id: "id",
                lastUpdatedTime: DateTime.Now,
                feedAlternateLink: serviceUrl
            );

            var service = new WSGEAEntities1(serviceUrl);

            var students = service.Students.Execute().ToList();
            var notes = service.Notes.Execute().ToList();


            var syndicationItemsStudents = new List<SyndicationItem>();
            foreach (var student in students)
            {
                var studentNotes = notes
                    .Where(note => note.StudentId == student.Id)
                    .Select(note => new SyndicationItem(
                        title: $"{student.Id} - {student.Name} - {note.Subject}",
                        content: $"{note.Note1}\t\n\n",
                        itemAlternateLink: null)
                    );

                syndicationItemsStudents.AddRange(studentNotes);
            }
            //foreach (var student in students)
            //{
            //    var studentNotes = string.Join(", ", notes
            //        .Where(note => note.StudentId == student.Id)
            //        .Select(note => $"{note.Subject} - {note.Note1}\t\n\n"));

            //    syndicationItemsStudents.Add(
            //        new SyndicationItem(
            //            title: student.Id.ToString() + " - " + student.Name,
            //            content: studentNotes,
            //            itemAlternateLink: null)
            //    );
            //}
            #region
            // заполнение канала синдикации, в <feed> добавляются все созданные <item>
            #endregion
            feed.Items = syndicationItemsStudents;

            #region
            // извлекаем формат из параметров URI запроса
            #endregion
            var query = WebOperationContext.Current?.IncomingRequest.UriTemplateMatch.QueryParameters["format"];
            SyndicationFeedFormatter formatter = null;
            if (query == "atom")
            {
                formatter = new Atom10FeedFormatter(feed);
            }
            else
            {
                formatter = new Rss20FeedFormatter(feed);
            }

            return formatter;
        }
    }
}
