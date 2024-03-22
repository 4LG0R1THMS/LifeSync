public class SettingsController : Controller
{
    public IActionResult Theme()
    {
        return View();
    }

    [HttpPost]
    public IActionResult ChangeTheme(string theme)
    {
        return RedirectToAction("Theme");
    }

    public IActionResult Settings()
    {
        return View();
    }

    [HttpPost]
    public IActionResult UpdateSettings(string dateFormat)
    {
        return RedirectToAction("Settings");
    }
}
