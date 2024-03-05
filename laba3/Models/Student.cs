using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace laba3.Models
{
    // класс для связи с бд
    [Table("students")]
    public class Student
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string phone { get; set; }
    }
}