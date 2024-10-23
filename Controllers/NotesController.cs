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
        return View(_context.Note.ToList());
    }

    public IActionResult Create()
    {
	return View();
    }

    public IActionResult CreateForm(Note model)
    {
	Random rnd = new Random();
	model.Id = rnd.Next(0,9999);

	_context.Add(model);

	_context.SaveChanges();

	return RedirectToAction("Index");
    }

    public IActionResult Delete(int? Id)
    {
	Note? note = _context.Note.Find(Id);

	if (note == null)
	{
	    return BadRequest();
	}

	_context.Note.Remove(note);

	_context.SaveChanges();

	return RedirectToAction("Index");
    }

    public IActionResult Edit(int Id)
    {
	Note? note = _context.Note.Find(Id);

	if (note == null)
	{
	    return BadRequest();
	}

	return View(note);
    }

    public IActionResult EditForm(Note model)
    {
	_context.Update(model);

	_context.SaveChanges();

	return RedirectToAction("Index");
    }
}
