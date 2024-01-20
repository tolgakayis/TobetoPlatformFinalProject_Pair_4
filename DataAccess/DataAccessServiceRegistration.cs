﻿using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Contexts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {
            //services.AddDbContext<NorthwindContext>(options => options.UseInMemoryDatabase("nArchitecture"));
            services.AddDbContext<TobetoContext>(options => options.UseSqlServer(configuration.GetConnectionString("Tobeto")));


            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<ICourseDal, EfCourseDal>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<IInstructorDal, EfInstructorDal>();
            services.AddScoped<ISurveyDal, EfSurveyDal>();
            services.AddScoped<IUserSurveyDal, EfUserSurveyDal>();
            services.AddScoped<ICalendarEventDal, EfCalendarEventDal>();
            services.AddScoped<IUserCourseDal, EfUserCourseDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IUserAnnouncementDal, EfUserAnnouncementDal>();
            services.AddScoped<IAppealDal, EfAppealDal>();
            services.AddScoped<IUserAppealDal, EfUserAppealDal>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<IExperienceDal, EfExperinceDal>();
            services.AddScoped<IForeignLanguageDal, EfForeignLanguageDal>();
            services.AddScoped<IExamDal, EfExamDal>();
            services.AddScoped<IUserExamDal, EfUserExamDal>();
            services.AddScoped<IExamQuestionDal, EfExamQuestionDal>();
            services.AddScoped<IQuestionAnswerDal, EfQuestionAnswerDal>();

            return services;
        }
    }
}
