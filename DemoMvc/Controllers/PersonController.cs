using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace DemoMvc.Controllers;
public class PersonController : Controller
{
    public IActionResult Tin()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Tin(Person ps)
    {
        string strOutput = "Xin chào" + ps.PersonId + "-" + ps.Fullname + "-" + ps.Address;
        ViewBag.infoPerson = strOutput;
        return View();
    }
}