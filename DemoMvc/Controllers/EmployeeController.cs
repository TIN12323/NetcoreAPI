using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace DemoMvc.ControllersMovie.Controllers;
public class EmployeeController : Controller
{
    public IActionResult Daica()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Daica(Employee ps)
    {
        string strOutput = "Xin chào" + ps.PersonId + "-" + ps.Fullname + "-" + ps.Address+ "-"+ ps.EmployeeId + "-" + ps.Age;
        ViewBag.infoDaica = strOutput;
        return View();
    }
}