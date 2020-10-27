using System;
using System.Collections.Generic;
using System.Text;

namespace GestaoPonto.Application.ViewModels
{
    public class CollaboratorViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Role { get; set; }

        public ICollection<PointRegisterViewModel> PointRegisters { get; set; }
    }
}
