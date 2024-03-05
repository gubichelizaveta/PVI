using lab_6_client.ServiceReference1;
using System;
using System.Data.Services.Client;
using System.Linq;
using System.Windows;


namespace lab_6_client
{
    public partial class MainWindow : Window
    {
        ServiceReference1.WSGEAEntities1 wsgea;

        public MainWindow()
        {
            InitializeComponent();
            wsgea = new ServiceReference1.WSGEAEntities1(new Uri("http://localhost:58061/StudentNotes.svc"));
        }

        public void OnGetStudentsClick(object sender, RoutedEventArgs e)
        {
            Result.Text = string.Empty;

            DataServiceQuery<Student> serviceQuery = wsgea.Students; 
            int result;

            if (!string.IsNullOrWhiteSpace(FilterColumn.Text) && !string.IsNullOrWhiteSpace(FilterValue.Text))
            {
                if (int.TryParse(FilterValue.Text, out result))
                    serviceQuery = serviceQuery.AddQueryOption("$filter", $"{FilterColumn.Text} eq {result}");
                else
                    serviceQuery = serviceQuery.AddQueryOption("$filter", $"substringof('{FilterValue.Text}', {FilterColumn.Text})");
            }

            if (!string.IsNullOrWhiteSpace(OrderBy.Text))
                serviceQuery = serviceQuery.AddQueryOption("$orderby", OrderBy.Text);

            try
            {   
                var queryResult = serviceQuery.Execute();
                foreach (var student in queryResult)
                {
                    Result.Text += (student?.Id > 0) ? student?.Id.ToString() : "";
                    Result.Text += (!string.IsNullOrWhiteSpace(student?.Name)) ? " - " + student?.Name : "";
                    Result.Text += "\n";
                }
            }
            catch (DataServiceQueryException ex)
            {
                Result.Text = "Error: " + ex.Message;
            }
        }
        public void OnGetNotesClick(object sender, RoutedEventArgs e)
        {
            Result.Text = string.Empty;

            DataServiceQuery<Note> serviceQuery = wsgea.Notes;
            int result;

            if (!string.IsNullOrWhiteSpace(FilterColumn.Text) && !string.IsNullOrWhiteSpace(FilterValue.Text))
            {
                if (int.TryParse(FilterValue.Text, out result))
                    serviceQuery = serviceQuery.AddQueryOption("$filter", $"{FilterColumn.Text} eq {result}");
                else
                    serviceQuery = serviceQuery.AddQueryOption("$filter", $"substringof('{FilterValue.Text}', {FilterColumn.Text})");
            }

            if (!string.IsNullOrWhiteSpace(OrderBy.Text))
                serviceQuery = serviceQuery.AddQueryOption("$orderby", OrderBy.Text);

            try
            {
                var queryResult = serviceQuery.Execute();
                foreach (var note in queryResult)
                {
                    Result.Text += (note?.Id > 0) ? (note?.Id).ToString() : "";
                    Result.Text += (!string.IsNullOrWhiteSpace(note?.Subject)) ? " - " + note?.Subject.ToString() : "";
                    Result.Text += (note?.Note1 != 0) ? "  Оценка: " + (note?.Note1).ToString() : "";
                    Result.Text += (note?.StudentId != 0) ? ("\tID студента: " + note?.StudentId).ToString() : "";
                    Result.Text += "\n";
                }
            }
            catch (DataServiceQueryException ex)
            {
                Result.Text = "Error: " + ex.Message;
            }
        }

        public void OnAddStudentClick(object sender, RoutedEventArgs e)
        {
            
            Student newStud = new Student();
            newStud.Name = StudentName.Text;
            wsgea.AddObject("Students", newStud);
            wsgea.SaveChanges();
        }
        public void OnDeleteStudentClick(object sender, RoutedEventArgs e)
        {
            int studentIdToDelete;

            if (int.TryParse(StudentIdToDelete.Text, out studentIdToDelete))
            {
                Student studentToUpdate = wsgea.Execute<Student>(new Uri($"Students({studentIdToDelete})", UriKind.Relative)).FirstOrDefault();
                studentToUpdate.Name = NewName.Text;
                wsgea.UpdateObject(studentToUpdate);
                wsgea.SaveChanges();
            }
        }
    }
}
