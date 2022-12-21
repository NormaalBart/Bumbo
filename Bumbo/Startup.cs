using System.Globalization;
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

namespace Bumbo;

public class Startup
{
    public Startup(IConfiguration configuration)
    {
        Configuration = configuration;
    }

    public IConfiguration Configuration { get; set; }

    public void ConfigureServices(IServiceCollection services)
    {
        // Add services to the container.
        services.AddControllersWithViews();
        services.AddAutoMapper(typeof(Program));
        services.AddAutoMapper(typeof(MapperServiceProfile));
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        services.AddScoped<IPrognosisRepository, PrognosisRepository>();
        services.AddScoped<IPlannedShiftsRepository, PlannedShiftsRepository>();
        services.AddScoped<IUnavailableMomentsRepository, UnavailableMomentRepository>();
        services.AddScoped<IDepartmentsRepository, DepartmentRepository>();
        services.AddScoped<IWorkedShiftRepository, WorkedShiftRepository>();
        services.AddScoped<IBranchRepository, BranchRepository>();
        services.AddScoped<IStandardRepository, StandardRepository>();
        services.AddScoped<IPrognosesService, PrognosisService>();
        services.AddScoped<IHourExportService, HourExportService>();
        services.AddScoped<ICAOService, DutchCAOService>();
        services.AddScoped<IImportService, ImportService>();
        services.AddScoped<IRosterService, RosterService>();

        services.AddDbContext<BumboContext>(options =>
        {
            options.UseSqlServer(Configuration.GetConnectionString("Bumbo"));
            options.EnableSensitiveDataLogging();
        });

        services.AddIdentity<Employee, IdentityRole>(
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

        // Set all displayed dates to the Dutch locale
        var cultureInfo = new CultureInfo("nl-NL");
        CultureInfo.DefaultThreadCurrentCulture = cultureInfo;
        CultureInfo.DefaultThreadCurrentUICulture = cultureInfo;
    }

    public void Configure(IApplicationBuilder app, IWebHostEnvironment webHostEnvironment, BumboContext bumboContext)
    {
        // Configure the HTTP request pipeline.
        if (!webHostEnvironment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error/Index");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        else
        {
            app.UseDeveloperExceptionPage();
        }

        app.Use(async (context, next) =>
        {
            await next();
            if (context.Response.StatusCode == 404)
            {
                context.Request.Path = "/Error/PageNotFound";
                await next();
            }
        });

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseAuthentication();
        app.UseRouting();
        app.UseAuthorization();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllerRoute(
                "default",
                "{controller=Account}/{action=Login}/{id?}");
        });

        bumboContext.Database.Migrate();
    }
}