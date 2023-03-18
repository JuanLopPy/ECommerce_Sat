using System.ComponentModel.DataAnnotations;

namespace ECommerce_Sat.DAL.Entities
{
    public class Entity
    {
        [Key]
        public virtual Guid Id { get; set; }


        [Display (Name =("Fecha de creación"))]
        public virtual String? CreateDate { get; set; }

        [Display(Name = ("Fecha de modificación"))]
        public virtual String? ModifiedDate { get; set; }
    }
}
