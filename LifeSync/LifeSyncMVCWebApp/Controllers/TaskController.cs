using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LifeSync.Models;

public class TaskController : Controller
{
    private readonly List<LifeSync.Models.Task> _tasks = new List<LifeSync.Models.Task>();
    public IActionResult Index()
    {
        return View(_tasks);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(LifeSync.Models.Task task)
    {
        _tasks.Add(task);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var task = _tasks.Find(t => t.Id == id);
        if (task == null)
        {
            return NotFound();
        }
        return View(task);
    }

    [HttpPost]
    public IActionResult Edit(LifeSync.Models.Task task)
    {
        var index = _tasks.FindIndex(t => t.Id == task.Id);
        if (index != -1)
        {
            _tasks[index] = task;
        }
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var task = _tasks.Find(t => t.Id == id);
        if (task == null)
        {
            return NotFound();
        }
        return View(task);
    }

    [HttpPost]
    public IActionResult DeleteConfirmed(int id)
    {
        var task = _tasks.Find(t => t.Id == id);
        if (task != null)
        {
            _tasks.Remove(task);
        }
        return RedirectToAction("Index");
    }
}
