using System.ComponentModel.DataAnnotations;
namespace PrimerPruebaMVC.Models
{
    public class DegreeModel :BaseModel
    {
        public DegreeModel()
        {
            
        }

        [Required(ErrorMessage ="El {0} es un campo requerido")]
        [StringLength(maximumLength: 50,MinimumLength =5, ErrorMessage ="La longitud del campo {0} debe ser entre mínimo {2} y el maximo {1}")]
         public String Nombre { get; set; }
    }
   
}