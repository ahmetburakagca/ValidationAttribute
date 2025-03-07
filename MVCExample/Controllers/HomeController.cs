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
            ViewBag.Mesaj = "Validasyon baþarýsýz! Zorunlu alanlarý doldurun.";
            return View(model);
        }

        ViewBag.Mesaj = "Validasyon baþarýlý!";
        return View(model);
    }
}
