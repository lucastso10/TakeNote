using Microsoft.AspNetCore.Mvc;
using TakeNote.Models;

namespace TakeNote.Controllers;

public class NotesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
