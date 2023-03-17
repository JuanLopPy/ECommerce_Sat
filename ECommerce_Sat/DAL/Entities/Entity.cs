﻿using System.ComponentModel.DataAnnotations;

namespace ECommerce_Sat.DAL.Entities
{
    public class Entity
    {
        [Key]
        public virtual Guid Id { get; set; }
        public virtual String? CreateDate { get; set; }
        public virtual String? ModifiedDate { get; set; }
    }
}
