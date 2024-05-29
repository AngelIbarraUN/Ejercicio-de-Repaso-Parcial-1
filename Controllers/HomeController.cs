using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimerPruebaMVC.Models;

namespace PrimerPruebaMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
      public IActionResult StudentList()
    {
       StudentModel alumno = new StudentModel();
       alumno.Nombre="Angel Ibarra";
       alumno.Carrera="Ingeniería en TI acentuado en Desarrollo de Software";
        return View(alumno);
    }
     public IActionResult TeacherList()
    {
       TeacherModel maestro1 = new TeacherModel();
       maestro1.Nombre="Marco Torres Garza";
       maestro1.Carrera="Ingeniería en Computación";
        return View(maestro1);
    }
    public IActionResult DegreeList()
    {
       DegreeModel carrera1 = new DegreeModel();
       carrera1.Nombre="Ingeniería en Tecnología de la Información acentuado en Desarrollo de Software";
        return View(carrera1);
    }


    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
