using BumboData;
using BumboData.Interfaces.Repositories;
using BumboData.Models;
using BumboRepositories.Repositories;
using BumboServices;
using BumboServices.CAO;
using BumboServices.Import;
using BumboServices.Interface;
using BumboServices.Prognoses;
using BumboServices.Roster;
using BumboServices.Utils;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Bumbo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllersWithViews();
            builder.Services.AddAutoMapper(typeof(Program));
            builder.Services.AddAutoMapper(typeof(MapperServiceProfile));

            builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IPrognosisRepository, PrognosisRepository>();
            builder.Services.AddScoped<IPlannedShiftsRepository, PlannedShiftsRepository>();
            builder.Services.AddScoped<IUnavailableMomentsRepository, UnavailableMomentRepository>();
            builder.Services.AddScoped<IDepartmentsRepository, DepartmentRepository>();
            builder.Services.AddScoped<IWorkedShiftRepository, WorkedShiftRepository>();
            builder.Services.AddScoped<IBranchRepository, BranchRepository>();
            builder.Services.AddScoped<IStandardRepository, StandardRepository>();
            builder.Services.AddScoped<IPrognosesService, PrognosisService>();
            builder.Services.AddScoped<IHourExportService, HourExportService>();
            builder.Services.AddScoped<ICAOService, DutchCAOService>();
            builder.Services.AddScoped<IImportService, ImportService>();
            builder.Services.AddScoped<IRosterService, RosterService>();

            builder.Services.AddDbContext<BumboContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Bumbo"));
                options.EnableSensitiveDataLogging();

            });

            builder.Services.AddIdentity<Employee, IdentityRole>(
                options =>
                {
                    options.SignIn.RequireConfirmedAccount = false;
                    options.Password.RequireUppercase = true;
                    options.Password.RequiredLength = 6;
                    options.Password.RequireDigit = true;
                    options.Password.RequireNonAlphanumeric = false;
                }
            ).AddEntityFrameworkStores<BumboContext>()
            .AddDefaultTokenProviders();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }


            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseAuthentication();
            app.UseRouting();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Login}/{id?}");

            app.Run();
        }
    }
}