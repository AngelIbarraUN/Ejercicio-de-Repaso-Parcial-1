using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using Microsoft.AspNetCore.Mvc;
using PrimerPruebaMVC.Models;

namespace PrimerPruebaMVC.Controllers;

public class DegreeController : Controller
{
       private readonly ILogger<DegreeController> _logger;

    public DegreeController(ILogger<DegreeController> logger)
    {
        _logger=logger;
    }
public IActionResult DegreeAdd()
{
    return View();
}
[HttpPost]
public IActionResult DegreeAdd(DegreeModel degree)
{
    if(!ModelState.IsValid)
    {
        _logger.LogWarning("El modelo no es valido");
        return View();

    }
    _logger.LogInformation("El modelo es valido");
    
    return Redirect("DegreeList");
}

public IActionResult DegreeList()
{
    /*Seccion de listado de carreras*/
   _logger.LogInformation("Esto es un mensaje al cargar las carreras");
    List<DegreeModel> list=new List<DegreeModel>();
//Crear objetos de carrera//
DegreeModel carrera =new DegreeModel();
carrera.Nombre="Licenciatura en Administración de Tecnologías";

DegreeModel carrera2 =new DegreeModel();
carrera2.Nombre="Licenciatura en Mercadotecnia";

DegreeModel carrera3 =new DegreeModel();
carrera3.Nombre="Licenciatura en Comercio Exterior";

DegreeModel carrera4 =new DegreeModel();
carrera4.Nombre="Ingeniería en Tecnologías de la Información";

//Objeto de lista de carrera//
    list.Add(carrera);
    list.Add(carrera2);
    list.Add(carrera3);
    list.Add(carrera4);
    return View(list);
}

public IActionResult DegreeEdit(Guid Id)
{
    DegreeModel carrera = new DegreeModel();
    carrera.Id=Id;
    carrera.Nombre="Carrera Cargada";
    return View(carrera);

}
[HttpPost]
public IActionResult DegreeEdit(DegreeModel carrera)
{
    if(!ModelState.IsValid)
    {
        _logger.LogWarning("El modelo no es valido");
     carrera.Nombre="Carrera cargada";
    return View(carrera);
    }
    _logger.LogInformation("El modelo es valido");
 
    return Redirect("DegreeList");
}
public IActionResult DegreeShowToDeleted(Guid Id)
{
     //Con el id se buscara en la BD el registro correspondiente
     //Despues se le asigna al objeto
     DegreeModel carrera = new DegreeModel();
    carrera.Id=Id;
    carrera.Nombre="Carrera para borrar";
    return View(carrera);
}

[HttpPost]
public IActionResult DegreeDeleted()
{
   
   /*Borra el registro*/
    return View();
}
}