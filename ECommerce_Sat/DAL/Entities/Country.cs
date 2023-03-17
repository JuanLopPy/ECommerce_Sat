using System.ComponentModel.DataAnnotations;

namespace ECommerce_Sat.DAL.Entities
{
    public class Country : Entity
    {
        [Display(Name="País")] //Nombre que quiero mostrar en la web
        [MaxLength(50)] //caracteres máximos que recibe Name. (Varchar)
        [Required(ErrorMessage ="El campo {0} es obligatorio")]// not null
        public String Name { get; set; }


    }
}
 