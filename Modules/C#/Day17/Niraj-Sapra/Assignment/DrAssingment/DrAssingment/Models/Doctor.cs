﻿using System;
using System.Collections.Generic;

#nullable disable

namespace DrAssingment.Models
{
    public partial class Doctor
    {
        public Doctor()
        {
            Patients = new HashSet<Patient>();
        }

        public int Doctorid { get; set; }
        public string Doctorname { get; set; }

        public virtual ICollection<Patient> Patients { get; set; }
    }
}
