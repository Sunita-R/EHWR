using EHWR.Services.Concrete;
using EHWR.Services.Interfaces;
using EHWR.Data.EHWRGenericRepository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Repository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EHWR.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using EHWR.Domain.BusinessRules;
using EHWR.Domain.BusinessRules.Job;
using EHWR.Services.Interfaces.Customer;
using EHWR.Services.Concrete.Customer;
using EHWR.Domain.BusinessRules.Customer;
using Repository.Repository.Customer;
using EHWR.Services.Interfaces.Employee;
using EHWR.Services.Concrete.Employee;
using EHWR.Domain.BusinessRules.Employee;
using Repository.Repository.Employee;
using EHWR.Services.Interfaces.GlobalCode;
using EHWR.Services.Concrete.GlobalCode;
using EHWR.Domain.BusinessRules.GlobalCode;
using Repository.Repository.GlobalCode;
using EHWR.Services.Interfaces.Locality;
using EHWR.Services.Concrete.Locality;
using EHWR.Domain.BusinessRules.Locality;
using Repository.Repository.Locality;
using EHWR.Services.Interfaces.Items;
using EHWR.Services.Concrete.Items;
using EHWR.Domain.BusinessRules.Items;
using Repository.Repository.Items;
using EHWR.Services.Interfaces.Notes;
using EHWR.Services.Concrete.Notes;
using EHWR.Domain.BusinessRules.Notes;
using Repository.Repository.Note;
using EHWR.Services.Interfaces.Invoice;
using EHWR.Services.Concrete.Invoice;
using EHWR.Domain.BusinessRules.Invoice;
using Repository.Repository.Invoice;
using EHWR.Services.Interfaces.Payment;
using EHWR.Services.Concrete.Payment;
using EHWR.Domain.BusinessRules.Payment;
using Repository.Repository.Payment;
using EHWR.Domain.Shared;
using EHWR.Services.Interfaces.Dashboard;
using EHWR.Services.Concrete.Dashboard;
using EHWR.Domain.BusinessRules.Dashboard;
using Repository.Repository.Dashboard;

namespace EHWR.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        private IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // configure strongly typed settings objects
            var appSettingsSection = Configuration.GetSection("AppSettings");
            var appSettings = appSettingsSection.Get<AppSettings>();

            // Set all appsetting configuration in static object 
            AppSettingConfigurations.AppSettings = appSettings;

            services.AddDbContext<AppIdentityDbContext>(options => options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"]));

            services.AddIdentity<AppIdentityUser, AppIdentityRole>()
                    .AddEntityFrameworkStores<AppIdentityDbContext>()
                    .AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(options =>
            {
                options.LoginPath = "/Security/Login";
                options.LogoutPath = "/Security/Logout";
                options.AccessDeniedPath = "/Security/AccessDenied";
                options.SlidingExpiration = true;
                options.Cookie = new CookieBuilder {
                    HttpOnly = true,
                    Name = ".Fiver.Security.Cookie",
                    Path = "/",
                    SameSite = SameSiteMode.Lax,
                    SecurePolicy = CookieSecurePolicy.SameAsRequest
                };
            });
            services.AddCors();
            services.AddControllersWithViews();

            services.AddSwaggerGen(c => c.SwaggerDoc("v1",
                new OpenApiInfo {
                    Title = "EHWR API",
                    Version = "v1"
                })
            );
            services.AddSingleton<IConfiguration>(Configuration);

            services.AddTransient<IGlobalCodeService, GlobalCodeService>();
            services.AddTransient<IGlobalCodeRepository, GlobalCodeRepository>();

            services.AddTransient<IAccountLogService, AccountService>();
            services.AddTransient<IAccountRepositoryLog, AccountLogRepository>();

            services.AddTransient<IGlobalCodeService, GlobalCodeService>();
            services.AddTransient<IGlobalCodeRepository, GlobalCodeRepository>();

            services.AddTransient<ILocalityService, LocalityService>();
            services.AddTransient<ILocalityRepository, LocalityRepository>();

            services.AddTransient<ICustomerService, CustomerService>();
            services.AddTransient<ICustomerRepository, CustomerRepository>();

            services.AddTransient<ICustomerContactService, CustomerContactService>();
            services.AddTransient<ICustomerContactRepository, CustomerContactRepository>();

            services.AddTransient<IJobService, JobService>();
            services.AddTransient<IJobRepository, JobRepository>();

            services.AddTransient<IJobOrderItemService, JobOrderItemService>();
            services.AddTransient<IJobOrderItemRepository, JobOrderItemRepository>();

            services.AddTransient<INotesService, NoteService>();
            services.AddTransient<INotesRepository, NotesRepository>();

            services.AddTransient<IInvoiceService, InvoiceService>();
            services.AddTransient<IInvoiceRepository, InvoiceRepository>();

            services.AddTransient<ICustomerInvoiceService, CustomerInvoiceService>();
            services.AddTransient<ICustomerInvoiceRepository, CustomerInvoiceRepository>();

            services.AddTransient<IPrintAllInvoicesService, PrintAllInvoicesService>();
            services.AddTransient<IPrintAllInvoicesRepository, PrintAllInvoicesRepository>();

            services.AddTransient<IPaymentService, PaymentService>();
            services.AddTransient<IPaymentRepository, PaymentRepository>();

            services.AddTransient<IPaymentOutstandingService, PaymentOutstandingService>();
            services.AddTransient<IPaymentOutstandingRepository, PaymentOutstandingRepository>();

            services.AddTransient<IEmployeeService, EmployeeService>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();

            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<IItemRepository, ItemRepository>();

            services.AddTransient<IItemPriceService, ItemPriceService>();
            services.AddTransient<IItemPriceRepository, ItemPriceRepository>();

            services.AddTransient<IDashboardService, DashboardService>();
            services.AddTransient<IDashboardRepository, DashboardRepository>();

            services.AddTransient<IJobCountGraphService, JobCountGraphService>();
            services.AddTransient<IJobCountGraphRepository, JobCountGraphRepository>();

            services.AddTransient<IJobCountMonthWiseService, JobCountMonthWiseService>();
            services.AddTransient<IJobCountMonthWiseRepository, JobCountMonthWiseRepository>();
        

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseHttpsRedirection();

            app.UseRouting();
            // global cors policy
            app.UseCors(x => x
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader());
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });

            app.UseSwagger();
            app.UseSwaggerUI(options => options.SwaggerEndpoint("/swagger/v1/swagger.json", "EHWR Services"));
        }
    }
}
