namespace PrimerPruebaMVC.Models
{
    public class EntityModel : BaseModel
    {
        public EntityModel()
        {

        }
    
    public int Matricula { get; set; }
    public string Nombre { get; set; }
    public string Carrera { get; set; }
    public int Edad { get; set; }
    public string Sexo { get; set; }
     public EntityModel(int matricula, string nombre, string carrera, int edad, string sexo) 
        {
            this.Matricula = matricula;
                this.Nombre = nombre;
                this.Carrera = carrera;
                this.Edad = edad;
                this.Sexo = sexo;
               
        }
    }
}