﻿namespace Business.Dtos.CourseAsyncContent.Responses
{
    public class DeletedCourseAsyncContentResponse
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public Guid AsyncContentId { get; set; }
    }
}
