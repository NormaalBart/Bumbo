using BumboData;
using BumboData.Models;
using BumboRepositories;
using BumboRepositories.Interfaces;
using BumboServices;
using BumboServices.Interface;
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
            builder.Configuration.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IPrognosisRepository, PrognosisRepository>();
            builder.Services.AddScoped<IPlannedShiftsRepository, PlannedShiftsRepository>();
            builder.Services.AddScoped<IUnavailableMomentsRepository, UnavailableMomentRepository>();
            builder.Services.AddScoped<IDepartmentsRepository, DepartmentRepository>();
            builder.Services.AddScoped<IWorkedShiftRepository, WorkedShiftRepository>();
            builder.Services.AddScoped<IBranchRepository, BranchRepository>();

            builder.Services.AddScoped<IHourExportService, HourExportService>();

            builder.Services.AddDbContext<BumboContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Bumbo"));


            });

            builder.Services.AddIdentity<Employee, IdentityRole>(
                options => {
            options.SignIn.RequireConfirmedAccount = false;
            }
            ).AddEntityFrameworkStores<BumboContext>();


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