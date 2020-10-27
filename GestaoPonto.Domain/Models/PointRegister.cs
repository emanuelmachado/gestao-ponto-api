using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GestaoPonto.Domain.Models
{
    public class PointRegister
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int CollaboratorId { get; set; }

        public DateTimeOffset Register { get; set; }

        public char EventIdentifier { get; set; }

    }
}
