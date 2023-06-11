using Hangfire;
using HangfireApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace HangfireApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            // Hangfire ile arka plan işi oluşturma
            BackgroundJob.Enqueue(() => LogMessage("This is a log message."));
            BackgroundJob.Schedule(() => SendEmail("example@example.com", "Hello from Hangfire!"), TimeSpan.FromSeconds(10));
            RecurringJob.AddOrUpdate(() => BackupDatabase(), Cron.Daily);

            return View();
        }

        public void LogMessage(string message)
        {
            // Temsili mesaj Loglama işlemi
            Console.WriteLine($"Log Message: {message}");
        }

        public void SendEmail(string email, string message)
        {
            //Temsili E-posta gönderme işlemi
            Console.WriteLine($"Sending email to {email}: {message}");
        }

        public void BackupDatabase()
        {
            //Temsili Veritabanı yedekleme işlemi
            Console.WriteLine("Backing up database...");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}