﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Education.Responses
{
    public class GetEducationResponse
    {
        public Guid Id { get; set; }
        public string EducationalDegree { get; set; }
        public string University { get; set; }
        public string Department { get; set; }
        public DateTime StartOfYear { get; set; }
        public DateTime GraduationYear { get; set; }
        public bool Status { get; set; }
    }
}
