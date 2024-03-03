﻿using Business.Dtos.Course.Responses;
using Business.Dtos.User.Responses;

namespace Business.Dtos.Course.Responses
{
    public class GetListCourseResponse
    {
        public Guid Id { get; set; }
        public Guid CategoryId { get; set; }
        public Guid InstructorId { get; set; }
        public Guid LikeId { get; set; }

        public string CategoryName { get; set; }
        public string InstructorName { get; set; }
        public string Name { get; set; }
        public DateTime StartOfDate { get; set; }
    }
}