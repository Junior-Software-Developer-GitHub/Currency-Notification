using System.Timers;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NotificationSystem.Services.CurrencyConverter;
using NotificationSystem.Services.CurrencyConverter.Interface;
using NotificationSystem.Services.ExchangeRate;
using NotificationSystem.Services.ExchangeRate.Interfaces;
using NotificationSystem.Services.Location;
using NotificationSystem.Services.Location.Interface;
using NotificationSystem.Services.Message;
using NotificationSystem.Services.Message.Interface;
using NotificationSystem.Services.Scheduler;
using NotificationSystem.Services.Scheduler.Interface;
using Timer = System.Timers.Timer;

namespace NotificationSystem
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IConfiguration Configuration => _configuration;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddTransient<IMessageService, MessageService>();
            services.AddTransient<IExchangeRatesService, ExchangeRatesService>();
            services.AddTransient<ISchedulerService, SchedulerService>();
            services.AddTransient<ICurrencyConverter, CurrencyConverter>();
            services.AddTransient<ILocationService, LocationService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ISchedulerService schedulerService)
        {
            
            var timer = new Timer(){Interval = 1000};
            timer.Elapsed += timer_Elapsed;
            timer.Start();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints => {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });        
        }
        private void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            // ReSharper disable once ObjectCreationAsStatement
           var scheduler =  new SchedulerService();
           scheduler.Schedule(new MessageService(new ExchangeRatesService(), new CurrencyConverter(), new LocationService()));
        }
    }
}