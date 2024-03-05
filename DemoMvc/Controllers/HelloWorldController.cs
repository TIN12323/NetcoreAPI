using Microsoft.AspNetCore.Mvc;

namespace DemoMvc.Controllers;
public class HelloWordController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(string FullName, string Address)
    {
        string strOutput = "Xin chào" + " " + FullName + " " + "đến từ" + " " + Address;
        ViewBag.Ma = strOutput;
        return View();
    }
}