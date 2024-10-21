using Microsoft.AspNetCore.Mvc;
using TakeNote.Data;
using TakeNote.Models;

namespace TakeNote.Controllers;

public class NotesController : Controller
{
    private readonly TakeNoteDbContext _context;

    public NotesController(TakeNoteDbContext context) {
      _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult FormPage()
    {
	return View();
    }

    public IActionResult NoteForm(Note model)
    {
	_context.Add(model);

	_context.SaveChanges();

	return RedirectToAction("Index");
    }
}
