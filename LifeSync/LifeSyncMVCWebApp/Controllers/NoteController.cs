using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using YourAppName.Models;

namespace LifeSync.Controllers
{
    public class NoteController : Controller
    {
        private readonly List<Note> _notes = new List<Note>();

        public IActionResult Index()
        {
            return View(_notes);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Note note)
        {
            note.CreatedAt = DateTime.Now;
            _notes.Add(note);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var note = _notes.FirstOrDefault(n => n.Id == id);
            if (note == null)
            {
                return NotFound();
            }
            return View(note);
        }

        [HttpPost]
        public IActionResult Edit(Note note)
        {
            var existingNote = _notes.FirstOrDefault(n => n.Id == note.Id);
            if (existingNote == null)
            {
                return NotFound();
            }

            existingNote.Title = note.Title;
            existingNote.Content = note.Content;

            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var note = _notes.FirstOrDefault(n => n.Id == id);
            if (note == null)
            {
                return NotFound();
            }
            return View(note);
        }

        public IActionResult Delete(int id)
        {
            var note = _notes.FirstOrDefault(n => n.Id == id);
            if (note == null)
            {
                return NotFound();
            }
            return View(note);
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var note = _notes.FirstOrDefault(n => n.Id == id);
            if (note == null)
            {
                return NotFound();
            }
            _notes.Remove(note);
            return RedirectToAction("Index");
        }
    }
}
