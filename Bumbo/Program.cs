using BumboData;
using BumboRepositories;
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
            
            builder.Services.AddScoped<IEmployee, EmployeeRepository>();
            builder.Services.AddScoped<IPrognosis, PrognosisRepository>();
            builder.Services.AddScoped<IPlannedShifts, PlannedShiftsRepository>();
            builder.Services.AddScoped<IUnavailableMoments, UnavailableMomentRepository>();
            builder.Services.AddScoped<IDepartmentsRepository, DepartmentRepository>();
            builder.Services.AddScoped<IWorkedShiftRepository, WorkedShiftRepository>();
            builder.Services.AddScoped<IBranchRepository, BranchRepository>();

            builder.Services.AddDbContext<BumboContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("Bumbo"));


            });

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

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}