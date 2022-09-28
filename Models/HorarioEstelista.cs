using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace PeluqueiaStar.Models
{
    public class HorarioEstelista
    {
        public int Id { get; set; }
        public bool Disponibilidad { get; set; }

        [DataType(dataType: DataType.Date)]
        public DateTime  Fecha { get; set; }
        public string Horario { get; set; }  = string.Empty;
    }
}