using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using YourAppName.Models;

public class TaskController : Controller
{
    private readonly List<Task> _tasks = new List<Task>(); // Пример: временно съхранение на задачите в лист

    public IActionResult Index()
    {
        return View(_tasks);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Task task)
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
    public IActionResult Edit(Task task)
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
