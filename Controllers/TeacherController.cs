using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using PrimerPruebaMVC.Models;

namespace PrimerPruebaMVC.Controllers;

public class TeacherController : Controller
{
       private readonly ILogger<TeacherController> _logger;

    public TeacherController(ILogger<TeacherController> logger)
    {
        _logger=logger;
    }
public IActionResult TeacherAdd()
{
    return View();
}
[HttpPost]
public IActionResult TeacherAdd(TeacherModel teacher)
{
    if(!ModelState.IsValid)
    {
        _logger.LogWarning("El modelo no es valido");
        return View();

    }
    _logger.LogInformation("El modelo es valido");
    
    return Redirect("TeacherList");
}

public IActionResult TeacherList()
{
 
   _logger.LogInformation("Esto es un mensaje al cargar las carreras");
    List<TeacherModel> list=new List<TeacherModel>();

TeacherModel profesor =new TeacherModel();
profesor.Nombre="Antonio Ruiz de León";
profesor.Carrera="Ingeniería en Computación";
profesor.Matricula=10;
profesor.Edad=34;
profesor.Sexo="Hombre";

TeacherModel profesor2 =new TeacherModel();
profesor2.Nombre="Miguel Morales Contreras";
profesor2.Carrera="Ingeniería en Sistemas Computacionales";
profesor2.Matricula=11;
profesor2.Edad=29;
profesor2.Sexo="Hombre";

TeacherModel profesor3 =new TeacherModel();
profesor3.Nombre="Laura Fernández García";
profesor3.Carrera="Licenciatura en Administración de Empresas";
profesor3.Matricula=12;
profesor3.Edad=31;
profesor3.Sexo="Mujer";


    list.Add(profesor);
    list.Add( profesor2);
    list.Add(profesor3);
    return View(list);
}

public IActionResult TeacherEdit(Guid Id)
{
    TeacherModel profesor = new TeacherModel();
    profesor.Id=Id;
    profesor.Nombre="Profesor cargado";
    return View(profesor);

}
[HttpPost]
public IActionResult TeacherEdit(TeacherModel profesor)
{
    if(!ModelState.IsValid)
    {
        _logger.LogWarning("El modelo no es valido");
     profesor.Nombre="Nombre de Profesor cargado";
    return View(profesor);
    }
    _logger.LogInformation("El modelo es valido");
 
    return Redirect("TeacherList");
}
public IActionResult TeacherShowToDeleted(Guid Id)
{
     TeacherModel profesor = new TeacherModel();
    profesor.Id=Id;
    profesor.Nombre="Nombre de profesor a borrar";
    return View(profesor);
}

[HttpPost]
public IActionResult TeacherDeleted()
{
   

    return View();
}
}