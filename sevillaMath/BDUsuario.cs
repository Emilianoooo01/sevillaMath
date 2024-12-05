using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace sevillaMath
{
    public class BDUsuario
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }

        public BDUsuario() { }
        public BDUsuario(string nombreUsuario, string Contrasena)
        {
            this.NombreUsuario = nombreUsuario;
            this.Contrasena = Contrasena;
        }
    }
}
