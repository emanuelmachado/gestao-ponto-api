using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoPonto.Application.ViewModels
{
    public class PointRegisterViewModel
    {
        public int Id { get; set; }

        public int CollaboratorId { get; set; }

        public DateTimeOffset Register { get; set; }

        public char EventIdentifier { get; set; }

    }
}
