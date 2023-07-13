using DevSpaceWeb.Data;
using DevSpaceWeb.Models;
using DevSpaceWeb.TBot;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DevSpaceWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, AppDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public async Task<IActionResult> Index(long? id)
        {
            ViewBag.ChatId = id;

            /*TelegramBot tbot = new TelegramBot();

            await tbot.SendMessageToTelegram(312872649, "testset");*/
            return View();
        }
        public IActionResult GetMessages(long chatId)
        {
            return PartialView(_db.Messages.Where(x => x.ChatId == chatId).ToList());
        }
        public IActionResult GetUsers()
        {
            return PartialView(_db.Users.Where(x=>x.Id != 1).ToList());
        }
        public IActionResult SaveMessage(long chatId, string messageText) 
        {
            Message message = new Message()
            {
                ChatId = chatId,
                MessageText = messageText,
                MessageDate = DateTime.Now,
                UserId = 1,
                IsOur = true,
                IsSended = false
            };
            _db.Messages.Add(message);
            _db.SaveChanges();
            return RedirectToAction("Index", new { id = chatId});
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