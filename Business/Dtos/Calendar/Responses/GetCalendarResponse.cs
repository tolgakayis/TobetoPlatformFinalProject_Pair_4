﻿namespace Business.Dtos.Calendar.Responses
{
    public class GetCalendarResponse
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid InstructorId { get; set; }
        public string InstructorName { get; set; }
        public DateTime EventDate { get; set; }
        public string EventDetails { get; set; }
        public string StatusOfCompleted { get; set; }
    }
}
