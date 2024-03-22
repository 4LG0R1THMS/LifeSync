using System;

public class EventController : Controller
{
    private readonly List<Event> _events = new List<Event>();

    public IActionResult Index()
    {
        return View(_events);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Event ev)
    {
        _events.Add(ev);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var existingEvent = _events.FirstOrDefault(e => e.Id == id);
        if (existingEvent == null)
        {
            return NotFound(); // Event not found
        }
        return View(existingEvent);
    }

    [HttpPost]
    public IActionResult Edit(Event updatedEvent)
    {
        var existingEvent = _events.FirstOrDefault(e => e.Id == updatedEvent.Id);
        if (existingEvent == null)
        {
            return NotFound(); 
        }
  
        existingEvent.Title = updatedEvent.Title;
        existingEvent.Description = updatedEvent.Description;
        existingEvent.StartDate = updatedEvent.StartDate;
        existingEvent.EndDate = updatedEvent.EndDate;
       
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var existingEvent = _events.FirstOrDefault(e => e.Id == id);
        if (existingEvent == null)
        {
            return NotFound(); // Event not found
        }
        return View(existingEvent);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        var existingEvent = _events.FirstOrDefault(e => e.Id == id);
        if (existingEvent == null)
        {
            return NotFound(); 
        }
        _events.Remove(existingEvent);

        return RedirectToAction("Index");
    }
}

