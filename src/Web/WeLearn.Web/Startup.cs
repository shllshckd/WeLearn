using System.Reflection;

using Hangfire;
using Hangfire.PostgreSql;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using WeLearn.Data;
using WeLearn.Data.Common;
using WeLearn.Data.Common.Repositories;
using WeLearn.Data.Models;

using WeLearn.Data.Repositories;
using WeLearn.Data.Seeding;
using WeLearn.Services;
using WeLearn.Services.Interfaces;
using WeLearn.Services.Mapping;
using WeLearn.Web.Infrastructure;
using WeLearn.Web.ViewModels;

namespace WeLearn.Web
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
            => this.configuration = configuration;

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddHttpContextAccessor();

            services.AddSignalR();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseNpgsql(this.configuration.GetConnectionString("DefaultConnectionPostgreSQL")));

            services.AddDefaultIdentity<ApplicationUser>(IdentityOptionsProvider.GetIdentityOptions)
                .AddRoles<ApplicationRole>().AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddRazorPages();
            services.AddRouting(options => options.LowercaseUrls = true);
            services.AddControllersWithViews(options =>
                {
                    options.Filters.Add(new AutoValidateAntiforgeryTokenAttribute());
                })
                .AddRazorRuntimeCompilation();

            services.AddSingleton(this.configuration);

            // Data repositories
            services.AddScoped(typeof(IDeletableEntityRepository<>), typeof(EfDeletableEntityRepository<>));
            services.AddScoped(typeof(IRepository<>), typeof(EfRepository<>));
            services.AddScoped<IDbQueryRunner, DbQueryRunner>();

            // Application services
            services.AddTransient<IHomeService, HomeService>();
            services.AddTransient<IChatService, ChatService>();
            services.AddTransient<IUsersService, ApplicationUsersService>();
            services.AddTransient<ILessonsService, LessonsService>();
            services.AddTransient<IReportsService, ReportsService>();
            services.AddTransient<IInputOutputService, InputOutputService>();
            services.AddTransient<ICommentsService, CommentsService>();
            services.AddTransient<ICategoriesService, CategoriesService>();
            services.AddTransient<IFileDownloadService, FileDownloadService>();
            services.AddTransient<IViewComponentsService, ViewComponentsService>();
            services.AddTransient<IPrivateMessageService, PrivateMessageService>();
            services.AddTransient<IEmailSender>(serviceProvider =>
                new SendGridEmailService(this.configuration["SendGrid:ApiKey"]));

            services.AddAuthentication()
                .AddGoogle(options =>
                {
                    IConfigurationSection googleAuthenticationSection =
                        this.configuration.GetSection("Authentication:Google");
                    options.ClientId = googleAuthenticationSection["ClientId"];
                    options.ClientSecret = googleAuthenticationSection["ClientSecret"];
                });

            services.AddHangfire(config =>
                config.UsePostgreSqlStorage(
                    this.configuration.GetConnectionString("DefaultConnectionPostgreSQL")));
        }

        public void Configure(
            ApplicationDbContext applicationDbContext,
            IApplicationBuilder app,
            IWebHostEnvironment env,
            IRecurringJobManager recurringJobManager)
        {
            AutoMapperConfig.RegisterMappings(typeof(ErrorViewModel).GetTypeInfo().Assembly);

            using (var serviceScope = app.ApplicationServices.CreateScope())
            {
                ApplicationDbContext dbContext = serviceScope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
                dbContext.Database.Migrate();
                new ApplicationDbContextSeeder().SeedAsync(dbContext, serviceScope.ServiceProvider).GetAwaiter().GetResult();
            }

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.SeedHangfireJobs(recurringJobManager, applicationDbContext);
            app.UseHangfire();

            app.UseEndpoints();
        }
    }
}
