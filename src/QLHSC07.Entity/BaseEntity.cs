using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLHSC07.Entity
{
    public class BaseEntity<T>
    {
        [Key]
        [Column("id")]
        public T Id { get; set; }
    }
}
