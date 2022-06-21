﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Data.Entities
{
    public class EmployeeEducation
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        [Key]

        public int ID { get; set; }

        public string? CourseName { get; set; }

        public string? UniversityName { get; set; }


        public int PassingYear { get; set; }

        public int MarksPercentage { get; set; }

        public Employee Employee { get; set; }
    }
}
