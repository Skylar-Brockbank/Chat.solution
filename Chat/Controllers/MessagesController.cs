using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Chat.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using System;

namespace Chat.Controllers
{
  [Authorize]
  public class MessagesController : Controller
  {
    private readonly ChatContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    public MessagesController(UserManager<ApplicationUser> userManager, ChatContext db)
    {
      _userManager = userManager;
      _db = db;
    }

    public ActionResult Index()
    {
      ViewBag.SelectUser = new SelectList(_db.Users, "Id", "UserName");
      
      
      return View();
    }

    [HttpPost]
    public ActionResult Index(string SelectUser)
    {
      return RedirectToAction("Details", new { id = SelectUser });
    }

    public ActionResult Details(string id)
    {
      var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
      ViewBag.OtherId = id;
      Console.WriteLine(id);
      ViewBag.MyId = userId;
      ViewBag.OtherName = _db.ChatUsers.FirstOrDefault(user => user.Id == id);
      ViewBag.MyName = _db.ChatUsers.FirstOrDefault(user => user.Id == userId);
      List<Message> messageList = (from Mes in _db.Messages where (Mes.SenderId == userId || Mes.RecieverId == userId)&&(Mes.SenderId== id || Mes.RecieverId==id) select Mes).ToList();
      return View(messageList);
    }
    [HttpPost]
    public ActionResult Details(string msg, string idtest, string metest)
    {
      Console.WriteLine("I Ran");
      Console.WriteLine(msg);
      Console.WriteLine(idtest);
      Console.WriteLine(metest);
      _db.Messages.Add(new Message(){SenderId = metest, RecieverId = idtest,Text = msg});
      _db.SaveChanges();
      return RedirectToAction("Details", new{id = idtest});
    }
  }
}
