using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NHibernateTutorial.Domain
{
    public class Character
    {
        public virtual Guid Id { get; set; }
        public virtual string Nombre { get; set; }
        public virtual string Apellido { get; set; }
        public virtual int Edad { get; set; }
        public virtual string Profesion { get; set; }
    }
}
