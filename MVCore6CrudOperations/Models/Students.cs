using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCore6CrudOperations.Models
{
    public class Students
    {
        [Key]
        public int Id { get; set; }
        [Column("StudentName", TypeName ="varchar(100)")]
        public string StudentName { get; set; }
        public string StudentFatherName { get; set; }

        public string StudentGender { get; set; }
        public int StudentAge { get; set; }

        
    }
}
    