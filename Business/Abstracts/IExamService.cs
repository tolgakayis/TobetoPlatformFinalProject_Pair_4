﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Dtos.Exam.Requests;
using Business.Dtos.Exam.Responses;
using Core.DataAccess.Paging;

namespace Business.Abstracts
{
    public interface IExamService
    {
        Task<CreatedExamResponse> AddAsync(CreateExamRequest createExamRequest);
        Task<UpdatedExamResponse> UpdateAsync(UpdateExamRequest updateExamRequest);
        Task<DeletedExamResponse> DeleteAsync(DeleteExamRequest deleteExamRequest);
        Task<GetByIdExamResponse> GetByIdAsync(GetByIdExamRequest getByIdExamRequest);
        Task<Paginate<GetListExamResponse>> GetListAsync();
    }
}