using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVCExample.Models;
using ValidationAttribute;

namespace MVCExample.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Index(User model)
    {
        if (!ValidationTool.Validate(model))
        {
            ViewBag.Mesaj = "Validasyon ba�ar�s�z! Zorunlu alanlar� doldurun.";
            return View(model);
        }

        ViewBag.Mesaj = "Validasyon ba�ar�l�!";
        return View(model);
    }
}
