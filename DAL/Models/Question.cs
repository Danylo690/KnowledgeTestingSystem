using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL.Models
{
    public class Question
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public int Grade { get; set; }

        public List<Answer> Answers { get; set; }

        [ForeignKey(nameof(Test))]
        public int TestId { get; set; }

        public Test Test { get; set; }

        public Question()
        {
            Answers = new List<Answer>();
        }
    }
}
