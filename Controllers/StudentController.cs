using Microsoft.AspNetCore.Mvc;
using PrimerPruebaMVC.Models;

namespace PrimerPruebaMVC.Controllers;

public class StudentController : Controller
{
    public StudentController()
    {
    }
    public IActionResult StudentAdd()
    {
        return View();
    }
    public IActionResult StudentList()
    {
        StudentModel alumno = new StudentModel();
        alumno.Nombre="Angel Javier Ibarra Rico";
        alumno.Carrera="Ingeniería en Tecnologías de la Información";
        alumno.FechaCreacion=new DateTime(2024,05,17);
        alumno.Edad=25;
        alumno.Matricula=44361;
        alumno.Sexo="Hombre";
        List<StudentModel> listStudents = new List<StudentModel>();
        listStudents.Add(alumno);

        listStudents.Add(new StudentModel(){Nombre="Miguel Ruiz Luna", Carrera="Ingeniería en Tecnologías de la Información"
                                            ,FechaCreacion=new DateTime(2024,07,22),Edad=22,Matricula=44324, Sexo="Hombre"});
        return View(listStudents);
    }	
    public IActionResult StudentSave()
    {
      
      /*Guardar en la base de datos*/
        return Redirect("StudentList");
    }
    public IActionResult StudentShowAndEdit()
    {
        return View();
    }
     public IActionResult StudentShowToDeleted()
    {
        return View();
    }
    public IActionResult StudentEdit()
    {
       /*Editar en la base de datos*/
        return Redirect("StudentList");
    }
     public IActionResult StudentDeleted()
    {
       /*Borrar en la base de datos*/
        return Redirect("StudentList");
    }

}
