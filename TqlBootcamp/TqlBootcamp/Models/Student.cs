using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TqlBootcamp.Models
{
    public class Student
    {
        public int Id { get; set; }

        // setting first & last name as not null
        
        [Required] 
        [StringLength(50)]
        public string Firstname { get; set; }
        [Required, StringLength(50)]
        public string Lastname { get; set; }

        //need to add so this can reflect the value in SQL.... decimal vs dec(11,2)
        [Column (TypeName = "decimal (11,2)" )]
        public decimal TargetSalary { get; set; }

        //allowes bool to be null
        public bool? InBootcamp { get; set; }
        //ctrl shift B to build this 

        public virtual  List<AssessmentScore> AssessmentScores{ get; set; }


        public Student() { }

       

    }
}
