using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace sevillaMath
{
    public class FormularioIntento
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public int TemaId { get; set; }
        public DateTime FechaIntento { get; set; }
        public int NumeroIntentos { get; set; }
        public double Puntuacion { get; set; }
        public bool PasoFormulario { get; set; }

        public DateTime FechaInicio { get; set; }
        public int DiasEnTema { get; set; }
    }
}
