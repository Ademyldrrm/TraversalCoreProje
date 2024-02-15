﻿using BusinessLayer.Abstract;
using BusinessLayer.Abstract.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.Concrete.UnitOfConcrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Container
{
    public static class Extentsions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDestinationService, DestinationManager>();
            services.AddScoped<IDestinationDal, EfDestinationDal>();

            services.AddScoped<ICommentService, CommentManager>();
            services.AddScoped<ICommentDal, EfCommentDal>();

            services.AddScoped<IAppUserService, AppUserManager>();
            services.AddScoped<IAppUserDal, EfAppUserDal>();

            services.AddScoped<IReservationService, ReservationManager>();
            services.AddScoped<IReservationDal, EfReservationDal>();

            services.AddScoped<IGuideService, GuideManager>();
            services.AddScoped<IGuideDal, EfGuideDal>();

            services.AddScoped<IExcelService, ExcelManager>();
            services.AddScoped<IPdfService, PdfManager>();

            services.AddScoped<IContactUsDal, EfContactUsDal>();
            services.AddScoped<IContactUsService, ContactUsManager>();

            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();

            services.AddScoped<IAccountService, AccountManager>();
            services.AddScoped<IAccountDal, EfAccountDal>();
            services.AddScoped<IUnitOfWorkDal, UnitOfWorkDal>();

        }
    }
}
