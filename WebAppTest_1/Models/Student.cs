﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppTest_1.Models
{
    public class Student
    {
       
            public int Id { get; set; }

            [Required]
            [StringLength(50, MinimumLength = 2)]
            public string FirstName { get; set; }

            [Required]
            public string LastName { get; set; }

            [Required]
            public string SlackHandle { get; set; }

            [Required]
            public int CohortId { get; set; }

            //public Cohort Cohort { get; set; }
            //public List<Exercise> Exercises { get; set; } = new List<Exercise>();
        
    }
}
